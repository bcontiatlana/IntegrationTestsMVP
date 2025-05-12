using System;
using Xunit.v3;

[assembly: Xunit.TestFramework(typeof(IntegrationTests.AspNetCore.AssemblyInitializer))]

namespace IntegrationTests.AspNetCore
{
    public class AssemblyInitializer : XunitTestFramework
    {
        public AssemblyInitializer()
        {
            // Set environment variables for connector configuration
            Environment.SetEnvironmentVariable("CURRENT_CONNECTOR_TYPE", "AspNetCore");
        }
    }
} 