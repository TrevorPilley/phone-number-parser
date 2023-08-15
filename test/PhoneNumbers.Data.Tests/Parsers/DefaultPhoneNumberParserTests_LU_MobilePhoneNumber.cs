namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Luxembourg <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LU_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Luxembourg);

    [Theory]
    [InlineData("621000000", "621000000")]
    [InlineData("621999999", "621999999")]
    [InlineData("651000000", "651000000")]
    [InlineData("651999999", "651999999")]
    [InlineData("655000000", "655000000")]
    [InlineData("656999999", "656999999")]
    [InlineData("661000000", "661000000")]
    [InlineData("661999999", "661999999")]
    [InlineData("671000000", "671000000")]
    [InlineData("671999999", "671999999")]
    [InlineData("681000000", "681000000")]
    [InlineData("681999999", "681999999")]
    [InlineData("691000000", "691000000")]
    [InlineData("691999999", "691999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Luxembourg, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
