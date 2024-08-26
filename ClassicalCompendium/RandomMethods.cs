using System;

namespace ClassicalCompendium
{
    public class RandomMethods
    {
        /// <summary>
        /// Takes a length and returns a random string of that length.
        /// </summary>
        /// <param name="length"></param> 
        /// <returns>A random string</returns>
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] randomString = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomString[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomString);
        }

        /// <summary>
        /// Returns a random boolean.
        /// </summary>
        /// <returns>A random bool</returns>
        public static bool RandomBoolean()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0;
        }

        /// <summary>
        /// Takes two integers and returns a random integer between them.
        /// </summary>
        /// <param name="min">Is the minimum value.</param>
        /// <param name="max">Is the maximum value.</param>
        /// <returns>A random integer</returns>
        public static int RandomInteger(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        /// <summary>
        /// Takes two doubles and returns a random double between them.
        /// </summary>
        /// <param name="min">Is the minimum value.</param>
        /// <param name="max">Is the maximum value.</param>
        /// <returns>A random double</returns>
        public static double RandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        /// <summary>
        /// Returns a random long.
        /// </summary>
        /// <param name="min">Is the minimum value.</param>
        /// <param name="max">Is the maximum value.</param>
        /// <returns></returns>
        public static long RandomLong(long min, long max)
        {
            Random random = new Random();
            byte[] buf = new byte[8];
            random.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return Math.Abs(longRand % (max - min)) + min;
        }
    }
}
