namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Montserrat <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MS_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Montserrat);

    [Theory]
    [InlineData("6642000000", "664", "2000000")]
    [InlineData("6642109999", "664", "2109999")]
    [InlineData("6642120000", "664", "2120000")]
    [InlineData("6643109999", "664", "3109999")]
    [InlineData("6643120000", "664", "3120000")]
    [InlineData("6644109999", "664", "4109999")]
    [InlineData("6644120000", "664", "4120000")]
    [InlineData("6645109999", "664", "5109999")]
    [InlineData("6645120000", "664", "5120000")]
    [InlineData("6646109999", "664", "6109999")]
    [InlineData("6646120000", "664", "6120000")]
    [InlineData("6647109999", "664", "7109999")]
    [InlineData("6647120000", "664", "7120000")]
    [InlineData("6648109999", "664", "8109999")]
    [InlineData("6648120000", "664", "8120000")]
    [InlineData("6649109999", "664", "9109999")]
    [InlineData("6649120000", "664", "9120000")]
    [InlineData("6649999999", "664", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montserrat, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
