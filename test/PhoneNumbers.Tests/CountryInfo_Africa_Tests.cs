namespace PhoneNumbers.Tests;

public class CountryInfo_Africa_Tests
{
    [Fact]
    public void CountryInfo_Egypt()
    {
        Assert.Same(CountryInfo.Egypt, CountryInfo.Egypt);

        var countryInfo = CountryInfo.Egypt;

        Assert.Equal("+20", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.True(countryInfo.HasNationalDestinationCodes);
        Assert.Equal("00", countryInfo.InternationalCallPrefix);
        Assert.Equal("EG", countryInfo.Iso3166Code);
        Assert.Equal("Egypt", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 10, 11 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    public void CountryInfo_Nigeria()
    {
        Assert.Same(CountryInfo.Nigeria, CountryInfo.Nigeria);

        var countryInfo = CountryInfo.Nigeria;

        Assert.Equal("+234", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Africa, countryInfo.Continent);
        Assert.True(countryInfo.HasNationalDestinationCodes);
        Assert.Equal("009", countryInfo.InternationalCallPrefix);
        Assert.Equal("NG", countryInfo.Iso3166Code);
        Assert.Equal("Nigeria", countryInfo.Name);
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

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
