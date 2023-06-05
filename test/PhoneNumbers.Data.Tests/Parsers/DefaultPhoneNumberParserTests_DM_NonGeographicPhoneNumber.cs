namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Dominica <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DM_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Dominica);

    [Theory]
    [InlineData("7672550000", "767", "2550000")]
    [InlineData("7672559999", "767", "2559999")]
    [InlineData("7672660000", "767", "2660000")]
    [InlineData("7672669999", "767", "2669999")]
    [InlineData("7674200000", "767", "4200000")]
    [InlineData("7674219999", "767", "4219999")]
    [InlineData("7674400000", "767", "4400000")]
    [InlineData("7674429999", "767", "4429999")]
    [InlineData("7674450000", "767", "4450000")]
    [InlineData("7674499999", "767", "4499999")]
    [InlineData("7675000000", "767", "5000000")]
    [InlineData("7675049999", "767", "5049999")]
    [InlineData("7677010000", "767", "7010000")]
    [InlineData("7677039999", "767", "7039999")]
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
