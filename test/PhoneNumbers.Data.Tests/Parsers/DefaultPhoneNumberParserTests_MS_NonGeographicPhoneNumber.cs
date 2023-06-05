namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Montserrat <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MS_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Montserrat);

    [Theory]
    [InlineData("6643910000", "664", "3910000")]
    [InlineData("6643919999", "664", "3919999")]
    [InlineData("6644100000", "664", "4100000")]
    [InlineData("6644109999", "664", "4109999")]
    [InlineData("6644120000", "664", "4120000")]
    [InlineData("6644159999", "664", "4159999")]
    [InlineData("6644910000", "664", "4910000")]
    [InlineData("6644919999", "664", "4919999")]
    [InlineData("6644920000", "664", "4920000")]
    [InlineData("6644920999", "664", "4920999")]
    [InlineData("6644923000", "664", "4923000")]
    [InlineData("6644927999", "664", "4927999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montserrat, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
