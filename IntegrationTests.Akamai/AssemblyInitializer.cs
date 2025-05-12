using System;
using Xunit.v3;

[assembly: Xunit.TestFramework(typeof(IntegrationTests.Akamai.AssemblyInitializer))]

namespace IntegrationTests.Akamai
{
    public class AssemblyInitializer : XunitTestFramework
    {
        public AssemblyInitializer()
        {
            // Set environment variables for connector configuration
            Environment.SetEnvironmentVariable("CURRENT_CONNECTOR_TYPE", "Akamai");
        }
    }
}