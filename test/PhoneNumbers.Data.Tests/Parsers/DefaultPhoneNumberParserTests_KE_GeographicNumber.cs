namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Kenya <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KE_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Kenya);

    [Theory]
    [InlineData("020000000", "20", "000000", "Nairobi")]
    [InlineData("0209999999", "20", "9999999", "Nairobi")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Kenya, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("040000000", "40", "000000", "Kwale")]
    [InlineData("0409999999", "40", "9999999", "Kwale")]
    [InlineData("0410000000", "41", "0000000", "Mombasa")]
    [InlineData("0419999999", "41", "9999999", "Mombasa")]
    [InlineData("04200000", "42", "00000", "Malindi, Lamu and Garsen")]
    [InlineData("0429999999", "42", "9999999", "Malindi, Lamu and Garsen")]
    [InlineData("0430000000", "43", "0000000", "Voi")]
    [InlineData("0439999999", "43", "9999999", "Voi")]
    [InlineData("04400000", "44", "00000", "Machakos, Makueni and Kitui")]
    [InlineData("0449999999", "44", "9999999", "Machakos, Makueni and Kitui")]
    [InlineData("04500000", "45", "00000", "Athi-River, Kajiado and Loitokitok")]
    [InlineData("0459999999", "45", "9999999", "Athi-River, Kajiado and Loitokitok")]
    [InlineData("0460000000", "46", "0000000", "Garissa, Wajir and Mandera")]
    [InlineData("0469999999", "46", "9999999", "Garissa, Wajir and Mandera")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Kenya, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0500000000", "50", "0000000", "Naivasha, Gilgil and Narok of Nakuru region")]
    [InlineData("0509999999", "50", "9999999", "Naivasha, Gilgil and Narok of Nakuru region")]
    [InlineData("051000000", "51", "000000", "Nakuru, Njoro, Molo areas of Nakuru")]
    [InlineData("0519999999", "51", "9999999", "Nakuru, Njoro, Molo areas of Nakuru")]
    [InlineData("05200000", "52", "00000", "Kericho and Bomet")]
    [InlineData("0529999999", "52", "9999999", "Kericho and Bomet")]
    [InlineData("05300000", "53", "00000", "Eldoret, Turbo, Kapsabet, Iten and Kabarnet")]
    [InlineData("0539999999", "53", "9999999", "Eldoret, Turbo, Kapsabet, Iten and Kabarnet")]
    [InlineData("05400000", "54", "00000", "Kitale, Moisbridge, Kapenguria and Lodwar")]
    [InlineData("0549999999", "54", "9999999", "Kitale, Moisbridge, Kapenguria and Lodwar")]
    [InlineData("05500000", "55", "00000", "Bungoma and Busia")]
    [InlineData("0559999999", "55", "9999999", "Bungoma and Busia")]
    [InlineData("05600000", "56", "00000", "Kakamega and Vihiga regions")]
    [InlineData("0569999999", "56", "9999999", "Kakamega and Vihiga regions")]
    [InlineData("05700000", "57", "00000", "Kisumu, and Siaya regions")]
    [InlineData("0579999999", "57", "9999999", "Kisumu, and Siaya regions")]
    [InlineData("0580000000", "58", "0000000", "Kisii, Kilgoris, Oyugis and Nyamira")]
    [InlineData("0589999999", "58", "9999999", "Kisii, Kilgoris, Oyugis and Nyamira")]
    [InlineData("05900000", "59", "00000", "Homabay and Migori")]
    [InlineData("0599999999", "59", "9999999", "Homabay and Migori")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Kenya, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("06000000", "60", "00000", "Muranga and Kirinyaga")]
    [InlineData("0609999999", "60", "9999999", "Muranga and Kirinyaga")]
    [InlineData("06100000", "61", "00000", "Nyeri")]
    [InlineData("0619999999", "61", "9999999", "Nyeri")]
    [InlineData("0620000000", "62", "0000000", "Nanyuki")]
    [InlineData("0629999999", "62", "9999999", "Nanyuki")]
    [InlineData("06400000", "64", "00000", "Meru, Maua and Chuka")]
    [InlineData("0649999999", "64", "9999999", "Meru, Maua and Chuka")]
    [InlineData("066000000", "66", "000000", "Thika and Ruiru")]
    [InlineData("0669999999", "66", "9999999", "Thika and Ruiru")]
    [InlineData("06700000", "67", "00000", "Kiambu and Kikuyu towns")]
    [InlineData("0679999999", "67", "9999999", "Kiambu and Kikuyu towns")]
    [InlineData("0680000000", "68", "0000000", "Embu")]
    [InlineData("0689999999", "68", "9999999", "Embu")]
    [InlineData("06900000", "69", "00000", "Marsabit and Moyale")]
    [InlineData("0699999999", "69", "9999999", "Marsabit and Moyale")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Kenya, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
