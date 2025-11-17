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
        Assert.Equal("Federative Republic of Brazil", countryInfo.FullName);
        Assert.Equal("0xx", countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("BR", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
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
        Assert.Equal("Republic of Colombia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("CO", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Colombia", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_FalklandIslands()
    {
        Assert.Same(CountryInfo.FalklandIslands, CountryInfo.FalklandIslands);

        var countryInfo = CountryInfo.FalklandIslands;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("500", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.SouthAmerica, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Falkland Islands", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("FK", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Falkland Islands", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal([5], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
    
    [Fact]
    public void CountryInfo_Peru()
    {
        Assert.Same(CountryInfo. Peru, CountryInfo. Peru);

        var countryInfo = CountryInfo. Peru;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("51", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.SouthAmerica, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Peru", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("PE", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Peru", countryInfo.Name);
        Assert. .Equal([2, 1], countryInfo.NdcLengths);
        Assert.Equal([6, 7, 9], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal(“0”, countryInfo.TrunkPrefix);
    }   
}
