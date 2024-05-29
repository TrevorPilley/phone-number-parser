namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Gibraltar <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GI_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Gibraltar);

    [Theory]
    [InlineData("20000000", "200", "00000", "Gibraltar")]
    [InlineData("20099999", "200", "99999", "Gibraltar")]
    [InlineData("20300000", "203", "00000", "Gibraltar")]
    [InlineData("20319999", "203", "19999", "Gibraltar")]
    [InlineData("21620000", "216", "20000", "Gibraltar")]
    [InlineData("21629999", "216", "29999", "Gibraltar")]
    [InlineData("21640000", "216", "40000", "Gibraltar")]
    [InlineData("21684999", "216", "84999", "Gibraltar")]
    [InlineData("21690000", "216", "90000", "Gibraltar")]
    [InlineData("21694999", "216", "94999", "Gibraltar")]
    [InlineData("22220000", "222", "20000", "Gibraltar")]
    [InlineData("22229999", "222", "29999", "Gibraltar")]
    [InlineData("22240000", "222", "40000", "Gibraltar")]
    [InlineData("22259999", "222", "59999", "Gibraltar")]
    [InlineData("22270000", "222", "70000", "Gibraltar")]
    [InlineData("22279999", "222", "79999", "Gibraltar")]
    [InlineData("22500000", "225", "00000", "Gibraltar")]
    [InlineData("22514999", "225", "14999", "Gibraltar")]
    [InlineData("22550000", "225", "50000", "Gibraltar")]
    [InlineData("22554999", "225", "54999", "Gibraltar")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Gibraltar, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
