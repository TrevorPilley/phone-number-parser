namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Jamaica <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_JM_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Jamaica);

    [Theory]
    [InlineData("6582000000", "658", "2000000")]
    [InlineData("6582109999", "658", "2109999")]
    [InlineData("6582120000", "658", "2120000")]
    [InlineData("6583109999", "658", "3109999")]
    [InlineData("6583120000", "658", "3120000")]
    [InlineData("6584109999", "658", "4109999")]
    [InlineData("6584120000", "658", "4120000")]
    [InlineData("6585109999", "658", "5109999")]
    [InlineData("6585120000", "658", "5120000")]
    [InlineData("6586109999", "658", "6109999")]
    [InlineData("6586120000", "658", "6120000")]
    [InlineData("6587109999", "658", "7109999")]
    [InlineData("6587120000", "658", "7120000")]
    [InlineData("6588109999", "658", "8109999")]
    [InlineData("6588120000", "658", "8120000")]
    [InlineData("6589109999", "658", "9109999")]
    [InlineData("6589120000", "658", "9120000")]
    [InlineData("6589999999", "658", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jamaica, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("8762000000", "876", "2000000")]
    [InlineData("8762109999", "876", "2109999")]
    [InlineData("8762120000", "876", "2120000")]
    [InlineData("8763109999", "876", "3109999")]
    [InlineData("8763120000", "876", "3120000")]
    [InlineData("8764109999", "876", "4109999")]
    [InlineData("8764120000", "876", "4120000")]
    [InlineData("8765109999", "876", "5109999")]
    [InlineData("8765120000", "876", "5120000")]
    [InlineData("8766109999", "876", "6109999")]
    [InlineData("8766120000", "876", "6120000")]
    [InlineData("8767109999", "876", "7109999")]
    [InlineData("8767120000", "876", "7120000")]
    [InlineData("8768109999", "876", "8109999")]
    [InlineData("8768120000", "876", "8120000")]
    [InlineData("8769109999", "876", "9109999")]
    [InlineData("8769120000", "876", "9120000")]
    [InlineData("8769999999", "876", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jamaica, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
