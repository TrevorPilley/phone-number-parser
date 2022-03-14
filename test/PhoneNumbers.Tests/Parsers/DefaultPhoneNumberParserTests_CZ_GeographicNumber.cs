namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Czech republic <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CZ_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CzechRepublic);

    [Theory]
    [InlineData("200000000", "2", "00000000", "Capital Praha and Region Stredocesky")]
    [InlineData("299999999", "2", "99999999", "Capital Praha and Region Stredocesky")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("310000000", "31", "0000000", "Capital Praha and Region Stredocesky")]
    [InlineData("319999999", "31", "9999999", "Capital Praha and Region Stredocesky")]
    [InlineData("320000000", "32", "0000000", "Capital Praha and Region Stredocesky")]
    [InlineData("329999999", "32", "9999999", "Capital Praha and Region Stredocesky")]
    [InlineData("350000000", "35", "0000000", "Region Karlovarsky")]
    [InlineData("359999999", "35", "9999999", "Region Karlovarsky")]
    [InlineData("370000000", "37", "0000000", "Region Plzensky")]
    [InlineData("379999999", "37", "9999999", "Region Plzensky")]
    [InlineData("380000000", "38", "0000000", "Region Jihocesky")]
    [InlineData("389999999", "38", "9999999", "Region Jihocesky")]
    [InlineData("390000000", "39", "0000000", "Region Jihocesky")]
    [InlineData("399999999", "39", "9999999", "Region Jihocesky")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("410000000", "41", "0000000", "Region Ustecky")]
    [InlineData("419999999", "41", "9999999", "Region Ustecky")]
    [InlineData("460000000", "46", "0000000", "Region Pardubicky")]
    [InlineData("469999999", "46", "9999999", "Region Pardubicky")]
    [InlineData("470000000", "47", "0000000", "Region Ustecky")]
    [InlineData("479999999", "47", "9999999", "Region Ustecky")]
    [InlineData("480000000", "48", "0000000", "Region Liberecky")]
    [InlineData("489999999", "48", "9999999", "Region Liberecky")]
    [InlineData("490000000", "49", "0000000", "Region Kralovehradecky")]
    [InlineData("499999999", "49", "9999999", "Region Kralovehradecky")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("510000000", "51", "0000000", "Region Jihomoravsky")]
    [InlineData("519999999", "51", "9999999", "Region Jihomoravsky")]
    [InlineData("530000000", "53", "0000000", "Region Jihomoravsky")]
    [InlineData("539999999", "53", "9999999", "Region Jihomoravsky")]
    [InlineData("540000000", "54", "0000000", "Region Jihomoravsky")]
    [InlineData("549999999", "54", "9999999", "Region Jihomoravsky")]
    [InlineData("550000000", "55", "0000000", "Region Moravskoslezsky")]
    [InlineData("559999999", "55", "9999999", "Region Moravskoslezsky")]
    [InlineData("560000000", "56", "0000000", "Region Vysocina")]
    [InlineData("569999999", "56", "9999999", "Region Vysocina")]
    [InlineData("570000000", "57", "0000000", "Region Zlinsky")]
    [InlineData("579999999", "57", "9999999", "Region Zlinsky")]
    [InlineData("580000000", "58", "0000000", "Region Olomoucky")]
    [InlineData("589999999", "58", "9999999", "Region Olomoucky")]
    [InlineData("590000000", "59", "0000000", "Region Moravskoslezsky")]
    [InlineData("599999999", "59", "9999999", "Region Moravskoslezsky")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
