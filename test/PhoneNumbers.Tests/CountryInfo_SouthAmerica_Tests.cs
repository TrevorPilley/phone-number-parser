using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests;

public class CountryInfo_SouthAmerica_Tests
{
    [Fact]
    public void CountryInfo_Brazil()
    {
        Assert.Same(CountryInfo.Brazil, CountryInfo.Brazil);

        var countryInfo = CountryInfo.Brazil;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("55", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.SouthAmerica, countryInfo.Continent);
        Assert.IsType<BRPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BR", countryInfo.Iso3166Code);
        Assert.Equal("Brazil", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Colombia()
    {
        Assert.Same(CountryInfo.Colombia, CountryInfo.Colombia);

        var countryInfo = CountryInfo.Colombia;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("57", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.SouthAmerica, countryInfo.Continent);
        Assert.IsType<COPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("CO", countryInfo.Iso3166Code);
        Assert.Equal("Colombia", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
