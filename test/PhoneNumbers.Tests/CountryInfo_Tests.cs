using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_Tests
    {
        [Fact]
        public void CountryInfo_ES()
        {
            Assert.Same(CountryInfo.ES, CountryInfo.ES);

            var countryInfo = CountryInfo.ES;

            Assert.Equal(new[] { 3, 2 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+34", countryInfo.CallingCode);
            Assert.IsType<ESPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("ES", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("Spain", countryInfo.Name);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_FR()
        {
            Assert.Same(CountryInfo.FR, CountryInfo.FR);

            var countryInfo = CountryInfo.FR;

            Assert.Empty(countryInfo.AreaCodeLengths);
            Assert.Equal("+33", countryInfo.CallingCode);
            Assert.IsType<FRPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("FR", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("France", countryInfo.Name);
            Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_GG()
        {
            Assert.Same(CountryInfo.GG, CountryInfo.GG);

            var countryInfo = CountryInfo.GG;

            Assert.Equal(new[] { 4 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.IsType<GBPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("GG", countryInfo.Iso3166Code);
            Assert.True(countryInfo.SharesCallingCode);
            Assert.Equal("Guernsey", countryInfo.Name);
            Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_IE()
        {
            Assert.Same(CountryInfo.IE, CountryInfo.IE);

            var countryInfo = CountryInfo.IE;

            Assert.Equal(new[] { 3, 2, 1 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+353", countryInfo.CallingCode);
            Assert.IsType<IEPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IE", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("Ireland", countryInfo.Name);
            Assert.Equal(new[] { 7, 8, 9 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_IM()
        {
            Assert.Same(CountryInfo.IM, CountryInfo.IM);

            var countryInfo = CountryInfo.IM;

            Assert.Equal(new[] { 4 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.IsType<GBPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IM", countryInfo.Iso3166Code);
            Assert.True(countryInfo.SharesCallingCode);
            Assert.Equal("Isle of Man", countryInfo.Name);
            Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_IT()
        {
            Assert.Same(CountryInfo.IT, CountryInfo.IT);

            var countryInfo = CountryInfo.IT;

            Assert.Equal(new[] { 4, 3, 2 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+39", countryInfo.CallingCode);
            Assert.IsType<ITPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("IT", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("Italy", countryInfo.Name);
            Assert.Equal(new[] { 6, 7, 8, 9, 10, 11 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_JE()
        {
            Assert.Same(CountryInfo.JE, CountryInfo.JE);

            var countryInfo = CountryInfo.JE;

            Assert.Equal(new[] { 4 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.IsType<GBPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("JE", countryInfo.Iso3166Code);
            Assert.True(countryInfo.SharesCallingCode);
            Assert.Equal("Jersey", countryInfo.Name);
            Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_UK()
        {
            Assert.Same(CountryInfo.UK, CountryInfo.UK);

            var countryInfo = CountryInfo.UK;

            Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.AreaCodeLengths);
            Assert.Equal("+44", countryInfo.CallingCode);
            Assert.IsType<GBPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.True(countryInfo.HasAreaCodes);
            Assert.Equal("00", countryInfo.InternationalCallPrefix);
            Assert.Equal("GB", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("United Kingdom", countryInfo.Name);
            Assert.Equal(new[] { 7, 9, 10 }, countryInfo.NsnLengths);
            Assert.Equal("0", countryInfo.TrunkPrefix);
        }

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
        [InlineData("012345678")]
        [InlineData("(0) 123 456 78")]
        [InlineData("(0) 123-456-78")]
        public void ReadNationalSignificantNumber_With_TrunkPrefix(string value) =>
            Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: "0").ReadNationalSignificantNumber(value));

        [Theory]
        [InlineData("+42212345678")]
        [InlineData("+422 123 456 78")]
        [InlineData("+422 123-456-78")]
        [InlineData("12345678")]
        [InlineData("123 456 78")]
        [InlineData("123-456-78")]
        public void ReadNationalSignificantNumber_Without_TrunkPrefix(string value) =>
            Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: null).ReadNationalSignificantNumber(value));

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
            Assert.Null(countryInfo.Name);
            Assert.Empty(countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }
    }
}
