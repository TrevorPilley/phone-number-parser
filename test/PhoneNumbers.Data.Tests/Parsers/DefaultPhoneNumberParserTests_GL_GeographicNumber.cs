namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Greenland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GL_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Greenland);

    [Theory]
    [InlineData("310000", "310000", "Nuuk")]
    [InlineData("379999", "379999", "Nuuk")]
    [InlineData("610000", "610000", "Nanortalik")]
    [InlineData("619999", "619999", "Nanortalik")]
    [InlineData("640000", "640000", "Qaqortoq")]
    [InlineData("649999", "649999", "Qaqortoq")]
    [InlineData("660000", "660000", "Narsaq")]
    [InlineData("669999", "669999", "Narsaq")]
    [InlineData("680000", "680000", "Paamiut")]
    [InlineData("689999", "689999", "Paamiut")]
    [InlineData("690000", "690000", "Ivittuut")]
    [InlineData("699999", "699999", "Ivittuut")]
    [InlineData("810000", "810000", "Maniitsoq")]
    [InlineData("819999", "819999", "Maniitsoq")]
    [InlineData("840000", "840000", "Kangerlussuaq")]
    [InlineData("849999", "849999", "Kangerlussuaq")]
    [InlineData("850000", "850000", "Sisimiut")]
    [InlineData("869999", "869999", "Sisimiut")]
    [InlineData("870000", "870000", "Kangaatsiaq")]
    [InlineData("879999", "879999", "Kangaatsiaq")]
    [InlineData("890000", "890000", "Aasiaat")]
    [InlineData("899999", "899999", "Aasiaat")]
    [InlineData("910000", "910000", "Qasigannguit")]
    [InlineData("919999", "919999", "Qasigannguit")]
    [InlineData("920000", "920000", "Qeqertasuaq")]
    [InlineData("929999", "929999", "Qeqertasuaq")]
    [InlineData("940000", "940000", "Ilulissat")]
    [InlineData("949999", "949999", "Ilulissat")]
    [InlineData("950000", "950000", "Uummannaq")]
    [InlineData("959999", "959999", "Uummannaq")]
    [InlineData("960000", "960000", "Upernavik")]
    [InlineData("969999", "969999", "Upernavik")]
    [InlineData("970000", "970000", "Qaanaaq")]
    [InlineData("979999", "979999", "Qaanaaq")]
    [InlineData("980000", "980000", "Tasiilaq")]
    [InlineData("989999", "989999", "Tasiilaq")]
    [InlineData("990000", "990000", "Illoqqortoormiut")]
    [InlineData("999999", "999999", "Illoqqortoormiut")]
    public void Parse_Known_GeographicPhoneNumber(string value, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Greenland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Null(geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
