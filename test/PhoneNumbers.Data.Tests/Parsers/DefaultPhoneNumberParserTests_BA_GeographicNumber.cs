namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bosnia and herzegovina <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BA_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.BosniaAndHerzegovina);

    [Theory]
    [InlineData("030000000", "30", "000000", "Central Bosnia Canton")]
    [InlineData("030999999", "30", "999999", "Central Bosnia Canton")]
    [InlineData("031000000", "31", "000000", "Posavina Canton")]
    [InlineData("031999999", "31", "999999", "Posavina Canton")]
    [InlineData("032000000", "32", "000000", "Zenica-Doboj Canton")]
    [InlineData("032999999", "32", "999999", "Zenica-Doboj Canton")]
    [InlineData("033000000", "33", "000000", "Sarajevo Canton")]
    [InlineData("033999999", "33", "999999", "Sarajevo Canton")]
    [InlineData("034000000", "34", "000000", "Canton 10")]
    [InlineData("034999999", "34", "999999", "Canton 10")]
    [InlineData("035000000", "35", "000000", "Tuzla Canton")]
    [InlineData("035999999", "35", "999999", "Tuzla Canton")]
    [InlineData("036000000", "36", "000000", "Hercegovina-Neretva Canton")]
    [InlineData("036999999", "36", "999999", "Hercegovina-Neretva Canton")]
    [InlineData("037000000", "37", "000000", "Unsa-Sana Canton")]
    [InlineData("037999999", "37", "999999", "Unsa-Sana Canton")]
    [InlineData("038000000", "38", "000000", "Bosanian-Podrinje Goražde Canton")]
    [InlineData("038999999", "38", "999999", "Bosanian-Podrinje Goražde Canton")]
    [InlineData("039000000", "39", "000000", "West Herzegovina Canton")]
    [InlineData("039999999", "39", "999999", "West Herzegovina Canton")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BosniaAndHerzegovina, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("049000000", "49", "000000", "Brčko Distirct B&H")]
    [InlineData("049999999", "49", "999999", "Brčko Distirct B&H")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BosniaAndHerzegovina, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("050000000", "50", "000000", "Mrkonjić Grad")]
    [InlineData("050999999", "50", "999999", "Mrkonjić Grad")]
    [InlineData("051000000", "51", "000000", "Banja Luka")]
    [InlineData("051999999", "51", "999999", "Banja Luka")]
    [InlineData("052000000", "52", "000000", "Prijedor")]
    [InlineData("052999999", "52", "999999", "Prijedor")]
    [InlineData("053000000", "53", "000000", "Doboj")]
    [InlineData("053999999", "53", "999999", "Doboj")]
    [InlineData("054000000", "54", "000000", "Šamac")]
    [InlineData("054999999", "54", "999999", "Šamac")]
    [InlineData("055000000", "55", "000000", "Bijeljina")]
    [InlineData("055999999", "55", "999999", "Bijeljina")]
    [InlineData("056000000", "56", "000000", "Zvornik")]
    [InlineData("056999999", "56", "999999", "Zvornik")]
    [InlineData("057000000", "57", "000000", "Istočno Sarajevo")]
    [InlineData("057999999", "57", "999999", "Istočno Sarajevo")]
    [InlineData("058000000", "58", "000000", "Foča")]
    [InlineData("058999999", "58", "999999", "Foča")]
    [InlineData("059000000", "59", "000000", "Trebinje")]
    [InlineData("059999999", "59", "999999", "Trebinje")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BosniaAndHerzegovina, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
