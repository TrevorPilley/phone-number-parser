namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Yemen <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_YE_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Yemen);

    [Theory]
    [InlineData("01200000", "1", "200000", "Sana'a")]
    [InlineData("01699999", "1", "699999", "Sana'a")]
    [InlineData("01810000", "1", "810000", "Sana'a")]
    [InlineData("01829999", "1", "829999", "Sana'a")]
    [InlineData("017500000", "1", "7500000", "Sana'a")]
    [InlineData("017599999", "1", "7599999", "Sana'a")]
    public void Parse_Known_GeographicPhoneNumber_1_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("02200000", "2", "200000", "Aden")]
    [InlineData("02399999", "2", "399999", "Aden")]
    [InlineData("02400000", "2", "400000", "Dhale'a")]
    [InlineData("02499999", "2", "499999", "Dhale'a")]
    [InlineData("02500000", "2", "500000", "Lahj")]
    [InlineData("02599999", "2", "599999", "Lahj")]
    [InlineData("02600000", "2", "600000", "Abyan")]
    [InlineData("02699999", "2", "699999", "Abyan")]
    [InlineData("02820000", "2", "820000", "Aden")]
    [InlineData("02829999", "2", "829999", "Aden")]
    [InlineData("02840000", "2", "840000", "Aden")]
    [InlineData("02840999", "2", "840999", "Aden")]
    [InlineData("02841000", "2", "841000", "Dhale'a")]
    [InlineData("02842999", "2", "842999", "Dhale'a")]
    [InlineData("02850000", "2", "850000", "Lahj")]
    [InlineData("02859999", "2", "859999", "Lahj")]
    [InlineData("02860000", "2", "860000", "Abyan")]
    [InlineData("02869999", "2", "869999", "Abyan")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("03200000", "3", "200000", "Hodaidah")]
    [InlineData("03399999", "3", "399999", "Hodaidah")]
    [InlineData("03500000", "3", "500000", "Hodaidah")]
    [InlineData("03509999", "3", "509999", "Hodaidah")]
    [InlineData("03830000", "3", "830000", "Hodaidah")]
    [InlineData("03839999", "3", "839999", "Hodaidah")]
    [InlineData("03850000", "3", "850000", "Hodaidah")]
    [InlineData("03859999", "3", "859999", "Hodaidah")]
    public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("04200000", "4", "200000", "Taiz")]
    [InlineData("04329999", "4", "329999", "Taiz")]
    [InlineData("04330000", "4", "330000", "Ibb")]
    [InlineData("04339999", "4", "339999", "Ibb")]
    [InlineData("04340000", "4", "340000", "Taiz")]
    [InlineData("04399999", "4", "399999", "Taiz")]
    [InlineData("04400000", "4", "400000", "Ibb")]
    [InlineData("04599999", "4", "599999", "Ibb")]
    [InlineData("04830000", "4", "830000", "Taiz")]
    [InlineData("04839999", "4", "839999", "Taiz")]
    [InlineData("04840000", "4", "840000", "Taiz")]
    [InlineData("04843999", "4", "843999", "Taiz")]
    [InlineData("04844000", "4", "844000", "Ibb")]
    [InlineData("04859999", "4", "859999", "Ibb")]
    public void Parse_Known_GeographicPhoneNumber_4_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("05200000", "5", "200000", "Shabwah")]
    [InlineData("05299999", "5", "299999", "Shabwah")]
    [InlineData("05300000", "5", "300000", "Hadhrmout")]
    [InlineData("05599999", "5", "599999", "Hadhrmout")]
    [InlineData("05600000", "5", "600000", "Al Mahrah")]
    [InlineData("05659999", "5", "659999", "Al Mahrah")]
    [InlineData("05660000", "5", "660000", "Soqatrah")]
    [InlineData("05669999", "5", "669999", "Soqatrah")]
    [InlineData("05670000", "5", "670000", "Al Mahrah")]
    [InlineData("05679999", "5", "679999", "Al Mahrah")]
    public void Parse_Known_GeographicPhoneNumber_5_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("06300000", "6", "300000", "Ma'areb")]
    [InlineData("06309999", "6", "309999", "Ma'areb")]
    [InlineData("06330000", "6", "330000", "Ma'areb")]
    [InlineData("06339999", "6", "339999", "Ma'areb")]
    [InlineData("06340000", "6", "340000", "Aljawf")]
    [InlineData("06349999", "6", "349999", "Aljawf")]
    [InlineData("06360000", "6", "360000", "Ma'areb")]
    [InlineData("06369999", "6", "369999", "Ma'areb")]
    [InlineData("06380000", "6", "380000", "Ma'areb")]
    [InlineData("06389999", "6", "389999", "Ma'areb")]
    [InlineData("06390000", "6", "390000", "Dhamar")]
    [InlineData("06399999", "6", "399999", "Dhamar")]
    [InlineData("06400000", "6", "400000", "Dhamar")]
    [InlineData("06499999", "6", "499999", "Dhamar")]
    [InlineData("06500000", "6", "500000", "Dhamar")]
    [InlineData("06519999", "6", "519999", "Dhamar")]
    [InlineData("06520000", "6", "520000", "Al Baidha")]
    [InlineData("06579999", "6", "579999", "Al Baidha")]
    [InlineData("06820000", "6", "820000", "Dhamar")]
    [InlineData("06829999", "6", "829999", "Dhamar")]
    [InlineData("06830000", "6", "830000", "Ma'areb")]
    [InlineData("06839999", "6", "839999", "Ma'areb")]
    [InlineData("06840000", "6", "840000", "Dhamar")]
    [InlineData("06849999", "6", "849999", "Dhamar")]
    [InlineData("06850000", "6", "850000", "Al Baidha")]
    [InlineData("06850999", "6", "850999", "Al Baidha")]
    [InlineData("06853000", "6", "853000", "Al Baidha")]
    [InlineData("06853999", "6", "853999", "Al Baidha")]
    [InlineData("06860000", "6", "860000", "Al Baidha")]
    [InlineData("06860999", "6", "860999", "Al Baidha")]
    [InlineData("06861000", "6", "861000", "Dhamar")]
    [InlineData("06861999", "6", "861999", "Dhamar")]
    [InlineData("06862000", "6", "862000", "Al Baidha")]
    [InlineData("06862999", "6", "862999", "Al Baidha")]
    [InlineData("06863000", "6", "863000", "Ma'areb")]
    [InlineData("06863999", "6", "863999", "Ma'areb")]
    [InlineData("06864000", "6", "864000", "Dhamar")]
    [InlineData("06867999", "6", "867999", "Dhamar")]
    [InlineData("06868000", "6", "868000", "Al Baidha")]
    [InlineData("06869999", "6", "869999", "Al Baidha")]
    public void Parse_Known_GeographicPhoneNumber_6_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("07200000", "7", "200000", "Hajjah")]
    [InlineData("07299999", "7", "299999", "Hajjah")]
    [InlineData("07400000", "7", "400000", "Al Mahweet")]
    [InlineData("07499999", "7", "499999", "Al Mahweet")]
    [InlineData("07500000", "7", "500000", "Sa'adah")]
    [InlineData("07599999", "7", "599999", "Sa'adah")]
    [InlineData("07600000", "7", "600000", "Amran")]
    [InlineData("07699999", "7", "699999", "Amran")]
    [InlineData("07845000", "7", "845000", "Al Mahweet")]
    [InlineData("07845999", "7", "845999", "Al Mahweet")]
    [InlineData("07850000", "7", "850000", "Sa'adah")]
    [InlineData("07859999", "7", "859999", "Sa'adah")]
    [InlineData("07860000", "7", "860000", "Amran")]
    [InlineData("07869999", "7", "869999", "Amran")]
    [InlineData("07870000", "7", "870000", "Hajjah")]
    [InlineData("07873999", "7", "873999", "Hajjah")]
    [InlineData("07874000", "7", "874000", "Al Mahweet")]
    [InlineData("07874999", "7", "874999", "Al Mahweet")]
    [InlineData("07875000", "7", "875000", "Sa'adah")]
    [InlineData("07875999", "7", "875999", "Sa'adah")]
    [InlineData("07876000", "7", "876000", "Amran")]
    [InlineData("07877999", "7", "877999", "Amran")]
    [InlineData("07878000", "7", "878000", "Sa'adah")]
    [InlineData("07878999", "7", "878999", "Sa'adah")]
    [InlineData("07879000", "7", "879000", "Al Mahweet")]
    [InlineData("07879999", "7", "879999", "Al Mahweet")]
    public void Parse_Known_GeographicPhoneNumber_7_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Yemen, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
