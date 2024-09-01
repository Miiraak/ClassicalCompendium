namespace ClassicalCompendium.Tests
{
    public class HashMethodsTests
    {
        [Fact]
        public void CRC8Test()
        {
            Assert.Equal("0x00", HashMethods.CRC8(""));
            Assert.Equal("0x2E", HashMethods.CRC8("Bonjour"));
            Assert.Equal("0xC1", HashMethods.CRC8("The quick brown fox jumps over the lazy dog"));
        }

        [Fact]
        public void SHA256Test()
        {
            Assert.Equal("e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", HashMethods.SHA256(""));
            Assert.Equal("d7a8fbb307d7809469ca9abcb0082e4f8d5651e46d3cdb762d02d0bf37c9e592", HashMethods.SHA256("The quick brown fox jumps over the lazy dog"));
        }
    }
}
