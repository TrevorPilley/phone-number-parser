using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_ES_Tests
    {
        [Fact]
        public void ES()
        {
            Assert.Same(CountryInfo.ES, CountryInfo.ES);

            var countryInfo = CountryInfo.ES;

            Assert.Equal(new[] { 3, 2 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+34", countryInfo.CallingCode);
            Assert.IsType<ESPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("ES", countryInfo.Iso3166Code);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+441132224444")]
        public void ES_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.ES.IsInternationalNumber(value));

        [Theory]
        [InlineData("+34912112233")]
        [InlineData("+34 912 112 233")]
        [InlineData("912112233")]
        [InlineData("912-112-233")]
        public void ES_ReadNationalSignificantNumber(string value) =>
            Assert.Equal("912112233", CountryInfo.ES.ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+441132224444")]
        [InlineData(@"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*()_+-={}[]:;""\\'|?/>.<,±`~ėęēêèéëūùûüúìįíîïīõøōœòôöóāãåæâàáäšßśłżžźčçćŵñń'¡¿…")]
        public void ES_ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(string.Empty, CountryInfo.ES.ReadNationalSignificantNumber(value));
    }
}
