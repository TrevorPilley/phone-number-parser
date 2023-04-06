namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Spain <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_ES_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Spain);

    [Theory]
    [InlineData("810000000", "81", "0000000", "Madrid")]
    [InlineData("819999999", "81", "9999999", "Madrid")]
    [InlineData("830000000", "83", "0000000", "Barcelona")]
    [InlineData("839999999", "83", "9999999", "Barcelona")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Spain, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("820000000", "820", "000000", "Ávila")]
    [InlineData("820999999", "820", "999999", "Ávila")]
    [InlineData("821000000", "821", "000000", "Segovia")]
    [InlineData("821999999", "821", "999999", "Segovia")]
    [InlineData("822000000", "822", "000000", "Santa Cruz de Tenerife")]
    [InlineData("822999999", "822", "999999", "Santa Cruz de Tenerife")]
    [InlineData("823000000", "823", "000000", "Salamanca")]
    [InlineData("823999999", "823", "999999", "Salamanca")]
    [InlineData("824000000", "824", "000000", "Badajoz")]
    [InlineData("824999999", "824", "999999", "Badajoz")]
    [InlineData("825000000", "825", "000000", "Toledo")]
    [InlineData("825999999", "825", "999999", "Toledo")]
    [InlineData("826000000", "826", "000000", "Ciudad Real")]
    [InlineData("826999999", "826", "999999", "Ciudad Real")]
    [InlineData("827000000", "827", "000000", "Cáceres")]
    [InlineData("827999999", "827", "999999", "Cáceres")]
    [InlineData("828000000", "828", "000000", "Palmas, Las")]
    [InlineData("828999999", "828", "999999", "Palmas, Las")]
    [InlineData("841000000", "841", "000000", "Rioja, La")]
    [InlineData("841999999", "841", "999999", "Rioja, La")]
    [InlineData("842000000", "842", "000000", "Cantabria")]
    [InlineData("842999999", "842", "999999", "Cantabria")]
    [InlineData("843000000", "843", "000000", "Guipúzcoa")]
    [InlineData("843999999", "843", "999999", "Guipúzcoa")]
    [InlineData("844000000", "844", "000000", "Vizcaya")]
    [InlineData("844999999", "844", "999999", "Vizcaya")]
    [InlineData("845000000", "845", "000000", "Álava")]
    [InlineData("845999999", "845", "999999", "Álava")]
    [InlineData("846000000", "846", "000000", "Vizcaya")]
    [InlineData("846999999", "846", "999999", "Vizcaya")]
    [InlineData("847000000", "847", "000000", "Burgos")]
    [InlineData("847999999", "847", "999999", "Burgos")]
    [InlineData("848000000", "848", "000000", "Navarra")]
    [InlineData("848999999", "848", "999999", "Navarra")]
    [InlineData("849000000", "849", "000000", "Guadalajara")]
    [InlineData("849999999", "849", "999999", "Guadalajara")]
    [InlineData("850000000", "850", "000000", "Almería")]
    [InlineData("850999999", "850", "999999", "Almería")]
    [InlineData("851000000", "851", "000000", "Málaga")]
    [InlineData("851999999", "851", "999999", "Málaga")]
    [InlineData("852000000", "852", "000000", "Málaga")]
    [InlineData("852999999", "852", "999999", "Málaga")]
    [InlineData("853000000", "853", "000000", "Jaén")]
    [InlineData("853999999", "853", "999999", "Jaén")]
    [InlineData("854000000", "854", "000000", "Sevilla")]
    [InlineData("854999999", "854", "999999", "Sevilla")]
    [InlineData("855000000", "855", "000000", "Sevilla")]
    [InlineData("855999999", "855", "999999", "Sevilla")]
    [InlineData("856000000", "856", "000000", "Cádiz")]
    [InlineData("856999999", "856", "999999", "Cádiz")]
    [InlineData("857000000", "857", "000000", "Córdoba")]
    [InlineData("857999999", "857", "999999", "Córdoba")]
    [InlineData("858000000", "858", "000000", "Granada")]
    [InlineData("858999999", "858", "999999", "Granada")]
    [InlineData("859000000", "859", "000000", "Huelva")]
    [InlineData("859999999", "859", "999999", "Huelva")]
    [InlineData("860000000", "860", "000000", "València")]
    [InlineData("860999999", "860", "999999", "València")]
    [InlineData("863000000", "863", "000000", "València")]
    [InlineData("863999999", "863", "999999", "València")]
    [InlineData("864000000", "864", "000000", "Castellón")]
    [InlineData("864999999", "864", "999999", "Castellón")]
    [InlineData("865000000", "865", "000000", "Alicante")]
    [InlineData("865999999", "865", "999999", "Alicante")]
    [InlineData("866000000", "866", "000000", "Alicante")]
    [InlineData("866999999", "866", "999999", "Alicante")]
    [InlineData("867000000", "867", "000000", "Albacete")]
    [InlineData("867999999", "867", "999999", "Albacete")]
    [InlineData("868000000", "868", "000000", "Murcia")]
    [InlineData("868999999", "868", "999999", "Murcia")]
    [InlineData("869000000", "869", "000000", "Cuenca")]
    [InlineData("869999999", "869", "999999", "Cuenca")]
    [InlineData("871000000", "871", "000000", "Balears, Illes")]
    [InlineData("871999999", "871", "999999", "Balears, Illes")]
    [InlineData("872000000", "872", "000000", "Gerona")]
    [InlineData("872999999", "872", "999999", "Gerona")]
    [InlineData("873000000", "873", "000000", "Lérida")]
    [InlineData("873999999", "873", "999999", "Lérida")]
    [InlineData("874000000", "874", "000000", "Huesca")]
    [InlineData("874999999", "874", "999999", "Huesca")]
    [InlineData("875000000", "875", "000000", "Soria")]
    [InlineData("875999999", "875", "999999", "Soria")]
    [InlineData("876000000", "876", "000000", "Zaragoza")]
    [InlineData("876999999", "876", "999999", "Zaragoza")]
    [InlineData("877000000", "877", "000000", "Tarragona")]
    [InlineData("877999999", "877", "999999", "Tarragona")]
    [InlineData("878000000", "878", "000000", "Teruel")]
    [InlineData("878999999", "878", "999999", "Teruel")]
    [InlineData("879000000", "879", "000000", "Palencia")]
    [InlineData("879999999", "879", "999999", "Palencia")]
    [InlineData("880000000", "880", "000000", "Zamora")]
    [InlineData("880999999", "880", "999999", "Zamora")]
    [InlineData("881000000", "881", "000000", "A Coruña")]
    [InlineData("881999999", "881", "999999", "A Coruña")]
    [InlineData("882000000", "882", "000000", "Lugo")]
    [InlineData("882999999", "882", "999999", "Lugo")]
    [InlineData("883000000", "883", "000000", "Valladolid")]
    [InlineData("883999999", "883", "999999", "Valladolid")]
    [InlineData("884000000", "884", "000000", "Asturias")]
    [InlineData("884999999", "884", "999999", "Asturias")]
    [InlineData("885000000", "885", "000000", "Asturias")]
    [InlineData("885999999", "885", "999999", "Asturias")]
    [InlineData("886000000", "886", "000000", "Pontevedra")]
    [InlineData("886999999", "886", "999999", "Pontevedra")]
    [InlineData("887000000", "887", "000000", "León")]
    [InlineData("887999999", "887", "999999", "León")]
    [InlineData("888000000", "888", "000000", "Ourense")]
    [InlineData("888999999", "888", "999999", "Ourense")]
    public void Parse_Known_GeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Spain, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("910000000", "91", "0000000", "Madrid")]
    [InlineData("919999999", "91", "9999999", "Madrid")]
    [InlineData("930000000", "93", "0000000", "Barcelona")]
    [InlineData("939999999", "93", "9999999", "Barcelona")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Spain, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("920000000", "920", "000000", "Ávila")]
    [InlineData("920999999", "920", "999999", "Ávila")]
    [InlineData("921000000", "921", "000000", "Segovia")]
    [InlineData("921999999", "921", "999999", "Segovia")]
    [InlineData("922000000", "922", "000000", "Santa Cruz de Tenerife")]
    [InlineData("922999999", "922", "999999", "Santa Cruz de Tenerife")]
    [InlineData("923000000", "923", "000000", "Salamanca")]
    [InlineData("923999999", "923", "999999", "Salamanca")]
    [InlineData("924000000", "924", "000000", "Badajoz")]
    [InlineData("924999999", "924", "999999", "Badajoz")]
    [InlineData("925000000", "925", "000000", "Toledo")]
    [InlineData("925999999", "925", "999999", "Toledo")]
    [InlineData("926000000", "926", "000000", "Ciudad Real")]
    [InlineData("926999999", "926", "999999", "Ciudad Real")]
    [InlineData("927000000", "927", "000000", "Cáceres")]
    [InlineData("927999999", "927", "999999", "Cáceres")]
    [InlineData("928000000", "928", "000000", "Palmas, Las")]
    [InlineData("928999999", "928", "999999", "Palmas, Las")]
    [InlineData("941000000", "941", "000000", "Rioja, La")]
    [InlineData("941999999", "941", "999999", "Rioja, La")]
    [InlineData("942000000", "942", "000000", "Cantabria")]
    [InlineData("942999999", "942", "999999", "Cantabria")]
    [InlineData("943000000", "943", "000000", "Guipúzcoa")]
    [InlineData("943999999", "943", "999999", "Guipúzcoa")]
    [InlineData("944000000", "944", "000000", "Vizcaya")]
    [InlineData("944999999", "944", "999999", "Vizcaya")]
    [InlineData("945000000", "945", "000000", "Álava")]
    [InlineData("945999999", "945", "999999", "Álava")]
    [InlineData("946000000", "946", "000000", "Vizcaya")]
    [InlineData("946999999", "946", "999999", "Vizcaya")]
    [InlineData("947000000", "947", "000000", "Burgos")]
    [InlineData("947999999", "947", "999999", "Burgos")]
    [InlineData("948000000", "948", "000000", "Navarra")]
    [InlineData("948999999", "948", "999999", "Navarra")]
    [InlineData("949000000", "949", "000000", "Guadalajara")]
    [InlineData("949999999", "949", "999999", "Guadalajara")]
    [InlineData("950000000", "950", "000000", "Almería")]
    [InlineData("950999999", "950", "999999", "Almería")]
    [InlineData("951000000", "951", "000000", "Málaga")]
    [InlineData("951999999", "951", "999999", "Málaga")]
    [InlineData("952000000", "952", "000000", "Málaga")]
    [InlineData("952999999", "952", "999999", "Málaga")]
    [InlineData("953000000", "953", "000000", "Jaén")]
    [InlineData("953999999", "953", "999999", "Jaén")]
    [InlineData("954000000", "954", "000000", "Sevilla")]
    [InlineData("954999999", "954", "999999", "Sevilla")]
    [InlineData("955000000", "955", "000000", "Sevilla")]
    [InlineData("955999999", "955", "999999", "Sevilla")]
    [InlineData("956000000", "956", "000000", "Cádiz")]
    [InlineData("956999999", "956", "999999", "Cádiz")]
    [InlineData("957000000", "957", "000000", "Córdoba")]
    [InlineData("957999999", "957", "999999", "Córdoba")]
    [InlineData("958000000", "958", "000000", "Granada")]
    [InlineData("958999999", "958", "999999", "Granada")]
    [InlineData("959000000", "959", "000000", "Huelva")]
    [InlineData("959999999", "959", "999999", "Huelva")]
    [InlineData("960000000", "960", "000000", "València")]
    [InlineData("960999999", "960", "999999", "València")]
    [InlineData("963000000", "963", "000000", "València")]
    [InlineData("963999999", "963", "999999", "València")]
    [InlineData("964000000", "964", "000000", "Castellón")]
    [InlineData("964999999", "964", "999999", "Castellón")]
    [InlineData("965000000", "965", "000000", "Alicante")]
    [InlineData("965999999", "965", "999999", "Alicante")]
    [InlineData("966000000", "966", "000000", "Alicante")]
    [InlineData("966999999", "966", "999999", "Alicante")]
    [InlineData("967000000", "967", "000000", "Albacete")]
    [InlineData("967999999", "967", "999999", "Albacete")]
    [InlineData("968000000", "968", "000000", "Murcia")]
    [InlineData("968999999", "968", "999999", "Murcia")]
    [InlineData("969000000", "969", "000000", "Cuenca")]
    [InlineData("969999999", "969", "999999", "Cuenca")]
    [InlineData("971000000", "971", "000000", "Balears, Illes")]
    [InlineData("971999999", "971", "999999", "Balears, Illes")]
    [InlineData("972000000", "972", "000000", "Gerona")]
    [InlineData("972999999", "972", "999999", "Gerona")]
    [InlineData("973000000", "973", "000000", "Lérida")]
    [InlineData("973999999", "973", "999999", "Lérida")]
    [InlineData("974000000", "974", "000000", "Huesca")]
    [InlineData("974999999", "974", "999999", "Huesca")]
    [InlineData("975000000", "975", "000000", "Soria")]
    [InlineData("975999999", "975", "999999", "Soria")]
    [InlineData("976000000", "976", "000000", "Zaragoza")]
    [InlineData("976999999", "976", "999999", "Zaragoza")]
    [InlineData("977000000", "977", "000000", "Tarragona")]
    [InlineData("977999999", "977", "999999", "Tarragona")]
    [InlineData("978000000", "978", "000000", "Teruel")]
    [InlineData("978999999", "978", "999999", "Teruel")]
    [InlineData("979000000", "979", "000000", "Palencia")]
    [InlineData("979999999", "979", "999999", "Palencia")]
    [InlineData("980000000", "980", "000000", "Zamora")]
    [InlineData("980999999", "980", "999999", "Zamora")]
    [InlineData("981000000", "981", "000000", "A Coruña")]
    [InlineData("981999999", "981", "999999", "A Coruña")]
    [InlineData("982000000", "982", "000000", "Lugo")]
    [InlineData("982999999", "982", "999999", "Lugo")]
    [InlineData("983000000", "983", "000000", "Valladolid")]
    [InlineData("983999999", "983", "999999", "Valladolid")]
    [InlineData("984000000", "984", "000000", "Asturias")]
    [InlineData("984999999", "984", "999999", "Asturias")]
    [InlineData("985000000", "985", "000000", "Asturias")]
    [InlineData("985999999", "985", "999999", "Asturias")]
    [InlineData("986000000", "986", "000000", "Pontevedra")]
    [InlineData("986999999", "986", "999999", "Pontevedra")]
    [InlineData("987000000", "987", "000000", "León")]
    [InlineData("987999999", "987", "999999", "León")]
    [InlineData("988000000", "988", "000000", "Ourense")]
    [InlineData("988999999", "988", "999999", "Ourense")]
    public void Parse_Known_GeographicPhoneNumber_9XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Spain, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
