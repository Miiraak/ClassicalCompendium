using System;

namespace ClassicalCompendium
{
    public class CryptoMethods
    {
        /// <summary>
        /// This method will return the converted string with the Cesar code. 
        /// </summary>
        /// <param name="shift">Key is the number of shift.</param>
        /// <param name="value">Value is the string to code.</param>
        /// <returns>A string syphered with the Cesar code.</returns>
        // Code by Orwell at https://openclassrooms.com/forum/sujet/c-probleme-de-chiffrement-de-cesare-94282
        public static string EncodeWithCesar(int shift, string value)
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

        public static string EncodeWithAtBash(string Text)
        {
            string output = "";

            foreach (char letter in Text.ToUpper())
            {
                if (PresetLists.Chars.ReverseAlphabet.ContainsKey(letter))
                {
                    output += PresetLists.Chars.ReverseAlphabet[letter];
                }
                else
                {
                    output += letter;
                }
            }
            return output;
        }
    }
}
