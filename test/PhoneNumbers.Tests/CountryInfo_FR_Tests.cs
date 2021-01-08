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
            Assert.IsType<FRPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("FR", countryInfo.Iso3166Code);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+35312222222")]
        public void FR_IsInternationalNumber_False(string value) =>
            Assert.False(CountryInfo.FR.IsInternationalNumber(value));

        [Theory]
        [InlineData("+33122334455")]
        [InlineData("+33(0)122334455")]
        [InlineData("+33 (0)1 22 33 44 55")]
        public void FR_IsInternationalNumber_True(string value) =>
            Assert.True(CountryInfo.FR.IsInternationalNumber(value));

        [Theory]
        [InlineData("+33122334455")]
        [InlineData("+33(0)122334455")]
        [InlineData("+33 (0)1 22 33 44 55")]
        [InlineData("(01) 22 33 44 55")]
        [InlineData("0122334455")]
        [InlineData("01-22-33-44-55")]
        public void FR_ReadNationalSignificantNumber(string value) =>
            Assert.Equal("122334455", CountryInfo.FR.ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+35312222222")]
        public void FR_ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(string.Empty, CountryInfo.FR.ReadNationalSignificantNumber(value));
    }
}
