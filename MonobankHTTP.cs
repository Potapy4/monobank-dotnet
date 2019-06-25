using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace monobank.dotnet
{
    internal static class MonobankHTTP
    {
        internal static async Task<string> GetRequest(string url, Dictionary<string, string> headers = null)
        {
            using (var httpClient = new HttpClient())
            {
                if (headers?.Count > 0)
                {
                    foreach (var header in headers)
                    {
                        httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                using (var response = await httpClient.GetAsync(url))
                {
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
