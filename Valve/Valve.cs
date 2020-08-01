using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Valve
{
    public class Valve
    {
        public static Boolean Control(string identifier, int percentEnabled)
        {
            HashAlgorithm hasher = new SHA256CryptoServiceProvider();
            byte[] hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(identifier));
            String hexedString = ConvertBytesToHexedString(hashed);

            var score = int.Parse(hexedString.Substring(Math.Max(hexedString.Length - 3, 0)), NumberStyles.HexNumber);
            return (score % 100) < percentEnabled;
        }

        private static String ConvertBytesToHexedString(byte[] hashedBytes)
        {
            StringBuilder hexedString = new StringBuilder();
            foreach (byte hashedByte in hashedBytes)
            {
                var hexedByte = 0xFF & hashedByte;
                hexedString.Append(hexedByte.ToString("X2"));
            }
            return hexedString.ToString();
        }

    }
}
