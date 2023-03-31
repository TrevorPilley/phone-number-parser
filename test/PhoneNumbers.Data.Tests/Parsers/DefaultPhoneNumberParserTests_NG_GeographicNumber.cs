namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Nigeria <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_NG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Nigeria);

    [Theory]
    [InlineData("012240000", "1", "2240000", "Lagos")]
    [InlineData("012289999", "1", "2289999", "Lagos")]
    [InlineData("012290000", "1", "2290000", "Lagos")]
    [InlineData("012299999", "1", "2299999", "Lagos")]
    [InlineData("012350000", "1", "2350000", "Lagos")]
    [InlineData("012369999", "1", "2369999", "Lagos")]
    [InlineData("012490000", "1", "2490000", "Lagos")]
    [InlineData("012499999", "1", "2499999", "Lagos")]
    [InlineData("012520000", "1", "2520000", "Lagos")]
    [InlineData("012529999", "1", "2529999", "Lagos")]
    [InlineData("012550000", "1", "2550000", "Lagos")]
    [InlineData("012559999", "1", "2559999", "Lagos")]
    [InlineData("012700000", "1", "2700000", "Lagos")]
    [InlineData("012719999", "1", "2719999", "Lagos")]
    [InlineData("012770000", "1", "2770000", "Lagos")]
    [InlineData("012809999", "1", "2809999", "Lagos")]
    [InlineData("012900000", "1", "2900000", "Lagos")]
    [InlineData("012939999", "1", "2939999", "Lagos")]
    [InlineData("012950000", "1", "2950000", "Lagos")]
    [InlineData("012959999", "1", "2959999", "Lagos")]
    [InlineData("013420000", "1", "3420000", "Lagos")]
    [InlineData("013424999", "1", "3424999", "Lagos")]
    [InlineData("013430000", "1", "3430000", "Lagos")]
    [InlineData("013489999", "1", "3489999", "Lagos")]
    [InlineData("014220000", "1", "4220000", "Lagos")]
    [InlineData("014249999", "1", "4249999", "Lagos")]
    [InlineData("014480000", "1", "4480000", "Lagos")]
    [InlineData("014489999", "1", "4489999", "Lagos")]
    [InlineData("014530000", "1", "4530000", "Lagos")]
    [InlineData("014549999", "1", "4549999", "Lagos")]
    [InlineData("014600000", "1", "4600000", "Lagos")]
    [InlineData("014699999", "1", "4699999", "Lagos")]
    [InlineData("014700000", "1", "4700000", "Lagos")]
    [InlineData("014799999", "1", "4799999", "Lagos")]
    [InlineData("014900000", "1", "4900000", "Lagos")]
    [InlineData("014904999", "1", "4904999", "Lagos")]
    [InlineData("015010000", "1", "5010000", "Lagos")]
    [InlineData("015039999", "1", "5039999", "Lagos")]
    [InlineData("015150000", "1", "5150000", "Lagos")]
    [InlineData("015169999", "1", "5169999", "Lagos")]
    [InlineData("015200000", "1", "5200000", "Lagos")]
    [InlineData("015299999", "1", "5299999", "Lagos")]
    [InlineData("016280000", "1", "6280000", "Lagos")]
    [InlineData("016389999", "1", "6389999", "Lagos")]
    [InlineData("017000000", "1", "7000000", "Lagos")]
    [InlineData("017009999", "1", "7009999", "Lagos")]
    [InlineData("017100000", "1", "7100000", "Lagos")]
    [InlineData("017159999", "1", "7159999", "Lagos")]
    [InlineData("018880000", "1", "8880000", "Lagos")]
    [InlineData("018889999", "1", "8889999", "Lagos")]
    [InlineData("019030000", "1", "9030000", "Lagos")]
    [InlineData("019159999", "1", "9159999", "Lagos")]
    public void Parse_Known_GeographicPhoneNumber_1_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("022900000", "2", "2900000", "Ibadan")]
    [InlineData("022900499", "2", "2900499", "Ibadan")]
    [InlineData("022910000", "2", "2910000", "Ibadan")]
    [InlineData("022919999", "2", "2919999", "Ibadan")]
    [InlineData("024610000", "2", "4610000", "Ibadan")]
    [InlineData("024619999", "2", "4619999", "Ibadan")]
    [InlineData("026280000", "2", "6280000", "Ibadan")]
    [InlineData("026289999", "2", "6289999", "Ibadan")]
    [InlineData("029030000", "2", "9030000", "Ibadan")]
    [InlineData("029059999", "2", "9059999", "Ibadan")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("031290000", "31", "290000", "Ilorin")]
    [InlineData("031299999", "31", "299999", "Ilorin")]
    [InlineData("031460000", "31", "460000", "Ilorin")]
    [InlineData("031469999", "31", "469999", "Ilorin")]
    [InlineData("037930000", "37", "930000", "Ijebu Ode")]
    [InlineData("037959999", "37", "959999", "Ijebu Ode")]
    [InlineData("039270000", "39", "270000", "Abeokuta")]
    [InlineData("039270499", "39", "270499", "Abeokuta")]
    [InlineData("039290000", "39", "290000", "Abeokuta")]
    [InlineData("039299999", "39", "299999", "Abeokuta")]
    [InlineData("039930000", "39", "930000", "Abeokuta")]
    [InlineData("039949999", "39", "949999", "Abeokuta")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("042290000", "42", "290000", "Enugu")]
    [InlineData("042299999", "42", "299999", "Enugu")]
    [InlineData("042660000", "42", "660000", "Enugu")]
    [InlineData("042669999", "42", "669999", "Enugu")]
    [InlineData("043290000", "43", "290000", "Abakaliki")]
    [InlineData("043299999", "43", "299999", "Abakaliki")]
    [InlineData("046280000", "46", "280000", "Onitsha")]
    [InlineData("046290999", "46", "290999", "Onitsha")]
    [InlineData("046660000", "46", "660000", "Onitsha")]
    [InlineData("046669999", "46", "669999", "Onitsha")]
    [InlineData("047630000", "47", "630000", "Lafia")]
    [InlineData("047630999", "47", "630999", "Lafia")]
    [InlineData("048290000", "48", "290000", "Awka")]
    [InlineData("048299999", "48", "299999", "Awka")]
    [InlineData("048880000", "48", "880000", "Awka")]
    [InlineData("048889999", "48", "889999", "Awka")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("052290000", "52", "290000", "Benin")]
    [InlineData("052299999", "52", "299999", "Benin")]
    [InlineData("052930000", "52", "930000", "Benin")]
    [InlineData("052969999", "52", "969999", "Benin")]
    [InlineData("053270000", "53", "270000", "Warri")]
    [InlineData("053270999", "53", "270999", "Warri")]
    [InlineData("053290000", "53", "290000", "Warri")]
    [InlineData("053299999", "53", "299999", "Warri")]
    [InlineData("053460000", "53", "460000", "Warri")]
    [InlineData("053469999", "53", "469999", "Warri")]
    [InlineData("053930000", "53", "930000", "Warri")]
    [InlineData("053949999", "53", "949999", "Warri")]
    [InlineData("055290000", "55", "290000", "Agbor")]
    [InlineData("055299999", "55", "299999", "Agbor")]
    [InlineData("056290000", "56", "290000", "Asaba")]
    [InlineData("056299999", "56", "299999", "Asaba")]
    [InlineData("056930000", "56", "930000", "Asaba")]
    [InlineData("056949999", "56", "949999", "Asaba")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("062270000", "62", "270000", "Kaduna")]
    [InlineData("062270999", "62", "270999", "Kaduna")]
    [InlineData("062290000", "62", "290000", "Kaduna")]
    [InlineData("062299999", "62", "299999", "Kaduna")]
    [InlineData("062370000", "62", "370000", "Kaduna")]
    [InlineData("062399999", "62", "399999", "Kaduna")]
    [InlineData("062460000", "62", "460000", "Kaduna")]
    [InlineData("062469999", "62", "469999", "Kaduna")]
    [InlineData("062930000", "62", "930000", "Kaduna")]
    [InlineData("062969999", "62", "969999", "Kaduna")]
    [InlineData("064270000", "64", "270000", "Kano")]
    [InlineData("064270999", "64", "270999", "Kano")]
    [InlineData("064290000", "64", "290000", "Kano")]
    [InlineData("064290499", "64", "290499", "Kano")]
    [InlineData("064310000", "64", "310000", "Kano")]
    [InlineData("064339999", "64", "339999", "Kano")]
    [InlineData("064400000", "64", "400000", "Kano")]
    [InlineData("064409999", "64", "409999", "Kano")]
    [InlineData("064430000", "64", "430000", "Kano")]
    [InlineData("064439999", "64", "439999", "Kano")]
    [InlineData("064460000", "64", "460000", "Kano")]
    [InlineData("064469999", "64", "469999", "Kano")]
    [InlineData("064700000", "64", "700000", "Kano")]
    [InlineData("064749999", "64", "749999", "Kano")]
    [InlineData("064830000", "64", "830000", "Kano")]
    [InlineData("064869999", "64", "869999", "Kano")]
    [InlineData("065290000", "65", "290000", "Katsina")]
    [InlineData("065299999", "65", "299999", "Katsina")]
    [InlineData("066930000", "66", "930000", "Minna")]
    [InlineData("066949999", "66", "949999", "Minna")]
    [InlineData("069290000", "69", "290000", "Zaria")]
    [InlineData("069299999", "69", "299999", "Zaria")]
    [InlineData("069370000", "69", "370000", "Zaria")]
    [InlineData("069389999", "69", "389999", "Zaria")]
    [InlineData("069930000", "69", "930000", "Zaria")]
    [InlineData("069959999", "69", "959999", "Zaria")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("073290000", "73", "290000", "Jos")]
    [InlineData("073299999", "73", "299999", "Jos")]
    [InlineData("076290000", "76", "290000", "Maiduguri")]
    [InlineData("076299999", "76", "299999", "Maiduguri")]
    [InlineData("076370000", "76", "370000", "Maiduguri")]
    [InlineData("076399999", "76", "399999", "Maiduguri")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("082290000", "82", "290000", "Aba")]
    [InlineData("082299999", "82", "299999", "Aba")]
    [InlineData("082440000", "82", "440000", "Aba")]
    [InlineData("082449999", "82", "449999", "Aba")]
    [InlineData("082460000", "82", "460000", "Aba")]
    [InlineData("082469999", "82", "469999", "Aba")]
    [InlineData("082550000", "82", "550000", "Aba")]
    [InlineData("082559999", "82", "559999", "Aba")]
    [InlineData("083430000", "83", "430000", "Owerri")]
    [InlineData("083439999", "83", "439999", "Owerri")]
    [InlineData("083660000", "83", "660000", "Owerri")]
    [InlineData("083669999", "83", "669999", "Owerri")]
    [InlineData("084200000", "84", "200000", "Port Harcourt")]
    [InlineData("084209999", "84", "209999", "Port Harcourt")]
    [InlineData("084270000", "84", "270000", "Port Harcourt")]
    [InlineData("084270999", "84", "270999", "Port Harcourt")]
    [InlineData("084280000", "84", "280000", "Port Harcourt")]
    [InlineData("084289999", "84", "289999", "Port Harcourt")]
    [InlineData("084290000", "84", "290000", "Port Harcourt")]
    [InlineData("084290999", "84", "290999", "Port Harcourt")]
    [InlineData("084300000", "84", "300000", "Port Harcourt")]
    [InlineData("084309999", "84", "309999", "Port Harcourt")]
    [InlineData("084360000", "84", "360000", "Port Harcourt")]
    [InlineData("084364999", "84", "364999", "Port Harcourt")]
    [InlineData("084440000", "84", "440000", "Port Harcourt")]
    [InlineData("084449999", "84", "449999", "Port Harcourt")]
    [InlineData("084450000", "84", "450000", "Port Harcourt")]
    [InlineData("084459999", "84", "459999", "Port Harcourt")]
    [InlineData("084460000", "84", "460000", "Port Harcourt")]
    [InlineData("084469999", "84", "469999", "Port Harcourt")]
    [InlineData("084550000", "84", "550000", "Port Harcourt")]
    [InlineData("084559999", "84", "559999", "Port Harcourt")]
    [InlineData("084570000", "84", "570000", "Port Harcourt")]
    [InlineData("084579999", "84", "579999", "Port Harcourt")]
    [InlineData("084630000", "84", "630000", "Port Harcourt")]
    [InlineData("084639999", "84", "639999", "Port Harcourt")]
    [InlineData("084650000", "84", "650000", "Port Harcourt")]
    [InlineData("084659999", "84", "659999", "Port Harcourt")]
    [InlineData("084660000", "84", "660000", "Port Harcourt")]
    [InlineData("084669999", "84", "669999", "Port Harcourt")]
    [InlineData("084700000", "84", "700000", "Port Harcourt")]
    [InlineData("084704999", "84", "704999", "Port Harcourt")]
    [InlineData("084930000", "84", "930000", "Port Harcourt")]
    [InlineData("084939999", "84", "939999", "Port Harcourt")]
    [InlineData("084940000", "84", "940000", "Port Harcourt")]
    [InlineData("084949999", "84", "949999", "Port Harcourt")]
    [InlineData("085290000", "85", "290000", "Uyo")]
    [InlineData("085299999", "85", "299999", "Uyo")]
    [InlineData("085660000", "85", "660000", "Uyo")]
    [InlineData("085669999", "85", "669999", "Uyo")]
    [InlineData("085900000", "85", "900000", "Uyo")]
    [InlineData("085902999", "85", "902999", "Uyo")]
    [InlineData("087290000", "87", "290000", "Calabar")]
    [InlineData("087299999", "87", "299999", "Calabar")]
    [InlineData("087460000", "87", "460000", "Calabar")]
    [InlineData("087469999", "87", "469999", "Calabar")]
    [InlineData("087660000", "87", "660000", "Calabar")]
    [InlineData("087669999", "87", "669999", "Calabar")]
    [InlineData("087770000", "87", "770000", "Calabar")]
    [InlineData("087779999", "87", "779999", "Calabar")]
    [InlineData("088290000", "88", "290000", "Umuahia")]
    [InlineData("088299999", "88", "299999", "Umuahia")]
    [InlineData("088660000", "88", "660000", "Umuahia")]
    [InlineData("088669999", "88", "669999", "Umuahia")]
    [InlineData("089460000", "89", "460000", "Yenegoa")]
    [InlineData("089469999", "89", "469999", "Yenegoa")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("092770000", "9", "2770000", "Abuja")]
    [InlineData("092780999", "9", "2780999", "Abuja")]
    [InlineData("092900000", "9", "2900000", "Abuja")]
    [InlineData("092929999", "9", "2929999", "Abuja")]
    [InlineData("092990000", "9", "2990000", "Abuja")]
    [InlineData("092999999", "9", "2999999", "Abuja")]
    [InlineData("093010000", "9", "3010000", "Abuja")]
    [InlineData("093014999", "9", "3014999", "Abuja")]
    [InlineData("093050000", "9", "3050000", "Abuja")]
    [InlineData("093059999", "9", "3059999", "Abuja")]
    [InlineData("094500000", "9", "4500000", "Abuja")]
    [InlineData("094509999", "9", "4509999", "Abuja")]
    [InlineData("094600000", "9", "4600000", "Abuja")]
    [InlineData("095150000", "9", "5150000", "Abuja")]
    [InlineData("095154999", "9", "5154999", "Abuja")]
    [InlineData("096049999", "9", "6049999", "Abuja")]
    [InlineData("096230000", "9", "6230000", "Abuja")]
    [InlineData("096249999", "9", "6249999", "Abuja")]
    [InlineData("096700000", "9", "6700000", "Abuja")]
    [InlineData("096749999", "9", "6749999", "Abuja")]
    [InlineData("097000000", "9", "7000000", "Abuja")]
    [InlineData("097004999", "9", "7004999", "Abuja")]
    [InlineData("099030000", "9", "9030000", "Abuja")]
    [InlineData("099049999", "9", "9049999", "Abuja")]
    public void Parse_Known_GeographicPhoneNumber_9_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
