using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_IE_Tests
    {
        [Fact]
        public void IE()
        {
            Assert.Same(CountryInfo.IE, CountryInfo.IE);

            var countryInfo = CountryInfo.IE;

            Assert.Equal(new[] { 3, 2, 1 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+353", countryInfo.CallingCode);
            Assert.IsType<IEPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IE", countryInfo.Iso3166Code);
            Assert.Equal(new[] { 7, 8, 9 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+441132224444")]
        public void IE_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.IE.IsInternationalNumber(value));

        [Theory]
        [InlineData("+35312000000")]
        [InlineData("+353(0)12000000")]
        [InlineData("+353 (0) 1 200 0000")]
        [InlineData("(01) 200 0000")]
        [InlineData("012000000")]
        [InlineData("01-200-0000")]
        public void IE_ReadNationalSignificantNumber(string value) =>
            Assert.Equal("12000000", CountryInfo.IE.ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+441132224444")]
        [InlineData(@"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*()_+-={}[]:;""\\'|?/>.<,±`~ėęēêèéëūùûüúìįíîïīõøōœòôöóāãåæâàáäšßśłżžźčçćŵñń'¡¿…")]
        public void IE_ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(string.Empty, CountryInfo.IE.ReadNationalSignificantNumber(value));
    }
}
