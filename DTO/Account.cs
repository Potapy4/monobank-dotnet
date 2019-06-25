using monobank.dotnet.Enums;
using Newtonsoft.Json;

namespace monobank.dotnet.DTO
{
    public sealed class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("creditLimit")]
        public long CreditLimit { get; set; }

        [JsonProperty("currencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("cashbackType")]
        public string CashbackType { get; set; }
    }
}
