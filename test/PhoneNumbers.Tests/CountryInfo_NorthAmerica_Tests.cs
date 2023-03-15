namespace PhoneNumbers.Tests;

public class CountryInfo_NorthAmerica_Tests
{
    [Fact]
    public void CountryInfo_Canada()
    {
        Assert.Same(CountryInfo.Canada, CountryInfo.Canada);

        var countryInfo = CountryInfo.Canada;

        Assert.Equal("+1", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.Equal("011", countryInfo.InternationalCallPrefix);
        Assert.Equal("CA", countryInfo.Iso3166Code);
        Assert.Equal("Canada", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Open, countryInfo.NumberingPlanType);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_PuertoRico()
    {
        Assert.Same(CountryInfo.PuertoRico, CountryInfo.PuertoRico);

        var countryInfo = CountryInfo.PuertoRico;

        Assert.Equal("+1", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.Equal("011", countryInfo.InternationalCallPrefix);
        Assert.Equal("PR", countryInfo.Iso3166Code);
        Assert.Equal("Puerto Rico", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Open, countryInfo.NumberingPlanType);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_UnitedStates()
    {
        Assert.Same(CountryInfo.UnitedStates, CountryInfo.UnitedStates);

        var countryInfo = CountryInfo.UnitedStates;

        Assert.Equal("+1", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.Equal("011", countryInfo.InternationalCallPrefix);
        Assert.Equal("US", countryInfo.Iso3166Code);
        Assert.Equal("United States", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Open, countryInfo.NumberingPlanType);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_UnitedStatesVirginIslands()
    {
        Assert.Same(CountryInfo.UnitedStatesVirginIslands, CountryInfo.UnitedStatesVirginIslands);

        var countryInfo = CountryInfo.UnitedStatesVirginIslands;

        Assert.Equal("+1", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.NorthAmerica, countryInfo.Continent);
        Assert.Equal("011", countryInfo.InternationalCallPrefix);
        Assert.Equal("VI", countryInfo.Iso3166Code);
        Assert.Equal("United States Virgin Islands", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Open, countryInfo.NumberingPlanType);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
