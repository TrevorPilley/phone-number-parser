namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Sint maarten <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SX_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SintMaarten);

    [Theory]
    [InlineData("7212000000", "721", "2000000")]
    [InlineData("7212109999", "721", "2109999")]
    [InlineData("7212120000", "721", "2120000")]
    [InlineData("7213109999", "721", "3109999")]
    [InlineData("7213120000", "721", "3120000")]
    [InlineData("7214109999", "721", "4109999")]
    [InlineData("7214120000", "721", "4120000")]
    [InlineData("7215109999", "721", "5109999")]
    [InlineData("7215120000", "721", "5120000")]
    [InlineData("7216109999", "721", "6109999")]
    [InlineData("7216120000", "721", "6120000")]
    [InlineData("7217109999", "721", "7109999")]
    [InlineData("7217120000", "721", "7120000")]
    [InlineData("7218109999", "721", "8109999")]
    [InlineData("7218120000", "721", "8120000")]
    [InlineData("7219109999", "721", "9109999")]
    [InlineData("7219120000", "721", "9120000")]
    [InlineData("7219999999", "721", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SintMaarten, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
