namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Grenada <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GD_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Grenada);

    [Theory]
    [InlineData("4732000000", "473", "2000000")]
    [InlineData("4732109999", "473", "2109999")]
    [InlineData("4732120000", "473", "2120000")]
    [InlineData("4733109999", "473", "3109999")]
    [InlineData("4733120000", "473", "3120000")]
    [InlineData("4734109999", "473", "4109999")]
    [InlineData("4734120000", "473", "4120000")]
    [InlineData("4735109999", "473", "5109999")]
    [InlineData("4735120000", "473", "5120000")]
    [InlineData("4736109999", "473", "6109999")]
    [InlineData("4736120000", "473", "6120000")]
    [InlineData("4737109999", "473", "7109999")]
    [InlineData("4737120000", "473", "7120000")]
    [InlineData("4738109999", "473", "8109999")]
    [InlineData("4738120000", "473", "8120000")]
    [InlineData("4739109999", "473", "9109999")]
    [InlineData("4739120000", "473", "9120000")]
    [InlineData("4739999999", "473", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Grenada, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
