using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Communication
{
    internal class Connection
    {
        public string SendData(string request, bool bIsJson, string apiKey, string url = "")
        {
            if (string.IsNullOrEmpty(url))
                url = ConfigurationManager.AppSettings["GatewayRestUrl"];
            var sMediaTYpe = bIsJson ? "application/json" : "application/xml";
            var sResponse = string.Empty;
            using (var c = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
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
        }
    }
}
