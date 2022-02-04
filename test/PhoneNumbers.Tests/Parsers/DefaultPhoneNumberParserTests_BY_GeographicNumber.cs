namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Belarus <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BY_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Belarus);

    [Theory]
    [InlineData("0170000000", "17", "0000000", "Minsk")]
    [InlineData("0179999999", "17", "9999999", "Minsk")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Belarus, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0152000000", "152", "000000", "Grodno")]
    [InlineData("0152999999", "152", "999999", "Grodno")]
    [InlineData("0154000000", "154", "000000", "Lida")]
    [InlineData("0154999999", "154", "999999", "Lida")]
    [InlineData("0162000000", "162", "000000", "Brest")]
    [InlineData("0162999999", "162", "999999", "Brest")]
    [InlineData("0163000000", "163", "000000", "Baranovichi")]
    [InlineData("0163999999", "163", "999999", "Baranovichi")]
    [InlineData("0165000000", "165", "000000", "Pinsk")]
    [InlineData("0165999999", "165", "999999", "Pinsk")]
    [InlineData("0174000000", "174", "000000", "Soligorsk")]
    [InlineData("0174999999", "174", "999999", "Soligorsk")]
    [InlineData("0176000000", "176", "000000", "Molodechno")]
    [InlineData("0176999999", "176", "999999", "Molodechno")]
    [InlineData("0177300000", "177", "300000", "Borisov")]
    [InlineData("0177399999", "177", "399999", "Borisov")]
    [InlineData("0177700000", "177", "700000", "Borisov")]
    [InlineData("0177999999", "177", "999999", "Borisov")]
    public void Parse_Known_GeographicPhoneNumber_1XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Belarus, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0151100000", "1511", "00000", "Berestovitsa")]
    [InlineData("0151199999", "1511", "99999", "Berestovitsa")]
    [InlineData("0151200000", "1512", "00000", "Volkovysk")]
    [InlineData("0151299999", "1512", "99999", "Volkovysk")]
    [InlineData("0151300000", "1513", "00000", "Svisloch")]
    [InlineData("0151399999", "1513", "99999", "Svisloch")]
    [InlineData("0151400000", "1514", "00000", "Shchuchin")]
    [InlineData("0151499999", "1514", "99999", "Shchuchin")]
    [InlineData("0151500000", "1515", "00000", "Mosty")]
    [InlineData("0151599999", "1515", "99999", "Mosty")]
    [InlineData("0156200000", "1562", "00000", "Slonim")]
    [InlineData("0156299999", "1562", "99999", "Slonim")]
    [InlineData("0156300000", "1563", "00000", "Dyatlovo")]
    [InlineData("0156399999", "1563", "99999", "Dyatlovo")]
    [InlineData("0156400000", "1564", "00000", "Zelva")]
    [InlineData("0156499999", "1564", "99999", "Zelva")]
    [InlineData("0159100000", "1591", "00000", "Ostrovets")]
    [InlineData("0159199999", "1591", "99999", "Ostrovets")]
    [InlineData("0159200000", "1592", "00000", "Smorgon")]
    [InlineData("0159299999", "1592", "99999", "Smorgon")]
    [InlineData("0159300000", "1593", "00000", "Oshmyany")]
    [InlineData("0159399999", "1593", "99999", "Oshmyany")]
    [InlineData("0159400000", "1594", "00000", "Voronovo")]
    [InlineData("0159499999", "1594", "99999", "Voronovo")]
    [InlineData("0159500000", "1595", "00000", "Ivye")]
    [InlineData("0159599999", "1595", "99999", "Ivye")]
    [InlineData("0159600000", "1596", "00000", "Korelichi")]
    [InlineData("0159699999", "1596", "99999", "Korelichi")]
    [InlineData("0159700000", "1597", "00000", "Novogrudok")]
    [InlineData("0159799999", "1597", "99999", "Novogrudok")]
    [InlineData("0163100000", "1631", "00000", "Kamenets")]
    [InlineData("0163199999", "1631", "99999", "Kamenets")]
    [InlineData("0163200000", "1632", "00000", "Pruzhany")]
    [InlineData("0163299999", "1632", "99999", "Pruzhany")]
    [InlineData("0163300000", "1633", "00000", "Lyakhovichi")]
    [InlineData("0163399999", "1633", "99999", "Lyakhovichi")]
    [InlineData("0164100000", "1641", "00000", "Zhabinka")]
    [InlineData("0164199999", "1641", "99999", "Zhabinka")]
    [InlineData("0164200000", "1642", "00000", "Kobrin")]
    [InlineData("0164299999", "1642", "99999", "Kobrin")]
    [InlineData("0164300000", "1643", "00000", "Bereza")]
    [InlineData("0164399999", "1643", "99999", "Bereza")]
    [InlineData("0164400000", "1644", "00000", "Drogichin")]
    [InlineData("0164499999", "1644", "99999", "Drogichin")]
    [InlineData("0164500000", "1645", "00000", "Ivatsevichi")]
    [InlineData("0164599999", "1645", "99999", "Ivatsevichi")]
    [InlineData("0164600000", "1646", "00000", "Gantsevichi")]
    [InlineData("0164699999", "1646", "99999", "Gantsevichi")]
    [InlineData("0164700000", "1647", "00000", "Lu9ts")]
    [InlineData("0164799999", "1647", "99999", "Lu9ts")]
    [InlineData("0165100000", "1651", "00000", "Malorita")]
    [InlineData("0165199999", "1651", "99999", "Malorita")]
    [InlineData("0165200000", "1652", "00000", "Ivanovo")]
    [InlineData("0165299999", "1652", "99999", "Ivanovo")]
    [InlineData("0165500000", "1655", "00000", "Stolin")]
    [InlineData("0165599999", "1655", "99999", "Stolin")]
    [InlineData("0171300000", "1713", "00000", "Maryina Gorka")]
    [InlineData("0171399999", "1713", "99999", "Maryina Gorka")]
    [InlineData("0171400000", "1714", "00000", "Cherven")]
    [InlineData("0171499999", "1714", "99999", "Cherven")]
    [InlineData("0171500000", "1715", "00000", "Berezino")]
    [InlineData("0171599999", "1715", "99999", "Berezino")]
    [InlineData("0171600000", "1716", "00000", "Dzerzhinsk")]
    [InlineData("0171699999", "1716", "99999", "Dzerzhinsk")]
    [InlineData("0171700000", "1717", "00000", "Stolbtsy")]
    [InlineData("0171799999", "1717", "99999", "Stolbtsy")]
    [InlineData("0171800000", "1718", "00000", "Uzda")]
    [InlineData("0171899999", "1718", "99999", "Uzda")]
    [InlineData("0171900000", "1719", "00000", "Kopyl")]
    [InlineData("0171999999", "1719", "99999", "Kopyl")]
    [InlineData("0177000000", "1770", "00000", "Nesvizh")]
    [InlineData("0177099999", "1770", "99999", "Nesvizh")]
    [InlineData("0177100000", "1771", "00000", "Vileyka")]
    [InlineData("0177199999", "1771", "99999", "Vileyka")]
    [InlineData("0177200000", "1772", "00000", "Volozhin")]
    [InlineData("0177299999", "1772", "99999", "Volozhin")]
    [InlineData("0177400000", "1774", "00000", "Logoysk")]
    [InlineData("0177499999", "1774", "99999", "Logoysk")]
    [InlineData("0177500000", "1775", "00000", "Zhodino")]
    [InlineData("0177599999", "1775", "99999", "Zhodino")]
    [InlineData("0177600000", "1776", "00000", "Smolevichi")]
    [InlineData("0177699999", "1776", "99999", "Smolevichi")]
    [InlineData("0179200000", "1792", "00000", "Starye Dorogi")]
    [InlineData("0179299999", "1792", "99999", "Starye Dorogi")]
    [InlineData("0179300000", "1793", "00000", "Kletsk")]
    [InlineData("0179399999", "1793", "99999", "Kletsk")]
    [InlineData("0179400000", "1794", "00000", "Lyuban")]
    [InlineData("0179499999", "1794", "99999", "Lyuban")]
    [InlineData("0179500000", "1795", "00000", "Slutsk")]
    [InlineData("0179599999", "1795", "99999", "Slutsk")]
    [InlineData("0179600000", "1796", "00000", "Krupki")]
    [InlineData("0179699999", "1796", "99999", "Krupki")]
    [InlineData("0179700000", "1797", "00000", "Myadel")]
    [InlineData("0179799999", "1797", "99999", "Myadel")]
    public void Parse_Known_GeographicPhoneNumber_1XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Belarus, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0212000000", "212", "000000", "Vitebsk")]
    [InlineData("0212999999", "212", "999999", "Vitebsk")]
    [InlineData("0214000000", "214", "000000", "Polotsk")]
    [InlineData("0214999999", "214", "999999", "Polotsk")]
    [InlineData("0222000000", "222", "000000", "Mogilev")]
    [InlineData("0222999999", "222", "999999", "Mogilev")]
    [InlineData("0225000000", "225", "000000", "Bobruysk")]
    [InlineData("0225999999", "225", "999999", "Bobruysk")]
    [InlineData("0232000000", "232", "000000", "Gomel")]
    [InlineData("0232999999", "232", "999999", "Gomel")]
    [InlineData("0236000000", "236", "000000", "Mozyr")]
    [InlineData("0236999999", "236", "999999", "Mozyr")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Belarus, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0213000000", "2130", "00000", "Shumilino")]
    [InlineData("0213099999", "2130", "99999", "Shumilino")]
    [InlineData("0213100000", "2131", "00000", "Beshenkovichi")]
    [InlineData("0213199999", "2131", "99999", "Beshenkovichi")]
    [InlineData("0213200000", "2132", "00000", "Lepel")]
    [InlineData("0213299999", "2132", "99999", "Lepel")]
    [InlineData("0213300000", "2133", "00000", "Chashniki")]
    [InlineData("0213399999", "2133", "99999", "Chashniki")]
    [InlineData("0213500000", "2135", "00000", "Senno")]
    [InlineData("0213599999", "2135", "99999", "Senno")]
    [InlineData("0213600000", "2136", "00000", "Tolochin")]
    [InlineData("0213699999", "2136", "99999", "Tolochin")]
    [InlineData("0213700000", "2137", "00000", "Dubrovno")]
    [InlineData("0213799999", "2137", "99999", "Dubrovno")]
    [InlineData("0213800000", "2138", "00000", "Liozno")]
    [InlineData("0213899999", "2138", "99999", "Liozno")]
    [InlineData("0213900000", "2139", "00000", "Gorodok")]
    [InlineData("0213999999", "2139", "99999", "Gorodok")]
    [InlineData("0215100000", "2151", "00000", "Verhnedvinsk")]
    [InlineData("0215199999", "2151", "99999", "Verhnedvinsk")]
    [InlineData("0215200000", "2152", "00000", "Miory")]
    [InlineData("0215299999", "2152", "99999", "Miory")]
    [InlineData("0215300000", "2153", "00000", "Braslav")]
    [InlineData("0215399999", "2153", "99999", "Braslav")]
    [InlineData("0215400000", "2154", "00000", "Sharkovshchina")]
    [InlineData("0215499999", "2154", "99999", "Sharkovshchina")]
    [InlineData("0215500000", "2155", "00000", "Postavy")]
    [InlineData("0215599999", "2155", "99999", "Postavy")]
    [InlineData("0215600000", "2156", "00000", "Glubokoye")]
    [InlineData("0215699999", "2156", "99999", "Glubokoye")]
    [InlineData("0215700000", "2157", "00000", "Dokshitsy")]
    [InlineData("0215799999", "2157", "99999", "Dokshitsy")]
    [InlineData("0215800000", "2158", "00000", "Ushachi")]
    [InlineData("0215899999", "2158", "99999", "Ushachi")]
    [InlineData("0215900000", "2159", "00000", "Rossony")]
    [InlineData("0215999999", "2159", "99999", "Rossony")]
    [InlineData("0223000000", "2230", "00000", "Gluzsk")]
    [InlineData("0223099999", "2230", "99999", "Gluzsk")]
    [InlineData("0223100000", "2231", "00000", "Byhov")]
    [InlineData("0223199999", "2231", "99999", "Byhov")]
    [InlineData("0223200000", "2232", "00000", "Belynichi")]
    [InlineData("0223299999", "2232", "99999", "Belynichi")]
    [InlineData("0223300000", "2233", "00000", "Gorki")]
    [InlineData("0223399999", "2233", "99999", "Gorki")]
    [InlineData("0223400000", "2234", "00000", "Krugloye")]
    [InlineData("0223499999", "2234", "99999", "Krugloye")]
    [InlineData("0223500000", "2235", "00000", "Osipovichi")]
    [InlineData("0223599999", "2235", "99999", "Osipovichi")]
    [InlineData("0223600000", "2236", "00000", "Klichev")]
    [InlineData("0223699999", "2236", "99999", "Klichev")]
    [InlineData("0223700000", "2237", "00000", "Kirovsk")]
    [InlineData("0223799999", "2237", "99999", "Kirovsk")]
    [InlineData("0223800000", "2238", "00000", "Krasnopolye")]
    [InlineData("0223899999", "2238", "99999", "Krasnopolye")]
    [InlineData("0223900000", "2239", "00000", "Shklov")]
    [InlineData("0223999999", "2239", "99999", "Shklov")]
    [InlineData("0224000000", "2240", "00000", "Mstislavl")]
    [InlineData("0224099999", "2240", "99999", "Mstislavl")]
    [InlineData("0224100000", "2241", "00000", "Krichev")]
    [InlineData("0224199999", "2241", "99999", "Krichev")]
    [InlineData("0224200000", "2242", "00000", "Chausy")]
    [InlineData("0224299999", "2242", "99999", "Chausy")]
    [InlineData("0224300000", "2243", "00000", "Cherikov")]
    [InlineData("0224399999", "2243", "99999", "Cherikov")]
    [InlineData("0224400000", "2244", "00000", "Klimovichi")]
    [InlineData("0224499999", "2244", "99999", "Klimovichi")]
    [InlineData("0224500000", "2245", "00000", "Kostyukovichi")]
    [InlineData("0224599999", "2245", "99999", "Kostyukovichi")]
    [InlineData("0224600000", "2246", "00000", "Slavgorod")]
    [InlineData("0224699999", "2246", "99999", "Slavgorod")]
    [InlineData("0224700000", "2247", "00000", "Khotimsk")]
    [InlineData("0224799999", "2247", "99999", "Khotimsk")]
    [InlineData("0224800000", "2248", "00000", "Dribin")]
    [InlineData("0224899999", "2248", "99999", "Dribin")]
    [InlineData("0233000000", "2330", "00000", "Vetka")]
    [InlineData("0233099999", "2330", "99999", "Vetka")]
    [InlineData("0233200000", "2332", "00000", "Chechersk")]
    [InlineData("0233299999", "2332", "99999", "Chechersk")]
    [InlineData("0233300000", "2333", "00000", "Dobrush")]
    [InlineData("0233399999", "2333", "99999", "Dobrush")]
    [InlineData("0233400000", "2334", "00000", "Zhlobin")]
    [InlineData("0233499999", "2334", "99999", "Zhlobin")]
    [InlineData("0233600000", "2336", "00000", "Budo-Koshelevo")]
    [InlineData("0233699999", "2336", "99999", "Budo-Koshelevo")]
    [InlineData("0233700000", "2337", "00000", "Korma")]
    [InlineData("0233799999", "2337", "99999", "Korma")]
    [InlineData("0233900000", "2339", "00000", "Rogachev")]
    [InlineData("0233999999", "2339", "99999", "Rogachev")]
    [InlineData("0234000000", "2340", "00000", "Rechitsa")]
    [InlineData("0234099999", "2340", "99999", "Rechitsa")]
    [InlineData("0234200000", "2342", "00000", "Svetlogorsk")]
    [InlineData("0234299999", "2342", "99999", "Svetlogorsk")]
    [InlineData("0234400000", "2344", "00000", "Bragin")]
    [InlineData("0234499999", "2344", "99999", "Bragin")]
    [InlineData("0234500000", "2345", "00000", "Kalinkovichi")]
    [InlineData("0234599999", "2345", "99999", "Kalinkovichi")]
    [InlineData("0234600000", "2346", "00000", "Khoyniki")]
    [InlineData("0234699999", "2346", "99999", "Khoyniki")]
    [InlineData("0234700000", "2347", "00000", "Loyev")]
    [InlineData("0234799999", "2347", "99999", "Loyev")]
    [InlineData("0235000000", "2350", "00000", "Petrikov")]
    [InlineData("0235099999", "2350", "99999", "Petrikov")]
    [InlineData("0235300000", "2353", "00000", "Zhitkovichi")]
    [InlineData("0235399999", "2353", "99999", "Zhitkovichi")]
    [InlineData("0235400000", "2354", "00000", "Yelsk")]
    [InlineData("0235499999", "2354", "99999", "Yelsk")]
    [InlineData("0235500000", "2355", "00000", "Narovlya")]
    [InlineData("0235599999", "2355", "99999", "Narovlya")]
    [InlineData("0235600000", "2356", "00000", "Lelchitsy")]
    [InlineData("0235699999", "2356", "99999", "Lelchitsy")]
    [InlineData("0235700000", "2357", "00000", "Oktyabrskiy")]
    [InlineData("0235799999", "2357", "99999", "Oktyabrskiy")]
    public void Parse_Known_GeographicPhoneNumber_2XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Belarus, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
