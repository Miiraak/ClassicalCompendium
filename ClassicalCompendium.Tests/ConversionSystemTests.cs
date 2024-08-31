namespace ClassicalCompendium.Tests
{
    public class ConversionSystemTests
    {
        [Fact]
        public static void DecimalToBinaryTest()
        {
            Assert.Equal("0", ConversionMethods.DecimalToBinary(0));
            Assert.Equal("1", ConversionMethods.DecimalToBinary(1));
            Assert.Equal("10", ConversionMethods.DecimalToBinary(2));
            Assert.Equal("11", ConversionMethods.DecimalToBinary(3));
            Assert.Equal("100", ConversionMethods.DecimalToBinary(4));
            Assert.Equal("101", ConversionMethods.DecimalToBinary(5));
            Assert.Equal("110", ConversionMethods.DecimalToBinary(6));
            Assert.Equal("111", ConversionMethods.DecimalToBinary(7));
            Assert.Equal("1000", ConversionMethods.DecimalToBinary(8));
            Assert.Equal("1001", ConversionMethods.DecimalToBinary(9));
            Assert.Equal("1010", ConversionMethods.DecimalToBinary(10));
            Assert.Equal("10000", ConversionMethods.DecimalToBinary(16));
            Assert.Equal("100000", ConversionMethods.DecimalToBinary(32));
            Assert.Equal("1000000", ConversionMethods.DecimalToBinary(64));
            Assert.Equal("10000000", ConversionMethods.DecimalToBinary(128));
            Assert.Equal("100000000", ConversionMethods.DecimalToBinary(256));
            Assert.Equal("1000000000", ConversionMethods.DecimalToBinary(512));
            Assert.Equal("10000000000", ConversionMethods.DecimalToBinary(1024));
        }

        [Fact]
        public static void DecimalToHexadecimalTest()
        {
            Assert.Equal("0", ConversionMethods.DecimalToHexadecimal(0));
            Assert.Equal("1", ConversionMethods.DecimalToHexadecimal(1));
            Assert.Equal("2", ConversionMethods.DecimalToHexadecimal(2));
            Assert.Equal("3", ConversionMethods.DecimalToHexadecimal(3));
            Assert.Equal("4", ConversionMethods.DecimalToHexadecimal(4));
            Assert.Equal("5", ConversionMethods.DecimalToHexadecimal(5));
            Assert.Equal("6", ConversionMethods.DecimalToHexadecimal(6));
            Assert.Equal("7", ConversionMethods.DecimalToHexadecimal(7));
            Assert.Equal("8", ConversionMethods.DecimalToHexadecimal(8));
            Assert.Equal("9", ConversionMethods.DecimalToHexadecimal(9));
            Assert.Equal("a", ConversionMethods.DecimalToHexadecimal(10));
            Assert.Equal("b", ConversionMethods.DecimalToHexadecimal(11));
            Assert.Equal("c", ConversionMethods.DecimalToHexadecimal(12));
            Assert.Equal("d", ConversionMethods.DecimalToHexadecimal(13));
            Assert.Equal("e", ConversionMethods.DecimalToHexadecimal(14));
            Assert.Equal("f", ConversionMethods.DecimalToHexadecimal(15));
            Assert.Equal("10", ConversionMethods.DecimalToHexadecimal(16));
            Assert.Equal("20", ConversionMethods.DecimalToHexadecimal(32));
            Assert.Equal("40", ConversionMethods.DecimalToHexadecimal(64));
            Assert.Equal("80", ConversionMethods.DecimalToHexadecimal(128));
            Assert.Equal("100", ConversionMethods.DecimalToHexadecimal(256));
            Assert.Equal("200", ConversionMethods.DecimalToHexadecimal(512));
            Assert.Equal("400", ConversionMethods.DecimalToHexadecimal(1024));
        }

        [Fact]
        public static void DecimalToOctalTest()
        {
            Assert.Equal("0", ConversionMethods.DecimalToOctal(0));
            Assert.Equal("1", ConversionMethods.DecimalToOctal(1));
            Assert.Equal("2", ConversionMethods.DecimalToOctal(2));
            Assert.Equal("3", ConversionMethods.DecimalToOctal(3));
            Assert.Equal("4", ConversionMethods.DecimalToOctal(4));
            Assert.Equal("5", ConversionMethods.DecimalToOctal(5));
            Assert.Equal("6", ConversionMethods.DecimalToOctal(6));
            Assert.Equal("7", ConversionMethods.DecimalToOctal(7));
            Assert.Equal("20", ConversionMethods.DecimalToOctal(16));
            Assert.Equal("40", ConversionMethods.DecimalToOctal(32));
            Assert.Equal("100", ConversionMethods.DecimalToOctal(64));
            Assert.Equal("200", ConversionMethods.DecimalToOctal(128));
            Assert.Equal("400", ConversionMethods.DecimalToOctal(256));
            Assert.Equal("1000", ConversionMethods.DecimalToOctal(512));
            Assert.Equal("2000", ConversionMethods.DecimalToOctal(1024));
        }

        [Fact]
        public static void BinaryToDecimalTest()
        {
            Assert.Equal(0, ConversionMethods.BinaryToDecimal("0"));
            Assert.Equal(1, ConversionMethods.BinaryToDecimal("1"));
            Assert.Equal(2, ConversionMethods.BinaryToDecimal("10"));
            Assert.Equal(3, ConversionMethods.BinaryToDecimal("11"));
            Assert.Equal(4, ConversionMethods.BinaryToDecimal("100"));
            Assert.Equal(5, ConversionMethods.BinaryToDecimal("101"));
            Assert.Equal(6, ConversionMethods.BinaryToDecimal("110"));
            Assert.Equal(7, ConversionMethods.BinaryToDecimal("111"));
            Assert.Equal(8, ConversionMethods.BinaryToDecimal("1000"));
            Assert.Equal(9, ConversionMethods.BinaryToDecimal("1001"));
            Assert.Equal(10, ConversionMethods.BinaryToDecimal("1010"));
            Assert.Equal(16, ConversionMethods.BinaryToDecimal("10000"));
            Assert.Equal(32, ConversionMethods.BinaryToDecimal("100000"));
            Assert.Equal(64, ConversionMethods.BinaryToDecimal("1000000"));
            Assert.Equal(128, ConversionMethods.BinaryToDecimal("10000000"));
            Assert.Equal(256, ConversionMethods.BinaryToDecimal("100000000"));
            Assert.Equal(512, ConversionMethods.BinaryToDecimal("1000000000"));
            Assert.Equal(1024, ConversionMethods.BinaryToDecimal("10000000000"));
        }

        [Fact]
        public static void BinaryToHexadecimalTest()
        {
            Assert.Equal("0", ConversionMethods.BinaryToHexadecimal("0"));
            Assert.Equal("1", ConversionMethods.BinaryToHexadecimal("1"));
            Assert.Equal("2", ConversionMethods.BinaryToHexadecimal("10"));
            Assert.Equal("3", ConversionMethods.BinaryToHexadecimal("11"));
            Assert.Equal("4", ConversionMethods.BinaryToHexadecimal("100"));
            Assert.Equal("5", ConversionMethods.BinaryToHexadecimal("101"));
            Assert.Equal("6", ConversionMethods.BinaryToHexadecimal("110"));
            Assert.Equal("7", ConversionMethods.BinaryToHexadecimal("111"));
            Assert.Equal("8", ConversionMethods.BinaryToHexadecimal("1000"));
            Assert.Equal("9", ConversionMethods.BinaryToHexadecimal("1001"));
            Assert.Equal("a", ConversionMethods.BinaryToHexadecimal("1010"));
            Assert.Equal("b", ConversionMethods.BinaryToHexadecimal("1011"));
            Assert.Equal("c", ConversionMethods.BinaryToHexadecimal("1100"));
            Assert.Equal("d", ConversionMethods.BinaryToHexadecimal("1101"));
            Assert.Equal("e", ConversionMethods.BinaryToHexadecimal("1110"));
            Assert.Equal("f", ConversionMethods.BinaryToHexadecimal("1111"));
        }

        [Fact]
        public static void BinaryToOctalTest()
        {
            Assert.Equal("0", ConversionMethods.BinaryToOctal("0"));
            Assert.Equal("1", ConversionMethods.BinaryToOctal("1"));
            Assert.Equal("2", ConversionMethods.BinaryToOctal("10"));
            Assert.Equal("3", ConversionMethods.BinaryToOctal("11"));
            Assert.Equal("4", ConversionMethods.BinaryToOctal("100"));
            Assert.Equal("5", ConversionMethods.BinaryToOctal("101"));
            Assert.Equal("6", ConversionMethods.BinaryToOctal("110"));
            Assert.Equal("7", ConversionMethods.BinaryToOctal("111"));
        }

        [Fact]
        public static void HexadecimalToDecimalTest()
        {
            Assert.Equal(0, ConversionMethods.HexadecimalToDecimal("0"));
            Assert.Equal(1, ConversionMethods.HexadecimalToDecimal("1"));
            Assert.Equal(2, ConversionMethods.HexadecimalToDecimal("2"));
            Assert.Equal(3, ConversionMethods.HexadecimalToDecimal("3"));
            Assert.Equal(4, ConversionMethods.HexadecimalToDecimal("4"));
            Assert.Equal(5, ConversionMethods.HexadecimalToDecimal("5"));
            Assert.Equal(6, ConversionMethods.HexadecimalToDecimal("6"));
            Assert.Equal(7, ConversionMethods.HexadecimalToDecimal("7"));
            Assert.Equal(8, ConversionMethods.HexadecimalToDecimal("8"));
            Assert.Equal(9, ConversionMethods.HexadecimalToDecimal("9"));
            Assert.Equal(10, ConversionMethods.HexadecimalToDecimal("a"));
            Assert.Equal(11, ConversionMethods.HexadecimalToDecimal("b"));
            Assert.Equal(12, ConversionMethods.HexadecimalToDecimal("c"));
            Assert.Equal(13, ConversionMethods.HexadecimalToDecimal("d"));
            Assert.Equal(14, ConversionMethods.HexadecimalToDecimal("e"));
            Assert.Equal(15, ConversionMethods.HexadecimalToDecimal("f"));
            Assert.Equal(16, ConversionMethods.HexadecimalToDecimal("10"));
            Assert.Equal(17, ConversionMethods.HexadecimalToDecimal("11"));
            Assert.Equal(18, ConversionMethods.HexadecimalToDecimal("12"));
            Assert.Equal(19, ConversionMethods.HexadecimalToDecimal("13"));
            Assert.Equal(20, ConversionMethods.HexadecimalToDecimal("14"));
            Assert.Equal(21, ConversionMethods.HexadecimalToDecimal("15"));
            Assert.Equal(22, ConversionMethods.HexadecimalToDecimal("16"));
            Assert.Equal(23, ConversionMethods.HexadecimalToDecimal("17"));
            Assert.Equal(24, ConversionMethods.HexadecimalToDecimal("18"));
            Assert.Equal(25, ConversionMethods.HexadecimalToDecimal("19"));
            Assert.Equal(26, ConversionMethods.HexadecimalToDecimal("1a"));
        }

        [Fact]
        public static void HexadecimalToBinaryTest()
        {
            Assert.Equal("0", ConversionMethods.HexadecimalToBinary("0"));
            Assert.Equal("1", ConversionMethods.HexadecimalToBinary("1"));
            Assert.Equal("10", ConversionMethods.HexadecimalToBinary("2"));
            Assert.Equal("11", ConversionMethods.HexadecimalToBinary("3"));
            Assert.Equal("100", ConversionMethods.HexadecimalToBinary("4"));
            Assert.Equal("101", ConversionMethods.HexadecimalToBinary("5"));
            Assert.Equal("110", ConversionMethods.HexadecimalToBinary("6"));
            Assert.Equal("111", ConversionMethods.HexadecimalToBinary("7"));
            Assert.Equal("1000", ConversionMethods.HexadecimalToBinary("8"));
            Assert.Equal("1001", ConversionMethods.HexadecimalToBinary("9"));
            Assert.Equal("1010", ConversionMethods.HexadecimalToBinary("a"));
            Assert.Equal("1011", ConversionMethods.HexadecimalToBinary("b"));
            Assert.Equal("1100", ConversionMethods.HexadecimalToBinary("c"));
            Assert.Equal("1101", ConversionMethods.HexadecimalToBinary("d"));
            Assert.Equal("1110", ConversionMethods.HexadecimalToBinary("e"));
            Assert.Equal("1111", ConversionMethods.HexadecimalToBinary("f"));
            Assert.Equal("10000", ConversionMethods.HexadecimalToBinary("10"));
            Assert.Equal("10001", ConversionMethods.HexadecimalToBinary("11"));
            Assert.Equal("10010", ConversionMethods.HexadecimalToBinary("12"));
            Assert.Equal("10011", ConversionMethods.HexadecimalToBinary("13"));
            Assert.Equal("10100", ConversionMethods.HexadecimalToBinary("14"));
            Assert.Equal("10101", ConversionMethods.HexadecimalToBinary("15"));
            Assert.Equal("10110", ConversionMethods.HexadecimalToBinary("16"));
            Assert.Equal("10111", ConversionMethods.HexadecimalToBinary("17"));
            Assert.Equal("11000", ConversionMethods.HexadecimalToBinary("18"));
            Assert.Equal("11001", ConversionMethods.HexadecimalToBinary("19"));
            Assert.Equal("11010", ConversionMethods.HexadecimalToBinary("1a"));
        }

        [Fact]
        public static void HexadecimalToOctalTest()
        {
            Assert.Equal("0", ConversionMethods.HexadecimalToOctal("0"));
            Assert.Equal("1", ConversionMethods.HexadecimalToOctal("1"));
            Assert.Equal("2", ConversionMethods.HexadecimalToOctal("2"));
            Assert.Equal("3", ConversionMethods.HexadecimalToOctal("3"));
            Assert.Equal("4", ConversionMethods.HexadecimalToOctal("4"));
            Assert.Equal("5", ConversionMethods.HexadecimalToOctal("5"));
            Assert.Equal("6", ConversionMethods.HexadecimalToOctal("6"));
            Assert.Equal("7", ConversionMethods.HexadecimalToOctal("7"));
            Assert.Equal("10", ConversionMethods.HexadecimalToOctal("8"));
            Assert.Equal("11", ConversionMethods.HexadecimalToOctal("9"));
            Assert.Equal("12", ConversionMethods.HexadecimalToOctal("a"));
            Assert.Equal("13", ConversionMethods.HexadecimalToOctal("b"));
            Assert.Equal("14", ConversionMethods.HexadecimalToOctal("c"));
            Assert.Equal("15", ConversionMethods.HexadecimalToOctal("d"));
            Assert.Equal("16", ConversionMethods.HexadecimalToOctal("e"));
            Assert.Equal("17", ConversionMethods.HexadecimalToOctal("f"));
            Assert.Equal("20", ConversionMethods.HexadecimalToOctal("10"));
            Assert.Equal("21", ConversionMethods.HexadecimalToOctal("11"));
            Assert.Equal("22", ConversionMethods.HexadecimalToOctal("12"));
            Assert.Equal("23", ConversionMethods.HexadecimalToOctal("13"));
            Assert.Equal("24", ConversionMethods.HexadecimalToOctal("14"));
            Assert.Equal("25", ConversionMethods.HexadecimalToOctal("15"));
            Assert.Equal("26", ConversionMethods.HexadecimalToOctal("16"));
            Assert.Equal("27", ConversionMethods.HexadecimalToOctal("17"));
            Assert.Equal("30", ConversionMethods.HexadecimalToOctal("18"));
            Assert.Equal("31", ConversionMethods.HexadecimalToOctal("19"));
            Assert.Equal("32", ConversionMethods.HexadecimalToOctal("1a"));
        }

        [Fact]
        public static void OctalToDecimalTest()
        {
            Assert.Equal(0, ConversionMethods.OctalToDecimal("0"));
            Assert.Equal(1, ConversionMethods.OctalToDecimal("1"));
            Assert.Equal(2, ConversionMethods.OctalToDecimal("2"));
            Assert.Equal(3, ConversionMethods.OctalToDecimal("3"));
            Assert.Equal(4, ConversionMethods.OctalToDecimal("4"));
            Assert.Equal(5, ConversionMethods.OctalToDecimal("5"));
            Assert.Equal(6, ConversionMethods.OctalToDecimal("6"));
            Assert.Equal(7, ConversionMethods.OctalToDecimal("7"));
            Assert.Equal(8, ConversionMethods.OctalToDecimal("10"));
            Assert.Equal(9, ConversionMethods.OctalToDecimal("11"));
            Assert.Equal(10, ConversionMethods.OctalToDecimal("12"));
            Assert.Equal(11, ConversionMethods.OctalToDecimal("13"));
            Assert.Equal(12, ConversionMethods.OctalToDecimal("14"));
            Assert.Equal(13, ConversionMethods.OctalToDecimal("15"));
            Assert.Equal(14, ConversionMethods.OctalToDecimal("16"));
            Assert.Equal(15, ConversionMethods.OctalToDecimal("17"));
            Assert.Equal(16, ConversionMethods.OctalToDecimal("20"));
            Assert.Equal(17, ConversionMethods.OctalToDecimal("21"));
            Assert.Equal(18, ConversionMethods.OctalToDecimal("22"));
            Assert.Equal(19, ConversionMethods.OctalToDecimal("23"));
            Assert.Equal(20, ConversionMethods.OctalToDecimal("24"));
            Assert.Equal(21, ConversionMethods.OctalToDecimal("25"));
            Assert.Equal(22, ConversionMethods.OctalToDecimal("26"));
            Assert.Equal(23, ConversionMethods.OctalToDecimal("27"));
            Assert.Equal(24, ConversionMethods.OctalToDecimal("30"));
            Assert.Equal(25, ConversionMethods.OctalToDecimal("31"));
            Assert.Equal(26, ConversionMethods.OctalToDecimal("32"));
        }

        [Fact]
        public static void OctalToBinaryTest()
        {
            Assert.Equal("0", ConversionMethods.OctalToBinary("0"));
            Assert.Equal("1", ConversionMethods.OctalToBinary("1"));
            Assert.Equal("10", ConversionMethods.OctalToBinary("2"));
            Assert.Equal("11", ConversionMethods.OctalToBinary("3"));
            Assert.Equal("100", ConversionMethods.OctalToBinary("4"));
            Assert.Equal("101", ConversionMethods.OctalToBinary("5"));
            Assert.Equal("110", ConversionMethods.OctalToBinary("6"));
            Assert.Equal("111", ConversionMethods.OctalToBinary("7"));
            Assert.Equal("1000", ConversionMethods.OctalToBinary("10"));
            Assert.Equal("1001", ConversionMethods.OctalToBinary("11"));
            Assert.Equal("1010", ConversionMethods.OctalToBinary("12"));
            Assert.Equal("1011", ConversionMethods.OctalToBinary("13"));
            Assert.Equal("1100", ConversionMethods.OctalToBinary("14"));
            Assert.Equal("1101", ConversionMethods.OctalToBinary("15"));
            Assert.Equal("1110", ConversionMethods.OctalToBinary("16"));
            Assert.Equal("1111", ConversionMethods.OctalToBinary("17"));
            Assert.Equal("10000", ConversionMethods.OctalToBinary("20"));
            Assert.Equal("10001", ConversionMethods.OctalToBinary("21"));
            Assert.Equal("10010", ConversionMethods.OctalToBinary("22"));
            Assert.Equal("10011", ConversionMethods.OctalToBinary("23"));
            Assert.Equal("10100", ConversionMethods.OctalToBinary("24"));
            Assert.Equal("10101", ConversionMethods.OctalToBinary("25"));
            Assert.Equal("10110", ConversionMethods.OctalToBinary("26"));
            Assert.Equal("10111", ConversionMethods.OctalToBinary("27"));
            Assert.Equal("11000", ConversionMethods.OctalToBinary("30"));
            Assert.Equal("11001", ConversionMethods.OctalToBinary("31"));
            Assert.Equal("11010", ConversionMethods.OctalToBinary("32"));
        }

        [Fact]
        public static void OctalToHexadecimalTest()
        {
            Assert.Equal("0", ConversionMethods.OctalToHexadecimal("0"));
            Assert.Equal("1", ConversionMethods.OctalToHexadecimal("1"));
            Assert.Equal("2", ConversionMethods.OctalToHexadecimal("2"));
            Assert.Equal("3", ConversionMethods.OctalToHexadecimal("3"));
            Assert.Equal("4", ConversionMethods.OctalToHexadecimal("4"));
            Assert.Equal("5", ConversionMethods.OctalToHexadecimal("5"));
            Assert.Equal("6", ConversionMethods.OctalToHexadecimal("6"));
            Assert.Equal("7", ConversionMethods.OctalToHexadecimal("7"));
            Assert.Equal("8", ConversionMethods.OctalToHexadecimal("10"));
            Assert.Equal("9", ConversionMethods.OctalToHexadecimal("11"));
            Assert.Equal("a", ConversionMethods.OctalToHexadecimal("12"));
            Assert.Equal("b", ConversionMethods.OctalToHexadecimal("13"));
            Assert.Equal("c", ConversionMethods.OctalToHexadecimal("14"));
            Assert.Equal("d", ConversionMethods.OctalToHexadecimal("15"));
            Assert.Equal("e", ConversionMethods.OctalToHexadecimal("16"));
            Assert.Equal("f", ConversionMethods.OctalToHexadecimal("17"));
            Assert.Equal("10", ConversionMethods.OctalToHexadecimal("20"));
            Assert.Equal("11", ConversionMethods.OctalToHexadecimal("21"));
            Assert.Equal("12", ConversionMethods.OctalToHexadecimal("22"));
            Assert.Equal("13", ConversionMethods.OctalToHexadecimal("23"));
            Assert.Equal("14", ConversionMethods.OctalToHexadecimal("24"));
            Assert.Equal("15", ConversionMethods.OctalToHexadecimal("25"));
            Assert.Equal("16", ConversionMethods.OctalToHexadecimal("26"));
            Assert.Equal("17", ConversionMethods.OctalToHexadecimal("27"));
            Assert.Equal("18", ConversionMethods.OctalToHexadecimal("30"));
            Assert.Equal("19", ConversionMethods.OctalToHexadecimal("31"));
            Assert.Equal("1a", ConversionMethods.OctalToHexadecimal("32"));
        }
    }
}
