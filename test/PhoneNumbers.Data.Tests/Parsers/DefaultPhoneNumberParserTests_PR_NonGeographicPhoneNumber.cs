namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Puerto rico <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_PR_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.PuertoRico);

    [Theory]
    [InlineData("7872000000", "787", "2000000")]
    [InlineData("7872109999", "787", "2109999")]
    [InlineData("7872120000", "787", "2120000")]
    [InlineData("7873109999", "787", "3109999")]
    [InlineData("7873120000", "787", "3120000")]
    [InlineData("7874109999", "787", "4109999")]
    [InlineData("7874120000", "787", "4120000")]
    [InlineData("7875109999", "787", "5109999")]
    [InlineData("7875120000", "787", "5120000")]
    [InlineData("7876109999", "787", "6109999")]
    [InlineData("7876120000", "787", "6120000")]
    [InlineData("7877109999", "787", "7109999")]
    [InlineData("7877120000", "787", "7120000")]
    [InlineData("7878109999", "787", "8109999")]
    [InlineData("7878120000", "787", "8120000")]
    [InlineData("7879109999", "787", "9109999")]
    [InlineData("7879120000", "787", "9120000")]
    [InlineData("7879999999", "787", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PuertoRico, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("9392000000", "939", "2000000")]
    [InlineData("9392109999", "939", "2109999")]
    [InlineData("9392120000", "939", "2120000")]
    [InlineData("9393109999", "939", "3109999")]
    [InlineData("9393120000", "939", "3120000")]
    [InlineData("9394109999", "939", "4109999")]
    [InlineData("9394120000", "939", "4120000")]
    [InlineData("9395109999", "939", "5109999")]
    [InlineData("9395120000", "939", "5120000")]
    [InlineData("9396109999", "939", "6109999")]
    [InlineData("9396120000", "939", "6120000")]
    [InlineData("9397109999", "939", "7109999")]
    [InlineData("9397120000", "939", "7120000")]
    [InlineData("9398109999", "939", "8109999")]
    [InlineData("9398120000", "939", "8120000")]
    [InlineData("9399109999", "939", "9109999")]
    [InlineData("9399120000", "939", "9120000")]
    [InlineData("9399999999", "939", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_9XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PuertoRico, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
