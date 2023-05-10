namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Latvia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LV_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Latvia);

    [Theory]
    [InlineData("63000000", "63000000", "Jelgava District")]
    [InlineData("63099999", "63099999", "Jelgava District")]
    [InlineData("63100000", "63100000", "Tukums District")]
    [InlineData("63199999", "63199999", "Tukums District")]
    [InlineData("63200000", "63200000", "Talsi District")]
    [InlineData("63299999", "63299999", "Talsi District")]
    [InlineData("63300000", "63300000", "Kuldiga District")]
    [InlineData("63399999", "63399999", "Kuldiga District")]
    [InlineData("63400000", "63400000", "Liepāja District")]
    [InlineData("63499999", "63499999", "Liepāja District")]
    [InlineData("63600000", "63600000", "Ventspils District")]
    [InlineData("63699999", "63699999", "Ventspils District")]
    [InlineData("63700000", "63700000", "Dobele District")]
    [InlineData("63799999", "63799999", "Dobele District")]
    [InlineData("63800000", "63800000", "Saldus District")]
    [InlineData("63899999", "63899999", "Saldus District")]
    [InlineData("63900000", "63900000", "Bauska District")]
    [InlineData("63999999", "63999999", "Bauska District")]
    [InlineData("64000000", "64000000", "Limbaži District")]
    [InlineData("64099999", "64099999", "Limbaži District")]
    [InlineData("64100000", "64100000", "Cēsis District")]
    [InlineData("64199999", "64199999", "Cēsis District")]
    [InlineData("64200000", "64200000", "Valmiera District")]
    [InlineData("64299999", "64299999", "Valmiera District")]
    [InlineData("64300000", "64300000", "Alūksne District")]
    [InlineData("64399999", "64399999", "Alūksne District")]
    [InlineData("64400000", "64400000", "Gulbene District")]
    [InlineData("64499999", "64499999", "Gulbene District")]
    [InlineData("64500000", "64500000", "Balvi District")]
    [InlineData("64599999", "64599999", "Balvi District")]
    [InlineData("64600000", "64600000", "Rēzekne District")]
    [InlineData("64699999", "64699999", "Rēzekne District")]
    [InlineData("64700000", "64700000", "Valka District")]
    [InlineData("64799999", "64799999", "Valka District")]
    [InlineData("64800000", "64800000", "Madona District")]
    [InlineData("64899999", "64899999", "Madona District")]
    [InlineData("64900000", "64900000", "Aizkraukle District")]
    [InlineData("64999999", "64999999", "Aizkraukle District")]
    [InlineData("65000000", "65000000", "Ogre District")]
    [InlineData("65099999", "65099999", "Ogre District")]
    [InlineData("65100000", "65100000", "Aizkraukle District")]
    [InlineData("65199999", "65199999", "Aizkraukle District")]
    [InlineData("65200000", "65200000", "Jēkabpils District")]
    [InlineData("65299999", "65299999", "Jēkabpils District")]
    [InlineData("65300000", "65300000", "Preiļi District")]
    [InlineData("65399999", "65399999", "Preiļi District")]
    [InlineData("65400000", "65400000", "Daugavpils District")]
    [InlineData("65499999", "65499999", "Daugavpils District")]
    [InlineData("65600000", "65600000", "Krāslava District")]
    [InlineData("65699999", "65699999", "Krāslava District")]
    [InlineData("65700000", "65700000", "Ludza District")]
    [InlineData("65799999", "65799999", "Ludza District")]
    [InlineData("65800000", "65800000", "Daugavpils District")]
    [InlineData("65899999", "65899999", "Daugavpils District")]
    [InlineData("66000000", "66000000", "Riga District")]
    [InlineData("67999999", "67999999", "Riga District")]
    [InlineData("69000000", "69000000", "Riga District")]
    [InlineData("69999999", "69999999", "Riga District")]
    public void Parse_Known_GeographicPhoneNumber(string value, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Latvia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Null(geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
