namespace ClassicalCompendium.Tests
{
    public class PresetListsTests
    {
        public class Time
        {
            [Fact]
            public void MonthsTests()
            {
                Assert.Equal("January", PresetLists.Time.Months[0]);
                Assert.Equal("February", PresetLists.Time.Months[1]);
                Assert.Equal("March", PresetLists.Time.Months[2]);
                Assert.Equal(12, PresetLists.Time.Months.Count);
            }

            [Fact]
            public void DaysOfWeekTests()
            {
                Assert.Equal("Monday", PresetLists.Time.WeekDays[0]);
                Assert.Equal("Tuesday", PresetLists.Time.WeekDays[1]);
                Assert.Equal("Wednesday", PresetLists.Time.WeekDays[2]);
                Assert.Equal(7, PresetLists.Time.WeekDays.Count);
            }

            [Fact]
            public void HoursTests()
            {
                Assert.Equal("12 PM", PresetLists.Time.Hours[0]);
                Assert.Equal("1 AM", PresetLists.Time.Hours[1]);
                Assert.Equal("2 AM", PresetLists.Time.Hours[2]);
                Assert.Equal(24, PresetLists.Time.Hours.Count);
            }
        }

        public class Countries
        {
            [Fact]
            public void CountryISOTests()
            {
                Assert.Equal("AF", PresetLists.Countries.CountryISO[0].Item2);
            }

            [Fact]
            public void MostUsedLangagesTests()
            {
                Assert.Equal("English", PresetLists.Countries.MostUsedLangages[0]);
                Assert.Equal("French", PresetLists.Countries.MostUsedLangages[1]);
                Assert.Equal("Arabic", PresetLists.Countries.MostUsedLangages[2]);
                Assert.Equal(10, PresetLists.Countries.MostUsedLangages.Count);
            }

            [Fact]
            public void OfficialLanguagesTests()
            {
                Assert.Equal("Abkhaz", PresetLists.Countries.OfficialLanguages[0]);
                Assert.Equal("Armenian", PresetLists.Countries.OfficialLanguages[9]);
                Assert.Equal("Bedik", PresetLists.Countries.OfficialLanguages[18]);
                Assert.Equal(214, PresetLists.Countries.OfficialLanguages.Count);
            }
        }

        public class Chars
        {
            [Fact]
            public void ReverseAlphabetTests()
            {
                Assert.Equal("Z", PresetLists.Chars.ReverseAlphabet['A']);
                Assert.Equal("Y", PresetLists.Chars.ReverseAlphabet['B']);
                Assert.Equal("A", PresetLists.Chars.ReverseAlphabet['Z']);
            }

            [Fact]
            public void OrderOfMagnitudeTests()
            {
                Assert.Equal(("kilo", 3), PresetLists.Chars.OrderOfMagnitude[14]);
                Assert.Equal(("quetta", 30), PresetLists.Chars.OrderOfMagnitude[23]);
                Assert.Equal(("quecto", -30), PresetLists.Chars.OrderOfMagnitude[0]);
            }
        }

        public class Numbers
        {
            [Fact]
            public void HexadecimalNumbersTests()
            {
                Assert.Equal("0", PresetLists.Numbers.HexadecimalNumbers[0]);
                Assert.Equal("1", PresetLists.Numbers.HexadecimalNumbers[1]);
                Assert.Equal("9", PresetLists.Numbers.HexadecimalNumbers[9]);
                Assert.Equal("A", PresetLists.Numbers.HexadecimalNumbers[10]);
                Assert.Equal("F", PresetLists.Numbers.HexadecimalNumbers[15]);
                Assert.Equal("10", PresetLists.Numbers.HexadecimalNumbers[16]);
                Assert.Equal("1F", PresetLists.Numbers.HexadecimalNumbers[31]);
                Assert.Equal("FF", PresetLists.Numbers.HexadecimalNumbers[255]);

            }

            [Fact]
            public void PrimeN()
            {
                Assert.Empty(PresetLists.Numbers.PrimesN(0));
                Assert.Empty(PresetLists.Numbers.PrimesN(1));
                Assert.Equal(100, PresetLists.Numbers.PrimesN(100).Count);
                Assert.Equal(200, PresetLists.Numbers.PrimesN(200).Count);
                Assert.True(PresetLists.Numbers.PrimesN(5).SequenceEqual(new List<int> { 2, 3, 5, 7, 11 }));
            }

            [Fact]
            public void FibonacciN()
            {
                Assert.True(PresetLists.Numbers.FibonacciN(1).SequenceEqual(new List<int> { 0 }));
                Assert.True(PresetLists.Numbers.FibonacciN(2).SequenceEqual(new List<int> { 0, 1 }));
                Assert.True(PresetLists.Numbers.FibonacciN(3).SequenceEqual(new List<int> { 0, 1, 1 }));
                Assert.True(PresetLists.Numbers.FibonacciN(4).SequenceEqual(new List<int> { 0, 1, 1, 2 }));
                Assert.True(PresetLists.Numbers.FibonacciN(5).SequenceEqual(new List<int> { 0, 1, 1, 2, 3 }));
                Assert.True(PresetLists.Numbers.FibonacciN(6).SequenceEqual(new List<int> { 0, 1, 1, 2, 3, 5 }));
                Assert.True(PresetLists.Numbers.FibonacciN(7).SequenceEqual(new List<int> { 0, 1, 1, 2, 3, 5, 8 }));
                Assert.Equal(50, PresetLists.Numbers.FibonacciN(50).Count);
            }

            [Fact]
            public void MercenneTests()
            {
                Assert.True(PresetLists.Numbers.MersenneN(1).SequenceEqual(new List<int> { 0 }));
                Assert.True(PresetLists.Numbers.MersenneN(2).SequenceEqual(new List<int> { 0, 1 }));
                Assert.True(PresetLists.Numbers.MersenneN(3).SequenceEqual(new List<int> { 0, 1, 3 }));
                Assert.True(PresetLists.Numbers.MersenneN(4).SequenceEqual(new List<int> { 0, 1, 3, 7 }));
                Assert.True(PresetLists.Numbers.MersenneN(5).SequenceEqual(new List<int> { 0, 1, 3, 7, 15 }));
                Assert.True(PresetLists.Numbers.MersenneN(6).SequenceEqual(new List<int> { 0, 1, 3, 7, 15, 31 }));
                Assert.True(PresetLists.Numbers.MersenneN(7).SequenceEqual(new List<int> { 0, 1, 3, 7, 15, 31, 63 }));
                Assert.Equal(50, PresetLists.Numbers.MersenneN(50).Count);
            }
        }
    }
}
