namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Sint maarten <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SX_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SintMaarten);

    [Theory]
    [InlineData("7215200000", "721", "5200000")]
    [InlineData("7215299999", "721", "5299999")]
    [InlineData("7215500000", "721", "5500000")]
    [InlineData("7215509999", "721", "5509999")]
    [InlineData("7215530000", "721", "5530000")]
    [InlineData("7215549999", "721", "5549999")]
    [InlineData("7215560000", "721", "5560000")]
    [InlineData("7215579999", "721", "5579999")]
    [InlineData("7215590000", "721", "5590000")]
    [InlineData("7215599999", "721", "5599999")]
    [InlineData("7215800000", "721", "5800000")]
    [InlineData("7215819999", "721", "5819999")]
    [InlineData("7215840000", "721", "5840000")]
    [InlineData("7215889999", "721", "5889999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SintMaarten, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
