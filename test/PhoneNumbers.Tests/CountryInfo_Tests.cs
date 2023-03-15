using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests;

public class CountryInfo_Tests
{
    [Fact]
    public void GetFormatter_E123_Returns_E123PhoneNumberFormatter() =>
        Assert.IsType<E123PhoneNumberFormatter>(CountryInfo.GetFormatter("E.123"));

    [Fact]
    public void GetFormatter_E164_Returns_E164PhoneNumberFormatter() =>
        Assert.IsType<E164PhoneNumberFormatter>(CountryInfo.GetFormatter("E.164"));

    [Fact]
    public void GetFormatter_N_Returns_NationalPhoneNumberFormatter() =>
        Assert.IsType<NationalPhoneNumberFormatter>(CountryInfo.GetFormatter("N"));

    [Fact]
    public void GetFormatter_RFC3966_Returns_Rfc3966PhoneNumberFormatter() =>
        Assert.IsType<Rfc3966PhoneNumberFormatter>(CountryInfo.GetFormatter("RFC3966"));

    [Fact]
    public void GetFormatter_Throws_For_Invalid_Format() =>
        Assert.Throws<FormatException>(() => CountryInfo.GetFormatter("X"));

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
    [InlineData("+422 (0) 123/456/78")]
    [InlineData("tel:+422-123-456-78")]
    public void HasCallingCode_True(string value) =>
        Assert.True(TestHelper.CreateCountryInfo().HasCallingCode(value));

    [Fact]
    public void HasNationalDestinationCodes_False() =>
        Assert.False(TestHelper.CreateCountryInfo(ndcLengths: null).HasNationalDestinationCodes);

    [Fact]
    public void HasNationalDestinationCodes_True() =>
        Assert.True(TestHelper.CreateCountryInfo(ndcLengths: new[] { 2 }).HasNationalDestinationCodes);

    [Fact]
    public void HasTrunkPrefix_False() =>
        Assert.False(TestHelper.CreateCountryInfo(trunkPrefix: null).HasTrunkPrefix);

    [Fact]
    public void HasTrunkPrefix_True() =>
        Assert.True(TestHelper.CreateCountryInfo(trunkPrefix: "0").HasTrunkPrefix);

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
    [InlineData("(0) 123/456/78")]
    [InlineData("A sentence containing a valid international formatted number +42212345678 within it.")]
    [InlineData("A sentence containing a valid national formatted number (0123) 45678 within it.")]
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
    [InlineData("(06) 166/80666")]
    [InlineData("A sentence containing a valid international formatted number +42216680666 within it.")]
    [InlineData("A sentence containing a valid national formatted number (06166) 80666 within it.")]
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
    [InlineData("123/456/78")]
    [InlineData("A sentence containing a valid international formatted number +42212345678 within it.")]
    [InlineData("A sentence containing a valid national formatted number 123 45678 within it.")]
    public void ReadNationalSignificantNumber_Without_TrunkPrefix(string value) =>
        Assert.Equal("12345678", TestHelper.CreateCountryInfo(trunkPrefix: null).ReadNationalSignificantNumber(value));

    [Fact]
    public void When_Constructed()
    {
        var countryInfo = new CountryInfo();

        Assert.Null(countryInfo.CallingCode);
        Assert.Null(countryInfo.Continent);
        Assert.False(countryInfo.HasNationalDestinationCodes);
        Assert.False(countryInfo.HasTrunkPrefix);
        Assert.Equal("00", countryInfo.InternationalCallPrefix);
        Assert.Null(countryInfo.Iso3166Code);
        Assert.Null(countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Empty(countryInfo.NsnLengths);
        Assert.Equal(NumberingPlanType.Closed, countryInfo.NumberingPlanType);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
