namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Turkey <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TR_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Turkey);

    [Theory]
    [InlineData("02122000000", "212", "2000000", "Istanbul (European Part)")]
    [InlineData("02129999999", "212", "9999999", "Istanbul (European Part)")]
    [InlineData("02162000000", "216", "2000000", "Istanbul (Anatolian Part)")]
    [InlineData("02169999999", "216", "9999999", "Istanbul (Anatolian Part)")]
    [InlineData("02222000000", "222", "2000000", "Eskişehir")]
    [InlineData("02229999999", "222", "9999999", "Eskişehir")]
    [InlineData("02242000000", "224", "2000000", "Bursa")]
    [InlineData("02249999999", "224", "9999999", "Bursa")]
    [InlineData("02262000000", "226", "2000000", "Yalova")]
    [InlineData("02269999999", "226", "9999999", "Yalova")]
    [InlineData("02282000000", "228", "2000000", "Bilecik")]
    [InlineData("02289999999", "228", "9999999", "Bilecik")]
    [InlineData("02322000000", "232", "2000000", "İzmir")]
    [InlineData("02329999999", "232", "9999999", "İzmir")]
    [InlineData("02362000000", "236", "2000000", "Manisa")]
    [InlineData("02369999999", "236", "9999999", "Manisa")]
    [InlineData("02422000000", "242", "2000000", "Antalya")]
    [InlineData("02429999999", "242", "9999999", "Antalya")]
    [InlineData("02462000000", "246", "2000000", "Isparta")]
    [InlineData("02469999999", "246", "9999999", "Isparta")]
    [InlineData("02482000000", "248", "2000000", "Burdur")]
    [InlineData("02489999999", "248", "9999999", "Burdur")]
    [InlineData("02522000000", "252", "2000000", "Muğla")]
    [InlineData("02529999999", "252", "9999999", "Muğla")]
    [InlineData("02562000000", "256", "2000000", "Aydın")]
    [InlineData("02569999999", "256", "9999999", "Aydın")]
    [InlineData("02582000000", "258", "2000000", "Denizli")]
    [InlineData("02589999999", "258", "9999999", "Denizli")]
    [InlineData("02622000000", "262", "2000000", "Kocaeli")]
    [InlineData("02629999999", "262", "9999999", "Kocaeli")]
    [InlineData("02642000000", "264", "2000000", "Sakarya")]
    [InlineData("02649999999", "264", "9999999", "Sakarya")]
    [InlineData("02662000000", "266", "2000000", "Balıkesir")]
    [InlineData("02669999999", "266", "9999999", "Balıkesir")]
    [InlineData("02722000000", "272", "2000000", "Afyon")]
    [InlineData("02729999999", "272", "9999999", "Afyon")]
    [InlineData("02742000000", "274", "2000000", "Kütahya")]
    [InlineData("02749999999", "274", "9999999", "Kütahya")]
    [InlineData("02762000000", "276", "2000000", "Uşak")]
    [InlineData("02769999999", "276", "9999999", "Uşak")]
    [InlineData("02822000000", "282", "2000000", "Tekirdağ")]
    [InlineData("02829999999", "282", "9999999", "Tekirdağ")]
    [InlineData("02842000000", "284", "2000000", "Edirne")]
    [InlineData("02849999999", "284", "9999999", "Edirne")]
    [InlineData("02862000000", "286", "2000000", "Çanakkale")]
    [InlineData("02869999999", "286", "9999999", "Çanakkale")]
    [InlineData("02882000000", "288", "2000000", "Kırklareli")]
    [InlineData("02889999999", "288", "9999999", "Kırklareli")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Turkey, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("03122000000", "312", "2000000", "Ankara")]
    [InlineData("03129999999", "312", "9999999", "Ankara")]
    [InlineData("03182000000", "318", "2000000", "Kırıkkale")]
    [InlineData("03189999999", "318", "9999999", "Kırıkkale")]
    [InlineData("03222000000", "322", "2000000", "Adana")]
    [InlineData("03229999999", "322", "9999999", "Adana")]
    [InlineData("03242000000", "324", "2000000", "İçel")]
    [InlineData("03249999999", "324", "9999999", "İçel")]
    [InlineData("03262000000", "326", "2000000", "Hatay")]
    [InlineData("03269999999", "326", "9999999", "Hatay")]
    [InlineData("03282000000", "328", "2000000", "Osmaniye")]
    [InlineData("03289999999", "328", "9999999", "Osmaniye")]
    [InlineData("03322000000", "332", "2000000", "Konya")]
    [InlineData("03329999999", "332", "9999999", "Konya")]
    [InlineData("03382000000", "338", "2000000", "Karaman")]
    [InlineData("03389999999", "338", "9999999", "Karaman")]
    [InlineData("03422000000", "342", "2000000", "Gaziantep")]
    [InlineData("03429999999", "342", "9999999", "Gaziantep")]
    [InlineData("03442000000", "344", "2000000", "Kahramanmaraş")]
    [InlineData("03449999999", "344", "9999999", "Kahramanmaraş")]
    [InlineData("03462000000", "346", "2000000", "Sivas")]
    [InlineData("03469999999", "346", "9999999", "Sivas")]
    [InlineData("03482000000", "348", "2000000", "Kilis")]
    [InlineData("03489999999", "348", "9999999", "Kilis")]
    [InlineData("03522000000", "352", "2000000", "Kayseri")]
    [InlineData("03529999999", "352", "9999999", "Kayseri")]
    [InlineData("03542000000", "354", "2000000", "Yozgat")]
    [InlineData("03549999999", "354", "9999999", "Yozgat")]
    [InlineData("03562000000", "356", "2000000", "Tokat")]
    [InlineData("03569999999", "356", "9999999", "Tokat")]
    [InlineData("03582000000", "358", "2000000", "Amasya")]
    [InlineData("03589999999", "358", "9999999", "Amasya")]
    [InlineData("03622000000", "362", "2000000", "Samsun")]
    [InlineData("03629999999", "362", "9999999", "Samsun")]
    [InlineData("03642000000", "364", "2000000", "Çorum")]
    [InlineData("03649999999", "364", "9999999", "Çorum")]
    [InlineData("03662000000", "366", "2000000", "Kastamonu")]
    [InlineData("03669999999", "366", "9999999", "Kastamonu")]
    [InlineData("03682000000", "368", "2000000", "Sinop")]
    [InlineData("03689999999", "368", "9999999", "Sinop")]
    [InlineData("03702000000", "370", "2000000", "Karabük")]
    [InlineData("03709999999", "370", "9999999", "Karabük")]
    [InlineData("03722000000", "372", "2000000", "Zonguldak")]
    [InlineData("03729999999", "372", "9999999", "Zonguldak")]
    [InlineData("03742000000", "374", "2000000", "Bolu")]
    [InlineData("03749999999", "374", "9999999", "Bolu")]
    [InlineData("03762000000", "376", "2000000", "Çankırı")]
    [InlineData("03769999999", "376", "9999999", "Çankırı")]
    [InlineData("03782000000", "378", "2000000", "Bartın")]
    [InlineData("03789999999", "378", "9999999", "Bartın")]
    [InlineData("03802000000", "380", "2000000", "Düzce")]
    [InlineData("03809999999", "380", "9999999", "Düzce")]
    [InlineData("03822000000", "382", "2000000", "Aksaray")]
    [InlineData("03829999999", "382", "9999999", "Aksaray")]
    [InlineData("03842000000", "384", "2000000", "Nevşehir")]
    [InlineData("03849999999", "384", "9999999", "Nevşehir")]
    [InlineData("03862000000", "386", "2000000", "Kırşehir")]
    [InlineData("03869999999", "386", "9999999", "Kırşehir")]
    [InlineData("03882000000", "388", "2000000", "Niğde")]
    [InlineData("03889999999", "388", "9999999", "Niğde")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Turkey, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("04122000000", "412", "2000000", "Diyarbakır")]
    [InlineData("04129999999", "412", "9999999", "Diyarbakır")]
    [InlineData("04142000000", "414", "2000000", "Şanlıurfa")]
    [InlineData("04149999999", "414", "9999999", "Şanlıurfa")]
    [InlineData("04162000000", "416", "2000000", "Adıyaman")]
    [InlineData("04169999999", "416", "9999999", "Adıyaman")]
    [InlineData("04222000000", "422", "2000000", "Malatya")]
    [InlineData("04229999999", "422", "9999999", "Malatya")]
    [InlineData("04242000000", "424", "2000000", "Elazığ")]
    [InlineData("04249999999", "424", "9999999", "Elazığ")]
    [InlineData("04262000000", "426", "2000000", "Bingöl")]
    [InlineData("04269999999", "426", "9999999", "Bingöl")]
    [InlineData("04282000000", "428", "2000000", "Tunceli")]
    [InlineData("04289999999", "428", "9999999", "Tunceli")]
    [InlineData("04322000000", "432", "2000000", "Van")]
    [InlineData("04329999999", "432", "9999999", "Van")]
    [InlineData("04342000000", "434", "2000000", "Bitlis")]
    [InlineData("04349999999", "434", "9999999", "Bitlis")]
    [InlineData("04362000000", "436", "2000000", "Muş")]
    [InlineData("04369999999", "436", "9999999", "Muş")]
    [InlineData("04382000000", "438", "2000000", "Hakkâri")]
    [InlineData("04389999999", "438", "9999999", "Hakkâri")]
    [InlineData("04422000000", "442", "2000000", "Erzurum")]
    [InlineData("04429999999", "442", "9999999", "Erzurum")]
    [InlineData("04462000000", "446", "2000000", "Erzincan")]
    [InlineData("04469999999", "446", "9999999", "Erzincan")]
    [InlineData("04522000000", "452", "2000000", "Ordu")]
    [InlineData("04529999999", "452", "9999999", "Ordu")]
    [InlineData("04542000000", "454", "2000000", "Giresun")]
    [InlineData("04549999999", "454", "9999999", "Giresun")]
    [InlineData("04562000000", "456", "2000000", "Gümüşhane")]
    [InlineData("04569999999", "456", "9999999", "Gümüşhane")]
    [InlineData("04582000000", "458", "2000000", "Bayburt")]
    [InlineData("04589999999", "458", "9999999", "Bayburt")]
    [InlineData("04622000000", "462", "2000000", "Trabzon")]
    [InlineData("04629999999", "462", "9999999", "Trabzon")]
    [InlineData("04642000000", "464", "2000000", "Rize")]
    [InlineData("04649999999", "464", "9999999", "Rize")]
    [InlineData("04662000000", "466", "2000000", "Artvinv")]
    [InlineData("04669999999", "466", "9999999", "Artvinv")]
    [InlineData("04722000000", "472", "2000000", "Ağrı")]
    [InlineData("04729999999", "472", "9999999", "Ağrı")]
    [InlineData("04742000000", "474", "2000000", "Kars")]
    [InlineData("04749999999", "474", "9999999", "Kars")]
    [InlineData("04762000000", "476", "2000000", "Iğdır")]
    [InlineData("04769999999", "476", "9999999", "Iğdır")]
    [InlineData("04782000000", "478", "2000000", "Ardahan")]
    [InlineData("04789999999", "478", "9999999", "Ardahan")]
    [InlineData("04822000000", "482", "2000000", "Mardin")]
    [InlineData("04829999999", "482", "9999999", "Mardin")]
    [InlineData("04842000000", "484", "2000000", "Siirt")]
    [InlineData("04849999999", "484", "9999999", "Siirt")]
    [InlineData("04862000000", "486", "2000000", "Şırnak")]
    [InlineData("04869999999", "486", "9999999", "Şırnak")]
    [InlineData("04882000000", "488", "2000000", "Batman")]
    [InlineData("04889999999", "488", "9999999", "Batman")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Turkey, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
