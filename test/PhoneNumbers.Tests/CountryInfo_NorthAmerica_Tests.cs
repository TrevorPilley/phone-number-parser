using System.Numerics;
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
        Assert.Equal("Anguilla", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("AI", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("Antigua and Barbuda", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("AG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("Commonwealth of The Bahamas", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BS", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("Barbados", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BB", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("Bermuda", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BM", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("British Virgin Islands", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("VG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Virgin Islands (British)", countryInfo.Name);
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
        Assert.Equal("Canada", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("CA", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
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
        Assert.Equal("Cayman Islands", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("KY", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("Commonwealth of Dominica", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("DM", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Dominica", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_DominicanRepublic()
    {
        Assert.Same(CountryInfo.DominicanRepublic, CountryInfo.DominicanRepublic);

        var countryInfo = CountryInfo.DominicanRepublic;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Dominican Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("DO", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Dominican Republic", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Greenland()
    {
        Assert.Same(CountryInfo.Greenland, CountryInfo.Greenland);

        var countryInfo = CountryInfo.Greenland;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("299", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Greenland", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("GL", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Greenland", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 6 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Grenada()
    {
        Assert.Same(CountryInfo.Grenada, CountryInfo.Grenada);

        var countryInfo = CountryInfo.Grenada;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Grenada", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("GD", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Grenada", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Guadeloupe()
    {
        Assert.Same(CountryInfo.Guadeloupe, CountryInfo.Guadeloupe);

        var countryInfo = CountryInfo.Guadeloupe;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("590", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<FodPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Guadeloupe", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.True(countryInfo.IsEuropeanUnionMember); // as a result of being part of France
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("GP", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Guadeloupe", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Jamaica()
    {
        Assert.Same(CountryInfo.Jamaica, CountryInfo.Jamaica);

        var countryInfo = CountryInfo.Jamaica;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Jamaica", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("JM", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Jamaica", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Martinique()
    {
        Assert.Same(CountryInfo.Martinique, CountryInfo.Martinique);

        var countryInfo = CountryInfo.Martinique;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("596", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<FodPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Martinique", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.True(countryInfo.IsEuropeanUnionMember); // as a result of being part of France
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MQ", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Martinique", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Mexico()
    {
        Assert.Same(CountryInfo.Mexico, CountryInfo.Mexico);

        var countryInfo = CountryInfo.Mexico;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("52", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<MXPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("United Mexican States", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MX", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Mexico", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal([10], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Montserrat()
    {
        Assert.Same(CountryInfo.Montserrat, CountryInfo.Montserrat);

        var countryInfo = CountryInfo.Montserrat;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Montserrat", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MS", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Montserrat", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_NorthernMarianaIslands()
    {
        Assert.Same(CountryInfo.NorthernMarianaIslands, CountryInfo.NorthernMarianaIslands);

        var countryInfo = CountryInfo.NorthernMarianaIslands;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Commonwealth of the Northern Mariana Islands", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MP", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Northern Mariana Islands", countryInfo.Name);
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
        Assert.Equal("Commonwealth of Puerto Rico", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("PR", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Puerto Rico", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SaintKittsAndNevis()
    {
        Assert.Same(CountryInfo.SaintKittsAndNevis, CountryInfo.SaintKittsAndNevis);

        var countryInfo = CountryInfo.SaintKittsAndNevis;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Federation of Saint Kitts and Nevis", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("KN", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Saint Kitts and Nevis", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SaintLucia()
    {
        Assert.Same(CountryInfo.SaintLucia, CountryInfo.SaintLucia);

        var countryInfo = CountryInfo.SaintLucia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Saint Lucia", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("LC", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Saint Lucia", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SaintVincentAndTheGrenadines()
    {
        Assert.Same(CountryInfo.SaintVincentAndTheGrenadines, CountryInfo.SaintVincentAndTheGrenadines);

        var countryInfo = CountryInfo.SaintVincentAndTheGrenadines;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Saint Vincent and the Grenadines", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("VC", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Saint Vincent and the Grenadines", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SintMaarten()
    {
        Assert.Same(CountryInfo.SintMaarten, CountryInfo.SintMaarten);

        var countryInfo = CountryInfo.SintMaarten;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Sint Maarten", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("SX", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Sint Maarten", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_TrinidadAndTobago()
    {
        Assert.Same(CountryInfo.TrinidadAndTobago, CountryInfo.TrinidadAndTobago);

        var countryInfo = CountryInfo.TrinidadAndTobago;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Trinidad and Tobago", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("TT", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Trinidad and Tobago", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_TurksAndCaicosIslands()
    {
        Assert.Same(CountryInfo.TurksAndCaicosIslands, CountryInfo.TurksAndCaicosIslands);

        var countryInfo = CountryInfo.TurksAndCaicosIslands;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Turks and Caicos Islands", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("TC", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Turks and Caicos Islands", countryInfo.Name);
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
        Assert.Equal("United States of America", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("US", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("United States", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_VirginIslandsOfTheUnitedStates()
    {
        Assert.Same(CountryInfo.VirginIslandsOfTheUnitedStates, CountryInfo.VirginIslandsOfTheUnitedStates);

        var countryInfo = CountryInfo.VirginIslandsOfTheUnitedStates;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Virgin Islands of the United States", countryInfo.FullName);
        Assert.Equal(CountryInfo.NanpInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("VI", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Virgin Islands (U.S.)", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
