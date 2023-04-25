using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests;

public class CountryInfo_SouthAmerica_Tests
{
    [Fact]
    public void CountryInfo_Brazil()
    {
        Assert.Same(CountryInfo.Brazil, CountryInfo.Brazil);

        var countryInfo = CountryInfo.Brazil;

        Assert.True(countryInfo.AllowLocalGeographicDialling);
        Assert.Equal("55", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.SouthAmerica, countryInfo.Continent);
        Assert.IsType<BRPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.Equal("BR", countryInfo.Iso3166Code);
        Assert.Equal("Brazil", countryInfo.Name);
        Assert.Equal(new[] { 3, 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }
}
