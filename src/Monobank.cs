using monobank.dotnet.DTO;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace monobank.dotnet
{
    public sealed class Monobank
    {
        private readonly string _apiKey;
        private const string API_URL = "https://api.monobank.ua";

        public Monobank(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentNullException("apiKey cannot be empty");
            }

            _apiKey = apiKey;
        }

        public async Task<ICollection<CurrencyInfo>> GetCurrencyInfoAsync()
        {
            var response = await MonobankHTTP.GetRequest($"{API_URL}/bank/currency");
            return JsonSerializer.Parse<ICollection<CurrencyInfo>>(response);
        }

        public async Task<UserInfo> GetClientInfoAsync()
        {
            var response = await MonobankHTTP.GetRequest($"{API_URL}/personal/client-info", new Dictionary<string, string>()
            {
                { "X-Token", _apiKey }
            });

            return JsonSerializer.Parse<UserInfo>(response);
        }

        public async Task<ICollection<StatementItem>> GetStatementsAsync(DateTime from, DateTime to, string account = "0")
        {
            var response = await MonobankHTTP.GetRequest($"{API_URL}/personal/client-info", new Dictionary<string, string>()
            {
                { "X-Token", _apiKey },
                { "account", account },
                { "from", ConvertToUnixTime(from).ToString() },
                { "to", ConvertToUnixTime(to).ToString() }
            });

            return JsonSerializer.Parse<ICollection<StatementItem>>(response);
        }

        private static int ConvertToUnixTime(DateTime date)
        {
            return (int)(date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
