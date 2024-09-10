using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassicalCompendium
{
    public class ConversionMethods
    {
        /// <summary>
        /// This method converts a number from one base to another. Works with bases 2-10.
        /// </summary>
        /// <param name="fromBase">The base of the number to be converted.</param>
        /// <param name="toBase">The base to convert to.</param>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        public static string BaseToBase(int fromBase, int toBase, string value)
        {
            return DecimalToBase(toBase, FromToDecimal(fromBase, value));
        }

        /// <summary>
        /// This method converts a number from a base to decimal.  
        /// </summary>
        /// <param name="fromBase">The base of the number to be converted.</param>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static int FromToDecimal(int fromBase, string value)    // FromBase = 2, value = "100"
        {
            int[] intArray = value.Select(c => int.Parse(c.ToString())).ToArray();
            Array.Reverse(intArray);
            int result = 0;
            int j = 0;

            foreach (int i in intArray)
            {
                result += (int)Math.Pow(fromBase, j) * i;
                j++;
            }

            return (int)result;
        }

        /// <summary>
        /// This method converts a decimal number to a number of a specified base.
        /// </summary>
        /// <param name="toBase">The base to convert to.</param>
        /// <param name="value">The value to convert.</param>
        /// <returns></returns>
        private static string DecimalToBase(int toBase, int value)
        {
            List<int> ints = new List<int>();

            while (value > 0)
            {
                ints.Add(value % toBase);
                value = (value - (value % toBase)) / toBase;
            }

            ints.Reverse();
            return string.Join("", ints);
        }
    }
}
