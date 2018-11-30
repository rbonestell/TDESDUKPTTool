using System;

namespace TDESDUKPTTool.Extensions
{
    public static class ByteExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ba"></param>
        /// <returns></returns>
        public static string ToHexString(this byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
