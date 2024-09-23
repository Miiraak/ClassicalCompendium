namespace ClassicalCompendium.Tests
{
    public class CaseMethodsTests
    {
        [Fact]
        public static void SentenceCaseTests()
        {
            Assert.Equal("Hello world", CaseMethods.SentenceCase("heLLo World"));
            Assert.Equal("A b c d e", CaseMethods.SentenceCase("a B c d e"));
        }

        [Fact]
        public static void TitleCaseTests()
        {
            Assert.Equal("Hello World", CaseMethods.TitleCase("heLLo world"));
            Assert.Equal("A B C D E", CaseMethods.TitleCase("a b c d e"));
            Assert.Equal("The Quick Brown Fox Jumps Over The Lazy Dog", CaseMethods.TitleCase("tHE quIck brown fox jumps over The LAzy DOG"));
        }

        [Fact]
        public static void StartCaseTests()
        {
            Assert.Equal("Hello World", CaseMethods.StartCase("heLLo world"));
            Assert.Equal("A B C D E F", CaseMethods.StartCase("A b C d E f"));
        }

        [Fact]
        public static void AllCapsTests()
        {
            Assert.Equal("HELLO WORLD", CaseMethods.AllCaps("heLLo worLd"));
            Assert.Equal("A B C D E", CaseMethods.AllCaps("a b c d e"));
        }

        [Fact]
        public static void AllLowerTests()
        {
            Assert.Equal("hello world", CaseMethods.AllLower("heLLo WORLD"));
            Assert.Equal("a b c d e", CaseMethods.AllLower("a B C d e"));
        }

        [Fact]
        public static void DromedaryCaseTests()
        {
            Assert.Equal("helloWorld", CaseMethods.DromedaryCase("heLLo woRld"));
            Assert.Equal("aBCDE", CaseMethods.DromedaryCase("a b C d e"));
        }

        [Fact]
        public static void SnakeCaseTests()
        {
            Assert.Equal("hello_world", CaseMethods.SnakeCase("heLLo worLd"));
            Assert.Equal("a_b_c_d_e", CaseMethods.SnakeCase("a B C d e"));
        }

        [Fact]
        public static void KebabCaseTests()
        {
            Assert.Equal("hello-world", CaseMethods.KebabCase("heLLo World"));
            Assert.Equal("a-b-c-d-e", CaseMethods.KebabCase("a b c D e"));
        }

        [Fact]
        public static void CamelCaseTests()
        {
            Assert.Equal("HelloWorld", CaseMethods.CamelCase("heLLo worlD"));
            Assert.Equal("ABCDE", CaseMethods.CamelCase("a B c d e"));
        }

        [Fact]
        public static void StudlyCapsTests()
        {
            Assert.NotEqual(CaseMethods.StudlyCaps("heLLo World"), CaseMethods.StudlyCaps("heLLo World"));
            Assert.NotEqual(CaseMethods.StudlyCaps("a B c d e"), CaseMethods.StudlyCaps("a B c d e"));
        }
    }
}
