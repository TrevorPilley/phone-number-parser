using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_HK_Tests
    {
        [Fact]
        public void HK()
        {
            Assert.Same(CountryInfo.HK, CountryInfo.HK);

            var countryInfo = CountryInfo.HK;

            Assert.Empty(countryInfo.AreaCodeLengths);
            Assert.Equal("+852", countryInfo.CallingCode);
            Assert.IsType<HKPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("001", countryInfo.InternationalCallPrefix);
            Assert.Equal("HK", countryInfo.Iso3116Code);
            Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+35312222222")]
        public void HK_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.HK.IsInternationalNumber(value));

        [Theory]
        [InlineData("+85212345678")]
        [InlineData("+852 1234 5678")]
        public void HK_IsInternationalNumber_True(string value) =>
            Assert.True(CountryInfo.HK.IsInternationalNumber(value));

        [Theory]
        [InlineData("+85229013000")]
        [InlineData("+852 2901 3000")]
        [InlineData("29013000")]
        [InlineData("2901 3000")]
        [InlineData("2901-3000")]
        public void HK_ReadNationalSignificantNumber(string value) =>
            Assert.Equal("29013000", CountryInfo.HK.ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+35312222222")]
        public void UK_ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(string.Empty, CountryInfo.HK.ReadNationalSignificantNumber(value));
    }
}
