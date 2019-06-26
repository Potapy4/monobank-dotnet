using System.Text.Json.Serialization;

namespace monobank.dotnet.DTO
{
    public sealed class Error
    {
        [JsonPropertyName("errorDescription")]
        public string Description { get; set; }
    }
}
