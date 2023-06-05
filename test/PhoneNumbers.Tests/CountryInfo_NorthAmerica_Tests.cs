using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests;

public class CountryInfo_NorthAmerica_Tests
{
    [Fact]
    public void CountryInfo_Anguilla()
    {
        Assert.Same(CountryInfo.Anguilla, CountryInfo.Anguilla);

        var countryInfo = CountryInfo.Anguilla;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("AI", countryInfo.Iso3166Code);
        Assert.Equal("Anguilla", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_AntiguaAndBarbuda()
    {
        Assert.Same(CountryInfo.AntiguaAndBarbuda, CountryInfo.AntiguaAndBarbuda);

        var countryInfo = CountryInfo.AntiguaAndBarbuda;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("AG", countryInfo.Iso3166Code);
        Assert.Equal("Antigua and Barbuda", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Bahamas()
    {
        Assert.Same(CountryInfo.Bahamas, CountryInfo.Bahamas);

        var countryInfo = CountryInfo.Bahamas;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("BS", countryInfo.Iso3166Code);
        Assert.Equal("Bahamas", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Barbados()
    {
        Assert.Same(CountryInfo.Barbados, CountryInfo.Barbados);

        var countryInfo = CountryInfo.Barbados;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("BB", countryInfo.Iso3166Code);
        Assert.Equal("Barbados", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Bermuda()
    {
        Assert.Same(CountryInfo.Bermuda, CountryInfo.Bermuda);

        var countryInfo = CountryInfo.Bermuda;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("BM", countryInfo.Iso3166Code);
        Assert.Equal("Bermuda", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_BritishVirginIslands()
    {
        Assert.Same(CountryInfo.BritishVirginIslands, CountryInfo.BritishVirginIslands);

        var countryInfo = CountryInfo.BritishVirginIslands;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("VG", countryInfo.Iso3166Code);
        Assert.Equal("British Virgin Islands", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Canada()
    {
        Assert.Same(CountryInfo.Canada, CountryInfo.Canada);

        var countryInfo = CountryInfo.Canada;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("CA", countryInfo.Iso3166Code);
        Assert.Equal("Canada", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_CaymanIslands()
    {
        Assert.Same(CountryInfo.CaymanIslands, CountryInfo.CaymanIslands);

        var countryInfo = CountryInfo.CaymanIslands;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("KY", countryInfo.Iso3166Code);
        Assert.Equal("Cayman Islands", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Dominica()
    {
        Assert.Same(CountryInfo.Dominica, CountryInfo.Dominica);

        var countryInfo = CountryInfo.Dominica;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("DM", countryInfo.Iso3166Code);
        Assert.Equal("Dominica", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_PuertoRico()
    {
        Assert.Same(CountryInfo.PuertoRico, CountryInfo.PuertoRico);

        var countryInfo = CountryInfo.PuertoRico;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("PR", countryInfo.Iso3166Code);
        Assert.Equal("Puerto Rico", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_UnitedStates()
    {
        Assert.Same(CountryInfo.UnitedStates, CountryInfo.UnitedStates);

        var countryInfo = CountryInfo.UnitedStates;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("US", countryInfo.Iso3166Code);
        Assert.Equal("United States", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_UnitedStatesVirginIslands()
    {
        Assert.Same(CountryInfo.UnitedStatesVirginIslands, CountryInfo.UnitedStatesVirginIslands);

        var countryInfo = CountryInfo.UnitedStatesVirginIslands;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("VI", countryInfo.Iso3166Code);
        Assert.Equal("United States Virgin Islands", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
