using System;

namespace Monobank.API.Extensions
{
    internal static class DateTimeExtension
    {
        internal static int ConvertToUnixTime(this DateTime date)
        {
            return (int)(date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
    }
}
