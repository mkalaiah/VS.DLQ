using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DLQMobileApp.Utilities
{
    public static class ServiceProxy
    {
		private static readonly string API_SERVER_URL = "http://10.0.2.2:5000/api/services/app";

        public static async Task<string> GetDataAsync(string reqUrl)
        {
            string data = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 0, 0, 0, 90000);

                    var uri = new Uri(string.Concat(API_SERVER_URL, reqUrl));
                    var response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        var t = response.Content.ReadAsStringAsync();
                        data = await t;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Exception --- " + e.Message);
                throw;
            }
            return data;
        }

        public static async Task<string> GetPostDataAsync(string reqUrl, object requestobj)
        {
            string data = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 0, 0, 30, 0);
                    var userReqData = JsonConvert.SerializeObject(requestobj);
                    var httpContent = new StringContent(userReqData);
                    httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
                    var uri = new Uri(string.Concat(API_SERVER_URL, reqUrl));
                    var response = await client.PostAsync(uri, httpContent);
                    if (response.IsSuccessStatusCode)
                    {
                        var t = response.Content.ReadAsStringAsync();
                        data = await t;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Exception --- " + e.Message);
                throw;
            }
            return data;
        }

        public static T GetDeserializedDataFromJson<T>(string data)
        {
            T response = default(T);

            if (!string.IsNullOrWhiteSpace(data))
            {
                response = JsonConvert.DeserializeObject<T>(data);
            }

            return response;
        }
    }
}
