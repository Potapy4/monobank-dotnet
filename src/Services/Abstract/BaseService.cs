using Monobank.API.Helpers;
using System.Net.Http;

namespace Monobank.API.Services.Abstract
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
