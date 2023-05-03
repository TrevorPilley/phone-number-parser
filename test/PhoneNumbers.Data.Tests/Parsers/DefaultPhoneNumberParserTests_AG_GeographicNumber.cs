namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Antigua and barbuda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.AntiguaAndBarbuda);

    [Theory]
    [InlineData("2684600000", "268", "4600000", "Antigua and Barbuda")]
    [InlineData("2684639999", "268", "4639999", "Antigua and Barbuda")]
    [InlineData("2685600000", "268", "5600000", "Antigua and Barbuda")]
    [InlineData("2685629999", "268", "5629999", "Antigua and Barbuda")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.AntiguaAndBarbuda, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
