namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Sweden <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SE_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Sweden);

    [Theory]
    [InlineData("01100000", "11", "00000", "Norrköping")]
    [InlineData("0119999999", "11", "9999999", "Norrköping")]
    [InlineData("01300000", "13", "00000", "Linköping")]
    [InlineData("0139999999", "13", "9999999", "Linköping")]
    [InlineData("01600000", "16", "00000", "Eskilstuna-Torshälla")]
    [InlineData("0169999999", "16", "9999999", "Eskilstuna-Torshälla")]
    [InlineData("018000000", "18", "000000", "Uppsala")]
    [InlineData("0189999999", "18", "9999999", "Uppsala")]
    [InlineData("019000000", "19", "000000", "Örebro-Kumla")]
    [InlineData("0199999999", "19", "9999999", "Örebro-Kumla")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("012000000", "120", "00000", "Åtvidaberg")]
    [InlineData("0120999999", "120", "999999", "Åtvidaberg")]
    [InlineData("012100000", "121", "00000", "Söderköping")]
    [InlineData("0121999999", "121", "999999", "Söderköping")]
    [InlineData("012200000", "122", "00000", "Finspång")]
    [InlineData("0122999999", "122", "999999", "Finspång")]
    [InlineData("012300000", "123", "00000", "Valdemarsvik")]
    [InlineData("0123999999", "123", "999999", "Valdemarsvik")]
    [InlineData("012500000", "125", "00000", "Vikbolandet")]
    [InlineData("0125999999", "125", "999999", "Vikbolandet")]
    [InlineData("014000000", "140", "00000", "Tranås")]
    [InlineData("0140999999", "140", "999999", "Tranås")]
    [InlineData("014100000", "141", "00000", "Motala")]
    [InlineData("0141999999", "141", "999999", "Motala")]
    [InlineData("014200000", "142", "00000", "Mjölby-Skänninge-Boxholm")]
    [InlineData("0142999999", "142", "999999", "Mjölby-Skänninge-Boxholm")]
    [InlineData("014300000", "143", "00000", "Vadstena")]
    [InlineData("0143999999", "143", "999999", "Vadstena")]
    [InlineData("014400000", "144", "00000", "Ödeshög")]
    [InlineData("0144999999", "144", "999999", "Ödeshög")]
    [InlineData("015000000", "150", "00000", "Katrineholm")]
    [InlineData("0150999999", "150", "999999", "Katrineholm")]
    [InlineData("015100000", "151", "00000", "Vingåker")]
    [InlineData("0151999999", "151", "999999", "Vingåker")]
    [InlineData("015200000", "152", "00000", "Strängnäs")]
    [InlineData("0152999999", "152", "999999", "Strängnäs")]
    [InlineData("015500000", "155", "00000", "Nyköping-Oxelösund")]
    [InlineData("0155999999", "155", "999999", "Nyköping-Oxelösund")]
    [InlineData("015600000", "156", "00000", "Trosa-Vagnhärad")]
    [InlineData("0156999999", "156", "999999", "Trosa-Vagnhärad")]
    [InlineData("015700000", "157", "00000", "Flen-Malmköping")]
    [InlineData("0157999999", "157", "999999", "Flen-Malmköping")]
    [InlineData("015800000", "158", "00000", "Gnesta")]
    [InlineData("0158999999", "158", "999999", "Gnesta")]
    [InlineData("015900000", "159", "00000", "Mariefred")]
    [InlineData("0159999999", "159", "999999", "Mariefred")]
    [InlineData("017100000", "171", "00000", "Enköping")]
    [InlineData("0171999999", "171", "999999", "Enköping")]
    [InlineData("017300000", "173", "00000", "Öregrund-Östhammar")]
    [InlineData("0173999999", "173", "999999", "Öregrund-Östhammar")]
    [InlineData("017400000", "174", "00000", "Alunda")]
    [InlineData("0174999999", "174", "999999", "Alunda")]
    [InlineData("017500000", "175", "00000", "Hallstavik-Rimbo")]
    [InlineData("0175999999", "175", "999999", "Hallstavik-Rimbo")]
    [InlineData("017600000", "176", "00000", "Norrtälje")]
    [InlineData("0176999999", "176", "999999", "Norrtälje")]
    public void Parse_Known_GeographicPhoneNumber_1XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("02100000", "21", "00000", "Västerås")]
    [InlineData("0219999999", "21", "9999999", "Västerås")]
    [InlineData("02300000", "23", "00000", "Falun")]
    [InlineData("0239999999", "23", "9999999", "Falun")]
    [InlineData("02600000", "26", "00000", "Gävle-Sandviken")]
    [InlineData("0269999999", "26", "9999999", "Gävle-Sandviken")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("022000000", "220", "00000", "Hallstahammar-Surahammar")]
    [InlineData("0220999999", "220", "999999", "Hallstahammar-Surahammar")]
    [InlineData("022100000", "221", "00000", "Köping")]
    [InlineData("0221999999", "221", "999999", "Köping")]
    [InlineData("022200000", "222", "00000", "Skinnskatteberg")]
    [InlineData("0222999999", "222", "999999", "Skinnskatteberg")]
    [InlineData("022300000", "223", "00000", "Fagersta-Norberg")]
    [InlineData("0223999999", "223", "999999", "Fagersta-Norberg")]
    [InlineData("022400000", "224", "00000", "Sala-Heby")]
    [InlineData("0224999999", "224", "999999", "Sala-Heby")]
    [InlineData("022500000", "225", "00000", "Hedemora-Säter")]
    [InlineData("0225999999", "225", "999999", "Hedemora-Säter")]
    [InlineData("022600000", "226", "00000", "Avesta-Krylbo")]
    [InlineData("0226999999", "226", "999999", "Avesta-Krylbo")]
    [InlineData("022700000", "227", "00000", "Kungsör")]
    [InlineData("0227999999", "227", "999999", "Kungsör")]
    [InlineData("024000000", "240", "00000", "Ludvika-Smedjebacken")]
    [InlineData("0240999999", "240", "999999", "Ludvika-Smedjebacken")]
    [InlineData("024100000", "241", "00000", "Gagnef-Floda")]
    [InlineData("0241999999", "241", "999999", "Gagnef-Floda")]
    [InlineData("024300000", "243", "00000", "Borlänge")]
    [InlineData("0243999999", "243", "999999", "Borlänge")]
    [InlineData("024600000", "246", "00000", "Svärdsjö-Enviken")]
    [InlineData("0246999999", "246", "999999", "Svärdsjö-Enviken")]
    [InlineData("024700000", "247", "00000", "Leksand-Insjön")]
    [InlineData("0247999999", "247", "999999", "Leksand-Insjön")]
    [InlineData("024800000", "248", "00000", "Rättvik")]
    [InlineData("0248999999", "248", "999999", "Rättvik")]
    [InlineData("025000000", "250", "00000", "Mora-Orsa")]
    [InlineData("0250999999", "250", "999999", "Mora-Orsa")]
    [InlineData("025100000", "251", "00000", "Älvdalen")]
    [InlineData("0251999999", "251", "999999", "Älvdalen")]
    [InlineData("025300000", "253", "00000", "Idre-Särna")]
    [InlineData("0253999999", "253", "999999", "Idre-Särna")]
    [InlineData("025800000", "258", "00000", "Furudal")]
    [InlineData("0258999999", "258", "999999", "Furudal")]
    [InlineData("027000000", "270", "00000", "Söderhamn")]
    [InlineData("0270999999", "270", "999999", "Söderhamn")]
    [InlineData("027100000", "271", "00000", "Alfta-Edsbyn")]
    [InlineData("0271999999", "271", "999999", "Alfta-Edsbyn")]
    [InlineData("027800000", "278", "00000", "Bollnäs")]
    [InlineData("0278999999", "278", "999999", "Bollnäs")]
    [InlineData("028000000", "280", "00000", "Malung")]
    [InlineData("0280999999", "280", "999999", "Malung")]
    [InlineData("028100000", "281", "00000", "Vansbro")]
    [InlineData("0281999999", "281", "999999", "Vansbro")]
    [InlineData("029000000", "290", "00000", "Hofors-Storvik")]
    [InlineData("0290999999", "290", "999999", "Hofors-Storvik")]
    [InlineData("029100000", "291", "00000", "Hedesunda-Österfärnebo")]
    [InlineData("0291999999", "291", "999999", "Hedesunda-Österfärnebo")]
    [InlineData("029200000", "292", "00000", "Tärnsjö-Östervåla")]
    [InlineData("0292999999", "292", "999999", "Tärnsjö-Östervåla")]
    [InlineData("029300000", "293", "00000", "Tierp-Söderfors")]
    [InlineData("0293999999", "293", "999999", "Tierp-Söderfors")]
    [InlineData("029400000", "294", "00000", "Karlholmsbruk-Skärplinge")]
    [InlineData("0294999999", "294", "999999", "Karlholmsbruk-Skärplinge")]
    [InlineData("029500000", "295", "00000", "Örbyhus-Dannemora")]
    [InlineData("0295999999", "295", "999999", "Örbyhus-Dannemora")]
    [InlineData("029700000", "297", "00000", "Ockelbo-Hamrånge")]
    [InlineData("0297999999", "297", "999999", "Ockelbo-Hamrånge")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("031000000", "31", "000000", "Göteborg")]
    [InlineData("0319999999", "31", "9999999", "Göteborg")]
    [InlineData("03300000", "33", "00000", "Borås")]
    [InlineData("0339999999", "33", "9999999", "Borås")]
    [InlineData("03500000", "35", "00000", "Halmstad")]
    [InlineData("0359999999", "35", "9999999", "Halmstad")]
    [InlineData("03600000", "36", "00000", "Jönköping-Huskvarna")]
    [InlineData("0369999999", "36", "9999999", "Jönköping-Huskvarna")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("030000000", "300", "00000", "Kungsbacka")]
    [InlineData("0300999999", "300", "999999", "Kungsbacka")]
    [InlineData("030100000", "301", "00000", "Hindås")]
    [InlineData("0301999999", "301", "999999", "Hindås")]
    [InlineData("030200000", "302", "00000", "Lerum")]
    [InlineData("0302999999", "302", "999999", "Lerum")]
    [InlineData("030300000", "303", "00000", "Kungälv")]
    [InlineData("0303999999", "303", "999999", "Kungälv")]
    [InlineData("030400000", "304", "00000", "Orust-Tjörn")]
    [InlineData("0304999999", "304", "999999", "Orust-Tjörn")]
    [InlineData("032000000", "320", "00000", "Kinna")]
    [InlineData("0320999999", "320", "999999", "Kinna")]
    [InlineData("032100000", "321", "00000", "Ulricehamn")]
    [InlineData("0321999999", "321", "999999", "Ulricehamn")]
    [InlineData("032200000", "322", "00000", "Alingsås-Vårgårda")]
    [InlineData("0322999999", "322", "999999", "Alingsås-Vårgårda")]
    [InlineData("032500000", "325", "00000", "Svenljunga-Tranemo")]
    [InlineData("0325999999", "325", "999999", "Svenljunga-Tranemo")]
    [InlineData("034000000", "340", "00000", "Varberg")]
    [InlineData("0340999999", "340", "999999", "Varberg")]
    [InlineData("034500000", "345", "00000", "Hyltebruk-Torup")]
    [InlineData("0345999999", "345", "999999", "Hyltebruk-Torup")]
    [InlineData("034600000", "346", "00000", "Falkenberg")]
    [InlineData("0346999999", "346", "999999", "Falkenberg")]
    [InlineData("037000000", "370", "00000", "Värnamo")]
    [InlineData("0370999999", "370", "999999", "Värnamo")]
    [InlineData("037100000", "371", "00000", "Gislaved- Anderstorp")]
    [InlineData("0371999999", "371", "999999", "Gislaved- Anderstorp")]
    [InlineData("037200000", "372", "00000", "Ljungby")]
    [InlineData("0372999999", "372", "999999", "Ljungby")]
    [InlineData("038000000", "380", "00000", "Nässjö")]
    [InlineData("0380999999", "380", "999999", "Nässjö")]
    [InlineData("038100000", "381", "00000", "Eksjö")]
    [InlineData("0381999999", "381", "999999", "Eksjö")]
    [InlineData("038200000", "382", "00000", "Sävsjö")]
    [InlineData("0382999999", "382", "999999", "Sävsjö")]
    [InlineData("038300000", "383", "00000", "Vetlanda")]
    [InlineData("0383999999", "383", "999999", "Vetlanda")]
    [InlineData("039000000", "390", "00000", "Gränna")]
    [InlineData("0390999999", "390", "999999", "Gränna")]
    [InlineData("039200000", "392", "00000", "Mullsjö")]
    [InlineData("0392999999", "392", "999999", "Mullsjö")]
    [InlineData("039300000", "393", "00000", "Vaggeryd")]
    [InlineData("0393999999", "393", "999999", "Vaggeryd")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("04000000", "40", "00000", "Malmö")]
    [InlineData("0409999999", "40", "9999999", "Malmö")]
    [InlineData("04200000", "42", "00000", "Helsingborg-Höganäs")]
    [InlineData("0429999999", "42", "9999999", "Helsingborg-Höganäs")]
    [InlineData("04400000", "44", "00000", "Kristianstad")]
    [InlineData("0449999999", "44", "9999999", "Kristianstad")]
    [InlineData("04600000", "46", "00000", "Lund")]
    [InlineData("0469999999", "46", "9999999", "Lund")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("041000000", "410", "00000", "Trelleborg")]
    [InlineData("0410999999", "410", "999999", "Trelleborg")]
    [InlineData("041100000", "411", "00000", "Ystad")]
    [InlineData("0411999999", "411", "999999", "Ystad")]
    [InlineData("041300000", "413", "00000", "Eslöv-Höör")]
    [InlineData("0413999999", "413", "999999", "Eslöv-Höör")]
    [InlineData("041400000", "414", "00000", "Simrishamn")]
    [InlineData("0414999999", "414", "999999", "Simrishamn")]
    [InlineData("041500000", "415", "00000", "Hörby")]
    [InlineData("0415999999", "415", "999999", "Hörby")]
    [InlineData("041600000", "416", "00000", "Sjöbo")]
    [InlineData("0416999999", "416", "999999", "Sjöbo")]
    [InlineData("041700000", "417", "00000", "Tomelilla")]
    [InlineData("0417999999", "417", "999999", "Tomelilla")]
    [InlineData("041800000", "418", "00000", "Landskrona-Svalöv")]
    [InlineData("0418999999", "418", "999999", "Landskrona-Svalöv")]
    [InlineData("043000000", "430", "00000", "Laholm")]
    [InlineData("0430999999", "430", "999999", "Laholm")]
    [InlineData("043100000", "431", "00000", "Ängelholm-Båstad")]
    [InlineData("0431999999", "431", "999999", "Ängelholm-Båstad")]
    [InlineData("043300000", "433", "00000", "Markaryd-Strömsnäsbruk")]
    [InlineData("0433999999", "433", "999999", "Markaryd-Strömsnäsbruk")]
    [InlineData("043500000", "435", "00000", "Klippan-Perstorp")]
    [InlineData("0435999999", "435", "999999", "Klippan-Perstorp")]
    [InlineData("045100000", "451", "00000", "Hässleholm")]
    [InlineData("0451999999", "451", "999999", "Hässleholm")]
    [InlineData("045400000", "454", "00000", "Karlshamn-Olofström")]
    [InlineData("0454999999", "454", "999999", "Karlshamn-Olofström")]
    [InlineData("045500000", "455", "00000", "Karlskrona")]
    [InlineData("0455999999", "455", "999999", "Karlskrona")]
    [InlineData("045600000", "456", "00000", "Sölvesborg-Bromölla")]
    [InlineData("0456999999", "456", "999999", "Sölvesborg-Bromölla")]
    [InlineData("045700000", "457", "00000", "Ronneby")]
    [InlineData("0457999999", "457", "999999", "Ronneby")]
    [InlineData("045900000", "459", "00000", "Ryd")]
    [InlineData("0459999999", "459", "999999", "Ryd")]
    [InlineData("047000000", "470", "00000", "Växjö")]
    [InlineData("0470999999", "470", "999999", "Växjö")]
    [InlineData("047100000", "471", "00000", "Emmaboda")]
    [InlineData("0471999999", "471", "999999", "Emmaboda")]
    [InlineData("047200000", "472", "00000", "Alvesta-Rydaholm")]
    [InlineData("0472999999", "472", "999999", "Alvesta-Rydaholm")]
    [InlineData("047400000", "474", "00000", "Åseda-Lenhovda")]
    [InlineData("0474999999", "474", "999999", "Åseda-Lenhovda")]
    [InlineData("047600000", "476", "00000", "Älmhult")]
    [InlineData("0476999999", "476", "999999", "Älmhult")]
    [InlineData("047700000", "477", "00000", "Tingsryd")]
    [InlineData("0477999999", "477", "999999", "Tingsryd")]
    [InlineData("047800000", "478", "00000", "Lessebo")]
    [InlineData("0478999999", "478", "999999", "Lessebo")]
    [InlineData("047900000", "479", "00000", "Osby")]
    [InlineData("0479999999", "479", "999999", "Osby")]
    [InlineData("048000000", "480", "00000", "Kalmar")]
    [InlineData("0480999999", "480", "999999", "Kalmar")]
    [InlineData("048100000", "481", "00000", "Nybro")]
    [InlineData("0481999999", "481", "999999", "Nybro")]
    [InlineData("048500000", "485", "00000", "Öland")]
    [InlineData("0485999999", "485", "999999", "Öland")]
    [InlineData("048600000", "486", "00000", "Torsås")]
    [InlineData("0486999999", "486", "999999", "Torsås")]
    [InlineData("049000000", "490", "00000", "Västervik")]
    [InlineData("0490999999", "490", "999999", "Västervik")]
    [InlineData("049100000", "491", "00000", "Oskarshamn-Högsby")]
    [InlineData("0491999999", "491", "999999", "Oskarshamn-Högsby")]
    [InlineData("049200000", "492", "00000", "Vimmerby")]
    [InlineData("0492999999", "492", "999999", "Vimmerby")]
    [InlineData("049300000", "493", "00000", "Gamleby")]
    [InlineData("0493999999", "493", "999999", "Gamleby")]
    [InlineData("049400000", "494", "00000", "Kisa")]
    [InlineData("0494999999", "494", "999999", "Kisa")]
    [InlineData("049500000", "495", "00000", "Hultsfred-Virserum")]
    [InlineData("0495999999", "495", "999999", "Hultsfred-Virserum")]
    [InlineData("049600000", "496", "00000", "Mariannelund")]
    [InlineData("0496999999", "496", "999999", "Mariannelund")]
    [InlineData("049800000", "498", "00000", "Gotland")]
    [InlineData("0498999999", "498", "999999", "Gotland")]
    [InlineData("049900000", "499", "00000", "Mönsterås")]
    [InlineData("0499999999", "499", "999999", "Mönsterås")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("054000000", "54", "000000", "Karlstad")]
    [InlineData("0549999999", "54", "9999999", "Karlstad")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("050000000", "500", "00000", "Skövde")]
    [InlineData("0500999999", "500", "999999", "Skövde")]
    [InlineData("050100000", "501", "00000", "Mariestad")]
    [InlineData("0501999999", "501", "999999", "Mariestad")]
    [InlineData("050200000", "502", "00000", "Tidaholm")]
    [InlineData("0502999999", "502", "999999", "Tidaholm")]
    [InlineData("050300000", "503", "00000", "Hjo")]
    [InlineData("0503999999", "503", "999999", "Hjo")]
    [InlineData("050400000", "504", "00000", "Tibro")]
    [InlineData("0504999999", "504", "999999", "Tibro")]
    [InlineData("050500000", "505", "00000", "Karlsborg")]
    [InlineData("0505999999", "505", "999999", "Karlsborg")]
    [InlineData("050600000", "506", "00000", "Töreboda-Hova")]
    [InlineData("0506999999", "506", "999999", "Töreboda-Hova")]
    [InlineData("051000000", "510", "00000", "Lidköping")]
    [InlineData("0510999999", "510", "999999", "Lidköping")]
    [InlineData("051100000", "511", "00000", "Skara-Götene")]
    [InlineData("0511999999", "511", "999999", "Skara-Götene")]
    [InlineData("051200000", "512", "00000", "Vara-Nossebro")]
    [InlineData("0512999999", "512", "999999", "Vara-Nossebro")]
    [InlineData("051300000", "513", "00000", "Herrljunga")]
    [InlineData("0513999999", "513", "999999", "Herrljunga")]
    [InlineData("051400000", "514", "00000", "Grästorp")]
    [InlineData("0514999999", "514", "999999", "Grästorp")]
    [InlineData("051500000", "515", "00000", "Falköping")]
    [InlineData("0515999999", "515", "999999", "Falköping")]
    [InlineData("052000000", "520", "00000", "Trollhättan")]
    [InlineData("0520999999", "520", "999999", "Trollhättan")]
    [InlineData("052100000", "521", "00000", "Vänersborg")]
    [InlineData("0521999999", "521", "999999", "Vänersborg")]
    [InlineData("052200000", "522", "00000", "Uddevalla")]
    [InlineData("0522999999", "522", "999999", "Uddevalla")]
    [InlineData("052300000", "523", "00000", "Lysekil")]
    [InlineData("0523999999", "523", "999999", "Lysekil")]
    [InlineData("052400000", "524", "00000", "Munkedal")]
    [InlineData("0524999999", "524", "999999", "Munkedal")]
    [InlineData("052500000", "525", "00000", "Grebbestad")]
    [InlineData("0525999999", "525", "999999", "Grebbestad")]
    [InlineData("052600000", "526", "00000", "Strömstad")]
    [InlineData("0526999999", "526", "999999", "Strömstad")]
    [InlineData("052800000", "528", "00000", "Färgelanda")]
    [InlineData("0528999999", "528", "999999", "Färgelanda")]
    [InlineData("053000000", "530", "00000", "Mellerud")]
    [InlineData("0530999999", "530", "999999", "Mellerud")]
    [InlineData("053100000", "531", "00000", "Bengtsfors")]
    [InlineData("0531999999", "531", "999999", "Bengtsfors")]
    [InlineData("053200000", "532", "00000", "Åmål")]
    [InlineData("0532999999", "532", "999999", "Åmål")]
    [InlineData("053300000", "533", "00000", "Säffle")]
    [InlineData("0533999999", "533", "999999", "Säffle")]
    [InlineData("053400000", "534", "00000", "Ed")]
    [InlineData("0534999999", "534", "999999", "Ed")]
    [InlineData("055000000", "550", "00000", "Kristinehamn")]
    [InlineData("0550999999", "550", "999999", "Kristinehamn")]
    [InlineData("055100000", "551", "00000", "Gullspång")]
    [InlineData("0551999999", "551", "999999", "Gullspång")]
    [InlineData("055200000", "552", "00000", "Deje")]
    [InlineData("0552999999", "552", "999999", "Deje")]
    [InlineData("055300000", "553", "00000", "Molkom")]
    [InlineData("0553999999", "553", "999999", "Molkom")]
    [InlineData("055400000", "554", "00000", "Kil")]
    [InlineData("0554999999", "554", "999999", "Kil")]
    [InlineData("055500000", "555", "00000", "Grums")]
    [InlineData("0555999999", "555", "999999", "Grums")]
    [InlineData("056000000", "560", "00000", "Torsby")]
    [InlineData("0560999999", "560", "999999", "Torsby")]
    [InlineData("056300000", "563", "00000", "Hagfors-Munkfors")]
    [InlineData("0563999999", "563", "999999", "Hagfors-Munkfors")]
    [InlineData("056400000", "564", "00000", "Sysslebäck")]
    [InlineData("0564999999", "564", "999999", "Sysslebäck")]
    [InlineData("056500000", "565", "00000", "Sunne")]
    [InlineData("0565999999", "565", "999999", "Sunne")]
    [InlineData("057000000", "570", "00000", "Arvika")]
    [InlineData("0570999999", "570", "999999", "Arvika")]
    [InlineData("057100000", "571", "00000", "Charlottenberg-Åmotfors")]
    [InlineData("0571999999", "571", "999999", "Charlottenberg-Åmotfors")]
    [InlineData("057300000", "573", "00000", "Årjäng")]
    [InlineData("0573999999", "573", "999999", "Årjäng")]
    [InlineData("058000000", "580", "00000", "Kopparberg")]
    [InlineData("0580999999", "580", "999999", "Kopparberg")]
    [InlineData("058100000", "581", "00000", "Lindesberg")]
    [InlineData("0581999999", "581", "999999", "Lindesberg")]
    [InlineData("058200000", "582", "00000", "Hallsberg")]
    [InlineData("0582999999", "582", "999999", "Hallsberg")]
    [InlineData("058300000", "583", "00000", "Askersund")]
    [InlineData("0583999999", "583", "999999", "Askersund")]
    [InlineData("058400000", "584", "00000", "Laxå")]
    [InlineData("0584999999", "584", "999999", "Laxå")]
    [InlineData("058500000", "585", "00000", "Fjugesta-Svartå")]
    [InlineData("0585999999", "585", "999999", "Fjugesta-Svartå")]
    [InlineData("058600000", "586", "00000", "Karlskoga-Degerfors")]
    [InlineData("0586999999", "586", "999999", "Karlskoga-Degerfors")]
    [InlineData("058700000", "587", "00000", "Nora")]
    [InlineData("0587999999", "587", "999999", "Nora")]
    [InlineData("058900000", "589", "00000", "Arboga")]
    [InlineData("0589999999", "589", "999999", "Arboga")]
    [InlineData("059000000", "590", "00000", "Filipstad")]
    [InlineData("0590999999", "590", "999999", "Filipstad")]
    [InlineData("059100000", "591", "00000", "Hällefors-Grythyttan")]
    [InlineData("0591999999", "591", "999999", "Hällefors-Grythyttan")]
    public void Parse_Known_GeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("06000000", "60", "00000", "Sundsvall-Timrå")]
    [InlineData("0609999999", "60", "9999999", "Sundsvall-Timrå")]
    [InlineData("06300000", "63", "00000", "Östersund")]
    [InlineData("0639999999", "63", "9999999", "Östersund")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("061100000", "611", "00000", "Härnösand")]
    [InlineData("0611999999", "611", "999999", "Härnösand")]
    [InlineData("061200000", "612", "00000", "Kramfors")]
    [InlineData("0612999999", "612", "999999", "Kramfors")]
    [InlineData("061300000", "613", "00000", "Ullånger")]
    [InlineData("0613999999", "613", "999999", "Ullånger")]
    [InlineData("062000000", "620", "00000", "Sollefteå")]
    [InlineData("0620999999", "620", "999999", "Sollefteå")]
    [InlineData("062100000", "621", "00000", "Junsele")]
    [InlineData("0621999999", "621", "999999", "Junsele")]
    [InlineData("062200000", "622", "00000", "Näsåker")]
    [InlineData("0622999999", "622", "999999", "Näsåker")]
    [InlineData("062300000", "623", "00000", "Ramsele")]
    [InlineData("0623999999", "623", "999999", "Ramsele")]
    [InlineData("062400000", "624", "00000", "Backe")]
    [InlineData("0624999999", "624", "999999", "Backe")]
    [InlineData("064000000", "640", "00000", "Krokom")]
    [InlineData("0640999999", "640", "999999", "Krokom")]
    [InlineData("064200000", "642", "00000", "Lit")]
    [InlineData("0642999999", "642", "999999", "Lit")]
    [InlineData("064300000", "643", "00000", "Hallen-Oviken")]
    [InlineData("0643999999", "643", "999999", "Hallen-Oviken")]
    [InlineData("064400000", "644", "00000", "Hammerdal")]
    [InlineData("0644999999", "644", "999999", "Hammerdal")]
    [InlineData("064500000", "645", "00000", "Föllinge")]
    [InlineData("0645999999", "645", "999999", "Föllinge")]
    [InlineData("064700000", "647", "00000", "Åre-Järpen")]
    [InlineData("0647999999", "647", "999999", "Åre-Järpen")]
    [InlineData("065000000", "650", "00000", "Hudiksvall")]
    [InlineData("0650999999", "650", "999999", "Hudiksvall")]
    [InlineData("065100000", "651", "00000", "Ljusdal")]
    [InlineData("0651999999", "651", "999999", "Ljusdal")]
    [InlineData("065200000", "652", "00000", "Bergsjö")]
    [InlineData("0652999999", "652", "999999", "Bergsjö")]
    [InlineData("065300000", "653", "00000", "Delsbo")]
    [InlineData("0653999999", "653", "999999", "Delsbo")]
    [InlineData("065700000", "657", "00000", "Los")]
    [InlineData("0657999999", "657", "999999", "Los")]
    [InlineData("066000000", "660", "00000", "Örnsköldsvik")]
    [InlineData("0660999999", "660", "999999", "Örnsköldsvik")]
    [InlineData("066100000", "661", "00000", "Bredbyn")]
    [InlineData("0661999999", "661", "999999", "Bredbyn")]
    [InlineData("066200000", "662", "00000", "Björna")]
    [InlineData("0662999999", "662", "999999", "Björna")]
    [InlineData("066300000", "663", "00000", "Husum")]
    [InlineData("0663999999", "663", "999999", "Husum")]
    [InlineData("067000000", "670", "00000", "Strömsund")]
    [InlineData("0670999999", "670", "999999", "Strömsund")]
    [InlineData("067100000", "671", "00000", "Hoting")]
    [InlineData("0671999999", "671", "999999", "Hoting")]
    [InlineData("067200000", "672", "00000", "Gäddede")]
    [InlineData("0672999999", "672", "999999", "Gäddede")]
    [InlineData("068000000", "680", "00000", "Sveg")]
    [InlineData("0680999999", "680", "999999", "Sveg")]
    [InlineData("068200000", "682", "00000", "Rätan")]
    [InlineData("0682999999", "682", "999999", "Rätan")]
    [InlineData("068400000", "684", "00000", "Hede-Funäsdalen")]
    [InlineData("0684999999", "684", "999999", "Hede-Funäsdalen")]
    [InlineData("068700000", "687", "00000", "Svenstavik")]
    [InlineData("0687999999", "687", "999999", "Svenstavik")]
    [InlineData("069000000", "690", "00000", "Ånge")]
    [InlineData("0690999999", "690", "999999", "Ånge")]
    [InlineData("069100000", "691", "00000", "Torpshammar")]
    [InlineData("0691999999", "691", "999999", "Torpshammar")]
    [InlineData("069200000", "692", "00000", "Liden")]
    [InlineData("0692999999", "692", "999999", "Liden")]
    [InlineData("069300000", "693", "00000", "Bräcke-Gällö")]
    [InlineData("0693999999", "693", "999999", "Bräcke-Gällö")]
    [InlineData("069500000", "695", "00000", "Stugun")]
    [InlineData("0695999999", "695", "999999", "Stugun")]
    [InlineData("069600000", "696", "00000", "Hammarstrand")]
    [InlineData("0696999999", "696", "999999", "Hammarstrand")]
    public void Parse_Known_GeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("08000000", "8", "000000", "Stockholm")]
    [InlineData("0899999999", "8", "99999999", "Stockholm")]
    public void Parse_Known_GeographicPhoneNumber_8_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("09000000", "90", "00000", "Umeå")]
    [InlineData("0909999999", "90", "9999999", "Umeå")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("091000000", "910", "00000", "Skellefteå")]
    [InlineData("0910999999", "910", "999999", "Skellefteå")]
    [InlineData("091100000", "911", "00000", "Piteå")]
    [InlineData("0911999999", "911", "999999", "Piteå")]
    [InlineData("091200000", "912", "00000", "Byske")]
    [InlineData("0912999999", "912", "999999", "Byske")]
    [InlineData("091300000", "913", "00000", "Lövånger")]
    [InlineData("0913999999", "913", "999999", "Lövånger")]
    [InlineData("091400000", "914", "00000", "Burträsk")]
    [InlineData("0914999999", "914", "999999", "Burträsk")]
    [InlineData("091500000", "915", "00000", "Bastuträsk")]
    [InlineData("0915999999", "915", "999999", "Bastuträsk")]
    [InlineData("091600000", "916", "00000", "Jörn")]
    [InlineData("0916999999", "916", "999999", "Jörn")]
    [InlineData("091800000", "918", "00000", "Norsjö")]
    [InlineData("0918999999", "918", "999999", "Norsjö")]
    [InlineData("092000000", "920", "00000", "Luleå")]
    [InlineData("0920999999", "920", "999999", "Luleå")]
    [InlineData("092100000", "921", "00000", "Boden")]
    [InlineData("0921999999", "921", "999999", "Boden")]
    [InlineData("092200000", "922", "00000", "Haparanda")]
    [InlineData("0922999999", "922", "999999", "Haparanda")]
    [InlineData("092300000", "923", "00000", "Kalix")]
    [InlineData("0923999999", "923", "999999", "Kalix")]
    [InlineData("092400000", "924", "00000", "Råneå")]
    [InlineData("0924999999", "924", "999999", "Råneå")]
    [InlineData("092500000", "925", "00000", "Lakaträsk")]
    [InlineData("0925999999", "925", "999999", "Lakaträsk")]
    [InlineData("092600000", "926", "00000", "Överkalix")]
    [InlineData("0926999999", "926", "999999", "Överkalix")]
    [InlineData("092700000", "927", "00000", "Övertorneå")]
    [InlineData("0927999999", "927", "999999", "Övertorneå")]
    [InlineData("092800000", "928", "00000", "Harads")]
    [InlineData("0928999999", "928", "999999", "Harads")]
    [InlineData("092900000", "929", "00000", "Älvsbyn")]
    [InlineData("0929999999", "929", "999999", "Älvsbyn")]
    [InlineData("093000000", "930", "00000", "Nordmaling")]
    [InlineData("0930999999", "930", "999999", "Nordmaling")]
    [InlineData("093200000", "932", "00000", "Bjurholm")]
    [InlineData("0932999999", "932", "999999", "Bjurholm")]
    [InlineData("093300000", "933", "00000", "Vindeln")]
    [InlineData("0933999999", "933", "999999", "Vindeln")]
    [InlineData("093400000", "934", "00000", "Robertsfors")]
    [InlineData("0934999999", "934", "999999", "Robertsfors")]
    [InlineData("093500000", "935", "00000", "Vännäs")]
    [InlineData("0935999999", "935", "999999", "Vännäs")]
    [InlineData("094000000", "940", "00000", "Vilhelmina")]
    [InlineData("0940999999", "940", "999999", "Vilhelmina")]
    [InlineData("094100000", "941", "00000", "Åsele")]
    [InlineData("0941999999", "941", "999999", "Åsele")]
    [InlineData("094200000", "942", "00000", "Dorotea")]
    [InlineData("0942999999", "942", "999999", "Dorotea")]
    [InlineData("094300000", "943", "00000", "Fredrika")]
    [InlineData("0943999999", "943", "999999", "Fredrika")]
    [InlineData("095000000", "950", "00000", "Lycksele")]
    [InlineData("0950999999", "950", "999999", "Lycksele")]
    [InlineData("095100000", "951", "00000", "Storuman")]
    [InlineData("0951999999", "951", "999999", "Storuman")]
    [InlineData("095200000", "952", "00000", "Sorsele")]
    [InlineData("0952999999", "952", "999999", "Sorsele")]
    [InlineData("095300000", "953", "00000", "Malå")]
    [InlineData("0953999999", "953", "999999", "Malå")]
    [InlineData("095400000", "954", "00000", "Tärnaby")]
    [InlineData("0954999999", "954", "999999", "Tärnaby")]
    [InlineData("096000000", "960", "00000", "Arvidsjaur")]
    [InlineData("0960999999", "960", "999999", "Arvidsjaur")]
    [InlineData("096100000", "961", "00000", "Arjeplog")]
    [InlineData("0961999999", "961", "999999", "Arjeplog")]
    [InlineData("097000000", "970", "00000", "Gällivare")]
    [InlineData("0970999999", "970", "999999", "Gällivare")]
    [InlineData("097100000", "971", "00000", "Jokkmokk")]
    [InlineData("0971999999", "971", "999999", "Jokkmokk")]
    [InlineData("097300000", "973", "00000", "Porjus")]
    [InlineData("0973999999", "973", "999999", "Porjus")]
    [InlineData("097500000", "975", "00000", "Hakkas")]
    [InlineData("0975999999", "975", "999999", "Hakkas")]
    [InlineData("097600000", "976", "00000", "Vuollerim")]
    [InlineData("0976999999", "976", "999999", "Vuollerim")]
    [InlineData("097700000", "977", "00000", "Korpilombolo")]
    [InlineData("0977999999", "977", "999999", "Korpilombolo")]
    [InlineData("097800000", "978", "00000", "Pajala")]
    [InlineData("0978999999", "978", "999999", "Pajala")]
    [InlineData("098000000", "980", "00000", "Kiruna")]
    [InlineData("0980999999", "980", "999999", "Kiruna")]
    [InlineData("098100000", "981", "00000", "Vittangi")]
    [InlineData("0981999999", "981", "999999", "Vittangi")]
    public void Parse_Known_GeographicPhoneNumber_9XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Sweden, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
