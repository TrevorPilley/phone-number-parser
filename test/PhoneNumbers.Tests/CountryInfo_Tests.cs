using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_Tests
    {
        [Fact]
        public void When_Constructed()
        {
            var countryInfo = new CountryInfo();

            Assert.Empty(countryInfo.AreaCodeLengths);
            Assert.Null(countryInfo.CallingCode);
            Assert.Same(PhoneNumberFormatter.Default, countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Null(countryInfo.Iso3166Code);
            Assert.Empty(countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }
    }
}
