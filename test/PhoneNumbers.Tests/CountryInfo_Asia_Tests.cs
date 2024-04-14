using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests;

public class CountryInfo_Asia_Tests
{
    [Fact]
    public void CountryInfo_HongKong()
    {
        Assert.Same(CountryInfo.HongKong, CountryInfo.HongKong);

        var countryInfo = CountryInfo.HongKong;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("852", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("HK", countryInfo.Iso3166Code);
        Assert.Equal("香港", countryInfo.Name);
        Assert.Equal("Hong Kong", countryInfo.NameEnglish);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Macau()
    {
        Assert.Same(CountryInfo.Macau, CountryInfo.Macau);

        var countryInfo = CountryInfo.Macau;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("853", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("MO", countryInfo.Iso3166Code);
        Assert.Equal("澳門", countryInfo.Name);
        Assert.Equal("Macau", countryInfo.NameEnglish);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Singapore()
    {
        Assert.Same(CountryInfo.Singapore, CountryInfo.Singapore);

        var countryInfo = CountryInfo.Singapore;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("65", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("SG", countryInfo.Iso3166Code);
        Assert.Equal("Singapore", countryInfo.Name);
        Assert.Equal("Singapore", countryInfo.NameEnglish);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
