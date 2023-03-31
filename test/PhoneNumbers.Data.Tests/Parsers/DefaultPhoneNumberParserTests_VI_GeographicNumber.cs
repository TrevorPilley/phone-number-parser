namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United states virgin islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VI_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.UnitedStatesVirginIslands);

    [Theory]
    [InlineData("3402000000", "340", "2000000", "Virgin Islands of the United States")]
    [InlineData("3402109999", "340", "2109999", "Virgin Islands of the United States")]
    [InlineData("3402120000", "340", "2120000", "Virgin Islands of the United States")]
    [InlineData("3403109999", "340", "3109999", "Virgin Islands of the United States")]
    [InlineData("3403120000", "340", "3120000", "Virgin Islands of the United States")]
    [InlineData("3404109999", "340", "4109999", "Virgin Islands of the United States")]
    [InlineData("3404120000", "340", "4120000", "Virgin Islands of the United States")]
    [InlineData("3405109999", "340", "5109999", "Virgin Islands of the United States")]
    [InlineData("3405120000", "340", "5120000", "Virgin Islands of the United States")]
    [InlineData("3406109999", "340", "6109999", "Virgin Islands of the United States")]
    [InlineData("3406120000", "340", "6120000", "Virgin Islands of the United States")]
    [InlineData("3407109999", "340", "7109999", "Virgin Islands of the United States")]
    [InlineData("3407120000", "340", "7120000", "Virgin Islands of the United States")]
    [InlineData("3408109999", "340", "8109999", "Virgin Islands of the United States")]
    [InlineData("3408120000", "340", "8120000", "Virgin Islands of the United States")]
    [InlineData("3409109999", "340", "9109999", "Virgin Islands of the United States")]
    [InlineData("3409120000", "340", "9120000", "Virgin Islands of the United States")]
    [InlineData("3409999999", "340", "9999999", "Virgin Islands of the United States")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedStatesVirginIslands, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
