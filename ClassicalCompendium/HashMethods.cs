using System;
using System.Text;

namespace ClassicalCompendium
{
    public class HashMethods
    {
        /// <summary>
        /// This method will return the CRC8 hash of the text.
        /// </summary>
        /// <param name="input">The string to hash.</param>
        /// <returns>A CRC8 hashed string</returns>
        public static string CRC8(string input)
        {
            byte[] Table = new byte[256];

            const byte polynomial = 0x07; // Standard CRC-8 polynomial
            for (int i = 0; i < 256; ++i)
            {
                byte crc = (byte)i;
                for (int j = 0; j < 8; ++j)
                {
                    if ((crc & 0x80) != 0)
                    {
                        crc = (byte)((crc << 1) ^ polynomial);
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }

                Table[i] = crc;
            }

            byte[] data = Encoding.UTF8.GetBytes(input);

            byte crcOutput = 0;
            foreach (byte b in data)
            {
                crcOutput = Table[crcOutput ^ b];
            }
            return "0x" + crcOutput.ToString("X2");
        }

        // Checksums
        /*
        public static void InternetChecksum()
        {

        }

        public static void Fletcher8()
        {

        }

        public static void Fletcher32()
        {

        }

        public static void Adler32()
        {

        }

        public static void Xor8()
        {

        }

        public static void LuhnAlgorithm()
        {

        }

        public static void VerhoeffAlgorithm()
        {

        }

        public static void DammAlgorithm()
        {

        }
        */

        // Universal hash function families
        /*
        public static void RabinFingerprint()
        {

        }

        public static void TabulationHashing()
        {

        }

        public static void ZobristHashing()
        {

        }
        */

        // Non-cryptographic hash functions
        /*
        public static void PearsonHash()
        {

        }

        public static void PJWHash()
        {

        }

        public static void MurmurHash()
        {

        }

        public static void FarmHash()
        {

        }

        public static void XXHash3() 
        {

        }

        public static void DHash()
        {

        }

        */

        // Keyed cryptographic hash functions
        /*
        public static void BLAKE3()
        {

        }

        public static void HMAC()
        {

        }

        public static void SipHash()
        {

        }

        public static void HighwayHash()
        {

        }
        */

        // Unkeyed cryptographic hash functions
        /*
        public static void BLAKE2s()
        {

        }

        public static void BLAKE2b()
        {

        }

        public static void BLAKE2X()
        {

        }
        */

        /// <summary>
        /// This method will return the SHA256 hash of the text.
        /// </summary>
        /// <param name="text">is the string to hash</param>
        /// <returns>A string passed through SHA256 hash.</returns>
        public static string SHA256(string text)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// This method will return the SHA512 hash of the text.
        /// </summary>
        /// <param name="text">is the string to hash</param>
        /// <returns>A string passed throug SHA512 hash</returns>
        public static string SHA512(string text)
        {
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                byte[] hash = sha512.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        /*
        public static void SHA3()
        {

        }

        public static void SpectralHash()
        {

        }

        public static void SWIFFT()
        {

        }

        public static void Whirlpool()
        {

        }  
        */
    }
}
