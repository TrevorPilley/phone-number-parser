namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bahamas <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BS_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bahamas);

    [Theory]
    [InlineData("2422000000", "242", "2000000")]
    [InlineData("2422109999", "242", "2109999")]
    [InlineData("2422120000", "242", "2120000")]
    [InlineData("2423109999", "242", "3109999")]
    [InlineData("2423120000", "242", "3120000")]
    [InlineData("2424109999", "242", "4109999")]
    [InlineData("2424120000", "242", "4120000")]
    [InlineData("2425109999", "242", "5109999")]
    [InlineData("2425120000", "242", "5120000")]
    [InlineData("2426109999", "242", "6109999")]
    [InlineData("2426120000", "242", "6120000")]
    [InlineData("2427109999", "242", "7109999")]
    [InlineData("2427120000", "242", "7120000")]
    [InlineData("2428109999", "242", "8109999")]
    [InlineData("2428120000", "242", "8120000")]
    [InlineData("2429109999", "242", "9109999")]
    [InlineData("2429120000", "242", "9120000")]
    [InlineData("2429999999", "242", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bahamas, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
