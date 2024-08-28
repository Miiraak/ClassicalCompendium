namespace ClassicalCompendium.Tests
{
    public class PreSetListsTests
    {
        [Fact]
        public void MonthsTests()
        {
            Assert.Equal("January", PreSetLists.Time.Months[0]);
            Assert.Equal("February", PreSetLists.Time.Months[1]);
            Assert.Equal("March", PreSetLists.Time.Months[2]);
            Assert.Equal(12, PreSetLists.Time.Months.Count());
        }

        [Fact]
        public void DaysOfWeekTests()
        {
            Assert.Equal("Monday", PreSetLists.Time.WeekDays[0]);
            Assert.Equal("Tuesday", PreSetLists.Time.WeekDays[1]);
            Assert.Equal("Wednesday", PreSetLists.Time.WeekDays[2]);
            Assert.Equal(7, PreSetLists.Time.WeekDays.Count);
        }                                                     

        [Fact]
        public void HoursTests()
        {
            Assert.Equal("12 PM", PreSetLists.Time.Hours[0]);
            Assert.Equal("1 AM", PreSetLists.Time.Hours[1]);
            Assert.Equal("2 AM", PreSetLists.Time.Hours[2]);
            Assert.Equal(24, PreSetLists.Time.Hours.Count);
        }

        [Fact]
        public void CountryISOTests()
        {
            Assert.Equal("AF", PreSetLists.Country.CountryISO[0].Item2);
        }

        [Fact]
        public void MostUsedLangagesTests()
        {
            Assert.Equal("English", PreSetLists.Country.MostUsedLangages[0]);
            Assert.Equal("French", PreSetLists.Country.MostUsedLangages[1]);
            Assert.Equal("Arabic", PreSetLists.Country.MostUsedLangages[2]);
            Assert.Equal(10, PreSetLists.Country.MostUsedLangages.Count);
        }

        [Fact]
        public void OfficialLanguagesTests()
        {
            Assert.Equal("Abkhaz", PreSetLists.Country.OfficialLanguages[0]);
            Assert.Equal("Armenian", PreSetLists.Country.OfficialLanguages[9]);
            Assert.Equal("Bedik", PreSetLists.Country.OfficialLanguages[18]);
            Assert.Equal(214, PreSetLists.Country.OfficialLanguages.Count);
        }
    }
}                          
