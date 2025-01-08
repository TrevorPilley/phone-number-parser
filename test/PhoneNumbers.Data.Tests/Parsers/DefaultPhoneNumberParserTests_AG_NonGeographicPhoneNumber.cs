namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Antigua and barbuda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AG_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.AntiguaAndBarbuda);

    [Theory]
    [InlineData("2682000000", "268", "2000000")]
    [InlineData("2682109999", "268", "2109999")]
    [InlineData("2682120000", "268", "2120000")]
    [InlineData("2683109999", "268", "3109999")]
    [InlineData("2683120000", "268", "3120000")]
    [InlineData("2684109999", "268", "4109999")]
    [InlineData("2684120000", "268", "4120000")]
    [InlineData("2685109999", "268", "5109999")]
    [InlineData("2685120000", "268", "5120000")]
    [InlineData("2686109999", "268", "6109999")]
    [InlineData("2686120000", "268", "6120000")]
    [InlineData("2687109999", "268", "7109999")]
    [InlineData("2687120000", "268", "7120000")]
    [InlineData("2688109999", "268", "8109999")]
    [InlineData("2688120000", "268", "8120000")]
    [InlineData("2689109999", "268", "9109999")]
    [InlineData("2689120000", "268", "9120000")]
    [InlineData("2689999999", "268", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.AntiguaAndBarbuda, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
