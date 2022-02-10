namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="GBPhoneNumberParser"/> class.
/// </summary>
public class GBPhoneNumberParserTests
{
    private readonly PhoneNumberParser _parser = GBPhoneNumberParser.Create();

    [Fact]
    public void Parse_Returns_Failure_For_1XX_NationalDestinationCode_And_SubscriberNumber_Not_7_Digits()
    {
        var result = _parser.Parse("0113111222");
        Assert.Equal("The national significant number 113111222 is not a valid United Kingdom phone number.", result.ParseError);
    }

    [Fact]
    public void Parse_Returns_Failure_For_2X_NationalDestinationCode_And_SubscriberNumber_Not_8_Digits()
    {
        var result = _parser.Parse("0201112222");
        Assert.Equal("The national significant number 201112222 is not a valid United Kingdom phone number.", result.ParseError);
    }

    [Fact]
    public void Parse_Returns_Failure_For_3XX_NationalDestinationCode_And_SubscriberNumber_Not_7_Digits()
    {
        var result = _parser.Parse("0300111111");
        Assert.Equal("The national significant number 300111111 is not a valid United Kingdom phone number.", result.ParseError);
    }

    [Fact]
    public void Parse_Returns_Failure_For_7XXX_NationalDestinationCode_And_SubscriberNumber_Not_6_Digits()
    {
        var result = _parser.Parse("0770012345");
        Assert.Equal("The national significant number 770012345 is not a valid United Kingdom phone number.", result.ParseError);
    }

    [Fact]
    public void Parse_Returns_Failure_If_CallingCode_Invalid()
    {
        var result = _parser.Parse("+1111111111");
        Assert.Equal($"The value must be a United Kingdom phone number starting +44 or 0 and the national significant number of the phone number must be {string.Join(" or ", CountryInfo.UnitedKingdom.NsnLengths)} digits in length.", result.ParseError);
    }

    [Theory]
    [InlineData("01100000000")]
    [InlineData("01110000000")]
    [InlineData("01120000000")]
    [InlineData("01190000000")]
    [InlineData("01710000000")]
    [InlineData("01810000000")]
    [InlineData("02100000000")]
    [InlineData("02200000000")]
    [InlineData("02500000000")]
    [InlineData("02600000000")]
    [InlineData("02700000000")]
    [InlineData("03100000000")]
    [InlineData("03200000000")]
    [InlineData("03500000000")]
    [InlineData("03600000000")]
    [InlineData("03800000000")]
    [InlineData("03900000000")]
    [InlineData("07200000000")]
    public void Parse_Returns_Failure_If_NationalDestinationCode_Invalid(string value)
    {
        var result = _parser.Parse(value);
        Assert.Equal($"The national significant number {value.Substring(1)} is not a valid United Kingdom phone number.", result.ParseError);
    }

    [Theory]
    [InlineData("02")]
    [InlineData("020")]
    [InlineData("0201")]
    [InlineData("02011")]
    [InlineData("020111")]
    [InlineData("0201111")]
    [InlineData("020111111")]    // 8
    [InlineData("020111111111")] // 11
    public void Parse_Returns_Failure_If_Nsn_Incorrect_Length(string value)
    {
        var result = _parser.Parse(value);
        Assert.Equal($"The value must be a United Kingdom phone number starting +44 or 0 and the national significant number of the phone number must be {string.Join(" or ", CountryInfo.UnitedKingdom.NsnLengths)} digits in length.", result.ParseError);
    }

    [Theory]
    [InlineData("0411111111")]
    [InlineData("0511111111")]
    [InlineData("0611111111")]
    [InlineData("0911111111")]
    public void Parse_Returns_Failure_If_ServiceType_Invalid(string value)
    {
        var result = _parser.Parse(value);
        Assert.Equal($"The national significant number {value.Substring(1)} is not a valid United Kingdom phone number.", result.ParseError);
    }

    [Theory]
    [InlineData("07101111111")]
    public void Parse_Returns_Failure_If_SubscriberNumber_Invalid_For_NationalDestinationCode(string value)
    {
        var result = _parser.Parse(value);
        Assert.Equal($"The national significant number {value.Substring(1)} is not a valid United Kingdom phone number.", result.ParseError);
    }
}
