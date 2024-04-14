using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests;

public class CountryInfo_Oceania_Tests
{
    [Fact]
    public void CountryInfo_AmericanSamoa()
    {
        Assert.Same(CountryInfo.AmericanSamoa, CountryInfo.AmericanSamoa);

        var countryInfo = CountryInfo.AmericanSamoa;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Oceania, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("AS", countryInfo.Iso3166Code);
        Assert.Equal("American Samoa", countryInfo.Name);
        Assert.Equal("American Samoa", countryInfo.NameEnglish);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Australia()
    {
        Assert.Same(CountryInfo.Australia, CountryInfo.Australia);

        var countryInfo = CountryInfo.Australia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("61", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Oceania, countryInfo.Continent);
        Assert.IsType<AUPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("AU", countryInfo.Iso3166Code);
        Assert.Equal("Australia", countryInfo.Name);
        Assert.Equal("Australia", countryInfo.NameEnglish);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 5, 6, 7, 8, 9, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Guam()
    {
        Assert.Same(CountryInfo.Guam, CountryInfo.Guam);

        var countryInfo = CountryInfo.Guam;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal(CountryInfo.NanpCallingCode, countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Oceania, countryInfo.Continent);
        Assert.IsType<NanpPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("GU", countryInfo.Iso3166Code);
        Assert.Equal("Guåhan", countryInfo.Name);
        Assert.Equal("Guam", countryInfo.NameEnglish);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_PapuaNewGuinea()
    {
        Assert.Same(CountryInfo.PapuaNewGuinea, CountryInfo.PapuaNewGuinea);

        var countryInfo = CountryInfo.PapuaNewGuinea;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("675", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Oceania, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("PG", countryInfo.Iso3166Code);
        Assert.Equal("Papua New Guinea", countryInfo.Name);
        Assert.Equal("Papua New Guinea", countryInfo.NameEnglish);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
