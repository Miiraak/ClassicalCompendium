namespace ClassicalCompendium.Tests
{
    public class CryptoMethodsTests
    {
        [Fact]
        public void CodeCesarTest()
        {
            Assert.Equal("B", CryptoMethods.CodeCesar(1, "A"));
            Assert.Equal("BC", CryptoMethods.CodeCesar(1, "AB"));
            Assert.Equal("BCD", CryptoMethods.CodeCesar(1, "ABC"));
            Assert.Equal("BC DE", CryptoMethods.CodeCesar(1, "AB CD"));
            Assert.Equal("BC DE FG", CryptoMethods.CodeCesar(1, "AB CD EF"));
            Assert.Equal("BC DE FG HI !!", CryptoMethods.CodeCesar(1, "AB CD EF GH !!"));
            Assert.Equal("A", CryptoMethods.CodeCesar(26, "A"));
            Assert.Equal("AB", CryptoMethods.CodeCesar(26, "AB"));
            Assert.Equal("ABC", CryptoMethods.CodeCesar(26, "ABC"));
            Assert.Equal("AB CD", CryptoMethods.CodeCesar(26, "AB CD"));
            Assert.Equal("AB CD EF", CryptoMethods.CodeCesar(26, "AB CD EF"));
            Assert.Equal("AB CD EF GH", CryptoMethods.CodeCesar(26, "AB CD EF GH"));
            Assert.Equal("AB CD EF GH !!", CryptoMethods.CodeCesar(26, "AB CD EF GH !!"));
            Assert.Equal("2345678901", CryptoMethods.CodeCesar(1, "0123456789"));

        }
    }
}