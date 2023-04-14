namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Cyprus <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CY_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Cyprus);

    [Theory]
    [InlineData("22000000", "22", "000000", "Nicosia")]
    [InlineData("22999999", "22", "999999", "Nicosia")]
    [InlineData("23000000", "23", "000000", "Famagusta")]
    [InlineData("23999999", "23", "999999", "Famagusta")]
    [InlineData("24000000", "24", "000000", "Larnaca")]
    [InlineData("24999999", "24", "999999", "Larnaca")]
    [InlineData("25000000", "25", "000000", "Limassol")]
    [InlineData("25999999", "25", "999999", "Limassol")]
    [InlineData("26000000", "26", "000000", "Pafos")]
    [InlineData("26999999", "26", "999999", "Pafos")]
    public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Cyprus, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
