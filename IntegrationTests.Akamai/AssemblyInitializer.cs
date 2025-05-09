using System;
using Xunit.Abstractions;
using Xunit.Sdk;

[assembly: Xunit.TestFramework("IntegrationTests.Akamai.AssemblyInitializer", "IntegrationTests.Akamai")]

namespace IntegrationTests.Akamai
{
    public class AssemblyInitializer : XunitTestFramework
    {
        public AssemblyInitializer(IMessageSink messageSink) : base(messageSink)
        {
            // Set environment variables for connector configuration
            Environment.SetEnvironmentVariable("CURRENT_CONNECTOR_TYPE", "Akamai");
        }
    }
} 