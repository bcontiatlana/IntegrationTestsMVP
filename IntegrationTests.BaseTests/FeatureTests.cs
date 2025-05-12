using Xunit;

namespace IntegrationTests.Base
{

    /// <summary>
    /// Test class for testing features of the connectors.
    /// </summary>
    public partial class HttpClientTests
    {
        [SkipForConnectorsFact("NetCore")]
        [Trait("Feature", "PostNorm")]
        public void TestMethod()
        {
            Assert.True(true);
        }
    }
}