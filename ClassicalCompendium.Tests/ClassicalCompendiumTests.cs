namespace ClassicalCompendium.Tests
{
    public class ClassicalCompendiumTests
    {
        [Fact]
        public void CodeCesarTest()
        {
            Assert.Equal("B", ListsMethods.CodeCesar(1, "A"));
            Assert.Equal("BC", ListsMethods.CodeCesar(1, "AB"));
            Assert.Equal("BCD", ListsMethods.CodeCesar(1, "ABC"));
            Assert.Equal("BC DE", ListsMethods.CodeCesar(1, "AB CD"));
            Assert.Equal("BC DE FG", ListsMethods.CodeCesar(1, "AB CD EF"));
            Assert.Equal("BC DE FG HI !!", ListsMethods.CodeCesar(1, "AB CD EF GH !!"));
            Assert.Equal("BC DE FG HI !! 234", ListsMethods.CodeCesar(1, "AB CD EF GH !! 123"));
            Assert.Equal("BC DE FG HI !! 234 567", ListsMethods.CodeCesar(1, "AB CD EF GH !! 123 456"));
            Assert.Equal("BC DE FG HI !! 234 567 890", ListsMethods.CodeCesar(1, "AB CD EF GH !! 123 456 789"));
            Assert.Equal("A", ListsMethods.CodeCesar(26, "A"));
            Assert.Equal("AB", ListsMethods.CodeCesar(26, "AB"));
            Assert.Equal("ABC", ListsMethods.CodeCesar(26, "ABC"));
            Assert.Equal("AB CD", ListsMethods.CodeCesar(26, "AB CD"));
            Assert.Equal("AB CD EF", ListsMethods.CodeCesar(26, "AB CD EF"));
            Assert.Equal("AB CD EF GH", ListsMethods.CodeCesar(26, "AB CD EF GH"));
            Assert.Equal("AB CD EF GH !!", ListsMethods.CodeCesar(26, "AB CD EF GH !!"));
        }
    }
}