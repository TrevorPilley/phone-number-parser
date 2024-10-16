namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Colombia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CO_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Colombia);

    [Theory]
    [InlineData("6012000000", "601", "2000000", "Bogotá and Cundinamarca")]
    [InlineData("6019999999", "601", "9999999", "Bogotá and Cundinamarca")]
    [InlineData("6022000000", "602", "2000000", "Valle del Cauca, Cauca and Nariño")]
    [InlineData("6029999999", "602", "9999999", "Valle del Cauca, Cauca and Nariño")]
    [InlineData("6042000000", "604", "2000000", "Antioquia, Chocó and Córdoba")]
    [InlineData("6049999999", "604", "9999999", "Antioquia, Chocó and Córdoba")]
    [InlineData("6052000000", "605", "2000000", "Atlántico, Bolívar, Cesar, La Guajira, Magdalena and Sucre")]
    [InlineData("6059999999", "605", "9999999", "Atlántico, Bolívar, Cesar, La Guajira, Magdalena and Sucre")]
    [InlineData("6062000000", "606", "2000000", "Caldas, Risaralda and Quindío")]
    [InlineData("6069999999", "606", "9999999", "Caldas, Risaralda and Quindío")]
    [InlineData("6072000000", "607", "2000000", "Norte de Santander, Santander and Arauca")]
    [InlineData("6079999999", "607", "9999999", "Norte de Santander, Santander and Arauca")]
    [InlineData("6082000000", "608", "2000000", "Boyacá, Tolima, Huila, San Andrés, Meta, Caquetá and the Amazon and Orinoco")]
    [InlineData("6089999999", "608", "9999999", "Boyacá, Tolima, Huila, San Andrés, Meta, Caquetá and the Amazon and Orinoco")]
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
