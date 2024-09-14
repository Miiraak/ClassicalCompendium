namespace ClassicalCompendium.Tests
{
    public class ConversionSystemTests
    {
        [Fact]
        public void Base2ToBaseXTests()
        {
            // Tests for base 2 to X
            Assert.Equal("101", ConversionMethods.BaseToBase(2, 3, "1010"));
            Assert.Equal("22", ConversionMethods.BaseToBase(2, 4, "1010"));
            Assert.Equal("20", ConversionMethods.BaseToBase(2, 5, "1010"));
            Assert.Equal("14", ConversionMethods.BaseToBase(2, 6, "1010"));
            Assert.Equal("13", ConversionMethods.BaseToBase(2, 7, "1010"));
            Assert.Equal("12", ConversionMethods.BaseToBase(2, 8, "1010"));
            Assert.Equal("11", ConversionMethods.BaseToBase(2, 9, "1010"));
            Assert.Equal("10", ConversionMethods.BaseToBase(2, 10, "1010"));
        }

        [Fact]
        public void Base3ToBaseXTests()
        {
            // Tests for base 3 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(3, 2, "101"));
            Assert.Equal("22", ConversionMethods.BaseToBase(3, 4, "101"));
            Assert.Equal("20", ConversionMethods.BaseToBase(3, 5, "101"));
            Assert.Equal("14", ConversionMethods.BaseToBase(3, 6, "101"));
            Assert.Equal("13", ConversionMethods.BaseToBase(3, 7, "101"));
            Assert.Equal("12", ConversionMethods.BaseToBase(3, 8, "101"));
            Assert.Equal("11", ConversionMethods.BaseToBase(3, 9, "101"));
            Assert.Equal("10", ConversionMethods.BaseToBase(3, 10, "101"));
        }

        [Fact]
        public void Base4ToBaseXTests()
        {
            // Tests for base 4 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(4, 2, "22"));
            Assert.Equal("101", ConversionMethods.BaseToBase(4, 3, "22"));
            Assert.Equal("20", ConversionMethods.BaseToBase(4, 5, "22"));
            Assert.Equal("14", ConversionMethods.BaseToBase(4, 6, "22"));
            Assert.Equal("13", ConversionMethods.BaseToBase(4, 7, "22"));
            Assert.Equal("12", ConversionMethods.BaseToBase(4, 8, "22"));
            Assert.Equal("11", ConversionMethods.BaseToBase(4, 9, "22"));
            Assert.Equal("10", ConversionMethods.BaseToBase(4, 10, "22"));
        }

        [Fact]
        public void Base5ToBaseXTests()
        {
            // Tests for base 5 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(5, 2, "20"));
            Assert.Equal("101", ConversionMethods.BaseToBase(5, 3, "20"));
            Assert.Equal("22", ConversionMethods.BaseToBase(5, 4, "20"));
            Assert.Equal("14", ConversionMethods.BaseToBase(5, 6, "20"));
            Assert.Equal("13", ConversionMethods.BaseToBase(5, 7, "20"));
            Assert.Equal("12", ConversionMethods.BaseToBase(5, 8, "20"));
            Assert.Equal("11", ConversionMethods.BaseToBase(5, 9, "20"));
            Assert.Equal("10", ConversionMethods.BaseToBase(5, 10, "20"));
        }

        [Fact]
        public void Base6ToBaseXTests()
        {
            // Tests for base 6 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(6, 2, "14"));
            Assert.Equal("101", ConversionMethods.BaseToBase(6, 3, "14"));
            Assert.Equal("22", ConversionMethods.BaseToBase(6, 4, "14"));
            Assert.Equal("20", ConversionMethods.BaseToBase(6, 5, "14"));
            Assert.Equal("13", ConversionMethods.BaseToBase(6, 7, "14"));
            Assert.Equal("12", ConversionMethods.BaseToBase(6, 8, "14"));
            Assert.Equal("11", ConversionMethods.BaseToBase(6, 9, "14"));
            Assert.Equal("10", ConversionMethods.BaseToBase(6, 10, "14"));
        }


        [Fact]
        public void Base7ToBaseXTests()
        {
            // Tests for base 7 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(7, 2, "13"));
            Assert.Equal("101", ConversionMethods.BaseToBase(7, 3, "13"));
            Assert.Equal("22", ConversionMethods.BaseToBase(7, 4, "13"));
            Assert.Equal("20", ConversionMethods.BaseToBase(7, 5, "13"));
            Assert.Equal("14", ConversionMethods.BaseToBase(7, 6, "13"));
            Assert.Equal("12", ConversionMethods.BaseToBase(7, 8, "13"));
            Assert.Equal("11", ConversionMethods.BaseToBase(7, 9, "13"));
            Assert.Equal("10", ConversionMethods.BaseToBase(7, 10, "13"));
        }

        [Fact]
        public void Base8ToBaseXTests()
        {
            // Tests for base 8 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(8, 2, "12"));
            Assert.Equal("101", ConversionMethods.BaseToBase(8, 3, "12"));
            Assert.Equal("22", ConversionMethods.BaseToBase(8, 4, "12"));
            Assert.Equal("20", ConversionMethods.BaseToBase(8, 5, "12"));
            Assert.Equal("14", ConversionMethods.BaseToBase(8, 6, "12"));
            Assert.Equal("13", ConversionMethods.BaseToBase(8, 7, "12"));
            Assert.Equal("11", ConversionMethods.BaseToBase(8, 9, "12"));
            Assert.Equal("10", ConversionMethods.BaseToBase(8, 10, "12"));
        }

        [Fact]
        public void Base9ToBaseXTests()
        {
            // Tests for base 9 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(9, 2, "11"));
            Assert.Equal("101", ConversionMethods.BaseToBase(9, 3, "11"));
            Assert.Equal("22", ConversionMethods.BaseToBase(9, 4, "11"));
            Assert.Equal("20", ConversionMethods.BaseToBase(9, 5, "11"));
            Assert.Equal("14", ConversionMethods.BaseToBase(9, 6, "11"));
            Assert.Equal("13", ConversionMethods.BaseToBase(9, 7, "11"));
            Assert.Equal("12", ConversionMethods.BaseToBase(9, 8, "11"));
            Assert.Equal("10", ConversionMethods.BaseToBase(9, 10, "11"));
        }

        [Fact]
        public void Base10ToBaseXTests()
        {
            // Tests for base 10 to X
            Assert.Equal("1010", ConversionMethods.BaseToBase(10, 2, "10"));
            Assert.Equal("101", ConversionMethods.BaseToBase(10, 3, "10"));
            Assert.Equal("22", ConversionMethods.BaseToBase(10, 4, "10"));
            Assert.Equal("20", ConversionMethods.BaseToBase(10, 5, "10"));
            Assert.Equal("14", ConversionMethods.BaseToBase(10, 6, "10"));
            Assert.Equal("13", ConversionMethods.BaseToBase(10, 7, "10"));
            Assert.Equal("12", ConversionMethods.BaseToBase(10, 8, "10"));
            Assert.Equal("11", ConversionMethods.BaseToBase(10, 9, "10"));
        }
    }
}
