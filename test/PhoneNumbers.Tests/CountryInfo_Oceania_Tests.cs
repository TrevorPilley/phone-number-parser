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
        Assert.Equal(new[] { 3, 2, 1 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 5, 6, 7, 8, 9, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_PapuaNewGuinea()
    {
        Assert.Same(CountryInfo.PapuaNewGuinea, CountryInfo.PapuaNewGuinea);

        var countryInfo = CountryInfo.PapuaNewGuinea;

        Assert.Equal("+675", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Oceania, countryInfo.Continent);
        Assert.True(countryInfo.HasNationalDestinationCodes);
        Assert.Equal("00", countryInfo.InternationalCallPrefix);
        Assert.Equal("PG", countryInfo.Iso3166Code);
        Assert.Equal("Papua New Guinea", countryInfo.Name);
        Assert.Equal(new[] { 2 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 8 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
