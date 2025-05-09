using System;
using Xunit;

namespace IntegrationTests.Base
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class SkipForConnectorsFactAttribute : FactAttribute
    {
        public string[] ConnectorTypes { get; }

        public SkipForConnectorsFactAttribute(params string[] connectorTypes)
        {
            ConnectorTypes = connectorTypes;

            // Check environment variable to determine current connector
            string currentConnector = Environment.GetEnvironmentVariable("CURRENT_CONNECTOR_TYPE");

            if (!string.IsNullOrEmpty(currentConnector) &&
                Array.Exists(ConnectorTypes, type => type.Equals(currentConnector, StringComparison.OrdinalIgnoreCase)))
            {
                Skip = $"Test not applicable for connector type: {currentConnector}";
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class SkipForConnectorsTheoryAttribute : TheoryAttribute
    {
        public string[] ConnectorTypes { get; }

        public SkipForConnectorsTheoryAttribute(params string[] connectorTypes)
        {
            ConnectorTypes = connectorTypes;

            // Check environment variable to determine current connector
            string currentConnector = Environment.GetEnvironmentVariable("CURRENT_CONNECTOR_TYPE");

            if (!string.IsNullOrEmpty(currentConnector) &&
                Array.Exists(ConnectorTypes, type => type.Equals(currentConnector, StringComparison.OrdinalIgnoreCase)))
            {
                Skip = $"Test not applicable for connector type: {currentConnector}";
            }
        }
    }
}