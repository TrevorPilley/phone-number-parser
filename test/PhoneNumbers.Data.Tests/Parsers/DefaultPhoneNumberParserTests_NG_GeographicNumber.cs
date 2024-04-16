namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Nigeria <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_NG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Nigeria);

    [Theory]
    [InlineData("02012000000", "201", "2000000", "Lagos")]
    [InlineData("02019999999", "201", "9999999", "Lagos")]
    [InlineData("02022000000", "202", "2000000", "Ibadan")]
    [InlineData("02029999999", "202", "9999999", "Ibadan")]
    [InlineData("02092000000", "209", "2000000", "Abuja")]
    [InlineData("02099999999", "209", "9999999", "Abuja")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
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
    [InlineData("02030200000", "2030", "200000", "Ado-Ekiti")]
    [InlineData("02030999999", "2030", "999999", "Ado-Ekiti")]
    [InlineData("02031200000", "2031", "200000", "Ilorin")]
    [InlineData("02031999999", "2031", "999999", "Ilorin")]
    [InlineData("02033200000", "2033", "200000", "New Bussa")]
    [InlineData("02033999999", "2033", "999999", "New Bussa")]
    [InlineData("02034200000", "2034", "200000", "Akure")]
    [InlineData("02034999999", "2034", "999999", "Akure")]
    [InlineData("02035200000", "2035", "200000", "Osogbo")]
    [InlineData("02035999999", "2035", "999999", "Osogbo")]
    [InlineData("02036200000", "2036", "200000", "Ile-Ife")]
    [InlineData("02036999999", "2036", "999999", "Ile-Ife")]
    [InlineData("02037200000", "2037", "200000", "Ijebu Ode")]
    [InlineData("02037999999", "2037", "999999", "Ijebu Ode")]
    [InlineData("02038200000", "2038", "200000", "Oyo")]
    [InlineData("02038999999", "2038", "999999", "Oyo")]
    [InlineData("02039200000", "2039", "200000", "Abeokuta")]
    [InlineData("02039999999", "2039", "999999", "Abeokuta")]
    [InlineData("02041200000", "2041", "200000", "Wukari")]
    [InlineData("02041999999", "2041", "999999", "Wukari")]
    [InlineData("02042200000", "2042", "200000", "Nsukka-Enugu")]
    [InlineData("02042999999", "2042", "999999", "Nsukka-Enugu")]
    [InlineData("02043200000", "2043", "200000", "Abakaliki")]
    [InlineData("02043999999", "2043", "999999", "Abakaliki")]
    [InlineData("02044200000", "2044", "200000", "Makurdi")]
    [InlineData("02044999999", "2044", "999999", "Makurdi")]
    [InlineData("02045200000", "2045", "200000", "Ogoja")]
    [InlineData("02045999999", "2045", "999999", "Ogoja")]
    [InlineData("02046200000", "2046", "200000", "Onitsha")]
    [InlineData("02046999999", "2046", "999999", "Onitsha")]
    [InlineData("02047200000", "2047", "200000", "Lafia/Keffi")]
    [InlineData("02047999999", "2047", "999999", "Lafia/Keffi")]
    [InlineData("02048200000", "2048", "200000", "Awka")]
    [InlineData("02048999999", "2048", "999999", "Awka")]
    [InlineData("02050200000", "2050", "200000", "Ikare")]
    [InlineData("02050999999", "2050", "999999", "Ikare")]
    [InlineData("02052200000", "2052", "200000", "Benin-City")]
    [InlineData("02052999999", "2052", "999999", "Benin-City")]
    [InlineData("02053200000", "2053", "200000", "Warri")]
    [InlineData("02053999999", "2053", "999999", "Warri")]
    [InlineData("02054200000", "2054", "200000", "Sapele")]
    [InlineData("02054999999", "2054", "999999", "Sapele")]
    [InlineData("02055200000", "2055", "200000", "Agbor")]
    [InlineData("02055999999", "2055", "999999", "Agbor")]
    [InlineData("02056200000", "2056", "200000", "Asaba")]
    [InlineData("02056999999", "2056", "999999", "Asaba")]
    [InlineData("02057200000", "2057", "200000", "Auchi")]
    [InlineData("02057999999", "2057", "999999", "Auchi")]
    [InlineData("02058200000", "2058", "200000", "Lokoja")]
    [InlineData("02058999999", "2058", "999999", "Lokoja")]
    [InlineData("02059200000", "2059", "200000", "Okitipupa")]
    [InlineData("02059999999", "2059", "999999", "Okitipupa")]
    [InlineData("02060200000", "2060", "200000", "Sokoto")]
    [InlineData("02060999999", "2060", "999999", "Sokoto")]
    [InlineData("02062200000", "2062", "200000", "Kaduna")]
    [InlineData("02062999999", "2062", "999999", "Kaduna")]
    [InlineData("02064200000", "2064", "200000", "Kano")]
    [InlineData("02064999999", "2064", "999999", "Kano")]
    [InlineData("02065200000", "2065", "200000", "Katsina")]
    [InlineData("02065999999", "2065", "999999", "Katsina")]
    [InlineData("02066200000", "2066", "200000", "Minna")]
    [InlineData("02066999999", "2066", "999999", "Minna")]
    [InlineData("02068200000", "2068", "200000", "Birnin-Kebbi")]
    [InlineData("02068999999", "2068", "999999", "Birnin-Kebbi")]
    [InlineData("02069200000", "2069", "200000", "Zaria")]
    [InlineData("02069999999", "2069", "999999", "Zaria")]
    [InlineData("02071200000", "2071", "200000", "Azare")]
    [InlineData("02071999999", "2071", "999999", "Azare")]
    [InlineData("02072200000", "2072", "200000", "Gombe")]
    [InlineData("02072999999", "2072", "999999", "Gombe")]
    [InlineData("02073200000", "2073", "200000", "Jos")]
    [InlineData("02073999999", "2073", "999999", "Jos")]
    [InlineData("02074200000", "2074", "200000", "Damaturu")]
    [InlineData("02074999999", "2074", "999999", "Damaturu")]
    [InlineData("02075200000", "2075", "200000", "Yola")]
    [InlineData("02075999999", "2075", "999999", "Yola")]
    [InlineData("02076200000", "2076", "200000", "Maiduguri")]
    [InlineData("02076999999", "2076", "999999", "Maiduguri")]
    [InlineData("02077200000", "2077", "200000", "Bauchi")]
    [InlineData("02077999999", "2077", "999999", "Bauchi")]
    [InlineData("02079200000", "2079", "200000", "Jalingo")]
    [InlineData("02079999999", "2079", "999999", "Jalingo")]
    [InlineData("02082200000", "2082", "200000", "Aba")]
    [InlineData("02082999999", "2082", "999999", "Aba")]
    [InlineData("02083200000", "2083", "200000", "Owerri")]
    [InlineData("02083999999", "2083", "999999", "Owerri")]
    [InlineData("02084200000", "2084", "200000", "Port-Harcourt")]
    [InlineData("02084999999", "2084", "999999", "Port-Harcourt")]
    [InlineData("02085200000", "2085", "200000", "Uyo")]
    [InlineData("02085999999", "2085", "999999", "Uyo")]
    [InlineData("02086200000", "2086", "200000", "Ahoada")]
    [InlineData("02086999999", "2086", "999999", "Ahoada")]
    [InlineData("02087200000", "2087", "200000", "Calabar")]
    [InlineData("02087999999", "2087", "999999", "Calabar")]
    [InlineData("02088200000", "2088", "200000", "Umuahia")]
    [InlineData("02088999999", "2088", "999999", "Umuahia")]
    [InlineData("02089200000", "2089", "200000", "Yenegoa")]
    [InlineData("02089999999", "2089", "999999", "Yenegoa")]
    public void Parse_Known_GeographicPhoneNumber_2XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
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
