namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint lucia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LC_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintLucia);

    [Theory]
    [InlineData("7582000000", "758", "2000000")]
    [InlineData("7582109999", "758", "2109999")]
    [InlineData("7582120000", "758", "2120000")]
    [InlineData("7583109999", "758", "3109999")]
    [InlineData("7583120000", "758", "3120000")]
    [InlineData("7584109999", "758", "4109999")]
    [InlineData("7584120000", "758", "4120000")]
    [InlineData("7585109999", "758", "5109999")]
    [InlineData("7585120000", "758", "5120000")]
    [InlineData("7586109999", "758", "6109999")]
    [InlineData("7586120000", "758", "6120000")]
    [InlineData("7587109999", "758", "7109999")]
    [InlineData("7587120000", "758", "7120000")]
    [InlineData("7588109999", "758", "8109999")]
    [InlineData("7588120000", "758", "8120000")]
    [InlineData("7589109999", "758", "9109999")]
    [InlineData("7589120000", "758", "9120000")]
    [InlineData("7589999999", "758", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintLucia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
