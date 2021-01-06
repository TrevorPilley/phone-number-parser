using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_FR_Tests
    {
        [Fact]
        public void FR()
        {
            Assert.Same(CountryInfo.FR, CountryInfo.FR);

            var countryInfo = CountryInfo.FR;

            Assert.Empty(countryInfo.AreaCodeLengths);
            Assert.Equal("+33", countryInfo.CallingCode);
            Assert.IsType<PhoneNumberFormatter>(countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("FR", countryInfo.Iso3116Code);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }
    }
}
