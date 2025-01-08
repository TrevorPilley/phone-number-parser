namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Cayman islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KY_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CaymanIslands);

    [Theory]
    [InlineData("3452000000", "345", "2000000")]
    [InlineData("3452109999", "345", "2109999")]
    [InlineData("3452120000", "345", "2120000")]
    [InlineData("3453109999", "345", "3109999")]
    [InlineData("3453120000", "345", "3120000")]
    [InlineData("3454109999", "345", "4109999")]
    [InlineData("3454120000", "345", "4120000")]
    [InlineData("3455109999", "345", "5109999")]
    [InlineData("3455120000", "345", "5120000")]
    [InlineData("3456109999", "345", "6109999")]
    [InlineData("3456120000", "345", "6120000")]
    [InlineData("3457109999", "345", "7109999")]
    [InlineData("3457120000", "345", "7120000")]
    [InlineData("3458109999", "345", "8109999")]
    [InlineData("3458120000", "345", "8120000")]
    [InlineData("3459109999", "345", "9109999")]
    [InlineData("3459120000", "345", "9120000")]
    [InlineData("3459999999", "345", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CaymanIslands, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
