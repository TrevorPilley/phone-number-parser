namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Croatia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_HR_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Croatia);

    [Theory]
    [InlineData("012000000", "1", "2000000", "Zagreb County and the City of Zagreb")]
    [InlineData("019999999", "1", "9999999", "Zagreb County and the City of Zagreb")]
    public void Parse_Known_GeographicPhoneNumber_1_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("020200000", "20", "200000", "Dubrovnik-Neretva County")]
    [InlineData("0209999999", "20", "9999999", "Dubrovnik-Neretva County")]
    [InlineData("021200000", "21", "200000", "Split-Dalmatia County")]
    [InlineData("0219999999", "21", "9999999", "Split-Dalmatia County")]
    [InlineData("022200000", "22", "200000", "Šibenik-Knin County")]
    [InlineData("0229999999", "22", "9999999", "Šibenik-Knin County")]
    [InlineData("023200000", "23", "200000", "Zadar County")]
    [InlineData("0239999999", "23", "9999999", "Zadar County")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("031200000", "31", "200000", "Osijek-Baranja County")]
    [InlineData("0319999999", "31", "9999999", "Osijek-Baranja County")]
    [InlineData("032200000", "32", "200000", "Vukovar-Srijem County")]
    [InlineData("0329999999", "32", "9999999", "Vukovar-Srijem County")]
    [InlineData("033200000", "33", "200000", "Virovitica-Podravina County")]
    [InlineData("0339999999", "33", "9999999", "Virovitica-Podravina County")]
    [InlineData("034200000", "34", "200000", "Požega-Slavonia County")]
    [InlineData("0349999999", "34", "9999999", "Požega-Slavonia County")]
    [InlineData("035200000", "35", "200000", "Brod-Posavina County")]
    [InlineData("0359999999", "35", "9999999", "Brod-Posavina County")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("040200000", "40", "200000", "Međimurje County")]
    [InlineData("0409999999", "40", "9999999", "Međimurje County")]
    [InlineData("042200000", "42", "200000", "Varaždin County")]
    [InlineData("0429999999", "42", "9999999", "Varaždin County")]
    [InlineData("043200000", "43", "200000", "Bjelovar-Bilogora County")]
    [InlineData("0439999999", "43", "9999999", "Bjelovar-Bilogora County")]
    [InlineData("044200000", "44", "200000", "Sisak-Moslavina County")]
    [InlineData("0449999999", "44", "9999999", "Sisak-Moslavina County")]
    [InlineData("047200000", "47", "200000", "Karlovac County")]
    [InlineData("0479999999", "47", "9999999", "Karlovac County")]
    [InlineData("048200000", "48", "200000", "Koprivnica-Križevci County")]
    [InlineData("0489999999", "48", "9999999", "Koprivnica-Križevci County")]
    [InlineData("049200000", "49", "200000", "Krapina-Zagorje County")]
    [InlineData("0499999999", "49", "9999999", "Krapina-Zagorje County")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("051200000", "51", "200000", "Primorsko-goranska County")]
    [InlineData("0519999999", "51", "9999999", "Primorsko-goranska County")]
    [InlineData("052200000", "52", "200000", "Istra County")]
    [InlineData("0529999999", "52", "9999999", "Istra County")]
    [InlineData("053200000", "53", "200000", "Lika-Senj County")]
    [InlineData("0539999999", "53", "9999999", "Lika-Senj County")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
