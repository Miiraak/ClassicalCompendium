namespace ClassicalCompendium.Tests
{
    public class CryptoMethodsTests
    {
        [Fact]
        public void CodeCesarTest()
        {
            Assert.Equal("B", CryptoMethods.EncodeWithCesar(1, "A"));
            Assert.Equal("BC", CryptoMethods.EncodeWithCesar(1, "AB"));
            Assert.Equal("BCD", CryptoMethods.EncodeWithCesar(1, "ABC"));
            Assert.Equal("BC DE", CryptoMethods.EncodeWithCesar(1, "AB CD"));
            Assert.Equal("BC DE FG", CryptoMethods.EncodeWithCesar(1, "AB CD EF"));
            Assert.Equal("BC DE FG HI !!", CryptoMethods.EncodeWithCesar(1, "AB CD EF GH !!"));
            Assert.Equal("A", CryptoMethods.EncodeWithCesar(26, "A"));
            Assert.Equal("AB", CryptoMethods.EncodeWithCesar(26, "AB"));
            Assert.Equal("ABC", CryptoMethods.EncodeWithCesar(26, "ABC"));
            Assert.Equal("AB CD", CryptoMethods.EncodeWithCesar(26, "AB CD"));
            Assert.Equal("AB CD EF", CryptoMethods.EncodeWithCesar(26, "AB CD EF"));
            Assert.Equal("AB CD EF GH", CryptoMethods.EncodeWithCesar(26, "AB CD EF GH"));
            Assert.Equal("AB CD EF GH !!", CryptoMethods.EncodeWithCesar(26, "AB CD EF GH !!"));
            Assert.Equal("2345678901", CryptoMethods.EncodeWithCesar(1, "0123456789"));
        }

        [Fact]
        public void CodeAtBashTest()
        {
            Assert.Equal("Z", CryptoMethods.EncodeWithAtBash("A"));
            Assert.Equal("Z", CryptoMethods.EncodeWithAtBash("a"));
            Assert.Equal("ZYXW", CryptoMethods.EncodeWithAtBash("AbCd"));
            Assert.Equal("Z Y X W", CryptoMethods.EncodeWithAtBash("a B c D"));
            Assert.Equal("!()#%&|╱|洱妍洹|#{[]育╡為", CryptoMethods.EncodeWithAtBash("!()#%&|╱|洱妍洹|#{[]育╡為"));
        }

        [Fact]
        public void DoSHA256Test()
        {
            Assert.Equal("e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", CryptoMethods.SHA256(""));
            Assert.Equal("d7a8fbb307d7809469ca9abcb0082e4f8d5651e46d3cdb762d02d0bf37c9e592", CryptoMethods.SHA256("The quick brown fox jumps over the lazy dog"));
        }
    }
}