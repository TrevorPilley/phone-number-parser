namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Ukraine <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_UA_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Ukraine);

    [Theory]
    [InlineData("0500000000", "50", "0000000")]
    [InlineData("0509999999", "50", "9999999")]
    [InlineData("0630000000", "63", "0000000")]
    [InlineData("0639999999", "63", "9999999")]
    [InlineData("0660000000", "66", "0000000")]
    [InlineData("0669999999", "66", "9999999")]
    [InlineData("0680000000", "68", "0000000")]
    [InlineData("0689999999", "68", "9999999")]
    [InlineData("0730000000", "73", "0000000")]
    [InlineData("0739999999", "73", "9999999")]
    [InlineData("0910000000", "91", "0000000")]
    [InlineData("0919999999", "91", "9999999")]
    [InlineData("0990000000", "99", "0000000")]
    [InlineData("0999999999", "99", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Ukraine, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
