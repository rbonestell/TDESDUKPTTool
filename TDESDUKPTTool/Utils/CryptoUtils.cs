using System;
using System.Linq;
using System.Security.Cryptography;

namespace TDESDUKPTTool.Utils
{
    public static class CryptoUtils
    {

        /// <summary>
        /// Gets the next multiple of 8 
        /// Works with both scenarios, getting 7 bytes instead of 8 and works when expecting 16 bytes and getting 15.
        /// </summary>
        private static int GetNearestWholeMultiple(decimal input, int multiple)
        {
            var output = Math.Round(input / multiple);
            if (output == 0 && input > 0) output += 1;
            output *= multiple;
            return (int)output;
        }

        /// <summary>
        /// Get first 6 characters of X9.24 check value 
        /// </summary>
        /// <param name="keyPart">Key Part Byte Array</param>
        /// <returns>Key part check value</returns>
        public static byte[] CalculateCheckValue(byte[] keyPart)
        {
            byte[] fullCheckData = CalculateCheckData(keyPart);
            if (fullCheckData == null)
                return null;
            byte[] checkData = new byte[3];
            Buffer.BlockCopy(fullCheckData, 0, checkData, 0, 3);
            return checkData;
        }

        /// <summary>
        /// Calculate Entire x9.24 Check Value for Key Part
        /// </summary>
        /// <param name="keyPartBytes">Key Part Byte Array</param>
        /// <returns>Entire key part check value array</returns>
        public static byte[] CalculateCheckData(byte[] keyPartBytes)
        {
            try
            {

                byte[] message = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

                using (var cipher = SymmetricAlgorithm.Create("TripleDES"))
                {
                    var k = keyPartBytes;
                    cipher.Key = new byte[Math.Max(0, GetNearestWholeMultiple(k.Length, 8) - k.Length)].Concat(keyPartBytes).ToArray();
                    cipher.IV = new byte[8];
                    cipher.Mode = CipherMode.ECB;
                    cipher.Padding = PaddingMode.Zeros;
                    using (var crypto = cipher.CreateEncryptor())
                    {
                        var data = message;
                        data = new byte[Math.Max(0, GetNearestWholeMultiple(data.Length, 8) - data.Length)].Concat(message).ToArray();
                        return crypto.TransformFinalBlock(data, 0, data.Length);
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        
    }
}
