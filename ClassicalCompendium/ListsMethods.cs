using System;
using System.Linq;

namespace ClassicalCompendium
{
    public class ListsMethods
    {
        /// <summary>
        /// This method will return the converted string with the Cesar code.
        /// </summary>
        /// <param name="key">Key is the number of shift.</param>
        /// <param name="value">Value is the string to code.</param>
        /// <returns></returns>
        public static string CodeCesar(int key, string value)
        {
            int decalage = key;

            Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);

            Func<char, char, int, char> decal =
                (c, offset, m) => (char)(offset + mod(c - offset + decalage, m));

            Func<char, char> cesar =
                c => ('a' <= c && c <= 'z') ? decal(c, 'a', 26)
                : ('A' <= c && c <= 'Z') ? decal(c, 'A', 26)
                : ('0' <= c && c <= '9') ? decal(c, '0', 10)
                : c;

            string output = new string(value.Select(cesar).ToArray());
            return output;
        }
    }
}
