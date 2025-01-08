namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for British virgin islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VG_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.BritishVirginIslands);

    [Theory]
    [InlineData("2842000000", "284", "2000000")]
    [InlineData("2842109999", "284", "2109999")]
    [InlineData("2842120000", "284", "2120000")]
    [InlineData("2843109999", "284", "3109999")]
    [InlineData("2843120000", "284", "3120000")]
    [InlineData("2844109999", "284", "4109999")]
    [InlineData("2844120000", "284", "4120000")]
    [InlineData("2845109999", "284", "5109999")]
    [InlineData("2845120000", "284", "5120000")]
    [InlineData("2846109999", "284", "6109999")]
    [InlineData("2846120000", "284", "6120000")]
    [InlineData("2847109999", "284", "7109999")]
    [InlineData("2847120000", "284", "7120000")]
    [InlineData("2848109999", "284", "8109999")]
    [InlineData("2848120000", "284", "8120000")]
    [InlineData("2849109999", "284", "9109999")]
    [InlineData("2849120000", "284", "9120000")]
    [InlineData("2849999999", "284", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BritishVirginIslands, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
