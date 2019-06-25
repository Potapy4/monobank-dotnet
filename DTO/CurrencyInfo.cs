using monobank.dotnet.Enums;
using Newtonsoft.Json;

namespace monobank.dotnet.DTO
{
    public sealed class CurrencyInfo
    {
        [JsonProperty("currencyCodeA")]
        public CurrencyCode CurrencyCodeA { get; set; }

        [JsonProperty("currencyCodeB")]
        public CurrencyCode CurrencyCodeB { get; set; }

        [JsonProperty("date")]
        public ulong Date { get; set; }

        [JsonProperty("rateSell")]
        public float RateSell { get; set; }

        [JsonProperty("rateBuy")]
        public float RateBuy { get; set; }

        [JsonProperty("rateCross")]
        public float RateCross { get; set; }
    }
}
