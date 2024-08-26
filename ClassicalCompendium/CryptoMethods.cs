using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ClassicalCompendium
{
    public class CryptoMethods
    {
        static readonly Dictionary<char, string> ReverseAlphabet = new Dictionary<char, string>{
              { 'A', "Z" }, { 'B', "Y" }, { 'C', "X" },
              { 'D', "W" }, { 'E', "V "}, { 'F', "U" },
              { 'G', "T" }, { 'H', "S" }, { 'I', "R" },
              { 'J', "Q" }, { 'K', "P" }, { 'L', "O" },
              { 'M', "N" }, { 'N', "M" }, { 'O', "L" },
              { 'P', "K" }, { 'Q', "J" }, { 'R', "I" },
              { 'S', "H" }, { 'T', "G" }, { 'U', "F" },
              { 'V', "E" }, { 'W', "D" }, { 'X', "C" },
              { 'Y', "B" }, { 'Z', "A" } };

        /// <summary>
        /// This method will return the converted string with the Cesar code. 
        /// </summary>
        /// <param name="key">Key is the number of shift.</param>
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
                if (ReverseAlphabet.ContainsKey(letter))
                {
                    output += ReverseAlphabet[letter];
                }
                else
                {
                    output += letter;
                }
            }
            return output;
        }

        public static string DoSHA256(string text)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
