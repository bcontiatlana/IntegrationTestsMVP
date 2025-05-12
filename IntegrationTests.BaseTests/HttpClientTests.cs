using System;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using Xunit;
using Xunit.Sdk;

namespace IntegrationTests.Base;

/// <summary>
/// Tests class for testing HttpClient calls.
/// </summary>
public abstract partial class HttpClientTests(string endpoint = null) : HttpClientBaseTest(endpoint)
{

    [Trait("Feature", "Normalization")]
    [SkipForConnectorsTheory("NetCore")]
    [InlineData("/api/basket/add?id=12345", "should match trigger with normal normalized url")]
    [InlineData("/./api/basket/add?id=12345", "should ignore /./ path segment from url")]
    [InlineData("/api/fake/../basket/add?id=12345", "should remove /../ path segment from url and remove previous segment")]
    [InlineData("/../api/basket/add?id=12345", "should remove /../ path segment from url and keep rest of path as-is")]
    [InlineData("/api//basket/add?id=12345", "should treat multiple consecutive forward slashes as single forward slash")]
    [InlineData("/api/\\basket/add?id=12345", "should treat backward slash as forward slash")]
    [InlineData("/api/\\\\//basket/add?id=12345", "should treat multiple consecutive slashes as one forward slash")]
    [InlineData("/api/basket/add?id=%31%32%33%34%35", "should decode query string parameter")]
    [InlineData("/api/basket/add?id=12345", "should decode forward slash in path and treat as normal path segment separator")]
    [InlineData("/%61%70%69/%62%61%73%6B%65%74/%61%64%64?%69%64=%31%32%33%34%35", "should decode entire path")]
    [InlineData("/api/fake/.././////////\\b%61sket\\/%61dd?id=%31%32%33%34%35", "should normalize url with mix of encodings, irregular slashes and dot segments")]
    public async Task Should_Trigger_Given_UrlWithEncodedAndObfuscatedPathi(string requestPath, string reason)
    {
        var endpoint = new Uri(_endpoint);

        var requestUrl = endpoint.GetLeftPart(UriPartial.Authority) + requestPath;

        // Using RestSharp since HttpClient will normalize the url before making the request
        var client = new RestClient(new RestClientOptions { FollowRedirects = false });
        var request = new RestRequest(requestUrl);

        var response = await client.ExecuteAsync(request);

        try
        {
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);

            var location = response.GetHeaderValue("Location");
            Assert.NotNull(location);
            Assert.StartsWith("https://queueitknownusertst.test.queue-it.net/?c=queueitknownusertst&e=event1", location);
            Assert.Contains("man=%2Fapi%2Fbasket%2Fadd%3Fid%3D12345", location);
        }
        catch (Exception ex)
        {
            throw new XunitException($"{reason}\n{ex}\nReceived Location header: {response.GetHeaderValue("Location")}");
        }
    }
}