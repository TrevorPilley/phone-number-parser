namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saudi arabia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SA_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaudiArabia);

    [Theory]
    [InlineData("0110000000", "11", "0000000", "Area 1 (Riyadh, Kharj)")]
    [InlineData("0119999999", "11", "9999999", "Area 1 (Riyadh, Kharj)")]
    [InlineData("0120000000", "12", "0000000", "Area 2 (Makkah, Jeddah)")]
    [InlineData("0129999999", "12", "9999999", "Area 2 (Makkah, Jeddah)")]
    [InlineData("0130000000", "13", "0000000", "Area 3 (Dammam, Khobar, Dahran)")]
    [InlineData("0139999999", "13", "9999999", "Area 3 (Dammam, Khobar, Dahran)")]
    [InlineData("0140000000", "14", "0000000", "Area 4 (Madenah, Arar, Tabuk, Yanbu)")]
    [InlineData("0149999999", "14", "9999999", "Area 4 (Madenah, Arar, Tabuk, Yanbu)")]
    [InlineData("0160000000", "16", "0000000", "Area 6 (Hail, Qasim)")]
    [InlineData("0169999999", "16", "9999999", "Area 6 (Hail, Qasim)")]
    [InlineData("0170000000", "17", "0000000", "Area 6 (Abha, Najran, Jezan)")]
    [InlineData("0179999999", "17", "9999999", "Area 6 (Abha, Najran, Jezan)")]
    public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaudiArabia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
