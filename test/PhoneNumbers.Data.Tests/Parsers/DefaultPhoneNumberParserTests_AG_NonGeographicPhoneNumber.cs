namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Antigua and barbuda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AG_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.AntiguaAndBarbuda);

    [Theory]
    [InlineData("2682220000", "268", "2220000")]
    [InlineData("2682229999", "268", "2229999")]
    [InlineData("2682680000", "268", "2680000")]
    [InlineData("2682689999", "268", "2689999")]
    [InlineData("2684040000", "268", "4040000")]
    [InlineData("2684049999", "268", "4049999")]
    [InlineData("2684800000", "268", "4800000")]
    [InlineData("2684819999", "268", "4819999")]
    [InlineData("2684840000", "268", "4840000")]
    [InlineData("2684849999", "268", "4849999")]
    [InlineData("2685550000", "268", "5550000")]
    [InlineData("2685559999", "268", "5559999")]
    [InlineData("2687390000", "268", "7390000")]
    [InlineData("2687399999", "268", "7399999")]
    [InlineData("2689380000", "268", "9380000")]
    [InlineData("2689389999", "268", "9389999")]
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
