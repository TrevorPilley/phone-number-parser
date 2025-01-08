namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Barbados <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BB_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Barbados);

    [Theory]
    [InlineData("2462000000", "246", "2000000")]
    [InlineData("2462109999", "246", "2109999")]
    [InlineData("2462120000", "246", "2120000")]
    [InlineData("2463109999", "246", "3109999")]
    [InlineData("2463120000", "246", "3120000")]
    [InlineData("2464109999", "246", "4109999")]
    [InlineData("2464120000", "246", "4120000")]
    [InlineData("2465109999", "246", "5109999")]
    [InlineData("2465120000", "246", "5120000")]
    [InlineData("2466109999", "246", "6109999")]
    [InlineData("2466120000", "246", "6120000")]
    [InlineData("2467109999", "246", "7109999")]
    [InlineData("2467120000", "246", "7120000")]
    [InlineData("2468109999", "246", "8109999")]
    [InlineData("2468120000", "246", "8120000")]
    [InlineData("2469109999", "246", "9109999")]
    [InlineData("2469120000", "246", "9120000")]
    [InlineData("2469999999", "246", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Barbados, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
