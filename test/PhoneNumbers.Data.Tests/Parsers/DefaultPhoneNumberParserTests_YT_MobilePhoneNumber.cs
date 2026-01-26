namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Mayotte <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_YT_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Mayotte);

    [Theory]
    [InlineData("0639000000", "639000000")]
    [InlineData("0639899999", "639899999")]
    [InlineData("0639900000", "639900000")]
    [InlineData("0639979999", "639979999")]
    [InlineData("0639990000", "639990000")]
    [InlineData("0639999999", "639999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Mayotte, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
