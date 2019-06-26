using monobank.dotnet.Helpers;
using System.Net.Http;

namespace monobank.dotnet.Services.Abstract
{
    public abstract class BaseService
    {
        internal readonly MonobankHTTP _monobankHTTP;

        internal BaseService(HttpClient client)
        {
            _monobankHTTP = new MonobankHTTP(client);
        }
    }
}
