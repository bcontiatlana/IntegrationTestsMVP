using System;
using System.Net;
using System.Net.Http;

namespace IntegrationTests.Base
{
    public class HttpClientBaseTest : IDisposable
    {
        protected HttpClient _httpClient = null!;
        protected HttpClientHandler _httpClientHandler = null!;
        protected readonly string _endpoint;
        protected readonly string _queueActionLayoutName = Uri.EscapeDataString("white space");

        public HttpClientBaseTest(string endpoint)
        {
            // Endpoint priority:
            // 1. Constructor parameter
            // 2. CONNECTOR_ENDPOINT environment variable
            // 3. Default localhost fallback
            _endpoint = endpoint ??
                        Environment.GetEnvironmentVariable("CONNECTOR_ENDPOINT") ??
                        "http://localhost:5000/";

            InitializeClient();
        }

        private void InitializeClient()
        {
            _httpClient?.Dispose();
            _httpClientHandler?.Dispose();

            _httpClientHandler = new HttpClientHandler
            {
                AllowAutoRedirect = false, // HttpClient in .NET Core does not accept following HTTPS => HTTP: https://github.com/dotnet/corefx/issues/24557
                CookieContainer = new CookieContainer()
            };

            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            _httpClient = new HttpClient(_httpClientHandler);
        }

        public void Dispose()
        {
            if (_httpClient != null)
                _httpClient.Dispose();

            if (_httpClientHandler != null)
                _httpClientHandler.Dispose();
        }
    }


}