namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Poland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_PL_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Poland);

    [Theory]
    [InlineData("120000000", "12", "0000000", "Kraków")]
    [InlineData("129999999", "12", "9999999", "Kraków")]
    [InlineData("130000000", "13", "0000000", "Krosno")]
    [InlineData("139999999", "13", "9999999", "Krosno")]
    [InlineData("140000000", "14", "0000000", "Tarnów")]
    [InlineData("149999999", "14", "9999999", "Tarnów")]
    [InlineData("150000000", "15", "0000000", "Tarnobrzeg")]
    [InlineData("159999999", "15", "9999999", "Tarnobrzeg")]
    [InlineData("160000000", "16", "0000000", "Przemyśl")]
    [InlineData("169999999", "16", "9999999", "Przemyśl")]
    [InlineData("170000000", "17", "0000000", "Rzeszów")]
    [InlineData("179999999", "17", "9999999", "Rzeszów")]
    [InlineData("180000000", "18", "0000000", "Nowy Sącz")]
    [InlineData("189999999", "18", "9999999", "Nowy Sącz")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("220000000", "22", "0000000", "Warszawa")]
    [InlineData("229999999", "22", "9999999", "Warszawa")]
    [InlineData("230000000", "23", "0000000", "Ciechanów")]
    [InlineData("239999999", "23", "9999999", "Ciechanów")]
    [InlineData("240000000", "24", "0000000", "Płock")]
    [InlineData("249999999", "24", "9999999", "Płock")]
    [InlineData("250000000", "25", "0000000", "Siedlce")]
    [InlineData("259999999", "25", "9999999", "Siedlce")]
    [InlineData("290000000", "29", "0000000", "Ostrołęka")]
    [InlineData("299999999", "29", "9999999", "Ostrołęka")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("320000000", "32", "0000000", "Katowice")]
    [InlineData("329999999", "32", "9999999", "Katowice")]
    [InlineData("330000000", "33", "0000000", "Bielsko-Biała")]
    [InlineData("339999999", "33", "9999999", "Bielsko-Biała")]
    [InlineData("340000000", "34", "0000000", "Częstochowa")]
    [InlineData("349999999", "34", "9999999", "Częstochowa")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("410000000", "41", "0000000", "Kielce")]
    [InlineData("419999999", "41", "9999999", "Kielce")]
    [InlineData("420000000", "42", "0000000", "Łódź")]
    [InlineData("429999999", "42", "9999999", "Łódź")]
    [InlineData("430000000", "43", "0000000", "Sieradz")]
    [InlineData("439999999", "43", "9999999", "Sieradz")]
    [InlineData("440000000", "44", "0000000", "Piotrków Kujawski")]
    [InlineData("449999999", "44", "9999999", "Piotrków Kujawski")]
    [InlineData("460000000", "46", "0000000", "Skierniewice")]
    [InlineData("469999999", "46", "9999999", "Skierniewice")]
    [InlineData("480000000", "48", "0000000", "Radom")]
    [InlineData("489999999", "48", "9999999", "Radom")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("520000000", "52", "0000000", "Bydgoszcz")]
    [InlineData("529999999", "52", "9999999", "Bydgoszcz")]
    [InlineData("540000000", "54", "0000000", "Włocławek")]
    [InlineData("549999999", "54", "9999999", "Włocławek")]
    [InlineData("550000000", "55", "0000000", "Elbląg")]
    [InlineData("559999999", "55", "9999999", "Elbląg")]
    [InlineData("560000000", "56", "0000000", "Toruń")]
    [InlineData("569999999", "56", "9999999", "Toruń")]
    [InlineData("580000000", "58", "0000000", "Gdańsk")]
    [InlineData("589999999", "58", "9999999", "Gdańsk")]
    [InlineData("590000000", "59", "0000000", "Słupsk")]
    [InlineData("599999999", "59", "9999999", "Słupsk")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("610000000", "61", "0000000", "Poznań")]
    [InlineData("619999999", "61", "9999999", "Poznań")]
    [InlineData("620000000", "62", "0000000", "Kalisz")]
    [InlineData("629999999", "62", "9999999", "Kalisz")]
    [InlineData("630000000", "63", "0000000", "Konin")]
    [InlineData("639999999", "63", "9999999", "Konin")]
    [InlineData("650000000", "65", "0000000", "Leszno")]
    [InlineData("659999999", "65", "9999999", "Leszno")]
    [InlineData("670000000", "67", "0000000", "Piła")]
    [InlineData("679999999", "67", "9999999", "Piła")]
    [InlineData("680000000", "68", "0000000", "Zielona Góra")]
    [InlineData("689999999", "68", "9999999", "Zielona Góra")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("710000000", "71", "0000000", "Wrocław")]
    [InlineData("719999999", "71", "9999999", "Wrocław")]
    [InlineData("740000000", "74", "0000000", "Wałbrzych")]
    [InlineData("749999999", "74", "9999999", "Wałbrzych")]
    [InlineData("750000000", "75", "0000000", "Jelenia Góra")]
    [InlineData("759999999", "75", "9999999", "Jelenia Góra")]
    [InlineData("760000000", "76", "0000000", "Legnica")]
    [InlineData("769999999", "76", "9999999", "Legnica")]
    [InlineData("770000000", "77", "0000000", "Opole")]
    [InlineData("779999999", "77", "9999999", "Opole")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("810000000", "81", "0000000", "Lublin")]
    [InlineData("819999999", "81", "9999999", "Lublin")]
    [InlineData("820000000", "82", "0000000", "Chełm")]
    [InlineData("829999999", "82", "9999999", "Chełm")]
    [InlineData("830000000", "83", "0000000", "Biała Podlaska")]
    [InlineData("839999999", "83", "9999999", "Biała Podlaska")]
    [InlineData("840000000", "84", "0000000", "Zamość")]
    [InlineData("849999999", "84", "9999999", "Zamość")]
    [InlineData("850000000", "85", "0000000", "Białystok")]
    [InlineData("859999999", "85", "9999999", "Białystok")]
    [InlineData("860000000", "86", "0000000", "Łomża")]
    [InlineData("869999999", "86", "9999999", "Łomża")]
    [InlineData("870000000", "87", "0000000", "Suwałki")]
    [InlineData("879999999", "87", "9999999", "Suwałki")]
    [InlineData("890000000", "89", "0000000", "Olsztyn")]
    [InlineData("899999999", "89", "9999999", "Olsztyn")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("910000000", "91", "0000000", "Szczecin")]
    [InlineData("919999999", "91", "9999999", "Szczecin")]
    [InlineData("940000000", "94", "0000000", "Koszalin")]
    [InlineData("949999999", "94", "9999999", "Koszalin")]
    [InlineData("950000000", "95", "0000000", "Gorzów Wielkopolski")]
    [InlineData("959999999", "95", "9999999", "Gorzów Wielkopolski")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Poland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
