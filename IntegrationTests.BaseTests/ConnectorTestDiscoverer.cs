//using Xunit.Abstractions;
//using Xunit.Sdk;

//namespace IntegrationTests.Base
//{
//    public class ConnectorTestDiscoverer : FactDiscoverer
//    {
//        public ConnectorTestDiscoverer(IMessageSink diagnosticMessageSink)
//            : base(diagnosticMessageSink) { }

//        public override IEnumerable<IXunitTestCase> Discover(
//            ITestFrameworkDiscoveryOptions discoveryOptions,
//            ITestMethod testMethod,
//            IAttributeInfo factAttribute)
//        {
//            // Get any skip connector attribute on this method
//            var skipAttr = testMethod.Method.GetCustomAttributes(typeof(SkipForConnectorsFactAttribute)).FirstOrDefault();

//            // Get current connector type from environment
//            string currentConnector = Environment.GetEnvironmentVariable("CURRENT_CONNECTOR_TYPE");

//            // If no skip attribute or connector type doesn't match skipped ones, include the test
//            if (skipAttr == null ||
//                string.IsNullOrEmpty(currentConnector) ||
//                !ShouldSkipForConnector(skipAttr, currentConnector))
//            {
//                foreach (var testCase in base.Discover(discoveryOptions, testMethod, factAttribute))
//                {
//                    yield return testCase;
//                }
//            }
//        }

//        private bool ShouldSkipForConnector(IAttributeInfo skipAttr, string currentConnector)
//        {
//            var connectorTypes = skipAttr.GetConstructorArguments().FirstOrDefault() as string[];
//            return connectorTypes != null &&
//                   connectorTypes.Any(type => type.Equals(currentConnector, StringComparison.OrdinalIgnoreCase));
//        }
//    }
//}