namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for American samoa <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AS_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.AmericanSamoa);

    [Theory]
    [InlineData("6842000000", "684", "2000000")]
    [InlineData("6842109999", "684", "2109999")]
    [InlineData("6842120000", "684", "2120000")]
    [InlineData("6843109999", "684", "3109999")]
    [InlineData("6843120000", "684", "3120000")]
    [InlineData("6844109999", "684", "4109999")]
    [InlineData("6844120000", "684", "4120000")]
    [InlineData("6845109999", "684", "5109999")]
    [InlineData("6845120000", "684", "5120000")]
    [InlineData("6846109999", "684", "6109999")]
    [InlineData("6846120000", "684", "6120000")]
    [InlineData("6847109999", "684", "7109999")]
    [InlineData("6847120000", "684", "7120000")]
    [InlineData("6848109999", "684", "8109999")]
    [InlineData("6848120000", "684", "8120000")]
    [InlineData("6849109999", "684", "9109999")]
    [InlineData("6849120000", "684", "9120000")]
    [InlineData("6849999999", "684", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.AmericanSamoa, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
