namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Guam <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GU_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Guam);

    [Theory]
    [InlineData("6712000000", "671", "2000000")]
    [InlineData("6712109999", "671", "2109999")]
    [InlineData("6712120000", "671", "2120000")]
    [InlineData("6713109999", "671", "3109999")]
    [InlineData("6713120000", "671", "3120000")]
    [InlineData("6714109999", "671", "4109999")]
    [InlineData("6714120000", "671", "4120000")]
    [InlineData("6715109999", "671", "5109999")]
    [InlineData("6715120000", "671", "5120000")]
    [InlineData("6716109999", "671", "6109999")]
    [InlineData("6716120000", "671", "6120000")]
    [InlineData("6717109999", "671", "7109999")]
    [InlineData("6717120000", "671", "7120000")]
    [InlineData("6718109999", "671", "8109999")]
    [InlineData("6718120000", "671", "8120000")]
    [InlineData("6719109999", "671", "9109999")]
    [InlineData("6719120000", "671", "9120000")]
    [InlineData("6719999999", "671", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Guam, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
