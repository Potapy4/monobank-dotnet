using monobank.dotnet.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace monobank.dotnet.Helpers
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

        internal async Task<string> GetRequest(string url, Dictionary<string, string> headers = null)
        {
            Client.DefaultRequestHeaders.Clear();
            if (headers?.Count > 0)
            {
                foreach (var header in headers)
                {
                    Client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            using (var response = await Client.GetAsync(url))
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
    }
}
