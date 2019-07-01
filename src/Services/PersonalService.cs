using Monobank.API.DTO;
using Monobank.API.Extensions;
using Monobank.API.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monobank.API.Services
{
    public sealed class PersonalService : BaseService
    {
        private readonly string _apiKey;

        internal PersonalService(HttpClient client, string apiKey) : base(client)
        {
            _apiKey = apiKey;
        }

        public async Task<UserInfo> GetClientInfoAsync()
        {
            var response = await _monobankHTTP.GetRequest("/personal/client-info", new Dictionary<string, string>()
            {
                { "X-Token", _apiKey }
            });

            return JsonSerializer.Parse<UserInfo>(response);
        }

        public async Task<ICollection<StatementItem>> GetStatementsAsync(DateTime from, DateTime? to = null, string account = "0")
        {
            var dateTo = to ?? DateTime.Now;
            var response = await _monobankHTTP.GetRequest($"/personal/statement/{account}/{from.ConvertToUnixTime()}/{dateTo.ConvertToUnixTime()}", new Dictionary<string, string>()
            {
                { "X-Token", _apiKey }
            });

            return JsonSerializer.Parse<ICollection<StatementItem>>(response);
        }
    }
}
