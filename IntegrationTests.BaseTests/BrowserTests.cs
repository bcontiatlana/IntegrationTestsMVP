using System.Net;
using RestSharp;
using Xunit;
using Xunit.Sdk;

namespace IntegrationTests.Base;

public abstract partial class BrowserTests(string endpoint = null) : BrowserBaseTest(endpoint)
{
    [Trait("Feature", "Normalization")]
    [SkipForConnectorsFact("Akamai")]
    public void BrowserTestMethod()
    {
        Assert.True(true);
    }
}