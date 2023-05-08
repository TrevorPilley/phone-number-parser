namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Barbados <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BB_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Barbados);

    [Theory]
    [InlineData("2462270000", "246", "2270000", "Barbados")]
    [InlineData("2462289999", "246", "2289999", "Barbados")]
    [InlineData("2462700000", "246", "2700000", "Barbados")]
    [InlineData("2462749999", "246", "2749999", "Barbados")]
    [InlineData("2464120000", "246", "4120000", "Barbados")]
    [InlineData("2464129999", "246", "4129999", "Barbados")]
    [InlineData("2464140000", "246", "4140000", "Barbados")]
    [InlineData("2464169999", "246", "4169999", "Barbados")]
    [InlineData("2464200000", "246", "4200000", "Barbados")]
    [InlineData("2464299999", "246", "4299999", "Barbados")]
    [InlineData("2464320000", "246", "4320000", "Barbados")]
    [InlineData("2464399999", "246", "4399999", "Barbados")]
    [InlineData("2465200000", "246", "5200000", "Barbados")]
    [InlineData("2465209999", "246", "5209999", "Barbados")]
    [InlineData("2465210000", "246", "5210000", "Barbados")]
    [InlineData("2465210999", "246", "5210999", "Barbados")]
    [InlineData("2465213000", "246", "5213000", "Barbados")]
    [InlineData("2465213999", "246", "5213999", "Barbados")]
    [InlineData("2465216000", "246", "5216000", "Barbados")]
    [InlineData("2465216999", "246", "5216999", "Barbados")]
    [InlineData("2465219000", "246", "5219000", "Barbados")]
    [InlineData("2465219999", "246", "5219999", "Barbados")]
    [InlineData("2465300000", "246", "5300000", "Barbados")]
    [InlineData("2465319999", "246", "5319999", "Barbados")]
    [InlineData("2465350000", "246", "5350000", "Barbados")]
    [InlineData("2465399999", "246", "5399999", "Barbados")]
    [InlineData("2465460000", "246", "5460000", "Barbados")]
    [InlineData("2465499999", "246", "5499999", "Barbados")]
    [InlineData("2465540000", "246", "5540000", "Barbados")]
    [InlineData("2465549999", "246", "5549999", "Barbados")]
    [InlineData("2465710000", "246", "5710000", "Barbados")]
    [InlineData("2465739999", "246", "5739999", "Barbados")]
    [InlineData("2466200000", "246", "6200000", "Barbados")]
    [InlineData("2466299999", "246", "6299999", "Barbados")]
    [InlineData("2466380000", "246", "6380000", "Barbados")]
    [InlineData("2466389999", "246", "6389999", "Barbados")]
    [InlineData("2467370000", "246", "7370000", "Barbados")]
    [InlineData("2467379999", "246", "7379999", "Barbados")]
    [InlineData("2467570000", "246", "7570000", "Barbados")]
    [InlineData("2467579999", "246", "7579999", "Barbados")]
    [InlineData("2469630000", "246", "9630000", "Barbados")]
    [InlineData("2469639999", "246", "9639999", "Barbados")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Barbados, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
