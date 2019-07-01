using Monobank.API.Services;
using System;
using System.Net.Http;

namespace Monobank.API
{
    public sealed class Monobank
    {
        public CurrencyService Currency { get; private set; }
        public PersonalService Personal { get; private set; }

        public Monobank(HttpClient client, string apiKey = null)
        {
            if (client == null)
            {
                throw new Exception("HttpClient cannot be null");
            }

            Currency = new CurrencyService(client);
            Personal = new PersonalService(client, apiKey);
        }
    }
}
