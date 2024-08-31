namespace ClassicalCompendium.Tests
{
    public class CalculsMethodsTests
    {
        [Fact]
        public void IsOddTest()
        {
            Assert.False(CalculsMethods.IsOdd(0));
            Assert.True(CalculsMethods.IsOdd(1));
            Assert.False(CalculsMethods.IsOdd(2));
            Assert.True(CalculsMethods.IsOdd(3));
            Assert.False(CalculsMethods.IsOdd(4));
            Assert.True(CalculsMethods.IsOdd(5));
            Assert.False(CalculsMethods.IsOdd(6));
            Assert.True(CalculsMethods.IsOdd(7));
            Assert.False(CalculsMethods.IsOdd(8));
            Assert.True(CalculsMethods.IsOdd(9));
            Assert.False(CalculsMethods.IsOdd(10));
        }

        [Fact]
        public void IsEvenTest()
        {
            Assert.True(CalculsMethods.IsEven(0));
            Assert.False(CalculsMethods.IsEven(1));
            Assert.True(CalculsMethods.IsEven(2));
            Assert.False(CalculsMethods.IsEven(3));
            Assert.True(CalculsMethods.IsEven(4));
            Assert.False(CalculsMethods.IsEven(5));
            Assert.True(CalculsMethods.IsEven(6));
            Assert.False(CalculsMethods.IsEven(7));
            Assert.True(CalculsMethods.IsEven(8));
            Assert.False(CalculsMethods.IsEven(9));
            Assert.True(CalculsMethods.IsEven(10));
        }

        [Fact]
        public void SumToNTest()
        {
            Assert.Equal(0, CalculsMethods.SumToN(0));
            Assert.Equal(1, CalculsMethods.SumToN(1));
            Assert.Equal(3, CalculsMethods.SumToN(2));
            Assert.Equal(6, CalculsMethods.SumToN(3));
            Assert.Equal(10, CalculsMethods.SumToN(4));
            Assert.Equal(15, CalculsMethods.SumToN(5));
            Assert.Equal(21, CalculsMethods.SumToN(6));
            Assert.Equal(28, CalculsMethods.SumToN(7));
            Assert.Equal(36, CalculsMethods.SumToN(8));
            Assert.Equal(45, CalculsMethods.SumToN(9));
            Assert.Equal(55, CalculsMethods.SumToN(10));
        }

        [Fact]
        public void SubtractToNTest()
        {
            Assert.Equal(0, CalculsMethods.SubtractToN(0));
            Assert.Equal(-1, CalculsMethods.SubtractToN(1));
            Assert.Equal(-3, CalculsMethods.SubtractToN(2));
            Assert.Equal(-6, CalculsMethods.SubtractToN(3));
            Assert.Equal(-10, CalculsMethods.SubtractToN(4));
            Assert.Equal(-15, CalculsMethods.SubtractToN(5));
            Assert.Equal(-21, CalculsMethods.SubtractToN(6));
            Assert.Equal(-28, CalculsMethods.SubtractToN(7));
            Assert.Equal(-36, CalculsMethods.SubtractToN(8));
            Assert.Equal(-45, CalculsMethods.SubtractToN(9));
            Assert.Equal(-55, CalculsMethods.SubtractToN(10));
        }

        [Fact]
        public void FactorialNTest()
        {
            Assert.Equal(0, CalculsMethods.FactorialN(0));
            Assert.Equal(1, CalculsMethods.FactorialN(1));
            Assert.Equal(2, CalculsMethods.FactorialN(2));
            Assert.Equal(6, CalculsMethods.FactorialN(3));
            Assert.Equal(24, CalculsMethods.FactorialN(4));
            Assert.Equal(120, CalculsMethods.FactorialN(5));
            Assert.Equal(720, CalculsMethods.FactorialN(6));
            Assert.Equal(5040, CalculsMethods.FactorialN(7));
            Assert.Equal(40320, CalculsMethods.FactorialN(8));
            Assert.Equal(362880, CalculsMethods.FactorialN(9));
            Assert.Equal(3628800, CalculsMethods.FactorialN(10));
        }

        [Fact]
        public void NegFactorialNTest()
        {
            Assert.Equal(0, CalculsMethods.NegFactorialN(0));
            Assert.Equal(-1, CalculsMethods.NegFactorialN(1));
            Assert.Equal(2, CalculsMethods.NegFactorialN(2));
            Assert.Equal(-6, CalculsMethods.NegFactorialN(3));
            Assert.Equal(24, CalculsMethods.NegFactorialN(4));
            Assert.Equal(-120, CalculsMethods.NegFactorialN(5));
            Assert.Equal(720, CalculsMethods.NegFactorialN(6));
            Assert.Equal(-5040, CalculsMethods.NegFactorialN(7));
            Assert.Equal(40320, CalculsMethods.NegFactorialN(8));
            Assert.Equal(-362880, CalculsMethods.NegFactorialN(9));
            Assert.Equal(3628800, CalculsMethods.NegFactorialN(10));
        }
    }
}
