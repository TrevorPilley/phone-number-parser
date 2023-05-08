namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Barbados <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BB_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Barbados);

    [Theory]
    [InlineData("2462110000", "246", "2110000")]
    [InlineData("2462119999", "246", "2119999")]
    [InlineData("2462230000", "246", "2230000")]
    [InlineData("2462239999", "246", "2239999")]
    [InlineData("2462290000", "246", "2290000")]
    [InlineData("2462299999", "246", "2299999")]
    [InlineData("2462920000", "246", "2920000")]
    [InlineData("2462929999", "246", "2929999")]
    [InlineData("2463100000", "246", "3100000")]
    [InlineData("2463199999", "246", "3199999")]
    [InlineData("2463670000", "246", "3670000")]
    [InlineData("2463679999", "246", "3679999")]
    [InlineData("2464110000", "246", "4110000")]
    [InlineData("2464119999", "246", "4119999")]
    [InlineData("2464170000", "246", "4170000")]
    [InlineData("2464190000", "246", "4190000")]
    [InlineData("2464300000", "246", "4300000")]
    [InlineData("2464319999", "246", "4319999")]
    [InlineData("2464440000", "246", "4440000")]
    [InlineData("2464449999", "246", "4449999")]
    [InlineData("2464470000", "246", "4470000")]
    [InlineData("2464499999", "246", "4499999")]
    [InlineData("2464670000", "246", "4670000")]
    [InlineData("2464679999", "246", "4679999")]
    [InlineData("2465110000", "246", "5110000")]
    [InlineData("2465119999", "246", "5119999")]
    [InlineData("2465550000", "246", "5550000")]
    [InlineData("2465559999", "246", "5559999")]
    [InlineData("2466110000", "246", "6110000")]
    [InlineData("2466119999", "246", "6119999")]
    [InlineData("2467110000", "246", "7110000")]
    [InlineData("2467119999", "246", "7119999")]
    [InlineData("2467360000", "246", "7360000")]
    [InlineData("2467369999", "246", "7369999")]
    [InlineData("2467530000", "246", "7530000")]
    [InlineData("2467539999", "246", "7539999")]
    [InlineData("2467760000", "246", "7760000")]
    [InlineData("2467789999", "246", "7789999")]
    [InlineData("2468110000", "246", "8110000")]
    [InlineData("2468119999", "246", "8119999")]
    [InlineData("2469110000", "246", "9110000")]
    [InlineData("2469119999", "246", "9119999")]
    [InlineData("2469180000", "246", "9180000")]
    [InlineData("2469199999", "246", "9199999")]
    [InlineData("2469580000", "246", "9580000")]
    [InlineData("2469589999", "246", "9589999")]
    [InlineData("2469760000", "246", "9760000")]
    [InlineData("2469769999", "246", "9769999")]
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
}
