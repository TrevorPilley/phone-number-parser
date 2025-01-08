namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint vincent and the grenadines <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VC_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintVincentAndTheGrenadines);

    [Theory]
    [InlineData("7842000000", "784", "2000000")]
    [InlineData("7842109999", "784", "2109999")]
    [InlineData("7842120000", "784", "2120000")]
    [InlineData("7843109999", "784", "3109999")]
    [InlineData("7843120000", "784", "3120000")]
    [InlineData("7844109999", "784", "4109999")]
    [InlineData("7844120000", "784", "4120000")]
    [InlineData("7845109999", "784", "5109999")]
    [InlineData("7845120000", "784", "5120000")]
    [InlineData("7846109999", "784", "6109999")]
    [InlineData("7846120000", "784", "6120000")]
    [InlineData("7847109999", "784", "7109999")]
    [InlineData("7847120000", "784", "7120000")]
    [InlineData("7848109999", "784", "8109999")]
    [InlineData("7848120000", "784", "8120000")]
    [InlineData("7849109999", "784", "9109999")]
    [InlineData("7849120000", "784", "9120000")]
    [InlineData("7849999999", "784", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintVincentAndTheGrenadines, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
