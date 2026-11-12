namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Australia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AU_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Australia);

    [Theory]
    [InlineData("09000000000", "900", "0000000")]
    [InlineData("09009999999", "900", "9999999")]
    [InlineData("09100000000", "910", "0000000")]
    [InlineData("09109999999", "910", "9999999")]
    [InlineData("09200000000", "920", "0000000")]
    [InlineData("09209999999", "920", "9999999")]
    [InlineData("09300000000", "930", "0000000")]
    [InlineData("09309999999", "930", "9999999")]
    [InlineData("09400000000", "940", "0000000")]
    [InlineData("09409999999", "940", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
