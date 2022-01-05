using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_Tests
    {
        [Fact]
        public void GetFormatter_E123_Returns_E123PhoneNumberFormatter() =>
            Assert.IsType<E123PhoneNumberFormatter>(TestHelper.CreateCountryInfo().GetFormatter("E.123"));

        [Fact]
        public void GetFormatter_E164_Returns_E164PhoneNumberFormatter() =>
            Assert.IsType<E164PhoneNumberFormatter>(TestHelper.CreateCountryInfo().GetFormatter("E.164"));

        [Fact]
        public void GetFormatter_N_Returns_NationalPhoneNumberFormatter() =>
            Assert.IsType<NationalPhoneNumberFormatter>(TestHelper.CreateCountryInfo().GetFormatter("N"));

        [Fact]
        public void GetFormatter_Throws_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => TestHelper.CreateCountryInfo().GetFormatter("X"));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("+35312222222")]
        public void IsInternationalNumber_False(string value) =>
            Assert.False(TestHelper.CreateCountryInfo().IsInternationalNumber(value));

        [Theory]
        [InlineData("+422012345678")]
        [InlineData("+422(0)12345678")]
        [InlineData("+422 (0) 123 456 78")]
        [InlineData("+422 (0) 123-456-78")]
        [InlineData("+422 (0) 123.456.78")]
        public void IsInternationalNumber_True(string value) =>
            Assert.True(TestHelper.CreateCountryInfo().IsInternationalNumber(value));

        [Theory]
        [InlineData(default(string))]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(@"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*()_+-={}[]:;""\\'|?/>.<,±`~ėęēêèéëūùûüúìįíîïīõøōœòôöóāãåæâàáäšßśłżžźčçćŵñń'¡¿…")]
        public void ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
            Assert.Equal(string.Empty, TestHelper.CreateCountryInfo().ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData("+422012345678")]
        [InlineData("+422(0)12345678")]
        [InlineData("+422 (0) 123 456 78")]
        [InlineData("+422 (0) 123-456-78")]
        [InlineData("+422 (0) 123.456.78")]
        [InlineData("012345678")]
        [InlineData("(0) 123 456 78")]
        [InlineData("(0) 123-456-78")]
        [InlineData("(0) 123.456.78")]
        public void ReadNationalSignificantNumber_With_TrunkPrefix(string value) =>
            Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: "0").ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData("+42212345678")]
        [InlineData("+422 123 456 78")]
        [InlineData("+422 123-456-78")]
        [InlineData("+422 123.456.78")]
        [InlineData("12345678")]
        [InlineData("123 456 78")]
        [InlineData("123-456-78")]
        [InlineData("123.456.78")]
        public void ReadNationalSignificantNumber_Without_TrunkPrefix(string value) =>
            Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: null).ReadNationalSignificantNumber(value));

        [Fact]
        public void When_Constructed()
        {
            var countryInfo = new CountryInfo();

            Assert.Null(countryInfo.CallingCode);
            Assert.False(countryInfo.HasNationalDestinationCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Null(countryInfo.Iso3166Code);
            Assert.Null(countryInfo.Name);
            Assert.Empty(countryInfo.NdcLengths);
            Assert.Empty(countryInfo.NsnLengths);
            Assert.True(countryInfo.RequireNdcForLocalGeographicDialling);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Null(countryInfo.TrunkPrefix);
        }
    }
}
