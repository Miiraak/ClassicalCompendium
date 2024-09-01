namespace ClassicalCompendium.Tests
{
    public class RandomMethodsTests
    {
        [Fact]
        public void RandomIntegerTest()
        {
            int min = 0;
            int max = 100;
            int random = RandomMethods.RandomInteger(min, max);
            Assert.True(random >= min && random <= max);
            min = -100;
            max = 0;
            random = RandomMethods.RandomInteger(min, max);
            Assert.True(random >= min && random <= max);
        }

        [Fact]
        public void RandomDoubleTest()
        {
            double min = 0;
            double max = 100;
            double random = RandomMethods.RandomDouble(min, max);
            Assert.True(random >= min && random <= max);
            min = -100;
            max = 0;
            random = RandomMethods.RandomDouble(min, max);
            Assert.True(random >= min && random <= max);
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
            Assert.NotEqual(RandomMethods.RandomString(10), RandomMethods.RandomString(10));
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
            long random2 = RandomMethods.RandomLong(min, max);
            Assert.True(random2 >= min && random2 < max);
            Assert.True(random != random2);
        }
    }
}
