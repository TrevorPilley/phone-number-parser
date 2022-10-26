namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for South africa <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_ZA_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SouthAfrica);

    [Theory]
    [InlineData("0600000000", "60", "0000000")]
    [InlineData("0609999999", "60", "9999999")]
    [InlineData("0740000000", "74", "0000000")]
    [InlineData("0749999999", "74", "9999999")]
    [InlineData("0760000000", "76", "0000000")]
    [InlineData("0769999999", "76", "9999999")]
    [InlineData("0790000000", "79", "0000000")]
    [InlineData("0799999999", "79", "9999999")]
    [InlineData("0810000000", "81", "0000000")]
    [InlineData("0819999999", "81", "9999999")]
    [InlineData("0840000000", "84", "0000000")]
    [InlineData("0849999999", "84", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
