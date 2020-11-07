using System;

namespace ch1seL.TonClientBlazor.Mediator.Utils
{
    internal static class DoubleExtensions
    {
        internal static DateTime ToDateTime(this double jsTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(jsTimeStamp).ToLocalTime();
        }

        internal static TimeSpan ToTimeSpan(this double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds);
        }
    }
}