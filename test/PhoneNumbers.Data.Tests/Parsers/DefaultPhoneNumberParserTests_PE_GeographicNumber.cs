namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Peru <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_PE_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Peru);

    [Theory]
    [InlineData("010000000", "1", "0000000", "Lima and Callao")]
    [InlineData("019999999", "1", "9999999", "Lima and Callao")]
    public void Parse_Known_GeographicPhoneNumber_1_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Peru, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("041000000", "41", "000000", "Amazonas")]
    [InlineData("041999999", "41", "999999", "Amazonas")]
    [InlineData("042000000", "42", "000000", "San Martín")]
    [InlineData("042999999", "42", "999999", "San Martín")]
    [InlineData("043000000", "43", "000000", "Ancash")]
    [InlineData("043999999", "43", "999999", "Ancash")]
    [InlineData("044000000", "44", "000000", "La Libertad")]
    [InlineData("044999999", "44", "999999", "La Libertad")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Peru, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("051000000", "51", "000000", "Puno")]
    [InlineData("051999999", "51", "999999", "Puno")]
    [InlineData("052000000", "52", "000000", "Tacna")]
    [InlineData("052999999", "52", "999999", "Tacna")]
    [InlineData("053000000", "53", "000000", "Moquegua")]
    [InlineData("053999999", "53", "999999", "Moquegua")]
    [InlineData("054000000", "54", "000000", "Arequipa")]
    [InlineData("054999999", "54", "999999", "Arequipa")]
    [InlineData("056000000", "56", "000000", "Ica")]
    [InlineData("056999999", "56", "999999", "Ica")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Peru, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("061000000", "61", "000000", "Ucayali")]
    [InlineData("061999999", "61", "999999", "Ucayali")]
    [InlineData("062000000", "62", "000000", "Huanuco")]
    [InlineData("062999999", "62", "999999", "Huanuco")]
    [InlineData("063000000", "63", "000000", "Pasco")]
    [InlineData("063999999", "63", "999999", "Pasco")]
    [InlineData("064000000", "64", "000000", "Junin")]
    [InlineData("064999999", "64", "999999", "Junin")]
    [InlineData("065000000", "65", "000000", "Loreto")]
    [InlineData("065999999", "65", "999999", "Loreto")]
    [InlineData("066000000", "66", "000000", "Ayacucho")]
    [InlineData("066999999", "66", "999999", "Ayacucho")]
    [InlineData("067000000", "67", "000000", "Huancavelica")]
    [InlineData("067999999", "67", "999999", "Huancavelica")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Peru, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("072000000", "72", "000000", "Tumbes")]
    [InlineData("072999999", "72", "999999", "Tumbes")]
    [InlineData("073000000", "73", "000000", "Plura")]
    [InlineData("073999999", "73", "999999", "Plura")]
    [InlineData("074000000", "74", "000000", "Lambayeque")]
    [InlineData("074999999", "74", "999999", "Lambayeque")]
    [InlineData("076000000", "76", "000000", "Cajamarca")]
    [InlineData("076999999", "76", "999999", "Cajamarca")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Peru, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("082000000", "82", "000000", "Madre de Dios")]
    [InlineData("082999999", "82", "999999", "Madre de Dios")]
    [InlineData("083000000", "83", "000000", "Apurimac")]
    [InlineData("083999999", "83", "999999", "Apurimac")]
    [InlineData("084000000", "84", "000000", "Cuzco")]
    [InlineData("084999999", "84", "999999", "Cuzco")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Peru, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
