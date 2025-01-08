namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Trinidad and tobago <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TT_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.TrinidadAndTobago);

    [Theory]
    [InlineData("8682000000", "868", "2000000")]
    [InlineData("8682109999", "868", "2109999")]
    [InlineData("8682120000", "868", "2120000")]
    [InlineData("8683109999", "868", "3109999")]
    [InlineData("8683120000", "868", "3120000")]
    [InlineData("8684109999", "868", "4109999")]
    [InlineData("8684120000", "868", "4120000")]
    [InlineData("8685109999", "868", "5109999")]
    [InlineData("8685120000", "868", "5120000")]
    [InlineData("8686109999", "868", "6109999")]
    [InlineData("8686120000", "868", "6120000")]
    [InlineData("8687109999", "868", "7109999")]
    [InlineData("8687120000", "868", "7120000")]
    [InlineData("8688109999", "868", "8109999")]
    [InlineData("8688120000", "868", "8120000")]
    [InlineData("8689109999", "868", "9109999")]
    [InlineData("8689120000", "868", "9120000")]
    [InlineData("8689999999", "868", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.TrinidadAndTobago, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
