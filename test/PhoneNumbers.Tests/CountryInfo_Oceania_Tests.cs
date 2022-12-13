namespace PhoneNumbers.Tests;

public class CountryInfo_Oceania_Tests
{
    [Fact]
    public void CountryInfo_Australia()
    {
        Assert.Same(CountryInfo.Australia, CountryInfo.Australia);

        var countryInfo = CountryInfo.Australia;

        Assert.Equal("+61", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Oceania, countryInfo.Continent);
        Assert.True(countryInfo.HasNationalDestinationCodes);
        Assert.Equal("00", countryInfo.InternationalCallPrefix);
        Assert.Equal("AU", countryInfo.Iso3166Code);
        Assert.Equal("Australia", countryInfo.Name);
        Assert.Equal(new[] { 4, 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }
}
