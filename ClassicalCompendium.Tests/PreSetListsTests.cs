namespace ClassicalCompendium.Tests
{
    public class PreSetListsTests
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
}
