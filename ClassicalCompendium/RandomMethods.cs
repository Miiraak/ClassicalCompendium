using System;

namespace ClassicalCompendium
{
    public class RandomMethods
    {
        /// <summary>
        /// Takes two integers and returns a random integer between them.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int RandomInteger(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static double RandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

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

        public static bool RandomBoolean()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0;
        }
            
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
