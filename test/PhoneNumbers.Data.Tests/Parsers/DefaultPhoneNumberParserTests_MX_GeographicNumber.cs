namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Mexico <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MX_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Mexico);

    [Theory]
    [InlineData("2100000000", "2100000000", "Este")]
    [InlineData("2999999999", "2999999999", "Este")]
    [InlineData("3100000000", "3100000000", "Oeste")]
    [InlineData("3999999999", "3999999999", "Oeste")]
    [InlineData("4100000000", "4100000000", "Norte")]
    [InlineData("4999999999", "4999999999", "Norte")]
    [InlineData("5100000000", "5100000000", "Central")]
    [InlineData("5999999999", "5999999999", "Central")]
    [InlineData("6100000000", "6100000000", "Noroeste")]
    [InlineData("6999999999", "6999999999", "Noroeste")]
    [InlineData("7100000000", "7100000000", "Sur oeste")]
    [InlineData("7999999999", "7999999999", "Sur oeste")]
    [InlineData("8100000000", "8100000000", "Noreste")]
    [InlineData("8999999999", "8999999999", "Noreste")]
    [InlineData("9100000000", "9100000000", "Sureste")]
    [InlineData("9109999999", "9109999999", "Sureste")]
    [InlineData("9129999999", "9129999999", "Sureste")]
    [InlineData("9999999999", "9999999999", "Sureste")]
    public void Parse_Known_GeographicPhoneNumber(string value, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Mexico, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Null(geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
