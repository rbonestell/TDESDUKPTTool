using System;
using System.Text.RegularExpressions;

namespace TDESDUKPTTool.Extensions
{
    public static class StringExtensions
    {

        public static byte[] HexStringToByteArray(this string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static bool IsValidHex(this string str)
        {
            return Regex.IsMatch(str, @"^([0-9a-fA-F]{2})+$");
        }

        public static string RemoveNonHexChars(this string str)
        {
            return Regex.Replace(str, @"[^0-9a-fA-F]", string.Empty);
        }
        
    }
}