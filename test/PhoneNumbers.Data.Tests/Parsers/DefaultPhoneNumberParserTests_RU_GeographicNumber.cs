namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Russia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_RU_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Russia);

    [Theory]
    [InlineData("83010000000", "301", "0000000", "Republic of Buryatia (Ulan – Ude)")]
    [InlineData("83019999999", "301", "9999999", "Republic of Buryatia (Ulan – Ude)")]
    [InlineData("83020000000", "302", "0000000", "Chita region together with the Agin-Buryat autonomous region (Chita)")]
    [InlineData("83029999999", "302", "9999999", "Chita region together with the Agin-Buryat autonomous region (Chita)")]
    [InlineData("83360000000", "336", "0000000", "Baikonur")]
    [InlineData("83369999999", "336", "9999999", "Baikonur")]
    [InlineData("83410000000", "341", "0000000", "Republic of Udmurtia (Izhevsk)")]
    [InlineData("83419999999", "341", "9999999", "Republic of Udmurtia (Izhevsk)")]
    [InlineData("83420000000", "342", "0000000", "Perm territory")]
    [InlineData("83429999999", "342", "9999999", "Perm territory")]
    [InlineData("83430000000", "343", "0000000", "Sverdlovsk region (Ekaterinburg)")]
    [InlineData("83439999999", "343", "9999999", "Sverdlovsk region (Ekaterinburg)")]
    [InlineData("83450000000", "345", "0000000", "Tyumen region")]
    [InlineData("83459999999", "345", "9999999", "Tyumen region")]
    [InlineData("83460000000", "346", "0000000", "Khanty – Mansiysk autonomous region – Yugra (Surgut)")]
    [InlineData("83469999999", "346", "9999999", "Khanty – Mansiysk autonomous region – Yugra (Surgut)")]
    [InlineData("83470000000", "347", "0000000", "Republic of Bashkortostan (Ufa)")]
    [InlineData("83479999999", "347", "9999999", "Republic of Bashkortostan (Ufa)")]
    [InlineData("83490000000", "349", "0000000", "Yamalo-Nenets autonomous region (Salekhard)")]
    [InlineData("83499999999", "349", "9999999", "Yamalo-Nenets autonomous region (Salekhard)")]
    [InlineData("83510000000", "351", "0000000", "Chelyabinsk region")]
    [InlineData("83519999999", "351", "9999999", "Chelyabinsk region")]
    [InlineData("83520000000", "352", "0000000", "Kurgan region")]
    [InlineData("83529999999", "352", "9999999", "Kurgan region")]
    [InlineData("83530000000", "353", "0000000", "Orenburg region")]
    [InlineData("83539999999", "353", "9999999", "Orenburg region")]
    [InlineData("83650000000", "365", "0000000", "Republic of Crimea (Simferopol)")]
    [InlineData("83659999999", "365", "9999999", "Republic of Crimea (Simferopol)")]
    [InlineData("83810000000", "381", "0000000", "Omsk region")]
    [InlineData("83819999999", "381", "9999999", "Omsk region")]
    [InlineData("83820000000", "382", "0000000", "Tomsk region")]
    [InlineData("83829999999", "382", "9999999", "Tomsk region")]
    [InlineData("83830000000", "383", "0000000", "Novosibirsk region")]
    [InlineData("83839999999", "383", "9999999", "Novosibirsk region")]
    [InlineData("83840000000", "384", "0000000", "Kemerovo region")]
    [InlineData("83849999999", "384", "9999999", "Kemerovo region")]
    [InlineData("83850000000", "385", "0000000", "Altai territory (Barnaul)")]
    [InlineData("83859999999", "385", "9999999", "Altai territory (Barnaul)")]
    [InlineData("83880000000", "388", "0000000", "Republic of Altai (Gorno-Altaisk)")]
    [InlineData("83889999999", "388", "9999999", "Republic of Altai (Gorno-Altaisk)")]
    [InlineData("83900000000", "390", "0000000", "Republic of Khakassia (Abakan)")]
    [InlineData("83909999999", "390", "9999999", "Republic of Khakassia (Abakan)")]
    [InlineData("83910000000", "391", "0000000", "Krasnoyarsk Territory in conjunction with the Evenk autonomous region and Taimyr (Dolgan-Nenets) autonomous region (Krasnoyarsk)")]
    [InlineData("83919999999", "391", "9999999", "Krasnoyarsk Territory in conjunction with the Evenk autonomous region and Taimyr (Dolgan-Nenets) autonomous region (Krasnoyarsk)")]
    [InlineData("83940000000", "394", "0000000", "Republic of Tyva (Kyzyl)")]
    [InlineData("83949999999", "394", "9999999", "Republic of Tyva (Kyzyl)")]
    [InlineData("83950000000", "395", "0000000", "Irkutsk region (Irkutsk)")]
    [InlineData("83959999999", "395", "9999999", "Irkutsk region (Irkutsk)")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Russia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("84950000000", "495", "0000000", "Moscow (city)")]
    [InlineData("84959999999", "495", "9999999", "Moscow (city)")]
    [InlineData("84960000000", "496", "0000000", "Moscow region")]
    [InlineData("84969999999", "496", "9999999", "Moscow region")]
    [InlineData("84980000000", "498", "0000000", "Moscow region")]
    [InlineData("84989999999", "498", "9999999", "Moscow region")]
    [InlineData("84990000000", "499", "0000000", "Moscow (city)")]
    [InlineData("84999999999", "499", "9999999", "Moscow (city)")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Russia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
