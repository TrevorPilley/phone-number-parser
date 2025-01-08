namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Anguilla <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AI_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Anguilla);

    [Theory]
    [InlineData("2642000000", "264", "2000000")]
    [InlineData("2642109999", "264", "2109999")]
    [InlineData("2642120000", "264", "2120000")]
    [InlineData("2643109999", "264", "3109999")]
    [InlineData("2643120000", "264", "3120000")]
    [InlineData("2644109999", "264", "4109999")]
    [InlineData("2644120000", "264", "4120000")]
    [InlineData("2645109999", "264", "5109999")]
    [InlineData("2645120000", "264", "5120000")]
    [InlineData("2646109999", "264", "6109999")]
    [InlineData("2646120000", "264", "6120000")]
    [InlineData("2647109999", "264", "7109999")]
    [InlineData("2647120000", "264", "7120000")]
    [InlineData("2648109999", "264", "8109999")]
    [InlineData("2648120000", "264", "8120000")]
    [InlineData("2649109999", "264", "9109999")]
    [InlineData("2649120000", "264", "9120000")]
    [InlineData("2649999999", "264", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Anguilla, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
