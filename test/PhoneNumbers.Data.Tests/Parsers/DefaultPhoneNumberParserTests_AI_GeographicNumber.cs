namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Anguilla <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AI_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Anguilla);

    [Theory]
    [InlineData("2642920000", "264", "2920000", "Anguilla")]
    [InlineData("2642929999", "264", "2929999", "Anguilla")]
    [InlineData("2644610000", "264", "4610000", "Anguilla")]
    [InlineData("2644629999", "264", "4629999", "Anguilla")]
    [InlineData("2644970000", "264", "4970000", "Anguilla")]
    [InlineData("2644989999", "264", "4989999", "Anguilla")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Anguilla, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
