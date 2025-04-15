namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Yemen <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_YE_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Yemen);

    [Theory]
    [InlineData("0700000000", "70", "0000000")]
    [InlineData("0709999999", "70", "9999999")]
    [InlineData("0710000000", "71", "0000000")]
    [InlineData("0719999999", "71", "9999999")]
    [InlineData("0730000000", "73", "0000000")]
    [InlineData("0739999999", "73", "9999999")]
    [InlineData("0770000000", "77", "0000000")]
    [InlineData("0779999999", "77", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
