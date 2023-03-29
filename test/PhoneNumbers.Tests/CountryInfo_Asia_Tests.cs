namespace PhoneNumbers.Tests;

public class CountryInfo_Asia_Tests
{
    [Fact]
    public void CountryInfo_HongKong()
    {
        Assert.Same(CountryInfo.HongKong, CountryInfo.HongKong);

        var countryInfo = CountryInfo.HongKong;

        Assert.Equal("852", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.Equal("HK", countryInfo.Iso3166Code);
        Assert.Equal("Hong Kong", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 12 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Closed, countryInfo.NumberingPlanType);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Macau()
    {
        Assert.Same(CountryInfo.Macau, CountryInfo.Macau);

        var countryInfo = CountryInfo.Macau;

        Assert.Equal("853", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.Equal("MO", countryInfo.Iso3166Code);
        Assert.Equal("Macau", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Closed, countryInfo.NumberingPlanType);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Singapore()
    {
        Assert.Same(CountryInfo.Singapore, CountryInfo.Singapore);

        var countryInfo = CountryInfo.Singapore;

        Assert.Equal("65", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.Equal("SG", countryInfo.Iso3166Code);
        Assert.Equal("Singapore", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 10, 11 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Closed, countryInfo.NumberingPlanType);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
