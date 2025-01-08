namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Dominica <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DM_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Dominica);

    [Theory]
    [InlineData("7672000000", "767", "2000000")]
    [InlineData("7672109999", "767", "2109999")]
    [InlineData("7672120000", "767", "2120000")]
    [InlineData("7673109999", "767", "3109999")]
    [InlineData("7673120000", "767", "3120000")]
    [InlineData("7674109999", "767", "4109999")]
    [InlineData("7674120000", "767", "4120000")]
    [InlineData("7675109999", "767", "5109999")]
    [InlineData("7675120000", "767", "5120000")]
    [InlineData("7676109999", "767", "6109999")]
    [InlineData("7676120000", "767", "6120000")]
    [InlineData("7677109999", "767", "7109999")]
    [InlineData("7677120000", "767", "7120000")]
    [InlineData("7678109999", "767", "8109999")]
    [InlineData("7678120000", "767", "8120000")]
    [InlineData("7679109999", "767", "9109999")]
    [InlineData("7679120000", "767", "9120000")]
    [InlineData("7679999999", "767", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Dominica, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
