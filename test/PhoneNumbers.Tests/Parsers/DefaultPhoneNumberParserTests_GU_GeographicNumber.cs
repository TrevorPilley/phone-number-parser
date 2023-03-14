namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Guam <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GU_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Guam);

    [Theory]
    [InlineData("16712000000", "671", "2000000", "Guam")]
    [InlineData("16712109999", "671", "2109999", "Guam")]
    [InlineData("16712120000", "671", "2120000", "Guam")]
    [InlineData("16713109999", "671", "3109999", "Guam")]
    [InlineData("16713120000", "671", "3120000", "Guam")]
    [InlineData("16714109999", "671", "4109999", "Guam")]
    [InlineData("16714120000", "671", "4120000", "Guam")]
    [InlineData("16715109999", "671", "5109999", "Guam")]
    [InlineData("16715120000", "671", "5120000", "Guam")]
    [InlineData("16716109999", "671", "6109999", "Guam")]
    [InlineData("16716120000", "671", "6120000", "Guam")]
    [InlineData("16717109999", "671", "7109999", "Guam")]
    [InlineData("16717120000", "671", "7120000", "Guam")]
    [InlineData("16718109999", "671", "8109999", "Guam")]
    [InlineData("16718120000", "671", "8120000", "Guam")]
    [InlineData("16719109999", "671", "9109999", "Guam")]
    [InlineData("16719120000", "671", "9120000", "Guam")]
    [InlineData("16719999999", "671", "9999999", "Guam")]
    public void Parse_Known_GeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Guam, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
