using System;
using System.Net.Http;
using System.Text;

namespace AriaWebAPI.AriaAccessAPI.Communication
{
    public static class Communication
    {
        // NOTE: TLS certificate validation is enforced by default. Do not disable certificate validation.
        // If connecting to a server with a self-signed certificate, pin the certificate explicitly.
        private static readonly HttpClient _httpClient = new HttpClient(new HttpClientHandler
        {
            UseDefaultCredentials = true
        });

        /// <summary>
        /// Send data to the Aria Access API
        /// </summary>
        /// <param name="request">The request in JSON or XML form</param>
        /// <param name="bIsJson">Whether the request is JSON or not</param>
        /// <param name="apiKey">The API key to use with the transaction</param>
        /// <param name="url">The URL to send the request to</param>
        /// <returns>The Response from the API</returns>
        public static string SendData(string request, bool bIsJson, string apiKey, string url)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey), "API key must not be null or empty.");

            try
            {
                var sMediaType = bIsJson ? "application/json" : "application/xml";

                var httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
                httpRequest.Headers.Add("ApiKey", apiKey);
                httpRequest.Content = new StringContent(request, Encoding.UTF8, sMediaType);

                var response = _httpClient.SendAsync(httpRequest).GetAwaiter().GetResult();
                string sResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                return sResponse;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception ex)
            {
                // Log ex internally here (logging infrastructure not yet in place)
                return "An error occurred while processing the request.";
            }
        }
    }
}
