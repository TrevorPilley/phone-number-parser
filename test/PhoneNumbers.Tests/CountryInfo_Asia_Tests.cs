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
        Assert.Equal("Hong Kong Special Administrative Region of China", countryInfo.FullName);
        Assert.Equal("001", countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("HK", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Hong Kong", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 9, 11, 12 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Kazakhstan()
    {
        Assert.Same(CountryInfo.Kazakhstan, CountryInfo.Kazakhstan);

        var countryInfo = CountryInfo.Kazakhstan;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("7", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Kazakhstan", countryInfo.FullName);
        Assert.Equal("8~xx", countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("KZ", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Kazakhstan", countryInfo.Name);
        Assert.Equal(new[] { 3 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 10 }, countryInfo.NsnLengths);
        Assert.True(countryInfo.SharesCallingCode);
        Assert.Equal("8", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Jordan()
    {
        Assert.Same(CountryInfo.Jordan, CountryInfo.Jordan);

        var countryInfo = CountryInfo.Jordan;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("962", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<SimplePhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Hashemite Kingdom of Jordan", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("JO", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Jordan", countryInfo.Name);
        Assert.Equal([1], countryInfo.NdcLengths);
        Assert.Equal([8, 9], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
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
        Assert.Equal("Macao Special Administrative Region of China", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("MO", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Macao", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Oman()
    {
        Assert.Same(CountryInfo.Oman, CountryInfo.Oman);

        var countryInfo = CountryInfo.Oman;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("968", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Sultanate of Oman", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("OM", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Oman", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal([8, 12], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Qatar()
    {
        Assert.Same(CountryInfo.Qatar, CountryInfo.Qatar);

        var countryInfo = CountryInfo.Qatar;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("974", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<BasicPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("State of Qatar", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("QA", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Qatar", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal([7, 8, 10], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_SaudiArabia()
    {
        Assert.Same(CountryInfo.SaudiArabia, CountryInfo.SaudiArabia);

        var countryInfo = CountryInfo.SaudiArabia;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("966", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Kingdom of Saudi Arabia", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("SA", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Saudi Arabia", countryInfo.Name);
        Assert.Equal([4, 3, 2], countryInfo.NdcLengths);
        Assert.Equal([8, 9, 10, 11, 12], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
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
        Assert.Equal("Republic of Singapore", countryInfo.FullName);
        Assert.Equal("000", countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("SG", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Singapore", countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Equal(new[] { 8, 10, 11 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Turkey()
    {
        Assert.Same(CountryInfo.Turkey, CountryInfo.Turkey);

        var countryInfo = CountryInfo.Turkey;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("90", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<TRPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Türkiye", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.False(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.True(countryInfo.IsNatoMember);
        Assert.Equal("TR", countryInfo.Iso3166Code);
        Assert.True(countryInfo.IsOecdMember);
        Assert.Equal("Türkiye", countryInfo.Name);
        Assert.Equal(new[] { 3, 0 }, countryInfo.NdcLengths);
        Assert.Equal(new[] { 7, 10 }, countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_UnitedArabEmirates()
    {
        Assert.Same(CountryInfo.UnitedArabEmirates, CountryInfo.UnitedArabEmirates);

        var countryInfo = CountryInfo.UnitedArabEmirates;

        Assert.True(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("971", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<ComplexPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("United Arab Emirates", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("AE", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("United Arab Emirates", countryInfo.Name);
        Assert.Equal([3, 2, 1], countryInfo.NdcLengths);
        Assert.Equal([5, 6, 7, 8, 9, 10, 11, 12], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }

    [Fact]
    public void CountryInfo_Yemen()
    {
        Assert.Same(CountryInfo.Yemen, CountryInfo.Yemen);

        var countryInfo = CountryInfo.Yemen;

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Equal("967", countryInfo.CallingCode);
        Assert.Equal(CountryInfo.Asia, countryInfo.Continent);
        Assert.IsType<YEPhoneNumberFormatProvider>(countryInfo.FormatProvider);
        Assert.Equal("Republic of Yemen", countryInfo.FullName);
        Assert.Equal(CountryInfo.ItuInternationalCallPrefix, countryInfo.InternationalCallPrefix);
        Assert.Empty(countryInfo.InternationalCallPrefixes);
        Assert.True(countryInfo.IsArabLeagueMember);
        Assert.False(countryInfo.IsEuropeanUnionMember);
        Assert.False(countryInfo.IsNatoMember);
        Assert.Equal("YE", countryInfo.Iso3166Code);
        Assert.False(countryInfo.IsOecdMember);
        Assert.Equal("Yemen", countryInfo.Name);
        Assert.Equal([2, 1], countryInfo.NdcLengths);
        Assert.Equal([7, 8, 9], countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Equal("0", countryInfo.TrunkPrefix);
    }
}
