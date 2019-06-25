using Newtonsoft.Json;
using System.Collections.Generic;

namespace monobank.dotnet.DTO
{
    public sealed class UserInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accounts")]
        public ICollection<Account> Accounts { get; set; }
    }
}
