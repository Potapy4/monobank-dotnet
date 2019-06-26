using monobank.dotnet.Enums;
using System.Text.Json.Serialization;

namespace monobank.dotnet.DTO
{
    public sealed class CurrencyInfo
    {
        [JsonPropertyName("currencyCodeA")]
        public CurrencyCode CurrencyCodeA { get; set; }

        [JsonPropertyName("currencyCodeB")]
        public CurrencyCode CurrencyCodeB { get; set; }

        [JsonPropertyName("date")]
        public ulong Date { get; set; }

        [JsonPropertyName("rateSell")]
        public float RateSell { get; set; }

        [JsonPropertyName("rateBuy")]
        public float RateBuy { get; set; }

        [JsonPropertyName("rateCross")]
        public float RateCross { get; set; }
    }
}
