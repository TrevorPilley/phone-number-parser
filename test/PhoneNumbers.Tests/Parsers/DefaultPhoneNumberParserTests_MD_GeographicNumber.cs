namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Moldova <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MD_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Moldova);

    [Theory]
    [InlineData("022000000", "22", "000000", "Chișinău")]
    [InlineData("022999999", "22", "999999", "Chișinău")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Moldova, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("021000000", "210", "00000", "Grigoriopol")]
    [InlineData("021099999", "210", "99999", "Grigoriopol")]
    [InlineData("021500000", "215", "00000", "Dubăsari")]
    [InlineData("021599999", "215", "99999", "Dubăsari")]
    [InlineData("021600000", "216", "00000", "Camenca")]
    [InlineData("021699999", "216", "99999", "Camenca")]
    [InlineData("021900000", "219", "00000", "Dnestrovsk")]
    [InlineData("021999999", "219", "99999", "Dnestrovsk")]
    [InlineData("023000000", "230", "00000", "Soroca")]
    [InlineData("023099999", "230", "99999", "Soroca")]
    [InlineData("023100000", "231", "00000", "Balţi")]
    [InlineData("023199999", "231", "99999", "Balţi")]
    [InlineData("023500000", "235", "00000", "Orhei")]
    [InlineData("023599999", "235", "99999", "Orhei")]
    [InlineData("023600000", "236", "00000", "Ungheni")]
    [InlineData("023699999", "236", "99999", "Ungheni")]
    [InlineData("023700000", "237", "00000", "Strășeni")]
    [InlineData("023799999", "237", "99999", "Strășeni")]
    [InlineData("024100000", "241", "00000", "Cimișlia")]
    [InlineData("024199999", "241", "99999", "Cimișlia")]
    [InlineData("024200000", "242", "00000", "Stefan Voda")]
    [InlineData("024299999", "242", "99999", "Stefan Voda")]
    [InlineData("024300000", "243", "00000", "Causeni")]
    [InlineData("024399999", "243", "99999", "Causeni")]
    [InlineData("024400000", "244", "00000", "Calarasi")]
    [InlineData("024499999", "244", "99999", "Calarasi")]
    [InlineData("024600000", "246", "00000", "Edineț")]
    [InlineData("024699999", "246", "99999", "Edineț")]
    [InlineData("024700000", "247", "00000", "Briceni")]
    [InlineData("024799999", "247", "99999", "Briceni")]
    [InlineData("024800000", "248", "00000", "Criuleni")]
    [InlineData("024899999", "248", "99999", "Criuleni")]
    [InlineData("024900000", "249", "00000", "Glodeni")]
    [InlineData("024999999", "249", "99999", "Glodeni")]
    [InlineData("025000000", "250", "00000", "Floresti")]
    [InlineData("025099999", "250", "99999", "Floresti")]
    [InlineData("025100000", "251", "00000", "Donduseni")]
    [InlineData("025199999", "251", "99999", "Donduseni")]
    [InlineData("025200000", "252", "00000", "Drochia")]
    [InlineData("025299999", "252", "99999", "Drochia")]
    [InlineData("025400000", "254", "00000", "Rezina")]
    [InlineData("025499999", "254", "99999", "Rezina")]
    [InlineData("025600000", "256", "00000", "Rîșcani")]
    [InlineData("025699999", "256", "99999", "Rîșcani")]
    [InlineData("025800000", "258", "00000", "Telenești")]
    [InlineData("025899999", "258", "99999", "Telenești")]
    [InlineData("025900000", "259", "00000", "Fălești")]
    [InlineData("025999999", "259", "99999", "Fălești")]
    [InlineData("026200000", "262", "00000", "Sîngerei")]
    [InlineData("026299999", "262", "99999", "Sîngerei")]
    [InlineData("026300000", "263", "00000", "Leova")]
    [InlineData("026399999", "263", "99999", "Leova")]
    [InlineData("026400000", "264", "00000", "Nisporeni")]
    [InlineData("026499999", "264", "99999", "Nisporeni")]
    [InlineData("026500000", "265", "00000", "Anenii Noi")]
    [InlineData("026599999", "265", "99999", "Anenii Noi")]
    [InlineData("026800000", "268", "00000", "Ialoveni")]
    [InlineData("026899999", "268", "99999", "Ialoveni")]
    [InlineData("026900000", "269", "00000", "Hîncești")]
    [InlineData("026999999", "269", "99999", "Hîncești")]
    [InlineData("027100000", "271", "00000", "Ocniţa")]
    [InlineData("027199999", "271", "99999", "Ocniţa")]
    [InlineData("027200000", "272", "00000", "Șoldănești")]
    [InlineData("027299999", "272", "99999", "Șoldănești")]
    [InlineData("027300000", "273", "00000", "Cantemir")]
    [InlineData("027399999", "273", "99999", "Cantemir")]
    [InlineData("029100000", "291", "00000", "Ceadir Lunga")]
    [InlineData("029199999", "291", "99999", "Ceadir Lunga")]
    [InlineData("029300000", "293", "00000", "Vulcanesti")]
    [InlineData("029399999", "293", "99999", "Vulcanesti")]
    [InlineData("029400000", "294", "00000", "Taraclia")]
    [InlineData("029499999", "294", "99999", "Taraclia")]
    [InlineData("029700000", "297", "00000", "Basarabeasca")]
    [InlineData("029799999", "297", "99999", "Basarabeasca")]
    [InlineData("029800000", "298", "00000", "Comrat")]
    [InlineData("029899999", "298", "99999", "Comrat")]
    [InlineData("029900000", "299", "00000", "Cahul")]
    [InlineData("029999999", "299", "99999", "Cahul")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Moldova, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("032000000", "32", "000000", "Chișinău")]
    [InlineData("032999999", "32", "999999", "Chișinău")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Moldova, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("033000000", "330", "00000", "Soroca")]
    [InlineData("033099999", "330", "99999", "Soroca")]
    [InlineData("033100000", "331", "00000", "Bălți")]
    [InlineData("033199999", "331", "99999", "Bălți")]
    [InlineData("033500000", "335", "00000", "Orhei")]
    [InlineData("033599999", "335", "99999", "Orhei")]
    [InlineData("033600000", "336", "00000", "Ungheni")]
    [InlineData("033699999", "336", "99999", "Ungheni")]
    [InlineData("033700000", "337", "00000", "Strășeni")]
    [InlineData("033799999", "337", "99999", "Strășeni")]
    [InlineData("034100000", "341", "00000", "Cimișlia")]
    [InlineData("034199999", "341", "99999", "Cimișlia")]
    [InlineData("034200000", "342", "00000", "Ștefan Vodă")]
    [InlineData("034299999", "342", "99999", "Ștefan Vodă")]
    [InlineData("034300000", "343", "00000", "Causeni")]
    [InlineData("034399999", "343", "99999", "Causeni")]
    [InlineData("034400000", "344", "00000", "Calarasi")]
    [InlineData("034499999", "344", "99999", "Calarasi")]
    [InlineData("034600000", "346", "00000", "Edineț")]
    [InlineData("034699999", "346", "99999", "Edineț")]
    [InlineData("034700000", "347", "00000", "Briceni")]
    [InlineData("034799999", "347", "99999", "Briceni")]
    [InlineData("034800000", "348", "00000", "Criuleni")]
    [InlineData("034899999", "348", "99999", "Criuleni")]
    [InlineData("034900000", "349", "00000", "Glodeni")]
    [InlineData("034999999", "349", "99999", "Glodeni")]
    [InlineData("035000000", "350", "00000", "Floresti")]
    [InlineData("035099999", "350", "99999", "Floresti")]
    [InlineData("035100000", "351", "00000", "Donduseni")]
    [InlineData("035199999", "351", "99999", "Donduseni")]
    [InlineData("035200000", "352", "00000", "Drochia")]
    [InlineData("035299999", "352", "99999", "Drochia")]
    [InlineData("035600000", "356", "00000", "Rîșcani")]
    [InlineData("035699999", "356", "99999", "Rîșcani")]
    [InlineData("035800000", "358", "00000", "Telenești")]
    [InlineData("035899999", "358", "99999", "Telenești")]
    [InlineData("035900000", "359", "00000", "Fălești")]
    [InlineData("035999999", "359", "99999", "Fălești")]
    [InlineData("036200000", "362", "00000", "Sîngerei")]
    [InlineData("036299999", "362", "99999", "Sîngerei")]
    [InlineData("036300000", "363", "00000", "Leova")]
    [InlineData("036399999", "363", "99999", "Leova")]
    [InlineData("036400000", "364", "00000", "Nisporeni")]
    [InlineData("036499999", "364", "99999", "Nisporeni")]
    [InlineData("036500000", "365", "00000", "Anenii Noi")]
    [InlineData("036599999", "365", "99999", "Anenii Noi")]
    [InlineData("036800000", "368", "00000", "Ialoveni")]
    [InlineData("036899999", "368", "99999", "Ialoveni")]
    [InlineData("036900000", "369", "00000", "Hîncești")]
    [InlineData("036999999", "369", "99999", "Hîncești")]
    [InlineData("037100000", "371", "00000", "Ocnița")]
    [InlineData("037199999", "371", "99999", "Ocnița")]
    [InlineData("037200000", "372", "00000", "Șoldănești")]
    [InlineData("037299999", "372", "99999", "Șoldănești")]
    [InlineData("037300000", "373", "00000", "Cantemir")]
    [InlineData("037399999", "373", "99999", "Cantemir")]
    [InlineData("039100000", "391", "00000", "Ceadir-Lunga")]
    [InlineData("039199999", "391", "99999", "Ceadir-Lunga")]
    [InlineData("039300000", "393", "00000", "Vulcănești")]
    [InlineData("039399999", "393", "99999", "Vulcănești")]
    [InlineData("039400000", "394", "00000", "Taraclia")]
    [InlineData("039499999", "394", "99999", "Taraclia")]
    [InlineData("039700000", "397", "00000", "Basarabeasca")]
    [InlineData("039799999", "397", "99999", "Basarabeasca")]
    [InlineData("039800000", "398", "00000", "Comrat")]
    [InlineData("039899999", "398", "99999", "Comrat")]
    [InlineData("039900000", "399", "00000", "Cahul")]
    [InlineData("039999999", "399", "99999", "Cahul")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Moldova, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("053300000", "533", "00000", "Tiraspol")]
    [InlineData("053399999", "533", "99999", "Tiraspol")]
    [InlineData("055200000", "552", "00000", "Bender")]
    [InlineData("055299999", "552", "99999", "Bender")]
    [InlineData("055500000", "555", "00000", "Rîbnița")]
    [InlineData("055599999", "555", "99999", "Rîbnița")]
    [InlineData("055700000", "557", "00000", "Slobozia")]
    [InlineData("055799999", "557", "99999", "Slobozia")]
    public void Parse_Known_GeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Moldova, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
