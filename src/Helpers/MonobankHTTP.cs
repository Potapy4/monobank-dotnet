using Monobank.API.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monobank.API.Helpers
{
    internal class MonobankHTTP
    {
        private const string API_URL = "https://api.monobank.ua";
        private readonly HttpClient Client;

        internal MonobankHTTP(HttpClient client)
        {
            Client = client;
            Client.BaseAddress = new Uri(API_URL);
        }

        private HttpRequestMessage InitRequestMessage(HttpMethod method, string url, Dictionary<string, string> headers = null)
        {
            var request = new HttpRequestMessage(method, url);

            if (headers?.Count > 0)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            return request;
        }

        private async Task<string> MakeRequest(HttpRequestMessage request)
        {
            using (var response = await Client.SendAsync(request))
            {
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var error = JsonSerializer.Parse<Error>(result);
                    throw new Exception(error.Description);
                }

                return result;
            }
        }

        internal async Task<string> GetRequest(string url, Dictionary<string, string> headers = null)
        {
            var request = InitRequestMessage(HttpMethod.Get, url, headers);
            return await MakeRequest(request);
        }

        internal async Task<string> PostRequest(string url, string payload, Dictionary<string, string> headers = null)
        {
            var request = InitRequestMessage(HttpMethod.Post, url, headers);
            request.Content = new StringContent(payload, Encoding.UTF8, "application/json");

            return await MakeRequest(request);
        }
    }
}
