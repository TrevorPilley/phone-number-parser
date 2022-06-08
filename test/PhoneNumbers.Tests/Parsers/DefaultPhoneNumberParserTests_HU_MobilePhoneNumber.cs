namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Hungary <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_HU_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Hungary);

    [Theory]
    [InlineData("06200000000", "20", "0000000")]
    [InlineData("06209999999", "20", "9999999")]
    [InlineData("06300000000", "30", "0000000")]
    [InlineData("06309999999", "30", "9999999")]
    [InlineData("06310000000", "31", "0000000")]
    [InlineData("06319999999", "31", "9999999")]
    [InlineData("06500000000", "50", "0000000")]
    [InlineData("06509999999", "50", "9999999")]
    [InlineData("06700000000", "70", "0000000")]
    [InlineData("06709999999", "70", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
