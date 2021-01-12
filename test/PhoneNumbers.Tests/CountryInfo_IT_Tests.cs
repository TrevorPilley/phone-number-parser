using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_IT_Tests
    {
        [Fact]
        public void IT()
        {
            Assert.Same(CountryInfo.IT, CountryInfo.IT);

            var countryInfo = CountryInfo.IT;

            Assert.Equal(new[] { 4, 3, 2 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+39", countryInfo.CallingCode);
            Assert.IsType<PhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IT", countryInfo.Iso3166Code);
            Assert.Equal(new[] { 6, 7, 8, 9, 10, 11 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+441132224444")]
        public void IT_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.IT.IsInternationalNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+441132224444")]
        [InlineData(@"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*()_+-={}[]:;""\\'|?/>.<,±`~ėęēêèéëūùûüúìįíîïīõøōœòôöóāãåæâàáäšßśłżžźčçćŵñń'¡¿…")]
        public void IT_ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(string.Empty, CountryInfo.IT.ReadNationalSignificantNumber(value));
    }
}
