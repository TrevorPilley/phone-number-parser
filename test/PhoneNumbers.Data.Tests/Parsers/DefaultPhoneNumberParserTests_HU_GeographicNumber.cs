namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Hungary <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_HU_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Hungary);

    [Theory]
    [InlineData("0610000000", "1", "0000000", "Budapest")]
    [InlineData("0619999999", "1", "9999999", "Budapest")]
    public void Parse_Known_GeographicPhoneNumber_1_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0622000000", "22", "000000", "Székesfehérvár")]
    [InlineData("0622999999", "22", "999999", "Székesfehérvár")]
    [InlineData("0623000000", "23", "000000", "Biatorbágy")]
    [InlineData("0623999999", "23", "999999", "Biatorbágy")]
    [InlineData("0624000000", "24", "000000", "Szigetszentmiklós")]
    [InlineData("0624999999", "24", "999999", "Szigetszentmiklós")]
    [InlineData("0625000000", "25", "000000", "Dunaújváros")]
    [InlineData("0625999999", "25", "999999", "Dunaújváros")]
    [InlineData("0626000000", "26", "000000", "Szentendre")]
    [InlineData("0626999999", "26", "999999", "Szentendre")]
    [InlineData("0627000000", "27", "000000", "Vác")]
    [InlineData("0627999999", "27", "999999", "Vác")]
    [InlineData("0629000000", "29", "000000", "Monor")]
    [InlineData("0629999999", "29", "999999", "Monor")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0632000000", "32", "000000", "Salgótarján")]
    [InlineData("0632999999", "32", "999999", "Salgótarján")]
    [InlineData("0633000000", "33", "000000", "Esztergom")]
    [InlineData("0633999999", "33", "999999", "Esztergom")]
    [InlineData("0634000000", "34", "000000", "Tatabánya")]
    [InlineData("0634999999", "34", "999999", "Tatabánya")]
    [InlineData("0635000000", "35", "000000", "Balassagyarmat")]
    [InlineData("0635999999", "35", "999999", "Balassagyarmat")]
    [InlineData("0636000000", "36", "000000", "Eger")]
    [InlineData("0636999999", "36", "999999", "Eger")]
    [InlineData("0637000000", "37", "000000", "Gyöngyös")]
    [InlineData("0637999999", "37", "999999", "Gyöngyös")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0642000000", "42", "000000", "Nyíregyháza")]
    [InlineData("0642999999", "42", "999999", "Nyíregyháza")]
    [InlineData("0644000000", "44", "000000", "Mátészalka")]
    [InlineData("0644999999", "44", "999999", "Mátészalka")]
    [InlineData("0645000000", "45", "000000", "Kisvárda")]
    [InlineData("0645999999", "45", "999999", "Kisvárda")]
    [InlineData("0646000000", "46", "000000", "Miskolc")]
    [InlineData("0646999999", "46", "999999", "Miskolc")]
    [InlineData("0647000000", "47", "000000", "Szerencs")]
    [InlineData("0647999999", "47", "999999", "Szerencs")]
    [InlineData("0648000000", "48", "000000", "Ózd")]
    [InlineData("0648999999", "48", "999999", "Ózd")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0652000000", "52", "000000", "Debrecen")]
    [InlineData("0652999999", "52", "999999", "Debrecen")]
    [InlineData("0653000000", "53", "000000", "Cegléd")]
    [InlineData("0653999999", "53", "999999", "Cegléd")]
    [InlineData("0654000000", "54", "000000", "Berettyóújfalu")]
    [InlineData("0654999999", "54", "999999", "Berettyóújfalu")]
    [InlineData("0656000000", "56", "000000", "Szolnok")]
    [InlineData("0656999999", "56", "999999", "Szolnok")]
    [InlineData("0657000000", "57", "000000", "Jászberény")]
    [InlineData("0657999999", "57", "999999", "Jászberény")]
    [InlineData("0659000000", "59", "000000", "Karcag")]
    [InlineData("0659999999", "59", "999999", "Karcag")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0662000000", "62", "000000", "Szeged")]
    [InlineData("0662999999", "62", "999999", "Szeged")]
    [InlineData("0663000000", "63", "000000", "Szentes")]
    [InlineData("0663999999", "63", "999999", "Szentes")]
    [InlineData("0666000000", "66", "000000", "Békéscsaba")]
    [InlineData("0666999999", "66", "999999", "Békéscsaba")]
    [InlineData("0668000000", "68", "000000", "Orosháza")]
    [InlineData("0668999999", "68", "999999", "Orosháza")]
    [InlineData("0669000000", "69", "000000", "Mohács")]
    [InlineData("0669999999", "69", "999999", "Mohács")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0672000000", "72", "000000", "Pécs")]
    [InlineData("0672999999", "72", "999999", "Pécs")]
    [InlineData("0673000000", "73", "000000", "Szigetvár")]
    [InlineData("0673999999", "73", "999999", "Szigetvár")]
    [InlineData("0674000000", "74", "000000", "Szekszárd")]
    [InlineData("0674999999", "74", "999999", "Szekszárd")]
    [InlineData("0675000000", "75", "000000", "Paks")]
    [InlineData("0675999999", "75", "999999", "Paks")]
    [InlineData("0676000000", "76", "000000", "Kecskemét")]
    [InlineData("0676999999", "76", "999999", "Kecskemét")]
    [InlineData("0677000000", "77", "000000", "Kiskunhalas")]
    [InlineData("0677999999", "77", "999999", "Kiskunhalas")]
    [InlineData("0679000000", "79", "000000", "Baja")]
    [InlineData("0679999999", "79", "999999", "Baja")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0682000000", "82", "000000", "Kaposvár")]
    [InlineData("0682999999", "82", "999999", "Kaposvár")]
    [InlineData("0683000000", "83", "000000", "Keszthely")]
    [InlineData("0683999999", "83", "999999", "Keszthely")]
    [InlineData("0684000000", "84", "000000", "Siófok")]
    [InlineData("0684999999", "84", "999999", "Siófok")]
    [InlineData("0685000000", "85", "000000", "Marcali")]
    [InlineData("0685999999", "85", "999999", "Marcali")]
    [InlineData("0687000000", "87", "000000", "Tapolca")]
    [InlineData("0687999999", "87", "999999", "Tapolca")]
    [InlineData("0688000000", "88", "000000", "Veszprém")]
    [InlineData("0688999999", "88", "999999", "Veszprém")]
    [InlineData("0689000000", "89", "000000", "Pápa")]
    [InlineData("0689999999", "89", "999999", "Pápa")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0692000000", "92", "000000", "Zalaegerszeg")]
    [InlineData("0692999999", "92", "999999", "Zalaegerszeg")]
    [InlineData("0693000000", "93", "000000", "Nagykanizsa")]
    [InlineData("0693999999", "93", "999999", "Nagykanizsa")]
    [InlineData("0694000000", "94", "000000", "Szombathely")]
    [InlineData("0694999999", "94", "999999", "Szombathely")]
    [InlineData("0695000000", "95", "000000", "Sárvár")]
    [InlineData("0695999999", "95", "999999", "Sárvár")]
    [InlineData("0699000000", "99", "000000", "Sopron")]
    [InlineData("0699999999", "99", "999999", "Sopron")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Hungary, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
