namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Barbados <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BB_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Barbados);

    [Theory]
    [InlineData("2462270000", "246", "2270000")]
    [InlineData("2462299999", "246", "2299999")]
    [InlineData("2462700000", "246", "2700000")]
    [InlineData("2462749999", "246", "2749999")]
    [InlineData("2462920000", "246", "2920000")]
    [InlineData("2462929999", "246", "2929999")]
    [InlineData("2463100000", "246", "3100000")]
    [InlineData("2463109999", "246", "3109999")]
    [InlineData("2463120000", "246", "3120000")]
    [InlineData("2463199999", "246", "3199999")]
    [InlineData("2463670000", "246", "3670000")]
    [InlineData("2463679999", "246", "3679999")]
    [InlineData("2464100000", "246", "4100000")]
    [InlineData("2464109999", "246", "4109999")]
    [InlineData("2464120000", "246", "4120000")]
    [InlineData("2464129999", "246", "4129999")]
    [InlineData("2464140000", "246", "4140000")]
    [InlineData("2464399999", "246", "4399999")]
    [InlineData("2464440000", "246", "4440000")]
    [InlineData("2464449999", "246", "4449999")]
    [InlineData("2464670000", "246", "4670000")]
    [InlineData("2464679999", "246", "4679999")]
    [InlineData("2465200000", "246", "5200000")]
    [InlineData("2465209999", "246", "5209999")]
    [InlineData("2465210000", "246", "5210000")]
    [InlineData("2465210999", "246", "5210999")]
    [InlineData("2465213000", "246", "5213000")]
    [InlineData("2465213999", "246", "5213999")]
    [InlineData("2465216000", "246", "5216000")]
    [InlineData("2465216999", "246", "5216999")]
    [InlineData("2465218000", "246", "5218000")]
    [InlineData("2465219999", "246", "5219999")]
    [InlineData("2465300000", "246", "5300000")]
    [InlineData("2465319999", "246", "5319999")]
    [InlineData("2465350000", "246", "5350000")]
    [InlineData("2465399999", "246", "5399999")]
    [InlineData("2465460000", "246", "5460000")]
    [InlineData("2465499999", "246", "5499999")]
    [InlineData("2465540000", "246", "5540000")]
    [InlineData("2465559999", "246", "5559999")]
    [InlineData("2465710000", "246", "5710000")]
    [InlineData("2465739999", "246", "5739999")]
    [InlineData("2466200000", "246", "6200000")]
    [InlineData("2466299999", "246", "6299999")]
    [InlineData("2466380000", "246", "6380000")]
    [InlineData("2466389999", "246", "6389999")]
    [InlineData("2467360000", "246", "7360000")]
    [InlineData("2467379999", "246", "7379999")]
    [InlineData("2467530000", "246", "7530000")]
    [InlineData("2467539999", "246", "7539999")]
    [InlineData("2467570000", "246", "7570000")]
    [InlineData("2467579999", "246", "7579999")]
    [InlineData("2467760000", "246", "7760000")]
    [InlineData("2467789999", "246", "7789999")]
    [InlineData("2469580000", "246", "9580000")]
    [InlineData("2469589999", "246", "9589999")]
    [InlineData("2469630000", "246", "9630000")]
    [InlineData("2469639999", "246", "9639999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Barbados, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("2462760000", "246", "2760000")]
    [InlineData("2462769999", "246", "2769999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Barbados, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
