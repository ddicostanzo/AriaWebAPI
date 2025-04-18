using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Communication
{
    public static class Communication
    {
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
            try
            {
                var sMediaTYpe = bIsJson ? "application/json" : "application/xml";
                var sResponse = string.Empty;

                // Ignore untrusted SSL certs for now. 
               
                using (var c = new HttpClient(new HttpClientHandler() { UseDefaultCredentials=true}))
                {
                    if (apiKey != null)
                        c.DefaultRequestHeaders.Add("ApiKey", apiKey);
                    var task = c.PostAsync(url, new StringContent(request, Encoding.UTF8, sMediaTYpe));
                   

                    Task.WaitAll(task);

                    var responseTask = task.Result.Content.ReadAsStringAsync();
                    Task.WaitAll(responseTask);
                    sResponse = responseTask.Result;
                }
                return sResponse;
            } catch (Exception ex)
            {
                return "There was an error processign the request: " + ex.Message;
            }
        }
    }
}
