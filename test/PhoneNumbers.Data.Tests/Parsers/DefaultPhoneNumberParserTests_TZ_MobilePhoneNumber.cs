namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Tanzania <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TZ_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Tanzania);

    [Theory]
    [InlineData("0610000000", "61", "0000000")]
    [InlineData("0619999999", "61", "9999999")]
    [InlineData("0620000000", "62", "0000000")]
    [InlineData("0629999999", "62", "9999999")]
    [InlineData("0650000000", "65", "0000000")]
    [InlineData("0659999999", "65", "9999999")]
    [InlineData("0690000000", "69", "0000000")]
    [InlineData("0699999999", "69", "9999999")]
    [InlineData("0710000000", "71", "0000000")]
    [InlineData("0719999999", "71", "9999999")]
    [InlineData("0730000000", "73", "0000000")]
    [InlineData("0739999999", "73", "9999999")]
    [InlineData("0780000000", "78", "0000000")]
    [InlineData("0789999999", "78", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
