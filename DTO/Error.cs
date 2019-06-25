using Newtonsoft.Json;

namespace monobank.dotnet.DTO
{
    public sealed class Error
    {
        [JsonProperty("errorDescription")]
        public string Description { get; set; }
    }
}
