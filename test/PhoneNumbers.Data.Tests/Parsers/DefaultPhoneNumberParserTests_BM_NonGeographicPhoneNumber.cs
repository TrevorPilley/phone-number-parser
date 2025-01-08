namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bermuda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BM_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bermuda);

    [Theory]
    [InlineData("4412000000", "441", "2000000")]
    [InlineData("4412109999", "441", "2109999")]
    [InlineData("4412120000", "441", "2120000")]
    [InlineData("4413109999", "441", "3109999")]
    [InlineData("4413120000", "441", "3120000")]
    [InlineData("4414109999", "441", "4109999")]
    [InlineData("4414120000", "441", "4120000")]
    [InlineData("4415109999", "441", "5109999")]
    [InlineData("4415120000", "441", "5120000")]
    [InlineData("4416109999", "441", "6109999")]
    [InlineData("4416120000", "441", "6120000")]
    [InlineData("4417109999", "441", "7109999")]
    [InlineData("4417120000", "441", "7120000")]
    [InlineData("4418109999", "441", "8109999")]
    [InlineData("4418120000", "441", "8120000")]
    [InlineData("4419109999", "441", "9109999")]
    [InlineData("4419120000", "441", "9120000")]
    [InlineData("4419999999", "441", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bermuda, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
