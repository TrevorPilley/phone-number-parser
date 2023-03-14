namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Puerto rico <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_PR_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.PuertoRico);

    [Theory]
    [InlineData("17872000000", "787", "2000000", "Puerto Rico")]
    [InlineData("17872109999", "787", "2109999", "Puerto Rico")]
    [InlineData("17872120000", "787", "2120000", "Puerto Rico")]
    [InlineData("17873109999", "787", "3109999", "Puerto Rico")]
    [InlineData("17873120000", "787", "3120000", "Puerto Rico")]
    [InlineData("17874109999", "787", "4109999", "Puerto Rico")]
    [InlineData("17874120000", "787", "4120000", "Puerto Rico")]
    [InlineData("17875109999", "787", "5109999", "Puerto Rico")]
    [InlineData("17875120000", "787", "5120000", "Puerto Rico")]
    [InlineData("17876109999", "787", "6109999", "Puerto Rico")]
    [InlineData("17876120000", "787", "6120000", "Puerto Rico")]
    [InlineData("17877109999", "787", "7109999", "Puerto Rico")]
    [InlineData("17877120000", "787", "7120000", "Puerto Rico")]
    [InlineData("17878109999", "787", "8109999", "Puerto Rico")]
    [InlineData("17878120000", "787", "8120000", "Puerto Rico")]
    [InlineData("17879109999", "787", "9109999", "Puerto Rico")]
    [InlineData("17879120000", "787", "9120000", "Puerto Rico")]
    [InlineData("17879999999", "787", "9999999", "Puerto Rico")]
    public void Parse_Known_GeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PuertoRico, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("19392000000", "939", "2000000", "Puerto Rico")]
    [InlineData("19392109999", "939", "2109999", "Puerto Rico")]
    [InlineData("19392120000", "939", "2120000", "Puerto Rico")]
    [InlineData("19393109999", "939", "3109999", "Puerto Rico")]
    [InlineData("19393120000", "939", "3120000", "Puerto Rico")]
    [InlineData("19394109999", "939", "4109999", "Puerto Rico")]
    [InlineData("19394120000", "939", "4120000", "Puerto Rico")]
    [InlineData("19395109999", "939", "5109999", "Puerto Rico")]
    [InlineData("19395120000", "939", "5120000", "Puerto Rico")]
    [InlineData("19396109999", "939", "6109999", "Puerto Rico")]
    [InlineData("19396120000", "939", "6120000", "Puerto Rico")]
    [InlineData("19397109999", "939", "7109999", "Puerto Rico")]
    [InlineData("19397120000", "939", "7120000", "Puerto Rico")]
    [InlineData("19398109999", "939", "8109999", "Puerto Rico")]
    [InlineData("19398120000", "939", "8120000", "Puerto Rico")]
    [InlineData("19399109999", "939", "9109999", "Puerto Rico")]
    [InlineData("19399120000", "939", "9120000", "Puerto Rico")]
    [InlineData("19399999999", "939", "9999999", "Puerto Rico")]
    public void Parse_Known_GeographicPhoneNumber_9XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PuertoRico, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
