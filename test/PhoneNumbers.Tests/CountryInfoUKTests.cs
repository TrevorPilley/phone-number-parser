using PhoneNumbers.Formatters;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests
{
    public partial class CountryInfoTests
    {
        [Fact]
        public void AllSupported_Contains_UK() =>
            Assert.Contains(CountryInfo.UK, CountryInfo.AllSupported());

        [Fact]
        public void UK()
        {
            Assert.Same(CountryInfo.UK, CountryInfo.UK);
            Assert.Same(CountryInfo.UK, CountryInfo.Find("GB"));

            CountryInfo countryInfo = CountryInfo.UK;

            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.IsType<UkPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.IsType<UkPhoneNumberParser>(countryInfo.Parser);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData("+441132224444")]
        [InlineData("(0113) 222 4444")]
        [InlineData("01132224444")]
        public void UK_ConvertToNationalNumber(string value) =>
            Assert.Equal("01132224444", CountryInfo.UK.ConvertToNationalNumber(value));

        [Theory]
        [InlineData("+35312222222")]
        [InlineData(" ")]
        [InlineData(default(string))]
        public void UK_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.UK.IsInternationalNumber(value));

        [Fact]
        public void UK_IsInternationalNumber_True() =>
            Assert.True(CountryInfo.UK.IsInternationalNumber("+441132224444"));

        [Theory]
        [InlineData("+35312222222")]
        [InlineData(" ")]
        [InlineData(default(string))]
        public void UK_IsNumber_False(string value) =>
            Assert.False(CountryInfo.UK.IsNumber(value));

        [Theory]
        [InlineData("+441132224444")]
        [InlineData("(0113) 222 4444")]
        [InlineData("01132224444")]
        public void UK_IsNumber_True(string value) =>
            Assert.True(CountryInfo.UK.IsNumber(value));
    }
}
