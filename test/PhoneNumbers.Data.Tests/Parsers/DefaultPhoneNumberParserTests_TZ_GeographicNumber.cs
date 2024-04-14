namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Tanzania <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TZ_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Tanzania);

    [Theory]
    [InlineData("0222000000", "22", "2000000", "Dar-Es-Salaam Region")]
    [InlineData("0222999999", "22", "2999999", "Dar-Es-Salaam Region")]
    [InlineData("0232000000", "23", "2000000", "Coast, Lindi, Morogoro, Mtwara Regions")]
    [InlineData("0232999999", "23", "2999999", "Coast, Lindi, Morogoro, Mtwara Regions")]
    [InlineData("0242000000", "24", "2000000", "Zanzibar (including Pemba and Unguja)")]
    [InlineData("0242999999", "24", "2999999", "Zanzibar (including Pemba and Unguja)")]
    [InlineData("0252000000", "25", "2000000", "Katavi, Mbeya, Rukwa, Ruvuma and Songwe Regions")]
    [InlineData("0252999999", "25", "2999999", "Katavi, Mbeya, Rukwa, Ruvuma and Songwe Regions")]
    [InlineData("0262000000", "26", "2000000", "Dodoma, Iringa, Njombe, Singida and Tabora Regions")]
    [InlineData("0262999999", "26", "2999999", "Dodoma, Iringa, Njombe, Singida and Tabora Regions")]
    [InlineData("0272000000", "27", "2000000", "Arusha, Kilimanjaro, Manyara and Tanga Regions")]
    [InlineData("0272999999", "27", "2999999", "Arusha, Kilimanjaro, Manyara and Tanga Regions")]
    [InlineData("0282000000", "28", "2000000", "Geita, Kagera, Kigoma, Mara, Mwanza, Shinyanga and Simiyu Regions")]
    [InlineData("0282999999", "28", "2999999", "Geita, Kagera, Kigoma, Mara, Mwanza, Shinyanga and Simiyu Regions")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
