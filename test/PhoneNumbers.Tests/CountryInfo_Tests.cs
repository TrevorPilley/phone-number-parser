using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests;

public class CountryInfo_Tests
{
    [Fact]
    public void GetFormatter_E123_Returns_E123PhoneNumberFormatter() =>
        Assert.IsType<E123PhoneNumberFormatter>(TestHelper.CreateCountryInfo().GetFormatter("E.123"));

    [Fact]
    public void GetFormatter_E164_Returns_E164PhoneNumberFormatter() =>
        Assert.IsType<E164PhoneNumberFormatter>(TestHelper.CreateCountryInfo().GetFormatter("E.164"));

    [Fact]
    public void GetFormatter_N_Returns_NationalPhoneNumberFormatter() =>
        Assert.IsType<NationalPhoneNumberFormatter>(TestHelper.CreateCountryInfo().GetFormatter("N"));

    [Fact]
    public void GetFormatter_Throws_For_Invalid_Format() =>
        Assert.Throws<FormatException>(() => TestHelper.CreateCountryInfo().GetFormatter("X"));

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("+35312222222")]
    public void HasCallingCode_False(string value) =>
        Assert.False(TestHelper.CreateCountryInfo().HasCallingCode(value));

    [Theory]
    [InlineData("+422012345678")]
    [InlineData("+422(0)12345678")]
    [InlineData("+422 (0) 123 456 78")]
    [InlineData("+422 (0) 123-456-78")]
    [InlineData("+422 (0) 123.456.78")]
    [InlineData("tel:+422-123-456-78")]
    public void HasCallingCode_True(string value) =>
        Assert.True(TestHelper.CreateCountryInfo().HasCallingCode(value));

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(@"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*()_+-={}[]:;""\\'|?/>.<,±`~ėęēêèéëūùûüúìįíîïīõøōœòôöóāãåæâàáäšßśłżžźčçćŵñń'¡¿…")]
    public void ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
        Assert.Equal(string.Empty, TestHelper.CreateCountryInfo().ReadNationalSignificantNumber(value));

    [Theory]
    [InlineData("+42212345678")]        // E.164 format
    [InlineData("+422 123 45678")]      // E.123 format
    [InlineData("(0123) 45678")]        // N format (open dialling)
    [InlineData("012345678")]           // N format (closed dialling)
    [InlineData("+422012345678")]       // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422(0)12345678")]     // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422 (0) 123 456 78")]
    [InlineData("+422 (0) 123-456-78")]
    [InlineData("+422 (0) 123.456.78")]
    [InlineData("(0) 123 456 78")]
    [InlineData("(0) 123-456-78")]
    [InlineData("(0) 123.456.78")]
    public void ReadNationalSignificantNumber_With_TrunkPrefix(string value) =>
        Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: "0").ReadNationalSignificantNumber(value));

    [Theory]
    [InlineData("+42216680666")]        // E.164 format
    [InlineData("+422 166 80666")]      // E.123 format
    [InlineData("(06166) 80666")]       // N format (open dialling)
    [InlineData("0616680666")]          // N format (closed dialling)
    [InlineData("+4220616680666")]      // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422(06)16680666")]    // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422 (06) 166 80666")]
    [InlineData("+422 (06) 166-80666")]
    [InlineData("+422 (06) 166.80666")]
    [InlineData("(06)16680666")]
    [InlineData("(06) 166 80666")]
    [InlineData("(06) 166-80666")]
    [InlineData("(06) 166.80666")]
    public void ReadNationalSignificantNumber_With_TrunkPrefix_MultiDigit(string value) =>
        Assert.Equal("16680666", TestHelper.CreateCountryInfo(trunkPrefix: "06").ReadNationalSignificantNumber(value));

    [Theory]
    [InlineData("+42212345678")]        // E.164 format
    [InlineData("+422 123 45678")]      // E.123 format
    [InlineData("123 45678")]           // N format (open dialling)
    [InlineData("12345678")]            // N format (closed dialling)
    [InlineData("+422 123 456 78")]
    [InlineData("+422 123-456-78")]
    [InlineData("+422 123.456.78")]
    [InlineData("123 456 78")]
    [InlineData("123-456-78")]
    [InlineData("123.456.78")]
    public void ReadNationalSignificantNumber_Without_TrunkPrefix(string value) =>
        Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: null).ReadNationalSignificantNumber(value));

    [Fact]
    public void When_Constructed()
    {
        var countryInfo = new CountryInfo();

        Assert.Null(countryInfo.CallingCode);
        Assert.Null(countryInfo.Continent);
        Assert.False(countryInfo.HasNationalDestinationCodes);
        Assert.Equal("00", countryInfo.InternationalCallPrefix);
        Assert.Null(countryInfo.Iso3166Code);
        Assert.Null(countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Empty(countryInfo.NsnLengths);
        Assert.True(countryInfo.RequireNdcForLocalGeographicDialling);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
