namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Egypt <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_EG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Egypt);

    [Theory]
    [InlineData("0130000000", "13", "0000000", "Elqalubia")]
    [InlineData("0139999999", "13", "9999999", "Elqalubia")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0200000000", "2", "00000000", "Cairo")]
    [InlineData("0299999999", "2", "99999999", "Cairo")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("030000000", "3", "0000000", "Alexandria")]
    [InlineData("039999999", "3", "9999999", "Alexandria")]
    public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0400000000", "40", "0000000", "Elgharbia")]
    [InlineData("0409999999", "40", "9999999", "Elgharbia")]
    [InlineData("0450000000", "45", "0000000", "Elbehera")]
    [InlineData("0459999999", "45", "9999999", "Elbehera")]
    [InlineData("0460000000", "46", "0000000", "Mersa Matrouh")]
    [InlineData("0469999999", "46", "9999999", "Mersa Matrouh")]
    [InlineData("0470000000", "47", "0000000", "Kafr el-Sheikh")]
    [InlineData("0479999999", "47", "9999999", "Kafr el-Sheikh")]
    [InlineData("0480000000", "48", "0000000", "El Menufia")]
    [InlineData("0489999999", "48", "9999999", "El Menufia")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0500000000", "50", "0000000", "El Dakahlia")]
    [InlineData("0509999999", "50", "9999999", "El Dakahlia")]
    [InlineData("0550000000", "55", "0000000", "10th of Ramadan")]
    [InlineData("0559999999", "55", "9999999", "10th of Ramadan")]
    [InlineData("057000000", "57", "000000", "Damietta")]
    [InlineData("0579999999", "57", "9999999", "Damietta")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0620000000", "62", "0000000", "ElSuez")]
    [InlineData("0629999999", "62", "9999999", "ElSuez")]
    [InlineData("0640000000", "64", "0000000", "Ismailia")]
    [InlineData("0649999999", "64", "9999999", "Ismailia")]
    [InlineData("0650000000", "65", "0000000", "El Red Sea")]
    [InlineData("0659999999", "65", "9999999", "El Red Sea")]
    [InlineData("0660000000", "66", "0000000", "Port Said")]
    [InlineData("0669999999", "66", "9999999", "Port Said")]
    [InlineData("0680000000", "68", "0000000", "North Sinai")]
    [InlineData("0689999999", "68", "9999999", "North Sinai")]
    [InlineData("0690000000", "69", "0000000", "South Sinai")]
    [InlineData("0699999999", "69", "9999999", "South Sinai")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0820000000", "82", "0000000", "Beni Suef")]
    [InlineData("0829999999", "82", "9999999", "Beni Suef")]
    [InlineData("0840000000", "84", "0000000", "Elfayoum")]
    [InlineData("0849999999", "84", "9999999", "Elfayoum")]
    [InlineData("0860000000", "86", "0000000", "Elminia")]
    [InlineData("0869999999", "86", "9999999", "Elminia")]
    [InlineData("0880000000", "88", "0000000", "Assiut")]
    [InlineData("0889999999", "88", "9999999", "Assiut")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0920000000", "92", "0000000", "El wadi El Gadeed")]
    [InlineData("0929999999", "92", "9999999", "El wadi El Gadeed")]
    [InlineData("0930000000", "93", "0000000", "Souhag")]
    [InlineData("0939999999", "93", "9999999", "Souhag")]
    [InlineData("0950000000", "95", "0000000", "Luxor")]
    [InlineData("0959999999", "95", "9999999", "Luxor")]
    [InlineData("0960000000", "96", "0000000", "Quena")]
    [InlineData("0969999999", "96", "9999999", "Quena")]
    [InlineData("0970000000", "97", "0000000", "Aswan")]
    [InlineData("0979999999", "97", "9999999", "Aswan")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Egypt, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
