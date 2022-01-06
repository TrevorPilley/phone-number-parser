namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Slovakia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SK_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Slovakia);

    [Theory]
    [InlineData("0200000000", "2", "00000000", "Bratislava")]
    [InlineData("0299999999", "2", "99999999", "Bratislava")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovakia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0310000000", "31", "0000000", "Dunajská Streda")]
    [InlineData("0319999999", "31", "9999999", "Dunajská Streda")]
    [InlineData("0320000000", "32", "0000000", "Trenčín")]
    [InlineData("0329999999", "32", "9999999", "Trenčín")]
    [InlineData("0330000000", "33", "0000000", "Trnava")]
    [InlineData("0339999999", "33", "9999999", "Trnava")]
    [InlineData("0340000000", "34", "0000000", "Senica")]
    [InlineData("0349999999", "34", "9999999", "Senica")]
    [InlineData("0350000000", "35", "0000000", "Nové Zámky")]
    [InlineData("0359999999", "35", "9999999", "Nové Zámky")]
    [InlineData("0360000000", "36", "0000000", "Levice")]
    [InlineData("0369999999", "36", "9999999", "Levice")]
    [InlineData("0370000000", "37", "0000000", "Nitra")]
    [InlineData("0379999999", "37", "9999999", "Nitra")]
    [InlineData("0380000000", "38", "0000000", "Topoľčany")]
    [InlineData("0389999999", "38", "9999999", "Topoľčany")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovakia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0410000000", "41", "0000000", "Žilina")]
    [InlineData("0419999999", "41", "9999999", "Žilina")]
    [InlineData("0420000000", "42", "0000000", "Považská Bystrica")]
    [InlineData("0429999999", "42", "9999999", "Považská Bystrica")]
    [InlineData("0430000000", "43", "0000000", "Martin")]
    [InlineData("0439999999", "43", "9999999", "Martin")]
    [InlineData("0440000000", "44", "0000000", "Liptovský Mikuláš")]
    [InlineData("0449999999", "44", "9999999", "Liptovský Mikuláš")]
    [InlineData("0450000000", "45", "0000000", "Zvolen")]
    [InlineData("0459999999", "45", "9999999", "Zvolen")]
    [InlineData("0460000000", "46", "0000000", "Prievidza")]
    [InlineData("0469999999", "46", "9999999", "Prievidza")]
    [InlineData("0470000000", "47", "0000000", "Lučenec")]
    [InlineData("0479999999", "47", "9999999", "Lučenec")]
    [InlineData("0480000000", "48", "0000000", "Banská Bystrica")]
    [InlineData("0489999999", "48", "9999999", "Banská Bystrica")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovakia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0510000000", "51", "0000000", "Prešov")]
    [InlineData("0519999999", "51", "9999999", "Prešov")]
    [InlineData("0520000000", "52", "0000000", "Poprad")]
    [InlineData("0529999999", "52", "9999999", "Poprad")]
    [InlineData("0530000000", "53", "0000000", "Spišská Nová Ves")]
    [InlineData("0539999999", "53", "9999999", "Spišská Nová Ves")]
    [InlineData("0540000000", "54", "0000000", "Bardejov")]
    [InlineData("0549999999", "54", "9999999", "Bardejov")]
    [InlineData("0550000000", "55", "0000000", "Košice")]
    [InlineData("0559999999", "55", "9999999", "Košice")]
    [InlineData("0560000000", "56", "0000000", "Michalovce")]
    [InlineData("0569999999", "56", "9999999", "Michalovce")]
    [InlineData("0570000000", "57", "0000000", "Humenné")]
    [InlineData("0579999999", "57", "9999999", "Humenné")]
    [InlineData("0580000000", "58", "0000000", "Rožňava")]
    [InlineData("0589999999", "58", "9999999", "Rožňava")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovakia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
