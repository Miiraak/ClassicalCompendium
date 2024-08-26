using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalCompendium.Tests
{
    public class NumeralSystemTests
    {
        [Fact]
        public static void DecimalToBinaryTest()
        {
            Assert.Equal("0", NumeralSystemMethods.DecimalToBinary(0));
            Assert.Equal("1", NumeralSystemMethods.DecimalToBinary(1));
            Assert.Equal("10", NumeralSystemMethods.DecimalToBinary(2));
            Assert.Equal("11", NumeralSystemMethods.DecimalToBinary(3));
            Assert.Equal("100", NumeralSystemMethods.DecimalToBinary(4));
            Assert.Equal("101", NumeralSystemMethods.DecimalToBinary(5));
            Assert.Equal("110", NumeralSystemMethods.DecimalToBinary(6));
            Assert.Equal("111", NumeralSystemMethods.DecimalToBinary(7));
            Assert.Equal("1000", NumeralSystemMethods.DecimalToBinary(8));
            Assert.Equal("1001", NumeralSystemMethods.DecimalToBinary(9));
            Assert.Equal("1010", NumeralSystemMethods.DecimalToBinary(10));
            Assert.Equal("1011", NumeralSystemMethods.DecimalToBinary(11));
            Assert.Equal("1100", NumeralSystemMethods.DecimalToBinary(12));
            Assert.Equal("1101", NumeralSystemMethods.DecimalToBinary(13));
            Assert.Equal("1110", NumeralSystemMethods.DecimalToBinary(14));
            Assert.Equal("1111", NumeralSystemMethods.DecimalToBinary(15));
            Assert.Equal("10000", NumeralSystemMethods.DecimalToBinary(16));
            Assert.Equal("10001", NumeralSystemMethods.DecimalToBinary(17));
            Assert.Equal("10010", NumeralSystemMethods.DecimalToBinary(18));
            Assert.Equal("10011", NumeralSystemMethods.DecimalToBinary(19));
            Assert.Equal("10100", NumeralSystemMethods.DecimalToBinary(20));
        }

        [Fact]
        public static void DecimalToHexadecimalTest()
        {
            Assert.Equal("0", NumeralSystemMethods.DecimalToHexadecimal(0));
            Assert.Equal("1", NumeralSystemMethods.DecimalToHexadecimal(1));
            Assert.Equal("2", NumeralSystemMethods.DecimalToHexadecimal(2));
            Assert.Equal("3", NumeralSystemMethods.DecimalToHexadecimal(3));
            Assert.Equal("4", NumeralSystemMethods.DecimalToHexadecimal(4));
            Assert.Equal("5", NumeralSystemMethods.DecimalToHexadecimal(5));
            Assert.Equal("6", NumeralSystemMethods.DecimalToHexadecimal(6));
            Assert.Equal("7", NumeralSystemMethods.DecimalToHexadecimal(7));
            Assert.Equal("8", NumeralSystemMethods.DecimalToHexadecimal(8));
            Assert.Equal("9", NumeralSystemMethods.DecimalToHexadecimal(9));
            Assert.Equal("a", NumeralSystemMethods.DecimalToHexadecimal(10));
            Assert.Equal("b", NumeralSystemMethods.DecimalToHexadecimal(11));
            Assert.Equal("c", NumeralSystemMethods.DecimalToHexadecimal(12));
            Assert.Equal("d", NumeralSystemMethods.DecimalToHexadecimal(13));
            Assert.Equal("e", NumeralSystemMethods.DecimalToHexadecimal(14));
            Assert.Equal("f", NumeralSystemMethods.DecimalToHexadecimal(15));
            Assert.Equal("10", NumeralSystemMethods.DecimalToHexadecimal(16));
            Assert.Equal("11", NumeralSystemMethods.DecimalToHexadecimal(17));
            Assert.Equal("12", NumeralSystemMethods.DecimalToHexadecimal(18));
            Assert.Equal("13", NumeralSystemMethods.DecimalToHexadecimal(19));
            Assert.Equal("14", NumeralSystemMethods.DecimalToHexadecimal(20));
            Assert.Equal("15", NumeralSystemMethods.DecimalToHexadecimal(21));
            Assert.Equal("16", NumeralSystemMethods.DecimalToHexadecimal(22));
            Assert.Equal("17", NumeralSystemMethods.DecimalToHexadecimal(23));
            Assert.Equal("18", NumeralSystemMethods.DecimalToHexadecimal(24));
            Assert.Equal("19", NumeralSystemMethods.DecimalToHexadecimal(25));
            Assert.Equal("1a", NumeralSystemMethods.DecimalToHexadecimal(26));
        }

        [Fact]
        public static void DecimalToOctalTest()
        {
            Assert.Equal("0", NumeralSystemMethods.DecimalToOctal(0));
            Assert.Equal("1", NumeralSystemMethods.DecimalToOctal(1));
            Assert.Equal("2", NumeralSystemMethods.DecimalToOctal(2));
            Assert.Equal("3", NumeralSystemMethods.DecimalToOctal(3));
            Assert.Equal("4", NumeralSystemMethods.DecimalToOctal(4));
            Assert.Equal("5", NumeralSystemMethods.DecimalToOctal(5));
            Assert.Equal("6", NumeralSystemMethods.DecimalToOctal(6));
            Assert.Equal("7", NumeralSystemMethods.DecimalToOctal(7));
            Assert.Equal("10", NumeralSystemMethods.DecimalToOctal(8));
            Assert.Equal("11", NumeralSystemMethods.DecimalToOctal(9));
            Assert.Equal("12", NumeralSystemMethods.DecimalToOctal(10));
            Assert.Equal("13", NumeralSystemMethods.DecimalToOctal(11));
            Assert.Equal("14", NumeralSystemMethods.DecimalToOctal(12));
            Assert.Equal("15", NumeralSystemMethods.DecimalToOctal(13));
            Assert.Equal("16", NumeralSystemMethods.DecimalToOctal(14));
            Assert.Equal("17", NumeralSystemMethods.DecimalToOctal(15));
            Assert.Equal("20", NumeralSystemMethods.DecimalToOctal(16));
            Assert.Equal("21", NumeralSystemMethods.DecimalToOctal(17));
            Assert.Equal("22", NumeralSystemMethods.DecimalToOctal(18));
            Assert.Equal("23", NumeralSystemMethods.DecimalToOctal(19));
            Assert.Equal("24", NumeralSystemMethods.DecimalToOctal(20));
            Assert.Equal("25", NumeralSystemMethods.DecimalToOctal(21));
            Assert.Equal("26", NumeralSystemMethods.DecimalToOctal(22));
            Assert.Equal("27", NumeralSystemMethods.DecimalToOctal(23));
            Assert.Equal("30", NumeralSystemMethods.DecimalToOctal(24));
            Assert.Equal("31", NumeralSystemMethods.DecimalToOctal(25));
            Assert.Equal("32", NumeralSystemMethods.DecimalToOctal(26));
        }

        [Fact]
        public static void BinaryToDecimalTest()
        {
            Assert.Equal(0, NumeralSystemMethods.BinaryToDecimal("0"));
            Assert.Equal(1, NumeralSystemMethods.BinaryToDecimal("1"));
            Assert.Equal(2, NumeralSystemMethods.BinaryToDecimal("10"));
            Assert.Equal(3, NumeralSystemMethods.BinaryToDecimal("11"));
            Assert.Equal(4, NumeralSystemMethods.BinaryToDecimal("100"));
            Assert.Equal(5, NumeralSystemMethods.BinaryToDecimal("101"));
            Assert.Equal(6, NumeralSystemMethods.BinaryToDecimal("110"));
            Assert.Equal(7, NumeralSystemMethods.BinaryToDecimal("111"));
            Assert.Equal(8, NumeralSystemMethods.BinaryToDecimal("1000"));
            Assert.Equal(9, NumeralSystemMethods.BinaryToDecimal("1001"));
            Assert.Equal(10, NumeralSystemMethods.BinaryToDecimal("1010"));
            Assert.Equal(11, NumeralSystemMethods.BinaryToDecimal("1011"));
            Assert.Equal(12, NumeralSystemMethods.BinaryToDecimal("1100"));
            Assert.Equal(13, NumeralSystemMethods.BinaryToDecimal("1101"));
            Assert.Equal(14, NumeralSystemMethods.BinaryToDecimal("1110"));
            Assert.Equal(15, NumeralSystemMethods.BinaryToDecimal("1111"));
            Assert.Equal(16, NumeralSystemMethods.BinaryToDecimal("10000"));
            Assert.Equal(17, NumeralSystemMethods.BinaryToDecimal("10001"));
            Assert.Equal(18, NumeralSystemMethods.BinaryToDecimal("10010"));
            Assert.Equal(19, NumeralSystemMethods.BinaryToDecimal("10011"));
            Assert.Equal(20, NumeralSystemMethods.BinaryToDecimal("10100"));
        }

        [Fact]
        public static void BinaryToHexadecimalTest()
        {
            Assert.Equal("0", NumeralSystemMethods.BinaryToHexadecimal("0"));
            Assert.Equal("1", NumeralSystemMethods.BinaryToHexadecimal("1"));
            Assert.Equal("2", NumeralSystemMethods.BinaryToHexadecimal("10"));
            Assert.Equal("3", NumeralSystemMethods.BinaryToHexadecimal("11"));
            Assert.Equal("4", NumeralSystemMethods.BinaryToHexadecimal("100"));
            Assert.Equal("5", NumeralSystemMethods.BinaryToHexadecimal("101"));
            Assert.Equal("6", NumeralSystemMethods.BinaryToHexadecimal("110"));
            Assert.Equal("7", NumeralSystemMethods.BinaryToHexadecimal("111"));
            Assert.Equal("8", NumeralSystemMethods.BinaryToHexadecimal("1000"));
            Assert.Equal("9", NumeralSystemMethods.BinaryToHexadecimal("1001"));
            Assert.Equal("a", NumeralSystemMethods.BinaryToHexadecimal("1010"));
            Assert.Equal("b", NumeralSystemMethods.BinaryToHexadecimal("1011"));
            Assert.Equal("c", NumeralSystemMethods.BinaryToHexadecimal("1100"));
            Assert.Equal("d", NumeralSystemMethods.BinaryToHexadecimal("1101"));
            Assert.Equal("e", NumeralSystemMethods.BinaryToHexadecimal("1110"));
            Assert.Equal("f", NumeralSystemMethods.BinaryToHexadecimal("1111"));
            Assert.Equal("10", NumeralSystemMethods.BinaryToHexadecimal("10000"));
            Assert.Equal("11", NumeralSystemMethods.BinaryToHexadecimal("10001"));
            Assert.Equal("12", NumeralSystemMethods.BinaryToHexadecimal("10010"));
            Assert.Equal("13", NumeralSystemMethods.BinaryToHexadecimal("10011"));
            Assert.Equal("14", NumeralSystemMethods.BinaryToHexadecimal("10100"));
            Assert.Equal("15", NumeralSystemMethods.BinaryToHexadecimal("10101"));
            Assert.Equal("16", NumeralSystemMethods.BinaryToHexadecimal("10110"));
            Assert.Equal("17", NumeralSystemMethods.BinaryToHexadecimal("10111"));
            Assert.Equal("18", NumeralSystemMethods.BinaryToHexadecimal("11000"));
            Assert.Equal("19", NumeralSystemMethods.BinaryToHexadecimal("11001"));
            Assert.Equal("1a", NumeralSystemMethods.BinaryToHexadecimal("11010"));
        }

        [Fact]
        public static void BinaryToOctalTest()
        {
            Assert.Equal("0", NumeralSystemMethods.BinaryToOctal("0"));
            Assert.Equal("1", NumeralSystemMethods.BinaryToOctal("1"));
            Assert.Equal("2", NumeralSystemMethods.BinaryToOctal("10"));
            Assert.Equal("3", NumeralSystemMethods.BinaryToOctal("11"));
            Assert.Equal("4", NumeralSystemMethods.BinaryToOctal("100"));
            Assert.Equal("5", NumeralSystemMethods.BinaryToOctal("101"));
            Assert.Equal("6", NumeralSystemMethods.BinaryToOctal("110"));
            Assert.Equal("7", NumeralSystemMethods.BinaryToOctal("111"));
            Assert.Equal("10", NumeralSystemMethods.BinaryToOctal("1000"));
            Assert.Equal("11", NumeralSystemMethods.BinaryToOctal("1001"));
            Assert.Equal("12", NumeralSystemMethods.BinaryToOctal("1010"));
            Assert.Equal("13", NumeralSystemMethods.BinaryToOctal("1011"));
            Assert.Equal("14", NumeralSystemMethods.BinaryToOctal("1100"));
            Assert.Equal("15", NumeralSystemMethods.BinaryToOctal("1101"));
            Assert.Equal("16", NumeralSystemMethods.BinaryToOctal("1110"));
            Assert.Equal("17", NumeralSystemMethods.BinaryToOctal("1111"));
            Assert.Equal("20", NumeralSystemMethods.BinaryToOctal("10000"));
            Assert.Equal("21", NumeralSystemMethods.BinaryToOctal("10001"));
            Assert.Equal("22", NumeralSystemMethods.BinaryToOctal("10010"));
            Assert.Equal("23", NumeralSystemMethods.BinaryToOctal("10011"));
            Assert.Equal("24", NumeralSystemMethods.BinaryToOctal("10100"));
        }

        [Fact]
        public static void HexadecimalToDecimalTest()
        {
            Assert.Equal(0, NumeralSystemMethods.HexadecimalToDecimal("0"));
            Assert.Equal(1, NumeralSystemMethods.HexadecimalToDecimal("1"));
            Assert.Equal(2, NumeralSystemMethods.HexadecimalToDecimal("2"));
            Assert.Equal(3, NumeralSystemMethods.HexadecimalToDecimal("3"));
            Assert.Equal(4, NumeralSystemMethods.HexadecimalToDecimal("4"));
            Assert.Equal(5, NumeralSystemMethods.HexadecimalToDecimal("5"));
            Assert.Equal(6, NumeralSystemMethods.HexadecimalToDecimal("6"));
            Assert.Equal(7, NumeralSystemMethods.HexadecimalToDecimal("7"));
            Assert.Equal(8, NumeralSystemMethods.HexadecimalToDecimal("8"));
            Assert.Equal(9, NumeralSystemMethods.HexadecimalToDecimal("9"));
            Assert.Equal(10, NumeralSystemMethods.HexadecimalToDecimal("a"));
            Assert.Equal(11, NumeralSystemMethods.HexadecimalToDecimal("b"));
            Assert.Equal(12, NumeralSystemMethods.HexadecimalToDecimal("c"));
            Assert.Equal(13, NumeralSystemMethods.HexadecimalToDecimal("d"));
            Assert.Equal(14, NumeralSystemMethods.HexadecimalToDecimal("e"));
            Assert.Equal(15, NumeralSystemMethods.HexadecimalToDecimal("f"));
            Assert.Equal(16, NumeralSystemMethods.HexadecimalToDecimal("10"));
            Assert.Equal(17, NumeralSystemMethods.HexadecimalToDecimal("11"));
            Assert.Equal(18, NumeralSystemMethods.HexadecimalToDecimal("12"));
            Assert.Equal(19, NumeralSystemMethods.HexadecimalToDecimal("13"));
            Assert.Equal(20, NumeralSystemMethods.HexadecimalToDecimal("14"));
            Assert.Equal(21, NumeralSystemMethods.HexadecimalToDecimal("15"));
            Assert.Equal(22, NumeralSystemMethods.HexadecimalToDecimal("16"));
            Assert.Equal(23, NumeralSystemMethods.HexadecimalToDecimal("17"));
            Assert.Equal(24, NumeralSystemMethods.HexadecimalToDecimal("18"));
            Assert.Equal(25, NumeralSystemMethods.HexadecimalToDecimal("19"));
            Assert.Equal(26, NumeralSystemMethods.HexadecimalToDecimal("1a"));
        }

        [Fact]
        public static void HexadecimalToBinaryTest()
        {
            Assert.Equal("0", NumeralSystemMethods.HexadecimalToBinary("0"));
            Assert.Equal("1", NumeralSystemMethods.HexadecimalToBinary("1"));
            Assert.Equal("10", NumeralSystemMethods.HexadecimalToBinary("2"));
            Assert.Equal("11", NumeralSystemMethods.HexadecimalToBinary("3"));
            Assert.Equal("100", NumeralSystemMethods.HexadecimalToBinary("4"));
            Assert.Equal("101", NumeralSystemMethods.HexadecimalToBinary("5"));
            Assert.Equal("110", NumeralSystemMethods.HexadecimalToBinary("6"));
            Assert.Equal("111", NumeralSystemMethods.HexadecimalToBinary("7"));
            Assert.Equal("1000", NumeralSystemMethods.HexadecimalToBinary("8"));
            Assert.Equal("1001", NumeralSystemMethods.HexadecimalToBinary("9"));
            Assert.Equal("1010", NumeralSystemMethods.HexadecimalToBinary("a"));
            Assert.Equal("1011", NumeralSystemMethods.HexadecimalToBinary("b"));
            Assert.Equal("1100", NumeralSystemMethods.HexadecimalToBinary("c"));
            Assert.Equal("1101", NumeralSystemMethods.HexadecimalToBinary("d"));
            Assert.Equal("1110", NumeralSystemMethods.HexadecimalToBinary("e"));
            Assert.Equal("1111", NumeralSystemMethods.HexadecimalToBinary("f"));
            Assert.Equal("10000", NumeralSystemMethods.HexadecimalToBinary("10"));
            Assert.Equal("10001", NumeralSystemMethods.HexadecimalToBinary("11"));
            Assert.Equal("10010", NumeralSystemMethods.HexadecimalToBinary("12"));
            Assert.Equal("10011", NumeralSystemMethods.HexadecimalToBinary("13"));
            Assert.Equal("10100", NumeralSystemMethods.HexadecimalToBinary("14"));
            Assert.Equal("10101", NumeralSystemMethods.HexadecimalToBinary("15"));
            Assert.Equal("10110", NumeralSystemMethods.HexadecimalToBinary("16"));
            Assert.Equal("10111", NumeralSystemMethods.HexadecimalToBinary("17"));
            Assert.Equal("11000", NumeralSystemMethods.HexadecimalToBinary("18"));
            Assert.Equal("11001", NumeralSystemMethods.HexadecimalToBinary("19"));
            Assert.Equal("11010", NumeralSystemMethods.HexadecimalToBinary("1a"));
        }

        [Fact]
        public static void HexadecimalToOctalTest()
        {
            Assert.Equal("0", NumeralSystemMethods.HexadecimalToOctal("0"));
            Assert.Equal("1", NumeralSystemMethods.HexadecimalToOctal("1"));
            Assert.Equal("2", NumeralSystemMethods.HexadecimalToOctal("2"));
            Assert.Equal("3", NumeralSystemMethods.HexadecimalToOctal("3"));
            Assert.Equal("4", NumeralSystemMethods.HexadecimalToOctal("4"));
            Assert.Equal("5", NumeralSystemMethods.HexadecimalToOctal("5"));
            Assert.Equal("6", NumeralSystemMethods.HexadecimalToOctal("6"));
            Assert.Equal("7", NumeralSystemMethods.HexadecimalToOctal("7"));
            Assert.Equal("10", NumeralSystemMethods.HexadecimalToOctal("8"));
            Assert.Equal("11", NumeralSystemMethods.HexadecimalToOctal("9"));
            Assert.Equal("12", NumeralSystemMethods.HexadecimalToOctal("a"));
            Assert.Equal("13", NumeralSystemMethods.HexadecimalToOctal("b"));
            Assert.Equal("14", NumeralSystemMethods.HexadecimalToOctal("c"));
            Assert.Equal("15", NumeralSystemMethods.HexadecimalToOctal("d"));
            Assert.Equal("16", NumeralSystemMethods.HexadecimalToOctal("e"));
            Assert.Equal("17", NumeralSystemMethods.HexadecimalToOctal("f"));
            Assert.Equal("20", NumeralSystemMethods.HexadecimalToOctal("10"));
            Assert.Equal("21", NumeralSystemMethods.HexadecimalToOctal("11"));
            Assert.Equal("22", NumeralSystemMethods.HexadecimalToOctal("12"));
            Assert.Equal("23", NumeralSystemMethods.HexadecimalToOctal("13"));
            Assert.Equal("24", NumeralSystemMethods.HexadecimalToOctal("14"));
            Assert.Equal("25", NumeralSystemMethods.HexadecimalToOctal("15"));
            Assert.Equal("26", NumeralSystemMethods.HexadecimalToOctal("16"));
            Assert.Equal("27", NumeralSystemMethods.HexadecimalToOctal("17"));
            Assert.Equal("30", NumeralSystemMethods.HexadecimalToOctal("18"));
            Assert.Equal("31", NumeralSystemMethods.HexadecimalToOctal("19"));
            Assert.Equal("32", NumeralSystemMethods.HexadecimalToOctal("1a"));
        }

        [Fact]
        public static void OctalToDecimalTest()
        {
            Assert.Equal(0, NumeralSystemMethods.OctalToDecimal("0"));
            Assert.Equal(1, NumeralSystemMethods.OctalToDecimal("1"));
            Assert.Equal(2, NumeralSystemMethods.OctalToDecimal("2"));
            Assert.Equal(3, NumeralSystemMethods.OctalToDecimal("3"));
            Assert.Equal(4, NumeralSystemMethods.OctalToDecimal("4"));
            Assert.Equal(5, NumeralSystemMethods.OctalToDecimal("5"));
            Assert.Equal(6, NumeralSystemMethods.OctalToDecimal("6"));
            Assert.Equal(7, NumeralSystemMethods.OctalToDecimal("7"));
            Assert.Equal(8, NumeralSystemMethods.OctalToDecimal("10"));
            Assert.Equal(9, NumeralSystemMethods.OctalToDecimal("11"));
            Assert.Equal(10, NumeralSystemMethods.OctalToDecimal("12"));
            Assert.Equal(11, NumeralSystemMethods.OctalToDecimal("13"));
            Assert.Equal(12, NumeralSystemMethods.OctalToDecimal("14"));
            Assert.Equal(13, NumeralSystemMethods.OctalToDecimal("15"));
            Assert.Equal(14, NumeralSystemMethods.OctalToDecimal("16"));
            Assert.Equal(15, NumeralSystemMethods.OctalToDecimal("17"));
            Assert.Equal(16, NumeralSystemMethods.OctalToDecimal("20"));
            Assert.Equal(17, NumeralSystemMethods.OctalToDecimal("21"));
            Assert.Equal(18, NumeralSystemMethods.OctalToDecimal("22"));
            Assert.Equal(19, NumeralSystemMethods.OctalToDecimal("23"));
            Assert.Equal(20, NumeralSystemMethods.OctalToDecimal("24"));
            Assert.Equal(21, NumeralSystemMethods.OctalToDecimal("25"));
            Assert.Equal(22, NumeralSystemMethods.OctalToDecimal("26"));
            Assert.Equal(23, NumeralSystemMethods.OctalToDecimal("27"));
            Assert.Equal(24, NumeralSystemMethods.OctalToDecimal("30"));
            Assert.Equal(25, NumeralSystemMethods.OctalToDecimal("31"));
            Assert.Equal(26, NumeralSystemMethods.OctalToDecimal("32"));
        }

        [Fact]
        public static void OctalToBinaryTest()
        {
            Assert.Equal("0", NumeralSystemMethods.OctalToBinary("0"));
            Assert.Equal("1", NumeralSystemMethods.OctalToBinary("1"));
            Assert.Equal("10", NumeralSystemMethods.OctalToBinary("2"));
            Assert.Equal("11", NumeralSystemMethods.OctalToBinary("3"));
            Assert.Equal("100", NumeralSystemMethods.OctalToBinary("4"));
            Assert.Equal("101", NumeralSystemMethods.OctalToBinary("5"));
            Assert.Equal("110", NumeralSystemMethods.OctalToBinary("6"));
            Assert.Equal("111", NumeralSystemMethods.OctalToBinary("7"));
            Assert.Equal("1000", NumeralSystemMethods.OctalToBinary("10"));
            Assert.Equal("1001", NumeralSystemMethods.OctalToBinary("11"));
            Assert.Equal("1010", NumeralSystemMethods.OctalToBinary("12"));
            Assert.Equal("1011", NumeralSystemMethods.OctalToBinary("13"));
            Assert.Equal("1100", NumeralSystemMethods.OctalToBinary("14"));
            Assert.Equal("1101", NumeralSystemMethods.OctalToBinary("15"));
            Assert.Equal("1110", NumeralSystemMethods.OctalToBinary("16"));
            Assert.Equal("1111", NumeralSystemMethods.OctalToBinary("17"));
            Assert.Equal("10000", NumeralSystemMethods.OctalToBinary("20"));
            Assert.Equal("10001", NumeralSystemMethods.OctalToBinary("21"));
            Assert.Equal("10010", NumeralSystemMethods.OctalToBinary("22"));
            Assert.Equal("10011", NumeralSystemMethods.OctalToBinary("23"));
            Assert.Equal("10100", NumeralSystemMethods.OctalToBinary("24"));
            Assert.Equal("10101", NumeralSystemMethods.OctalToBinary("25"));
            Assert.Equal("10110", NumeralSystemMethods.OctalToBinary("26"));
            Assert.Equal("10111", NumeralSystemMethods.OctalToBinary("27"));
            Assert.Equal("11000", NumeralSystemMethods.OctalToBinary("30"));
            Assert.Equal("11001", NumeralSystemMethods.OctalToBinary("31"));
            Assert.Equal("11010", NumeralSystemMethods.OctalToBinary("32"));
        }

        [Fact]
        public static void OctalToHexadecimalTest()
        {
            Assert.Equal("0", NumeralSystemMethods.OctalToHexadecimal("0"));
            Assert.Equal("1", NumeralSystemMethods.OctalToHexadecimal("1"));
            Assert.Equal("2", NumeralSystemMethods.OctalToHexadecimal("2"));
            Assert.Equal("3", NumeralSystemMethods.OctalToHexadecimal("3"));
            Assert.Equal("4", NumeralSystemMethods.OctalToHexadecimal("4"));
            Assert.Equal("5", NumeralSystemMethods.OctalToHexadecimal("5"));
            Assert.Equal("6", NumeralSystemMethods.OctalToHexadecimal("6"));
            Assert.Equal("7", NumeralSystemMethods.OctalToHexadecimal("7"));
            Assert.Equal("8", NumeralSystemMethods.OctalToHexadecimal("10"));
            Assert.Equal("9", NumeralSystemMethods.OctalToHexadecimal("11"));
            Assert.Equal("a", NumeralSystemMethods.OctalToHexadecimal("12"));
            Assert.Equal("b", NumeralSystemMethods.OctalToHexadecimal("13"));
            Assert.Equal("c", NumeralSystemMethods.OctalToHexadecimal("14"));
            Assert.Equal("d", NumeralSystemMethods.OctalToHexadecimal("15"));
            Assert.Equal("e", NumeralSystemMethods.OctalToHexadecimal("16"));
            Assert.Equal("f", NumeralSystemMethods.OctalToHexadecimal("17"));
            Assert.Equal("10", NumeralSystemMethods.OctalToHexadecimal("20"));
            Assert.Equal("11", NumeralSystemMethods.OctalToHexadecimal("21"));
            Assert.Equal("12", NumeralSystemMethods.OctalToHexadecimal("22"));
            Assert.Equal("13", NumeralSystemMethods.OctalToHexadecimal("23"));
            Assert.Equal("14", NumeralSystemMethods.OctalToHexadecimal("24"));
            Assert.Equal("15", NumeralSystemMethods.OctalToHexadecimal("25"));
            Assert.Equal("16", NumeralSystemMethods.OctalToHexadecimal("26"));
            Assert.Equal("17", NumeralSystemMethods.OctalToHexadecimal("27"));
            Assert.Equal("18", NumeralSystemMethods.OctalToHexadecimal("30"));
            Assert.Equal("19", NumeralSystemMethods.OctalToHexadecimal("31"));
            Assert.Equal("1a", NumeralSystemMethods.OctalToHexadecimal("32"));
        }
    }
}
