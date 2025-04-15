namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saudi arabia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SA_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaudiArabia);

    [Theory]
    [InlineData("0112000000", "11", "2000000", "Area 1 (Riyadh, Kharj)")]
    [InlineData("0118999999", "11", "8999999", "Area 1 (Riyadh, Kharj)")]
    [InlineData("0122000000", "12", "2000000", "Area 2 (Makkah, Jeddah)")]
    [InlineData("0128999999", "12", "8999999", "Area 2 (Makkah, Jeddah)")]
    [InlineData("0132000000", "13", "2000000", "Area 3 (Dammam, Khobar, Dahran)")]
    [InlineData("0138999999", "13", "8999999", "Area 3 (Dammam, Khobar, Dahran)")]
    [InlineData("0142000000", "14", "2000000", "Area 4 (Madenah, Arar, Tabuk, Yanbu)")]
    [InlineData("0148999999", "14", "8999999", "Area 4 (Madenah, Arar, Tabuk, Yanbu)")]
    [InlineData("0162000000", "16", "2000000", "Area 6 (Hail, Qasim)")]
    [InlineData("0168999999", "16", "8999999", "Area 6 (Hail, Qasim)")]
    [InlineData("0172000000", "17", "2000000", "Area 6 (Abha, Najran, Jezan)")]
    [InlineData("0178999999", "17", "8999999", "Area 6 (Abha, Najran, Jezan)")]
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
