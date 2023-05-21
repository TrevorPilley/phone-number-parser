namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Lithuania <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LT_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Lithuania);

    [Theory]
    [InlineData("837200000", "37", "200000", "Kaunas city and district")]
    [InlineData("837999999", "37", "999999", "Kaunas city and district")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Lithuania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("831020000", "310", "20000", "Varėna district")]
    [InlineData("831099999", "310", "99999", "Varėna district")]
    [InlineData("831320000", "313", "20000", "Druskininkai town")]
    [InlineData("831399999", "313", "99999", "Druskininkai town")]
    [InlineData("831520000", "315", "20000", "Alytus town and district")]
    [InlineData("831599999", "315", "99999", "Alytus town and district")]
    [InlineData("831820000", "318", "20000", "Lazdijai district")]
    [InlineData("831899999", "318", "99999", "Lazdijai district")]
    [InlineData("831920000", "319", "20000", "Prienai district and Birštonas town")]
    [InlineData("831999999", "319", "99999", "Prienai district and Birštonas town")]
    [InlineData("834020000", "340", "20000", "Ukmergė district")]
    [InlineData("834099999", "340", "99999", "Ukmergė district")]
    [InlineData("834220000", "342", "20000", "Vilkaviškis district")]
    [InlineData("834299999", "342", "99999", "Vilkaviškis district")]
    [InlineData("834320000", "343", "20000", "Marijampolė district")]
    [InlineData("834399999", "343", "99999", "Marijampolė district")]
    [InlineData("834520000", "345", "20000", "Šakiai district")]
    [InlineData("834599999", "345", "99999", "Šakiai district")]
    [InlineData("834620000", "346", "20000", "Kaišiadorys district")]
    [InlineData("834699999", "346", "99999", "Kaišiadorys district")]
    [InlineData("834720000", "347", "20000", "Kėdainiai district")]
    [InlineData("834799999", "347", "99999", "Kėdainiai district")]
    [InlineData("834920000", "349", "20000", "Jonava district")]
    [InlineData("834999999", "349", "99999", "Jonava district")]
    [InlineData("838020000", "380", "20000", "Šalčininkai district")]
    [InlineData("838099999", "380", "99999", "Šalčininkai district")]
    [InlineData("838120000", "381", "20000", "Anykščiai district")]
    [InlineData("838199999", "381", "99999", "Anykščiai district")]
    [InlineData("838220000", "382", "20000", "Širvintos district")]
    [InlineData("838299999", "382", "99999", "Širvintos district")]
    [InlineData("838320000", "383", "20000", "Molėtai district")]
    [InlineData("838399999", "383", "99999", "Molėtai district")]
    [InlineData("838520000", "385", "20000", "Zarasai district")]
    [InlineData("838599999", "385", "99999", "Zarasai district")]
    [InlineData("838620000", "386", "20000", "Ignalina district and Visaginas town")]
    [InlineData("838699999", "386", "99999", "Ignalina district and Visaginas town")]
    [InlineData("838720000", "387", "20000", "Švenčionys district")]
    [InlineData("838799999", "387", "99999", "Švenčionys district")]
    [InlineData("838920000", "389", "20000", "Utena district")]
    [InlineData("838999999", "389", "99999", "Utena district")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Lithuania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("841200000", "41", "200000", "Šiauliai city and district")]
    [InlineData("841999999", "41", "999999", "Šiauliai city and district")]
    [InlineData("845400000", "45", "400000", "Panevėžys city and district")]
    [InlineData("845599999", "45", "599999", "Panevėžys city and district")]
    [InlineData("846200000", "46", "200000", "Klaipėda city and district")]
    [InlineData("846499999", "46", "499999", "Klaipėda city and district")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Lithuania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("842120000", "421", "20000", "Pakruojis district")]
    [InlineData("842199999", "421", "99999", "Pakruojis district")]
    [InlineData("842220000", "422", "20000", "Radviliškis district")]
    [InlineData("842299999", "422", "99999", "Radviliškis district")]
    [InlineData("842520000", "425", "20000", "Akmenė district")]
    [InlineData("842599999", "425", "99999", "Akmenė district")]
    [InlineData("842620000", "426", "20000", "Joniškis district")]
    [InlineData("842699999", "426", "99999", "Joniškis district")]
    [InlineData("842720000", "427", "20000", "Kelmė district")]
    [InlineData("842799999", "427", "99999", "Kelmė district")]
    [InlineData("842820000", "428", "20000", "Raseiniai district")]
    [InlineData("842899999", "428", "99999", "Raseiniai district")]
    [InlineData("844020000", "440", "20000", "Skuodas district")]
    [InlineData("844099999", "440", "99999", "Skuodas district")]
    [InlineData("844120000", "441", "20000", "Šilutė district")]
    [InlineData("844199999", "441", "99999", "Šilutė district")]
    [InlineData("844320000", "443", "20000", "Mažeikiai district")]
    [InlineData("844399999", "443", "99999", "Mažeikiai district")]
    [InlineData("844420000", "444", "20000", "Telšiai district")]
    [InlineData("844499999", "444", "99999", "Telšiai district")]
    [InlineData("844520000", "445", "20000", "Kretinga district")]
    [InlineData("844599999", "445", "99999", "Kretinga district")]
    [InlineData("844620000", "446", "20000", "Tauragė district")]
    [InlineData("844699999", "446", "99999", "Tauragė district")]
    [InlineData("844720000", "447", "20000", "Jurbarkas district")]
    [InlineData("844799999", "447", "99999", "Jurbarkas district")]
    [InlineData("844820000", "448", "20000", "Plungė district")]
    [InlineData("844899999", "448", "99999", "Plungė district")]
    [InlineData("844920000", "449", "20000", "Šilalė district")]
    [InlineData("844999999", "449", "99999", "Šilalė district")]
    [InlineData("845020000", "450", "20000", "Biržai district")]
    [InlineData("845099999", "450", "99999", "Biržai district")]
    [InlineData("845120000", "451", "20000", "Pasvalys district")]
    [InlineData("845199999", "451", "99999", "Pasvalys district")]
    [InlineData("845820000", "458", "20000", "Rokiškis district")]
    [InlineData("845899999", "458", "99999", "Rokiškis district")]
    [InlineData("845920000", "459", "20000", "Kupiškis district")]
    [InlineData("845999999", "459", "99999", "Kupiškis district")]
    [InlineData("846020000", "460", "20000", "Palanga town")]
    [InlineData("846099999", "460", "99999", "Palanga town")]
    [InlineData("846920000", "469", "20000", "Neringa town")]
    [InlineData("846999999", "469", "99999", "Neringa town")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Lithuania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("852000000", "5", "2000000", "Vilnius city and district")]
    [InlineData("852799999", "5", "2799999", "Vilnius city and district")]
    public void Parse_Known_GeographicPhoneNumber_5_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Lithuania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("852820000", "528", "20000", "Trakai district")]
    [InlineData("852899999", "528", "99999", "Trakai district")]
    public void Parse_Known_GeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Lithuania, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
