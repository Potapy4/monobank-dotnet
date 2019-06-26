using monobank.dotnet.DTO;
using monobank.dotnet.Services.Abstract;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace monobank.dotnet.Services
{
    public sealed class CurrencyService : BaseService
    {
        internal CurrencyService(HttpClient client) : base(client) { }

        public async Task<ICollection<CurrencyInfo>> GetCurrencyInfoAsync()
        {
            var response = await _monobankHTTP.GetRequest("/bank/currency");
            return JsonSerializer.Parse<ICollection<CurrencyInfo>>(response);
        }
    }
}
