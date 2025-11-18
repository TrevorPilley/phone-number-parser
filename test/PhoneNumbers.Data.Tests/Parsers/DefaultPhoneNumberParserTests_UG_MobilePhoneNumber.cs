namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Uganda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_UG_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Uganda);

    [Theory]
    [InlineData("0700000000", "700", "000000")]
    [InlineData("0700999999", "700", "999999")]
    [InlineData("0719000000", "719", "000000")]
    [InlineData("0719999999", "719", "999999")]
    [InlineData("0740000000", "740", "000000")]
    [InlineData("0740999999", "740", "999999")]
    [InlineData("0746000000", "746", "000000")]
    [InlineData("0746999999", "746", "999999")]
    [InlineData("0750000000", "750", "000000")]
    [InlineData("0750999999", "750", "999999")]
    [InlineData("0768000000", "768", "000000")]
    [InlineData("0768999999", "768", "999999")]
    [InlineData("0770000000", "770", "000000")]
    [InlineData("0770999999", "770", "999999")]
    [InlineData("0789000000", "789", "000000")]
    [InlineData("0789999999", "789", "999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Uganda, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
