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
        public void RandomIntegerTest()
        {
            int min = 0;
            int max = 100;
            int random = RandomMethods.RandomInteger(min, max);
            Assert.True(random >= min && random < max);
            min = -100;
            max = 0;
            random = RandomMethods.RandomInteger(min, max);
            Assert.True(random >= min && random < max);
        }

        [Fact]
        public void RandomDoubleTest()
        {
            double min = 0;
            double max = 100;
            double random = RandomMethods.RandomDouble(min, max);
            Assert.True(random >= min && random < max);
            min = -100;
            max = 0;
            random = RandomMethods.RandomDouble(min, max);
            Assert.True(random >= min && random < max);
        }

        [Fact]
        public void RandomStringTest()
        {
            int length = 10;
            string random = RandomMethods.RandomString(length);
            Assert.Equal(length, random.Length);
            length = 100;
            random = RandomMethods.RandomString(length);
            Assert.Equal(length, random.Length);
        }

        [Fact]
        public void RandomBooleanTest()
        {
            bool random = RandomMethods.RandomBoolean();
            Assert.True(random == true || random == false);
            random = RandomMethods.RandomBoolean();
            Assert.True(random == true || random == false);
        }

        [Fact]
        public void RandomLongTest()
        {
            long min = 0;
            long max = 100;
            long random = RandomMethods.RandomLong(min, max);
            Assert.True(random >= min && random < max);
            min = -100;
            max = 0;
            random = RandomMethods.RandomLong(min, max);
            Assert.True(random >= min && random < max);
        }
    }
}