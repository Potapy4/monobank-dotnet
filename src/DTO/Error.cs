using System.Text.Json.Serialization;

namespace Monobank.API.DTO
{
    public sealed class Error
    {
        [JsonPropertyName("errorDescription")]
        public string Description { get; set; }
    }
}
