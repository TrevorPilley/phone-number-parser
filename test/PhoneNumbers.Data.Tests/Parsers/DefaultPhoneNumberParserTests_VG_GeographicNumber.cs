namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for British virgin islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.BritishVirginIslands);

    [Theory]
    [InlineData("2842290000", "284", "2290000", "British Virgin Islands")]
    [InlineData("2842299999", "284", "2299999", "British Virgin Islands")]
    [InlineData("2844460000", "284", "4460000", "British Virgin Islands")]
    [InlineData("2844469999", "284", "4469999", "British Virgin Islands")]
    [InlineData("2844940000", "284", "4940000", "British Virgin Islands")]
    [InlineData("2844959999", "284", "4959999", "British Virgin Islands")]
    [InlineData("2844960000", "284", "4960000", "British Virgin Islands")]
    [InlineData("2844965999", "284", "4965999", "British Virgin Islands")]
    [InlineData("2848520000", "284", "8520000", "British Virgin Islands")]
    [InlineData("2848529999", "284", "8529999", "British Virgin Islands")]
    [InlineData("2848640000", "284", "8640000", "British Virgin Islands")]
    [InlineData("2848659999", "284", "8659999", "British Virgin Islands")]
    [InlineData("2848690000", "284", "8690000", "British Virgin Islands")]
    [InlineData("2848699999", "284", "8699999", "British Virgin Islands")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BritishVirginIslands, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
