namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Nigeria <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_NG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Nigeria);

    [Theory]
    [InlineData("01200000", "1", "200000", "Lagos")]
    [InlineData("019999999", "1", "9999999", "Lagos")]
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
    [InlineData("02200000", "2", "200000", "Ibadan")]
    [InlineData("029999999", "2", "9999999", "Ibadan")]
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
    [InlineData("092000000", "9", "2000000", "Abuja")]
    [InlineData("099999999", "9", "9999999", "Abuja")]
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

    [Theory]
    [InlineData("030200000", "30", "200000", "Ado Ekiti")]
    [InlineData("030999999", "30", "999999", "Ado Ekiti")]
    [InlineData("031200000", "31", "200000", "Ilorin")]
    [InlineData("031999999", "31", "999999", "Ilorin")]
    [InlineData("033200000", "33", "200000", "New Bussa")]
    [InlineData("033999999", "33", "999999", "New Bussa")]
    [InlineData("034200000", "34", "200000", "Akure")]
    [InlineData("034999999", "34", "999999", "Akure")]
    [InlineData("035200000", "35", "200000", "Oshogbo")]
    [InlineData("035999999", "35", "999999", "Oshogbo")]
    [InlineData("036200000", "36", "200000", "Ile Ife")]
    [InlineData("036999999", "36", "999999", "Ile Ife")]
    [InlineData("037200000", "37", "200000", "Ijebu Ode")]
    [InlineData("037999999", "37", "999999", "Ijebu Ode")]
    [InlineData("038200000", "38", "200000", "Oyo")]
    [InlineData("038999999", "38", "999999", "Oyo")]
    [InlineData("039200000", "39", "200000", "Abeokuta")]
    [InlineData("039999999", "39", "999999", "Abeokuta")]
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
    [InlineData("04120000", "41", "20000", "Wukari")]
    [InlineData("04199999", "41", "99999", "Wukari")]
    [InlineData("042200000", "42", "200000", "Enugu")]
    [InlineData("042999999", "42", "999999", "Enugu")]
    [InlineData("043200000", "43", "200000", "Abakaliki")]
    [InlineData("043999999", "43", "999999", "Abakaliki")]
    [InlineData("04420000", "44", "20000", "Makurdi")]
    [InlineData("044999999", "44", "999999", "Makurdi")]
    [InlineData("045200000", "45", "200000", "Ogoja")]
    [InlineData("045999999", "45", "999999", "Ogoja")]
    [InlineData("046200000", "46", "200000", "Onitsha")]
    [InlineData("046999999", "46", "999999", "Onitsha")]
    [InlineData("04720000", "47", "20000", "Lafia")]
    [InlineData("047999999", "47", "999999", "Lafia")]
    [InlineData("048200000", "48", "200000", "Awka")]
    [InlineData("048999999", "48", "999999", "Awka")]
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
    [InlineData("050200000", "50", "200000", "Ikare")]
    [InlineData("050999999", "50", "999999", "Ikare")]
    [InlineData("05120000", "51", "20000", "Owo")]
    [InlineData("051999999", "51", "999999", "Owo")]
    [InlineData("052200000", "52", "200000", "Benin")]
    [InlineData("052999999", "52", "999999", "Benin")]
    [InlineData("053200000", "53", "200000", "Warri")]
    [InlineData("053999999", "53", "999999", "Warri")]
    [InlineData("05420000", "54", "20000", "Sapele")]
    [InlineData("054999999", "54", "999999", "Sapele")]
    [InlineData("05520000", "55", "20000", "Agbor")]
    [InlineData("055999999", "55", "999999", "Agbor")]
    [InlineData("056200000", "56", "200000", "Asaba")]
    [InlineData("056999999", "56", "999999", "Asaba")]
    [InlineData("05720000", "57", "20000", "Auchi")]
    [InlineData("057999999", "57", "999999", "Auchi")]
    [InlineData("058200000", "58", "200000", "Lokoja")]
    [InlineData("058999999", "58", "999999", "Lokoja")]
    [InlineData("05920000", "59", "20000", "Okitipupa")]
    [InlineData("059999999", "59", "999999", "Okitipupa")]
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
    [InlineData("060200000", "60", "200000", "Sokobo")]
    [InlineData("060999999", "60", "999999", "Sokobo")]
    [InlineData("06120000", "61", "20000", "Kafanchau")]
    [InlineData("061999999", "61", "999999", "Kafanchau")]
    [InlineData("062200000", "62", "200000", "Kaduna")]
    [InlineData("062999999", "62", "999999", "Kaduna")]
    [InlineData("063200000", "63", "200000", "Gusau")]
    [InlineData("063999999", "63", "999999", "Gusau")]
    [InlineData("064200000", "64", "200000", "Kano")]
    [InlineData("064999999", "64", "999999", "Kano")]
    [InlineData("06520000", "65", "20000", "Katsina")]
    [InlineData("065999999", "65", "999999", "Katsina")]
    [InlineData("066200000", "66", "200000", "Minna")]
    [InlineData("066999999", "66", "999999", "Minna")]
    [InlineData("06720000", "67", "20000", "Kontagora")]
    [InlineData("067999999", "67", "999999", "Kontagora")]
    [InlineData("06820000", "68", "20000", "Birnin-Kebbi")]
    [InlineData("068999999", "68", "999999", "Birnin-Kebbi")]
    [InlineData("069200000", "69", "200000", "Zaria")]
    [InlineData("069999999", "69", "999999", "Zaria")]
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
    [InlineData("07020000", "70", "20000", "Pank Shin")]
    [InlineData("070999999", "70", "999999", "Pank Shin")]
    [InlineData("07120000", "71", "20000", "Azare")]
    [InlineData("071999999", "71", "999999", "Azare")]
    [InlineData("07220000", "72", "20000", "Gombe")]
    [InlineData("072999999", "72", "999999", "Gombe")]
    [InlineData("07320000", "73", "20000", "Jos")]
    [InlineData("073999999", "73", "999999", "Jos")]
    [InlineData("074200000", "74", "200000", "Damaturu")]
    [InlineData("074999999", "74", "999999", "Damaturu")]
    [InlineData("07520000", "75", "20000", "Yola")]
    [InlineData("075999999", "75", "999999", "Yola")]
    [InlineData("076200000", "76", "200000", "Maiduguri")]
    [InlineData("076999999", "76", "999999", "Maiduguri")]
    [InlineData("07720000", "77", "20000", "Bauchi")]
    [InlineData("077999999", "77", "999999", "Bauchi")]
    [InlineData("078200000", "78", "200000", "Hadejia")]
    [InlineData("078999999", "78", "999999", "Hadejia")]
    [InlineData("079200000", "79", "200000", "Jalingo")]
    [InlineData("079999999", "79", "999999", "Jalingo")]
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
    [InlineData("082200000", "82", "200000", "Aba")]
    [InlineData("082999999", "82", "999999", "Aba")]
    [InlineData("083200000", "83", "200000", "Owerri")]
    [InlineData("083999999", "83", "999999", "Owerri")]
    [InlineData("084200000", "84", "200000", "Port Harcourt")]
    [InlineData("084999999", "84", "999999", "Port Harcourt")]
    [InlineData("085200000", "85", "200000", "Uyo")]
    [InlineData("085999999", "85", "999999", "Uyo")]
    [InlineData("086200000", "86", "200000", "Ahoada")]
    [InlineData("086999999", "86", "999999", "Ahoada")]
    [InlineData("087200000", "87", "200000", "Calabar")]
    [InlineData("087999999", "87", "999999", "Calabar")]
    [InlineData("088200000", "88", "200000", "Umuahia")]
    [InlineData("088999999", "88", "999999", "Umuahia")]
    [InlineData("089200000", "89", "200000", "Yenegoa")]
    [InlineData("089999999", "89", "999999", "Yenegoa")]
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
}
