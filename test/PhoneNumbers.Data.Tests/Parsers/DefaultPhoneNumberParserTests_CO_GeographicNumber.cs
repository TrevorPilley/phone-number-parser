namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Colombia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CO_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Colombia);

    [Theory]
    [InlineData("06010000000", "601", "0000000", "Bogotá and Cundinamarca")]
    [InlineData("06019999999", "601", "9999999", "Bogotá and Cundinamarca")]
    [InlineData("06020000000", "602", "0000000", "Valle del Cauca, Cauca and Nariño")]
    [InlineData("06029999999", "602", "9999999", "Valle del Cauca, Cauca and Nariño")]
    [InlineData("06040000000", "604", "0000000", "Antioquia, Chocó and Córdoba")]
    [InlineData("06049999999", "604", "9999999", "Antioquia, Chocó and Córdoba")]
    [InlineData("06050000000", "605", "0000000", "Atlántico, Bolívar, Cesar, La Guajira, Magdalena and Sucre")]
    [InlineData("06059999999", "605", "9999999", "Atlántico, Bolívar, Cesar, La Guajira, Magdalena and Sucre")]
    [InlineData("06060000000", "606", "0000000", "Caldas, Risaralda and Quindío")]
    [InlineData("06069999999", "606", "9999999", "Caldas, Risaralda and Quindío")]
    [InlineData("06070000000", "607", "0000000", "Norte de Santander, Santander and Arauca")]
    [InlineData("06079999999", "607", "9999999", "Norte de Santander, Santander and Arauca")]
    [InlineData("06080000000", "608", "0000000", "Boyacá, Tolima, Huila, San Andrés, Meta, Caquetá and the Amazon and Orinoco")]
    [InlineData("06089999999", "608", "9999999", "Boyacá, Tolima, Huila, San Andrés, Meta, Caquetá and the Amazon and Orinoco")]
    public void Parse_Known_GeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Colombia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
