namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Isle of man <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IM_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.IsleOfMan);

    [Theory]
    [InlineData("07418400000", "7418", "400000")]
    [InlineData("07418499999", "7418", "499999")]
    [InlineData("07452000000", "7452", "000000")]
    [InlineData("07452699999", "7452", "699999")]
    [InlineData("07624000000", "7624", "000000")]
    [InlineData("07624499999", "7624", "499999")]
    [InlineData("07624560000", "7624", "560000")]
    [InlineData("07624569999", "7624", "569999")]
    [InlineData("07624600000", "7624", "600000")]
    [InlineData("07624699999", "7624", "699999")]
    [InlineData("07624800000", "7624", "800000")]
    [InlineData("07624999999", "7624", "999999")]
    [InlineData("07924000000", "7924", "000000")]
    [InlineData("07924499999", "7924", "499999")]
    [InlineData("07924600000", "7924", "600000")]
    [InlineData("07924999999", "7924", "999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.IsleOfMan, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
