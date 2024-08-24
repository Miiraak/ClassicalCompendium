using System;
using System.Linq;

namespace ClassicalCompendium
{
    public class CryptoMethods
    {
        /// <summary>
        /// This method will return the converted string with the Cesar code.
        /// </summary>
        /// <param name="key">Key is the number of shift.</param>
        /// <param name="value">Value is the string to code.</param>
        /// <returns></returns>
        public static string CodeCesar(int shift, string value)
        {
            int mod(int val, int m) => val % m + (val < 0 ? m : 0);

            char[] chars = value.ToCharArray();
            for (int i = 0; i < value.Length; i++)
            {
                int c = chars[i];
                if ('a' <= c && c <= 'z')
                    c = 'a' + mod(c - 'a' + shift, 26);
                else if ('A' <= c && c <= 'Z')
                    c = 'A' + mod(c - 'A' + shift, 26);
                else if ('0' <= c && c <= '9')
                    c = '0' + mod(c - '9' + shift, 10);
                chars[i] = (char)c;
            }

            return new String(chars);
        }
    }
}
