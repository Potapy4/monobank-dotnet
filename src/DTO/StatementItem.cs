using monobank.dotnet.Enums;
using System.Text.Json.Serialization;

namespace monobank.dotnet.DTO
{
    public sealed class StatementItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("time")]
        public ulong Time { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("mcc")]
        public int MCC { get; set; }

        [JsonPropertyName("hold")]
        public bool IsHold { get; set; }

        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        [JsonPropertyName("operationAmount")]
        public long OperationAmount { get; set; }

        [JsonPropertyName("currencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonPropertyName("commissionRate")]
        public long ComissionRate { get; set; }

        [JsonPropertyName("cashbackAmount")]
        public long CashbackAmount { get; set; }

        [JsonPropertyName("balance")]
        public long Balance { get; set; }
    }
}
