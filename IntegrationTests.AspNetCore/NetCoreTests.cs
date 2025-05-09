using System;
using IntegrationTests.AspNetCore;
using IntegrationTests.Base;
using Xunit;

namespace IntegrationTests.DotNetCore;

[Trait("Connector", "DotNetCore")]
public class DotNetCoreHttpClientTests : HttpClientTests
{
    public DotNetCoreHttpClientTests() : base(TestConfiguration.HttpEndpointUrl)
    {
    }

    [Fact]
    public void SpecificHttpTestForDotNetCore()
    {
        Console.WriteLine(_endpoint);
        Assert.True(true);
    }
}

[Trait("Connector", "DotNetCore")]
public class DotNetCoreBrowserTests : BrowserTests
{
    public DotNetCoreBrowserTests() : base(TestConfiguration.BrowserEndpointUrl)
    {
    }

    [Fact]
    public void SpecificBrowserTestForDotNetCore()
    {
        Console.WriteLine(_endpoint);
        Assert.True(true);
    }
}