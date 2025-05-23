using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests;

public class CountryInfo_Africa_Tests
{
    [Fact]
    public void CountryInfo_Egypt()
    {
        Assert.Same(CountryInfo.Egypt, CountryInfo.Egypt);

        var countryInfo = CountryInfo.Egypt;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("20", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Arab Republic of Egypt", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("EG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Egypt", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Kenya()
    {
        Assert.Same(CountryInfo.Kenya, CountryInfo.Kenya);

        var countryInfo = CountryInfo.Kenya;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("254", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.IsType<SimplePhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Kenya", countryInfo.FullName);
        Assert.Equal("000", countryInfo.InternationalCallPrefix);
        Assert.Equal(2, countryInfo.InternationalCallPrefixes.Count);
        Assert.Equal("006", countryInfo.InternationalCallPrefixes["256"]); // Uganda
        Assert.Equal("007", countryInfo.InternationalCallPrefixes["255"]); // Tanzania
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("KE", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Kenya", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Nigeria()
    {
        Assert.Same(CountryInfo.Nigeria, CountryInfo.Nigeria);

        var countryInfo = CountryInfo.Nigeria;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("234", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Federal Republic of Nigeria", countryInfo.FullName);
        Assert.Equal("009", countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("NG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Nigeria", countryInfo.Name);
        Assert.Equal(new[] { 4, 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SouthAfrica()
    {
        Assert.Same(CountryInfo.SouthAfrica, CountryInfo.SouthAfrica);

        var countryInfo = CountryInfo.SouthAfrica;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("27", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of South Africa", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("ZA", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("South Africa", countryInfo.Name);
        Assert.Equal(new[] { 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 13 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Tanzania()
    {
        Assert.Same(CountryInfo.Tanzania, CountryInfo.Tanzania);

        var countryInfo = CountryInfo.Tanzania;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("255", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("United Republic of Tanzania", countryInfo.FullName);
        Assert.Equal("000", countryInfo.InternationalCallPrefix);
        Assert.Equal(2, countryInfo.InternationalCallPrefixes.Count);
        Assert.Equal("005", countryInfo.InternationalCallPrefixes["254"]); // Kenya
        Assert.Equal("006", countryInfo.InternationalCallPrefixes["256"]); // Uganda
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("TZ", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Tanzania", countryInfo.Name);
        Assert.Equal(new[] { 5, 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Uganda()
    {
        Assert.Same(CountryInfo.Uganda, CountryInfo.Uganda);

        var countryInfo = CountryInfo.Uganda;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("256", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.IsType<UGPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Uganda", countryInfo.FullName);
        Assert.Equal("000", countryInfo.InternationalCallPrefix);
        Assert.Equal(2, countryInfo.InternationalCallPrefixes.Count);
        Assert.Equal("005", countryInfo.InternationalCallPrefixes["254"]); // Kenya
        Assert.Equal("007", countryInfo.InternationalCallPrefixes["255"]); // Tanzania
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("UG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Uganda", countryInfo.Name);
        Assert.Equal(new[] { 6, 5, 4, 3, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }
}
