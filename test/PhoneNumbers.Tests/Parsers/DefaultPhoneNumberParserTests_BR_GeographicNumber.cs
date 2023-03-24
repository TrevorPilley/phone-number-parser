namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Brazil <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BR_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Brazil);

    [Theory]
    [InlineData("01120000000", "11", "20000000", "São Paulo")]
    [InlineData("01159999999", "11", "59999999", "São Paulo")]
    [InlineData("01920000000", "19", "20000000", "São Paulo")]
    [InlineData("01959999999", "19", "59999999", "São Paulo")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("02120000000", "21", "20000000", "Rio de Janeiro")]
    [InlineData("02159999999", "21", "59999999", "Rio de Janeiro")]
    [InlineData("02220000000", "22", "20000000", "Rio de Janeiro")]
    [InlineData("02259999999", "22", "59999999", "Rio de Janeiro")]
    [InlineData("02420000000", "24", "20000000", "Rio de Janeiro")]
    [InlineData("02459999999", "24", "59999999", "Rio de Janeiro")]
    [InlineData("02720000000", "27", "20000000", "Espirito Santo")]
    [InlineData("02759999999", "27", "59999999", "Espirito Santo")]
    [InlineData("02820000000", "28", "20000000", "Espirito Santo")]
    [InlineData("02859999999", "28", "59999999", "Espirito Santo")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("03120000000", "31", "20000000", "Minas Gerais")]
    [InlineData("03159999999", "31", "59999999", "Minas Gerais")]
    [InlineData("03520000000", "35", "20000000", "Minas Gerais")]
    [InlineData("03559999999", "35", "59999999", "Minas Gerais")]
    [InlineData("03720000000", "37", "20000000", "Minas Gerais")]
    [InlineData("03759999999", "37", "59999999", "Minas Gerais")]
    [InlineData("03820000000", "38", "20000000", "Minas Gerais")]
    [InlineData("03859999999", "38", "59999999", "Minas Gerais")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("04120000000", "41", "20000000", "Paraná")]
    [InlineData("04159999999", "41", "59999999", "Paraná")]
    [InlineData("04620000000", "46", "20000000", "Paraná")]
    [InlineData("04659999999", "46", "59999999", "Paraná")]
    [InlineData("04720000000", "47", "20000000", "Santa Catarina")]
    [InlineData("04759999999", "47", "59999999", "Santa Catarina")]
    [InlineData("04920000000", "49", "20000000", "Santa Catarina")]
    [InlineData("04959999999", "49", "59999999", "Santa Catarina")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("05120000000", "51", "20000000", "Rio Grande do Sul")]
    [InlineData("05159999999", "51", "59999999", "Rio Grande do Sul")]
    [InlineData("05520000000", "55", "20000000", "Rio Grande do Sul")]
    [InlineData("05559999999", "55", "59999999", "Rio Grande do Sul")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("06120000000", "61", "20000000", "Distrito Federal")]
    [InlineData("06159999999", "61", "59999999", "Distrito Federal")]
    [InlineData("06220000000", "62", "20000000", "Goiás")]
    [InlineData("06259999999", "62", "59999999", "Goiás")]
    [InlineData("06320000000", "63", "20000000", "Tocantins")]
    [InlineData("06359999999", "63", "59999999", "Tocantins")]
    [InlineData("06420000000", "64", "20000000", "Goiás")]
    [InlineData("06459999999", "64", "59999999", "Goiás")]
    [InlineData("06520000000", "65", "20000000", "Mato Grosso")]
    [InlineData("06559999999", "65", "59999999", "Mato Grosso")]
    [InlineData("06620000000", "66", "20000000", "Mato Grosso")]
    [InlineData("06659999999", "66", "59999999", "Mato Grosso")]
    [InlineData("06720000000", "67", "20000000", "Mato Grosso do Sul")]
    [InlineData("06759999999", "67", "59999999", "Mato Grosso do Sul")]
    [InlineData("06820000000", "68", "20000000", "Acre")]
    [InlineData("06859999999", "68", "59999999", "Acre")]
    [InlineData("06920000000", "69", "20000000", "Rondônia")]
    [InlineData("06959999999", "69", "59999999", "Rondônia")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("07120000000", "71", "20000000", "Bahia")]
    [InlineData("07159999999", "71", "59999999", "Bahia")]
    [InlineData("07320000000", "73", "20000000", "Bahia")]
    [InlineData("07359999999", "73", "59999999", "Bahia")]
    [InlineData("07520000000", "75", "20000000", "Bahia")]
    [InlineData("07559999999", "75", "59999999", "Bahia")]
    [InlineData("07720000000", "77", "20000000", "Bahia")]
    [InlineData("07759999999", "77", "59999999", "Bahia")]
    [InlineData("07920000000", "79", "20000000", "Sergipe")]
    [InlineData("07959999999", "79", "59999999", "Sergipe")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("08120000000", "81", "20000000", "Pernambuco")]
    [InlineData("08159999999", "81", "59999999", "Pernambuco")]
    [InlineData("08220000000", "82", "20000000", "Alagoas")]
    [InlineData("08259999999", "82", "59999999", "Alagoas")]
    [InlineData("08320000000", "83", "20000000", "Paraiba")]
    [InlineData("08359999999", "83", "59999999", "Paraiba")]
    [InlineData("08420000000", "84", "20000000", "Rio Grande do Norte")]
    [InlineData("08459999999", "84", "59999999", "Rio Grande do Norte")]
    [InlineData("08520000000", "85", "20000000", "Ceará")]
    [InlineData("08559999999", "85", "59999999", "Ceará")]
    [InlineData("08620000000", "86", "20000000", "Piauí")]
    [InlineData("08659999999", "86", "59999999", "Piauí")]
    [InlineData("08720000000", "87", "20000000", "Piauí")]
    [InlineData("08759999999", "87", "59999999", "Piauí")]
    [InlineData("08820000000", "88", "20000000", "Ceará")]
    [InlineData("08859999999", "88", "59999999", "Ceará")]
    [InlineData("08920000000", "89", "20000000", "Pernambuco")]
    [InlineData("08959999999", "89", "59999999", "Pernambuco")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("09120000000", "91", "20000000", "Pará")]
    [InlineData("09159999999", "91", "59999999", "Pará")]
    [InlineData("09220000000", "92", "20000000", "Amazonas")]
    [InlineData("09259999999", "92", "59999999", "Amazonas")]
    [InlineData("09320000000", "93", "20000000", "Pará")]
    [InlineData("09359999999", "93", "59999999", "Pará")]
    [InlineData("09420000000", "94", "20000000", "Pará")]
    [InlineData("09459999999", "94", "59999999", "Pará")]
    [InlineData("09520000000", "95", "20000000", "Roraima")]
    [InlineData("09559999999", "95", "59999999", "Roraima")]
    [InlineData("09620000000", "96", "20000000", "Amapá")]
    [InlineData("09659999999", "96", "59999999", "Amapá")]
    [InlineData("09720000000", "97", "20000000", "Amazonas")]
    [InlineData("09759999999", "97", "59999999", "Amazonas")]
    [InlineData("09820000000", "98", "20000000", "Maranhão")]
    [InlineData("09859999999", "98", "59999999", "Maranhão")]
    [InlineData("09920000000", "99", "20000000", "Maranhão")]
    [InlineData("09959999999", "99", "59999999", "Maranhão")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Brazil, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
