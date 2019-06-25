﻿using monobank.dotnet.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            return JsonConvert.DeserializeObject<ICollection<CurrencyInfo>>(response);
        }

        public async Task<UserInfo> GetClientInfoAsync()
        {
            var response = await MonobankHTTP.GetRequest($"{API_URL}/personal/client-info", new Dictionary<string, string>()
            {
                { "X-Token", _apiKey }
            });

            return JsonConvert.DeserializeObject<UserInfo>(response);
        }

        public async Task<ICollection<StatementItem>> GetStatementsAsync(string from, string to, string account = "0")
        {
            var response = await MonobankHTTP.GetRequest($"{API_URL}/personal/client-info", new Dictionary<string, string>()
            {
                { "X-Token", _apiKey },
                { "account", account },
                { "from", from },
                { "to", to }
            });

            return JsonConvert.DeserializeObject<ICollection<StatementItem>>(response);
        }
    }
}
