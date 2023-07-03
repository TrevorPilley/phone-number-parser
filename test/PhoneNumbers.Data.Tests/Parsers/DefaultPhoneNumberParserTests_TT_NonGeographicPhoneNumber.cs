namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Trinidad and tobago <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TT_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.TrinidadAndTobago);

    [Theory]
    [InlineData("8682010000", "868", "2010000")]
    [InlineData("8682019999", "868", "2019999")]
    [InlineData("8682030000", "868", "2030000")]
    [InlineData("8682039999", "868", "2039999")]
    [InlineData("8682150000", "868", "2150000")]
    [InlineData("8682299999", "868", "2299999")]
    [InlineData("8682300000", "868", "2300000")]
    [InlineData("8682429999", "868", "2429999")]
    [InlineData("8686070000", "868", "6070000")]
    [InlineData("8686089999", "868", "6089999")]
    [InlineData("8686140000", "868", "6140000")]
    [InlineData("8686169999", "868", "6169999")]
    [InlineData("8686190000", "868", "6190000")]
    [InlineData("8686199999", "868", "6199999")]
    [InlineData("8686210000", "868", "6210000")]
    [InlineData("8686779999", "868", "6779999")]
    [InlineData("8686790000", "868", "6790000")]
    [InlineData("8686799999", "868", "6799999")]
    [InlineData("8686900000", "868", "6900000")]
    [InlineData("8686989999", "868", "6989999")]
    [InlineData("8688210000", "868", "8210000")]
    [InlineData("8688229999", "868", "8229999")]
    public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.TrinidadAndTobago, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
