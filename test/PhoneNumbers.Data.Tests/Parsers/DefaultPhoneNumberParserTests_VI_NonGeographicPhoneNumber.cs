namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United states virgin islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VI_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.VirginIslandsOfTheUnitedStates);

    [Theory]
    [InlineData("3402000000", "340", "2000000")]
    [InlineData("3402109999", "340", "2109999")]
    [InlineData("3402120000", "340", "2120000")]
    [InlineData("3403109999", "340", "3109999")]
    [InlineData("3403120000", "340", "3120000")]
    [InlineData("3404109999", "340", "4109999")]
    [InlineData("3404120000", "340", "4120000")]
    [InlineData("3405109999", "340", "5109999")]
    [InlineData("3405120000", "340", "5120000")]
    [InlineData("3406109999", "340", "6109999")]
    [InlineData("3406120000", "340", "6120000")]
    [InlineData("3407109999", "340", "7109999")]
    [InlineData("3407120000", "340", "7120000")]
    [InlineData("3408109999", "340", "8109999")]
    [InlineData("3408120000", "340", "8120000")]
    [InlineData("3409109999", "340", "9109999")]
    [InlineData("3409120000", "340", "9120000")]
    [InlineData("3409999999", "340", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.VirginIslandsOfTheUnitedStates, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
