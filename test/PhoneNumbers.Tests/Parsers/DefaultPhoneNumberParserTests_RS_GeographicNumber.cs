namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Serbia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_RS_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Serbia);

    [Theory]
    [InlineData("0102000000", "10", "2000000", "Pirot")]
    [InlineData("0109999999999", "10", "9999999999", "Pirot")]
    [InlineData("0112000000", "11", "2000000", "Beograd")]
    [InlineData("0119999999999", "11", "9999999999", "Beograd")]
    [InlineData("0122000000", "12", "2000000", "Požarevac")]
    [InlineData("0129999999999", "12", "9999999999", "Požarevac")]
    [InlineData("0132000000", "13", "2000000", "Pančevo")]
    [InlineData("0139999999999", "13", "9999999999", "Pančevo")]
    [InlineData("0142000000", "14", "2000000", "Valjevo")]
    [InlineData("0149999999999", "14", "9999999999", "Valjevo")]
    [InlineData("0152000000", "15", "2000000", "Šabac")]
    [InlineData("0159999999999", "15", "9999999999", "Šabac")]
    [InlineData("0162000000", "16", "2000000", "Leskovac")]
    [InlineData("0169999999999", "16", "9999999999", "Leskovac")]
    [InlineData("0172000000", "17", "2000000", "Vranje")]
    [InlineData("0179999999999", "17", "9999999999", "Vranje")]
    [InlineData("0182000000", "18", "2000000", "Niš")]
    [InlineData("0189999999999", "18", "9999999999", "Niš")]
    [InlineData("0192000000", "19", "2000000", "Zaječar")]
    [InlineData("0199999999999", "19", "9999999999", "Zaječar")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Serbia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0202000000", "20", "2000000", "Novi Pazar")]
    [InlineData("0209999999999", "20", "9999999999", "Novi Pazar")]
    [InlineData("0212000000", "21", "2000000", "Novi Sad")]
    [InlineData("0219999999999", "21", "9999999999", "Novi Sad")]
    [InlineData("0222000000", "22", "2000000", "Sremska Mitrovica")]
    [InlineData("0229999999999", "22", "9999999999", "Sremska Mitrovica")]
    [InlineData("0232000000", "23", "2000000", "Zrenjanin")]
    [InlineData("0239999999999", "23", "9999999999", "Zrenjanin")]
    [InlineData("0242000000", "24", "2000000", "Subotica")]
    [InlineData("0249999999999", "24", "9999999999", "Subotica")]
    [InlineData("0252000000", "25", "2000000", "Sombor")]
    [InlineData("0259999999999", "25", "9999999999", "Sombor")]
    [InlineData("0262000000", "26", "2000000", "Smederevo")]
    [InlineData("0269999999999", "26", "9999999999", "Smederevo")]
    [InlineData("0272000000", "27", "2000000", "Prokuplje")]
    [InlineData("0279999999999", "27", "9999999999", "Prokuplje")]
    [InlineData("0282000000", "28", "2000000", "Kosovska Mitrovica")]
    [InlineData("0289999999999", "28", "9999999999", "Kosovska Mitrovica")]
    [InlineData("0292000000", "29", "2000000", "Prizren")]
    [InlineData("0299999999999", "29", "9999999999", "Prizren")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Serbia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0230200000", "230", "200000", "Kikinda")]
    [InlineData("0230999999999", "230", "999999999", "Kikinda")]
    [InlineData("0280200000", "280", "200000", "Gnjilane")]
    [InlineData("0280999999999", "280", "999999999", "Gnjilane")]
    [InlineData("0290200000", "290", "200000", "Uroševac")]
    [InlineData("0290999999999", "290", "999999999", "Uroševac")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Serbia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0302000000", "30", "2000000", "Bor")]
    [InlineData("0309999999999", "30", "9999999999", "Bor")]
    [InlineData("0312000000", "31", "2000000", "Užice")]
    [InlineData("0319999999999", "31", "9999999999", "Užice")]
    [InlineData("0322000000", "32", "2000000", "Čačak")]
    [InlineData("0329999999999", "32", "9999999999", "Čačak")]
    [InlineData("0332000000", "33", "2000000", "Prijepolje")]
    [InlineData("0339999999999", "33", "9999999999", "Prijepolje")]
    [InlineData("0342000000", "34", "2000000", "Kragujevac (TC)")]
    [InlineData("0349999999999", "34", "9999999999", "Kragujevac (TC)")]
    [InlineData("0352000000", "35", "2000000", "Jagodina")]
    [InlineData("0359999999999", "35", "9999999999", "Jagodina")]
    [InlineData("0362000000", "36", "2000000", "Kraljevo")]
    [InlineData("0369999999999", "36", "9999999999", "Kraljevo")]
    [InlineData("0372000000", "37", "2000000", "Kruševac")]
    [InlineData("0379999999999", "37", "9999999999", "Kruševac")]
    [InlineData("0382000000", "38", "2000000", "Priština")]
    [InlineData("0389999999999", "38", "9999999999", "Priština")]
    [InlineData("0392000000", "39", "2000000", "Peć")]
    [InlineData("0399999999999", "39", "9999999999", "Peć")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Serbia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0390200000", "390", "200000", "Dakovica")]
    [InlineData("0390999999999", "390", "999999999", "Dakovica")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Serbia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
