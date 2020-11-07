using System;

namespace ch1seL.TonClientBlazor.Utils
{
    public static class HexToDecExtensions
    {
        public static long HexToDec(this string hex)
        {
            return Convert.ToInt64(hex, 16);
        }
    }
}