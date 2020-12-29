using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfoUKTests
    {
        [Fact]
        public void UK()
        {
            Assert.Same(CountryInfo.UK, CountryInfo.UK);

            var countryInfo = CountryInfo.UK;

            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.IsType<UKPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("GB", countryInfo.Iso3116Code);
            Assert.Equal(new[] { 7, 9, 10 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData("+35312222222")]
        [InlineData(" ")]
        [InlineData(default(string))]
        public void UK_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.UK.IsInternationalNumber(value));

        [Theory]
        [InlineData("+441132224444")]
        [InlineData("+44 (0) 113 222 4444")]
        public void UK_IsInternationalNumber_True(string value) =>
            Assert.True(CountryInfo.UK.IsInternationalNumber(value));

        [Theory]
        [InlineData("+35312222222")]
        [InlineData(" ")]
        [InlineData(default(string))]
        public void UK_IsNumber_False(string value) =>
            Assert.False(CountryInfo.UK.IsNumber(value));

        [Theory]
        [InlineData("+441132224444")]
        [InlineData("+44 (0) 113 222 4444")]
        [InlineData("(0113) 222 4444")]
        [InlineData("01132224444")]
        public void UK_IsNumber_True(string value) =>
            Assert.True(CountryInfo.UK.IsNumber(value));

        [Theory]
        [InlineData("+441132224444")]
        [InlineData("+44 (0) 113 222 4444")]
        [InlineData("(0113) 222 4444")]
        [InlineData("01132224444")]
        public void UK_ReadNationalSignificantNumber(string value) =>
            Assert.Equal("1132224444", CountryInfo.UK.ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        public void UK_ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(value, CountryInfo.UK.ReadNationalSignificantNumber(value));
    }
}
