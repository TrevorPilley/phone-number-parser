using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class CountryInfo_Tests
    {
        [Fact]
        public void CountryInfo_France()
        {
            Assert.Same(CountryInfo.France, CountryInfo.France);

            var countryInfo = CountryInfo.France;

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
        public void CountryInfo_Guernsey()
        {
            Assert.Same(CountryInfo.Guernsey, CountryInfo.Guernsey);

            var countryInfo = CountryInfo.Guernsey;

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
        public void CountryInfo_HongKong()
        {
            Assert.Same(CountryInfo.HongKong, CountryInfo.HongKong);

            var countryInfo = CountryInfo.HongKong;

            Assert.Empty(countryInfo.AreaCodeLengths);
            Assert.Equal("+852", countryInfo.CallingCode);
            Assert.IsType<HKPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("001", countryInfo.InternationalCallPrefix);
            Assert.Equal("HK", countryInfo.Iso3166Code);
            Assert.Equal("Hong Kong", countryInfo.Name);
            Assert.Equal(new[] { 8, 9 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Ireland()
        {
            Assert.Same(CountryInfo.Ireland, CountryInfo.Ireland);

            var countryInfo = CountryInfo.Ireland;

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
        public void CountryInfo_IsleOfMan()
        {
            Assert.Same(CountryInfo.IsleOfMan, CountryInfo.IsleOfMan);

            var countryInfo = CountryInfo.IsleOfMan;

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
        public void CountryInfo_Italy()
        {
            Assert.Same(CountryInfo.Italy, CountryInfo.Italy);

            var countryInfo = CountryInfo.Italy;

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
        public void CountryInfo_Jersey()
        {
            Assert.Same(CountryInfo.Jersey, CountryInfo.Jersey);

            var countryInfo = CountryInfo.Jersey;

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
        public void CountryInfo_Singapore()
        {
            Assert.Same(CountryInfo.Singapore, CountryInfo.Singapore);

            var countryInfo = CountryInfo.Singapore;

            Assert.Empty(countryInfo.AreaCodeLengths);
            Assert.Equal("+65", countryInfo.CallingCode);
            Assert.IsType<SGPhoneNumberFormatter>(countryInfo.Formatter);
            Assert.False(countryInfo.HasAreaCodes);
            Assert.Equal("001", countryInfo.InternationalCallPrefix);
            Assert.Equal("SG", countryInfo.Iso3166Code);
            Assert.False(countryInfo.SharesCallingCode);
            Assert.Equal("Singapore", countryInfo.Name);
            Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
            Assert.Null(countryInfo.TrunkPrefix);
        }

        [Fact]
        public void CountryInfo_Spain()
        {
            Assert.Same(CountryInfo.Spain, CountryInfo.Spain);

            var countryInfo = CountryInfo.Spain;

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
        public void CountryInfo_UnitedKingdom()
        {
            Assert.Same(CountryInfo.UnitedKingdom, CountryInfo.UnitedKingdom);

            var countryInfo = CountryInfo.UnitedKingdom;

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
