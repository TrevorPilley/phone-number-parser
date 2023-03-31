namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for South africa <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_ZA_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SouthAfrica);

    [Theory]
    [InlineData("0100000000", "10", "0000000", "Johannesburg")]
    [InlineData("0109999999", "10", "9999999", "Johannesburg")]
    [InlineData("0110000000", "11", "0000000", "Johannesburg")]
    [InlineData("0119999999", "11", "9999999", "Johannesburg")]
    [InlineData("0120000000", "12", "0000000", "Tshwane region")]
    [InlineData("0129999999", "12", "9999999", "Tshwane region")]
    [InlineData("0130000000", "13", "0000000", "Northern and western parts of Mpumalanga")]
    [InlineData("0139999999", "13", "9999999", "Northern and western parts of Mpumalanga")]
    [InlineData("0140000000", "14", "0000000", "Northern part of North West and southern and western parts of Limpopo")]
    [InlineData("0149999999", "14", "9999999", "Northern part of North West and southern and western parts of Limpopo")]
    [InlineData("0150000000", "15", "0000000", "Northern and eastern parts of Limpopo")]
    [InlineData("0159999999", "15", "9999999", "Northern and eastern parts of Limpopo")]
    [InlineData("0160000000", "16", "0000000", "Vaal Triangle")]
    [InlineData("0169999999", "16", "9999999", "Vaal Triangle")]
    [InlineData("0170000000", "17", "0000000", "Southern part of Mpumalanga")]
    [InlineData("0179999999", "17", "9999999", "Southern part of Mpumalanga")]
    [InlineData("0180000000", "18", "0000000", "Southern part of North West")]
    [InlineData("0189999999", "18", "9999999", "Southern part of North West")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0210000000", "21", "0000000", "Cape Town Region")]
    [InlineData("0219999999", "21", "9999999", "Cape Town Region")]
    [InlineData("0220000000", "22", "0000000", "Western coast of Western Cape and Boland")]
    [InlineData("0229999999", "22", "9999999", "Western coast of Western Cape and Boland")]
    [InlineData("0230000000", "23", "0000000", "Karoo")]
    [InlineData("0239999999", "23", "9999999", "Karoo")]
    [InlineData("0270000000", "27", "0000000", "Namaqualand")]
    [InlineData("0279999999", "27", "9999999", "Namaqualand")]
    [InlineData("0280000000", "28", "0000000", "Southern coast of Western Cape")]
    [InlineData("0289999999", "28", "9999999", "Southern coast of Western Cape")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0310000000", "31", "0000000", "Durban region")]
    [InlineData("0319999999", "31", "9999999", "Durban region")]
    [InlineData("0320000000", "32", "0000000", "KwaZulu Natal central coast")]
    [InlineData("0329999999", "32", "9999999", "KwaZulu Natal central coast")]
    [InlineData("0330000000", "33", "0000000", "KwaZulu Natal Midlands")]
    [InlineData("0339999999", "33", "9999999", "KwaZulu Natal Midlands")]
    [InlineData("0340000000", "34", "0000000", "Northern KwaZulu Natal")]
    [InlineData("0349999999", "34", "9999999", "Northern KwaZulu Natal")]
    [InlineData("0350000000", "35", "0000000", "Zululand")]
    [InlineData("0359999999", "35", "9999999", "Zululand")]
    [InlineData("0360000000", "36", "0000000", "Drakensberg")]
    [InlineData("0369999999", "36", "9999999", "Drakensberg")]
    [InlineData("0390000000", "39", "0000000", "Eastern Pondoland and southern coast of KwaZulu Natal")]
    [InlineData("0399999999", "39", "9999999", "Eastern Pondoland and southern coast of KwaZulu Natal")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0400000000", "40", "0000000", "Bhisho region")]
    [InlineData("0409999999", "40", "9999999", "Bhisho region")]
    [InlineData("0410000000", "41", "0000000", "Port Elizabeth region")]
    [InlineData("0419999999", "41", "9999999", "Port Elizabeth region")]
    [InlineData("0420000000", "42", "0000000", "Southern and central parts of Eastern Cape")]
    [InlineData("0429999999", "42", "9999999", "Southern and central parts of Eastern Cape")]
    [InlineData("0430000000", "43", "0000000", "East London region")]
    [InlineData("0439999999", "43", "9999999", "East London region")]
    [InlineData("0440000000", "44", "0000000", "Garden Route")]
    [InlineData("0449999999", "44", "9999999", "Garden Route")]
    [InlineData("0450000000", "45", "0000000", "Northern and eastern parts of Eastern Cape")]
    [InlineData("0459999999", "45", "9999999", "Northern and eastern parts of Eastern Cape")]
    [InlineData("0460000000", "46", "0000000", "Southern and eastern parts of Eastern Cape")]
    [InlineData("0469999999", "46", "9999999", "Southern and eastern parts of Eastern Cape")]
    [InlineData("0470000000", "47", "0000000", "Eastern part of Eastern Cape")]
    [InlineData("0479999999", "47", "9999999", "Eastern part of Eastern Cape")]
    [InlineData("0480000000", "48", "0000000", "Northern part of Eastern Cape")]
    [InlineData("0489999999", "48", "9999999", "Northern part of Eastern Cape")]
    [InlineData("0490000000", "49", "0000000", "Western part of Eastern Cape")]
    [InlineData("0499999999", "49", "9999999", "Western part of Eastern Cape")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0510000000", "51", "0000000", "Southern and central parts of Free State and far eastern part of Eastern Cape")]
    [InlineData("0519999999", "51", "9999999", "Southern and central parts of Free State and far eastern part of Eastern Cape")]
    [InlineData("0530000000", "53", "0000000", "Eastern part of Northern Cape and far western part of North West")]
    [InlineData("0539999999", "53", "9999999", "Eastern part of Northern Cape and far western part of North West")]
    [InlineData("0540000000", "54", "0000000", "Gordonia")]
    [InlineData("0549999999", "54", "9999999", "Gordonia")]
    [InlineData("0560000000", "56", "0000000", "Northern part of Free State")]
    [InlineData("0569999999", "56", "9999999", "Northern part of Free State")]
    [InlineData("0570000000", "57", "0000000", "Free State Goldfields")]
    [InlineData("0579999999", "57", "9999999", "Free State Goldfields")]
    [InlineData("0580000000", "58", "0000000", "Eastern part of Free State")]
    [InlineData("0589999999", "58", "9999999", "Eastern part of Free State")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
