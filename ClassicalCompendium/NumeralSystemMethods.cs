using System;

namespace ClassicalCompendium
{
    public class NumeralSystemMethods
    {
        /// <summary>
        /// This method will convert a decimal number to a binary number.
        /// </summary>
        /// <param name="decimalNumber">The decimal number to convert.</param>
        /// <returns>The binary number.</returns>
        public static string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        /// <summary>
        /// This method will convert a decimal number to a hexadecimal number.
        /// </summary>
        /// <param name="decimalNumber">The decimal number to convert.</param>
        /// <returns>The hexadecimal number.</returns>
        public static string DecimalToHexadecimal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 16);
        }

        /// <summary>
        /// This method will convert a decimal number to an octal number.
        /// </summary>
        /// <param name="decimalNumber">The decimal number to convert.</param>
        /// <returns>The octal number.</returns>
        public static string DecimalToOctal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 8);
        }

        /// <summary>
        /// This method will convert a binary number to a decimal number.
        /// </summary>
        /// <param name="binaryNumber">The binary number to convert.</param>
        /// <returns>The decimal number.</returns>
        public static int BinaryToDecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        /// <summary>
        /// This method will convert a binary number to a hexadecimal number.
        /// </summary>
        /// <param name="binaryNumber">The binary number to convert.</param>
        /// <returns>The hexadecimal number.</returns>
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            return Convert.ToString(Convert.ToInt32(binaryNumber, 2), 16);
        }

        /// <summary>
        /// This method will convert a binary number to an octal number.
        /// </summary>
        /// <param name="binaryNumber">The binary number to convert.</param>
        /// <returns>The octal number.</returns>
        public static string BinaryToOctal(string binaryNumber)
        {
            return Convert.ToString(Convert.ToInt32(binaryNumber, 2), 8);
        }

        /// <summary>
        /// This method will convert an octal number to a decimal number.
        /// </summary>
        /// <param name="hexadecimalNumber"></param>
        /// <returns></returns>
        public static int HexadecimalToDecimal(string hexadecimalNumber)
        {
            return Convert.ToInt32(hexadecimalNumber, 16);
        }

        /// <summary>
        /// This method will convert an octal number to a binary number.
        /// </summary>
        /// <param name="hexadecimalNumber"></param>
        /// <returns></returns>
        public static string HexadecimalToBinary(string hexadecimalNumber)
        {
            return Convert.ToString(Convert.ToInt32(hexadecimalNumber, 16), 2);
        }

        /// <summary>
        /// This method will convert an octal number to a binary number.
        /// </summary>
        /// <param name="hexadecimalNumber"></param>
        /// <returns></returns>
        public static string HexadecimalToOctal(string hexadecimalNumber)
        {
            return Convert.ToString(Convert.ToInt32(hexadecimalNumber, 16), 8);
        }

        /// <summary>
        ///  This method will convert an octal number to a decimal number.
        /// </summary>
        /// <param name="octalNumber"></param>
        /// <returns></returns>
        public static int OctalToDecimal(string octalNumber)
        {
            return Convert.ToInt32(octalNumber, 8);
        }

        /// <summary>
        /// This method will convert an octal number to a binary number.
        /// </summary>
        /// <param name="octalNumber"></param>
        /// <returns></returns>
        public static string OctalToBinary(string octalNumber)
        {
            return Convert.ToString(Convert.ToInt32(octalNumber, 8), 2);
        }

        /// <summary>
        /// This method will convert an octal number to a hexadecimal number.
        /// </summary>
        /// <param name="octalNumber"></param>
        /// <returns></returns>
        public static string OctalToHexadecimal(string octalNumber)
        {
            return Convert.ToString(Convert.ToInt32(octalNumber, 8), 16);
        }
    }
}
