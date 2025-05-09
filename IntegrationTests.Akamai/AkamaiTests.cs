using System;
using IntegrationTests.Base;

namespace IntegrationTests.Akamai;


[Trait("Connector", "Akamai")]
public class AkamaiHttpClientTests : HttpClientTests
{
    public AkamaiHttpClientTests() : base(TestConfiguration.HttpEndpointUrl)
    {
    }

    [Fact]
    public void SpecificHttpTestForAkamai()
    {
        Console.WriteLine(_endpoint);
        Assert.True(true);
    }
}

[Trait("Connector", "Akamai")]
public class AkamaiBrowserTests : BrowserTests
{
    public AkamaiBrowserTests() : base(TestConfiguration.BrowserEndpointUrl)
    {
    }

    [Fact]
    public void SpecificBrowserTestForAkamai()
    {
        Console.WriteLine(_endpoint);
        Assert.True(true);
    }
}    