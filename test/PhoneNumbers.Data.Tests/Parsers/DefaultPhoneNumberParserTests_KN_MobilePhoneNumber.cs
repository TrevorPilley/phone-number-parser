namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint kitts and nevis <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KN_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintKittsAndNevis);

    [Theory]
    [InlineData("8695560000", "869", "5560000")]
    [InlineData("8695589999", "869", "5589999")]
    [InlineData("8695650000", "869", "5650000")]
    [InlineData("8695679999", "869", "5679999")]
    [InlineData("8696600000", "869", "6600000")]
    [InlineData("8696699999", "869", "6699999")]
    [InlineData("8697600000", "869", "7600000")]
    [InlineData("8697609999", "869", "7609999")]
    [InlineData("8697620000", "869", "7620000")]
    [InlineData("8697669999", "869", "7669999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintKittsAndNevis, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
