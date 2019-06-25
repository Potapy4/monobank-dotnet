using monobank.dotnet.Enums;
using Newtonsoft.Json;

namespace monobank.dotnet.DTO
{
    public sealed class StatementItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("time")]
        public ulong Time { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mcc")]
        public int MCC { get; set; }

        [JsonProperty("hold")]
        public bool IsHold { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("operationAmount")]
        public long OperationAmount { get; set; }

        [JsonProperty("currencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("commissionRate")]
        public long ComissionRate { get; set; }

        [JsonProperty("cashbackAmount")]
        public long CashbackAmount { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }
    }
}
