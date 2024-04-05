namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Montenegro <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_ME_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Montenegro);

    [Theory]
    [InlineData("020000000", "20", "000000", "Podgorica, Tuzi, Danilovgrad, Kolašin")]
    [InlineData("020999999", "20", "999999", "Podgorica, Tuzi, Danilovgrad, Kolašin")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montenegro, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("030000000", "30", "000000", "Bar, Ulcinj")]
    [InlineData("030999999", "30", "999999", "Bar, Ulcinj")]
    [InlineData("031000000", "31", "000000", "Herceg Novi")]
    [InlineData("031999999", "31", "999999", "Herceg Novi")]
    [InlineData("032000000", "32", "000000", "Kotor, Tivat")]
    [InlineData("032999999", "32", "999999", "Kotor, Tivat")]
    [InlineData("033000000", "33", "000000", "Budva")]
    [InlineData("033999999", "33", "999999", "Budva")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montenegro, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("040000000", "40", "000000", "Nikšić, Šavnik, Plužine")]
    [InlineData("040999999", "40", "999999", "Nikšić, Šavnik, Plužine")]
    [InlineData("041000000", "41", "000000", "Cetinje")]
    [InlineData("041999999", "41", "999999", "Cetinje")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montenegro, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("050000000", "50", "000000", "Bijelo Polje, Mojkovac")]
    [InlineData("050999999", "50", "999999", "Bijelo Polje, Mojkovac")]
    [InlineData("051000000", "51", "000000", "Berane, Andrijevica, Rožaje, Plav, Petnjica, Gusinje")]
    [InlineData("051999999", "51", "999999", "Berane, Andrijevica, Rožaje, Plav, Petnjica, Gusinje")]
    [InlineData("052000000", "52", "000000", "Pljevlja, Žabljak")]
    [InlineData("052999999", "52", "999999", "Pljevlja, Žabljak")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montenegro, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
