using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace monobank.dotnet.DTO
{
    public sealed class UserInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("accounts")]
        public ICollection<Account> Accounts { get; set; }
    }
}
