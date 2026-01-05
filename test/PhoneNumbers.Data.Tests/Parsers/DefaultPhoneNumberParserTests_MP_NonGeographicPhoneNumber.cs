namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Northern mariana island <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MP_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.NorthernMarianaIslands);

    [Theory]
    [InlineData("6702000000", "670", "2000000")]
    [InlineData("6702109999", "670", "2109999")]
    [InlineData("6702120000", "670", "2120000")]
    [InlineData("6703109999", "670", "3109999")]
    [InlineData("6703120000", "670", "3120000")]
    [InlineData("6704109999", "670", "4109999")]
    [InlineData("6704120000", "670", "4120000")]
    [InlineData("6705109999", "670", "5109999")]
    [InlineData("6705120000", "670", "5120000")]
    [InlineData("6706109999", "670", "6109999")]
    [InlineData("6706120000", "670", "6120000")]
    [InlineData("6707109999", "670", "7109999")]
    [InlineData("6707120000", "670", "7120000")]
    [InlineData("6708109999", "670", "8109999")]
    [InlineData("6708120000", "670", "8120000")]
    [InlineData("6709109999", "670", "9109999")]
    [InlineData("6709120000", "670", "9120000")]
    [InlineData("6709999999", "670", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.NorthernMarianaIslands, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
