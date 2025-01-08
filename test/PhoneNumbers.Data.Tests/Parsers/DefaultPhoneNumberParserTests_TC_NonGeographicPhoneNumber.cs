namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Turks and caicos islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TC_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.TurksAndCaicosIslands);

    [Theory]
    [InlineData("6492000000", "649", "2000000")]
    [InlineData("6492109999", "649", "2109999")]
    [InlineData("6492120000", "649", "2120000")]
    [InlineData("6493109999", "649", "3109999")]
    [InlineData("6493120000", "649", "3120000")]
    [InlineData("6494109999", "649", "4109999")]
    [InlineData("6494120000", "649", "4120000")]
    [InlineData("6495109999", "649", "5109999")]
    [InlineData("6495120000", "649", "5120000")]
    [InlineData("6496109999", "649", "6109999")]
    [InlineData("6496120000", "649", "6120000")]
    [InlineData("6497109999", "649", "7109999")]
    [InlineData("6497120000", "649", "7120000")]
    [InlineData("6498109999", "649", "8109999")]
    [InlineData("6498120000", "649", "8120000")]
    [InlineData("6499109999", "649", "9109999")]
    [InlineData("6499120000", "649", "9120000")]
    [InlineData("6499999999", "649", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.TurksAndCaicosIslands, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
