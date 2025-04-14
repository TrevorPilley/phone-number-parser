namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Oman <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_OM_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Oman);

    [Theory]
    [InlineData("23000000", "23000000", "Dhofar & Al Wusta")]
    [InlineData("23999999", "23999999", "Dhofar & Al Wusta")]
    [InlineData("24000000", "24000000", "Muscat")]
    [InlineData("24999999", "24999999", "Muscat")]
    [InlineData("25000000", "25000000", "A’Dakhliyah, Al Sharqiya & A’Dhahira")]
    [InlineData("25999999", "25999999", "A’Dakhliyah, Al Sharqiya & A’Dhahira")]
    [InlineData("26000000", "26000000", "Al Batinah & Musandam")]
    [InlineData("26999999", "26999999", "Al Batinah & Musandam")]
    public void Parse_Known_GeographicPhoneNumber(string value, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Oman, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Null(geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
