namespace PhoneNumbers.Tests;

public class CountryInfo_Africa_Tests
{
    [Fact]
    public void CountryInfo_SouthAfrica()
    {
        Assert.Same(CountryInfo.SouthAfrica, CountryInfo.SouthAfrica);

        var countryInfo = CountryInfo.SouthAfrica;

        Assert.Equal("+27", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.True(countryInfo.HasNationalDestinationCodes);
        Assert.Equal("00", countryInfo.InternationalCallPrefix);
        Assert.Equal("ZA", countryInfo.Iso3166Code);
        Assert.Equal("South Africa", countryInfo.Name);
        Assert.Equal(new[] { 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 9, 13 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }
}
