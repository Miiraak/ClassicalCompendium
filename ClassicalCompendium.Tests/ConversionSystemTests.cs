namespace ClassicalCompendium.Tests
{
    public class ConversionSystemTests
    {
        [Fact]
        public void BaseToBaseTests()
        {
            Assert.Equal("4", ConversionMethods.BaseToBase(2, 10, "100"));
            Assert.Equal("100", ConversionMethods.BaseToBase(10, 2, "4"));
        }
    }
}
