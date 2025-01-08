namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint kitts and nevis <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KN_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintKittsAndNevis);

    [Theory]
    [InlineData("8692000000", "869", "2000000")]
    [InlineData("8692109999", "869", "2109999")]
    [InlineData("8692120000", "869", "2120000")]
    [InlineData("8693109999", "869", "3109999")]
    [InlineData("8693120000", "869", "3120000")]
    [InlineData("8694109999", "869", "4109999")]
    [InlineData("8694120000", "869", "4120000")]
    [InlineData("8695109999", "869", "5109999")]
    [InlineData("8695120000", "869", "5120000")]
    [InlineData("8696109999", "869", "6109999")]
    [InlineData("8696120000", "869", "6120000")]
    [InlineData("8697109999", "869", "7109999")]
    [InlineData("8697120000", "869", "7120000")]
    [InlineData("8698109999", "869", "8109999")]
    [InlineData("8698120000", "869", "8120000")]
    [InlineData("8699109999", "869", "9109999")]
    [InlineData("8699120000", "869", "9120000")]
    [InlineData("8699999999", "869", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintKittsAndNevis, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
