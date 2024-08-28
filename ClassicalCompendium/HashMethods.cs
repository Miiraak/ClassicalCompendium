using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassicalCompendium
{
    public class HashMethods
    {
        // Cyclic redundancy checks
        /*
        public static string CRC8(string input)
        {

        }

        public static void CRC16()
        {
            
        }

        public static void CRC32()
        {

        }

        public static void CRC64()
        {

        }
        */

        // Checksums
        /*
        public static void BSDchecksum()
        {

        }

        public static void SYSVchecksum()
        {

        }

        public static void InternetChecksum()
        {

        }

        public static void Sum8()
        {

        }

        public static void Sum24()
        {

        }

        public static void Sum32()
        {

        }

        public static void Fletcher4()
        {

        }

        public static void Fletcher8()
        {

        }

        public static void Fletcher16()
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

        public static void UniversalOneWayHash()
        {

        }
        */

        // Non-cryptographic hash functions
        /*
        public static void PearsonHash()
        {

        }

        public static void PaulHsiehSuperFastHash()
        {

        }

        public static void Buzhash()
        {

        }

        public static void FNVHash()
        {

        }

        public static void JenkinsHash()
        {

        }

        public static void BernsteinHash()
        {

        }

        public static void PJWHash()
        {

        }

        public static void MurmurHash()
        {

        }

        public static void SpookyHash()
        {

        }

        public static void FastHash()
        {

        }

        public static void CityHash()
        {

        }

        public static void FarmHash()
        {

        }

        public static void MetroHash()
        {

        }

        public static void NHash()
        {

        }

        public static void XXHash() 
        {
            
        }

        public static void GxHash()
        {

        }

        public static void PHash()
        {

        }

        public static void DHash()
        {

        }

        public static void SDBM()
        {

        }

        public static void OSDB()
        {

        }

        public static void KomiHash()
        {

        }
        */

        // Keyed cryptographic hash functions
        /*
        public static void BLAKE2()
        {

        } 

        public static void BLAKE3()
        {

        }

        public static void HMAC()
        {

        }

        public static void KMAC()
        {

        }

        public static void MD6()
        {

        }

        public static void OMAC()
        {

        }

        public static void PMAC()
        {

        }

        public static void Poly1305AES()
        {

        }

        public static void SipHash()
        {

        }

        public static void HighwayHash()
        {

        }

        public static void UMAC()
        {

        }

        public static void VMAC()
        {

        }
        */

        // Unkeyed cryptographic hash functions
        /*
        public static void BLAKE256()
        {

        }

        public static void BLAKE512()
        {

        }

        public static void BLAKE2s()
        {

        }

        public static void BLAKE2b()
        {

        }

        public static void BLAKE2X()
        {

        }

        public static void ECOH()
        {

        }

        public static void FSB()
        {

        }

        public static void GOST()
        {

        }

        public static void Grostl()
        {

        }

        public static void HAS160()
        {

        }

        public static void HAVAL()
        {

        }

        public static void JH()
        {

        }

        public static void LSH()
        {

        }

        public static void MD2()
        {

        }

        public static void MD4()
        {

        }

        public static void MD5()
        {

        }

        public static void RadioGatun()
        {

        }

        public static void RIPEMD()
        {

        }

        public static void RIPEMD128()
        {

        }

        public static void RIPEMD160()
        {

        }

        public static void RIPEMD256()
        {

        }

        public static void RIPEMD320()
        {

        }

        public static void SHA1()
        {

        }

        public static void SHA224()
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
        /// This method will return the SHA384 hash of the text.
        /// </summary>
        /// <param name="text">is the string to hash</param>
        /// <returns>A string passed through SHA384 hash</returns>
        public static string SHA384(string text)
        {
            using (var sha384 = System.Security.Cryptography.SHA384.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                byte[] hash = sha384.ComputeHash(bytes);
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

        public static void Skein()
        {

        }

        public static void Snefru()
        {

        }

        public static void SpectralHash()
        {

        }

        public static void Streebog()
        {

        }

        public static void SWIFFT()
        {

        }

        public static void Tiger()
        {

        }

        public static void Whirlpool()
        {

        }  
        */
    }
}
