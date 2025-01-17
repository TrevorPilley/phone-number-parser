namespace PhoneNumbers.Tests;

using PhoneNumbers.Formatters.FormatProviders;

public class CountryInfo_Europe_Tests
{
    [Fact]
    public void CountryInfo_Albania()
    {
        Assert.Same(CountryInfo.Albania, CountryInfo.Albania);

        var countryInfo = CountryInfo.Albania;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("355", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Albania", countryInfo.FullName);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("AL", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Albania", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal([8, 9], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Andorra()
    {
        Assert.Same(CountryInfo.Andorra, CountryInfo.Andorra);

        var countryInfo = CountryInfo.Andorra;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("376", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Principality of Andorra", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("AD", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Andorra", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 8, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Austria()
    {
        Assert.Same(CountryInfo.Austria, CountryInfo.Austria);

        var countryInfo = CountryInfo.Austria;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("43", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Austria", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("AT", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Austria", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Belarus()
    {
        Assert.Same(CountryInfo.Belarus, CountryInfo.Belarus);

        var countryInfo = CountryInfo.Belarus;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("375", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<SimplePhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Belarus", countryInfo.FullName);
        Assert.Equal("8~10", countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BY", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Belarus", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 9, 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("8", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Belgium()
    {
        Assert.Same(CountryInfo.Belgium, CountryInfo.Belgium);

        var countryInfo = CountryInfo.Belgium;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("32", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<BEPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Kingdom of Belgium", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("BE", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Belgium", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_BosniaAndHerzegovina()
    {
        Assert.Same(CountryInfo.BosniaAndHerzegovina, CountryInfo.BosniaAndHerzegovina);

        var countryInfo = CountryInfo.BosniaAndHerzegovina;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("387", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Bosnia and Herzegovina", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BA", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Bosnia and Herzegovina", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 8, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Bulgaria()
    {
        Assert.Same(CountryInfo.Bulgaria, CountryInfo.Bulgaria);

        var countryInfo = CountryInfo.Bulgaria;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("359", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Bulgaria", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("BG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Bulgaria", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Croatia()
    {
        Assert.Same(CountryInfo.Croatia, CountryInfo.Croatia);

        var countryInfo = CountryInfo.Croatia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("385", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Croatia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("HR", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Croatia", countryInfo.Name);
        Assert.Equal(new[] { 5, 4, 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 7, 8, 9, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Cyprus()
    {
        Assert.Same(CountryInfo.Cyprus, CountryInfo.Cyprus);

        var countryInfo = CountryInfo.Cyprus;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("357", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<CYPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Cyprus", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("CY", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Cyprus", countryInfo.Name);
        Assert.Equal(new[] { 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_CzechRepublic()
    {
        Assert.Same(CountryInfo.CzechRepublic, CountryInfo.CzechRepublic);

        var countryInfo = CountryInfo.CzechRepublic;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("420", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<CZPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Czech Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("CZ", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Czech Republic", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 9, 10, 11, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Denmark()
    {
        Assert.Same(CountryInfo.Denmark, CountryInfo.Denmark);

        var countryInfo = CountryInfo.Denmark;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("45", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Denmark", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("DK", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Denmark", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Estonia()
    {
        Assert.Same(CountryInfo.Estonia, CountryInfo.Estonia);

        var countryInfo = CountryInfo.Estonia;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("372", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Estonia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("EE", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Estonia", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 8, 10, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_FaroeIslands()
    {
        Assert.Same(CountryInfo.FaroeIslands, CountryInfo.FaroeIslands);

        var countryInfo = CountryInfo.FaroeIslands;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("298", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<FOPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Faroe Islands", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("FO", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Faroe Islands", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 6 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Finland()
    {
        Assert.Same(CountryInfo.Finland, CountryInfo.Finland);

        var countryInfo = CountryInfo.Finland;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("358", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Finland", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("FI", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Finland", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 5, 6, 7, 8, 9, 10, 11, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_France()
    {
        Assert.Same(CountryInfo.France, CountryInfo.France);

        var countryInfo = CountryInfo.France;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("33", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<FRPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("French Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("FR", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("France", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 13 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Germany()
    {
        Assert.Same(CountryInfo.Germany, CountryInfo.Germany);

        var countryInfo = CountryInfo.Germany;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("49", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<SimplePhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Federal Republic of Germany", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("DE", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Germany", countryInfo.Name);
        Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Gibraltar()
    {
        Assert.Same(CountryInfo.Gibraltar, CountryInfo.Gibraltar);

        var countryInfo = CountryInfo.Gibraltar;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("350", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Gibraltar", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("GI", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Gibraltar", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 4, 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Greece()
    {
        Assert.Same(CountryInfo.Greece, CountryInfo.Greece);

        var countryInfo = CountryInfo.Greece;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("30", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<GRPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Hellenic Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("GR", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Greece", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Guernsey()
    {
        Assert.Same(CountryInfo.Guernsey, CountryInfo.Guernsey);

        var countryInfo = CountryInfo.Guernsey;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("44", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<GBPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Guernsey", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("GG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Guernsey", countryInfo.Name);
        Assert.Equal(new[] { 4 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Hungary()
    {
        Assert.Same(CountryInfo.Hungary, CountryInfo.Hungary);

        var countryInfo = CountryInfo.Hungary;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("36", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Hungary", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("HU", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Hungary", countryInfo.Name);
        Assert.Equal(new[] { 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("06", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Iceland()
    {
        Assert.Same(CountryInfo.Iceland, CountryInfo.Iceland);

        var countryInfo = CountryInfo.Iceland;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("354", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Iceland", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("IS", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Iceland", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Ireland()
    {
        Assert.Same(CountryInfo.Ireland, CountryInfo.Ireland);

        var countryInfo = CountryInfo.Ireland;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("353", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Ireland", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("IE", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Ireland", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_IsleOfMan()
    {
        Assert.Same(CountryInfo.IsleOfMan, CountryInfo.IsleOfMan);

        var countryInfo = CountryInfo.IsleOfMan;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("44", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<GBPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Isle of Man", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("IM", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Isle of Man", countryInfo.Name);
        Assert.Equal(new[] { 4 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Italy()
    {
        Assert.Same(CountryInfo.Italy, CountryInfo.Italy);

        var countryInfo = CountryInfo.Italy;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("39", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<SimplePhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Italian Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("IT", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Italy", countryInfo.Name);
        Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 5, 6, 7, 8, 9, 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Jersey()
    {
        Assert.Same(CountryInfo.Jersey, CountryInfo.Jersey);

        var countryInfo = CountryInfo.Jersey;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("44", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<GBPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Bailiwick of Jersey", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("JE", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Jersey", countryInfo.Name);
        Assert.Equal(new[] { 4 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Kosovo()
    {
        Assert.Same(CountryInfo.Kosovo, CountryInfo.Kosovo);

        var countryInfo = CountryInfo.Kosovo;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("383", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Kosovo", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("XK", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Kosovo", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Latvia()
    {
        Assert.Same(CountryInfo.Latvia, CountryInfo.Latvia);

        var countryInfo = CountryInfo.Latvia;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("371", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Latvia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("LV", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Latvia", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Liechtenstein()
    {
        Assert.Same(CountryInfo.Liechtenstein, CountryInfo.Liechtenstein);

        var countryInfo = CountryInfo.Liechtenstein;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("423", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<LIPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Principality of Liechtenstein", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("LI", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Liechtenstein", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Lithuania()
    {
        Assert.Same(CountryInfo.Lithuania, CountryInfo.Lithuania);

        var countryInfo = CountryInfo.Lithuania;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("370", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Lithuania", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("LT", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Lithuania", countryInfo.Name);
        Assert.Equal(new[] { 3 , 2, 1}, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("8", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Luxembourg()
    {
        Assert.Same(CountryInfo.Luxembourg, CountryInfo.Luxembourg);

        var countryInfo = CountryInfo.Luxembourg;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("352", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<LUPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Grand Duchy of Luxembourg", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("LU", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Luxembourg", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Malta()
    {
        Assert.Same(CountryInfo.Malta, CountryInfo.Malta);

        var countryInfo = CountryInfo.Malta;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("356", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Malta", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MT", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Malta", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Moldova()
    {
        Assert.Same(CountryInfo.Moldova, CountryInfo.Moldova);

        var countryInfo = CountryInfo.Moldova;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("373", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Moldova", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MD", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Moldova", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 5, 6, 7, 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Monaco()
    {
        Assert.Same(CountryInfo.Monaco, CountryInfo.Monaco);

        var countryInfo = CountryInfo.Monaco;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("377", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<MCPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Principality of Monaco", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MC", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Monaco", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Montenegro()
    {
        Assert.Same(CountryInfo.Montenegro, CountryInfo.Montenegro);

        var countryInfo = CountryInfo.Montenegro;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("382", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Montenegro", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("ME", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Montenegro", countryInfo.Name);
        Assert.Equal(new[] { 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 4, 5, 8, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Netherlands()
    {
        Assert.Same(CountryInfo.Netherlands, CountryInfo.Netherlands);

        var countryInfo = CountryInfo.Netherlands;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("31", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<NLPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Netherlands", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("NL", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Netherlands", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_NorthMacedonia()
    {
        Assert.Same(CountryInfo.NorthMacedonia, CountryInfo.NorthMacedonia);

        var countryInfo = CountryInfo.NorthMacedonia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("389", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of North Macedonia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("MK", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("North Macedonia", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 } ,countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Norway()
    {
        Assert.Same(CountryInfo.Norway, CountryInfo.Norway);

        var countryInfo = CountryInfo.Norway;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("47", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<NOPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Kingdom of Norway", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("NO", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Norway", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Poland()
    {
        Assert.Same(CountryInfo.Poland, CountryInfo.Poland);

        var countryInfo = CountryInfo.Poland;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("48", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<PLPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Poland", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("PL", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Poland", countryInfo.Name);
        Assert.Equal(new[] { 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 7, 8, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Portugal()
    {
        Assert.Same(CountryInfo.Portugal, CountryInfo.Portugal);

        var countryInfo = CountryInfo.Portugal;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("351", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Portuguese Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("PT", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Portugal", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Romania()
    {
        Assert.Same(CountryInfo.Romania, CountryInfo.Romania);

        var countryInfo = CountryInfo.Romania;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("40", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ROPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Romania", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("RO", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Romania", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 7, 8, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SanMarino()
    {
        Assert.Same(CountryInfo.SanMarino, CountryInfo.SanMarino);

        var countryInfo = CountryInfo.SanMarino;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("378", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<SMPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Most Serene Republic of San Marino", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("SM", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("San Marino", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 7, 8, 9, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Serbia()
    {
        Assert.Same(CountryInfo.Serbia, CountryInfo.Serbia);

        var countryInfo = CountryInfo.Serbia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("381", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Serbia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("RS", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Serbia", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 10, 11, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Slovakia()
    {
        Assert.Same(CountryInfo.Slovakia, CountryInfo.Slovakia);

        var countryInfo = CountryInfo.Slovakia;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("421", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Slovak Republic", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("SK", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Slovakia", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Slovenia()
    {
        Assert.Same(CountryInfo.Slovenia, CountryInfo.Slovenia);

        var countryInfo = CountryInfo.Slovenia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("386", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<SLPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Slovenia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("SL", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Slovenia", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Spain()
    {
        Assert.Same(CountryInfo.Spain, CountryInfo.Spain);

        var countryInfo = CountryInfo.Spain;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("34", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<ESPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Kingdom of Spain", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("ES", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Spain", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 13  }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Sweden()
    {
        Assert.Same(CountryInfo.Sweden, CountryInfo.Sweden);

        var countryInfo = CountryInfo.Sweden;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("46", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<SEPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Kingdom of Sweden", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("SE", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Sweden", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 6, 7, 8, 9, 10, 13 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Switzerland()
    {
        Assert.Same(CountryInfo.Switzerland, CountryInfo.Switzerland);

        var countryInfo = CountryInfo.Switzerland;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("41", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<CHPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Swiss Confederation", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("CH", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Switzerland", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Ukraine()
    {
        Assert.Same(CountryInfo.Ukraine, CountryInfo.Ukraine);

        var countryInfo = CountryInfo.Ukraine;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("380", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<UAPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Ukraine", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("UA", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Ukraine", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_UnitedKingdom()
    {
        Assert.Same(CountryInfo.UnitedKingdom, CountryInfo.UnitedKingdom);

        var countryInfo = CountryInfo.UnitedKingdom;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("44", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Europe, countryInfo.Continent);
        Assert.IsType<GBPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("United Kingdom of Great Britain and Northern Ireland", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("GB", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("United Kingdom", countryInfo.Name);
        Assert.Equal(new[] { 5, 4, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 9, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }
}
