namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Liechtenstein <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LI_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Liechtenstein);

    [Theory]
    [InlineData("2170000", "2170000")]
    [InlineData("2179999", "2179999")]
    [InlineData("2200000", "2200000")]
    [InlineData("2209999", "2209999")]
    [InlineData("2220000", "2220000")]
    [InlineData("2229999", "2229999")]
    [InlineData("2240000", "2240000")]
    [InlineData("2249999", "2249999")]
    [InlineData("2300000", "2300000")]
    [InlineData("2309999", "2309999")]
    [InlineData("2310000", "2310000")]
    [InlineData("2319999", "2319999")]
    [InlineData("2320000", "2320000")]
    [InlineData("2329999", "2329999")]
    [InlineData("2330000", "2330000")]
    [InlineData("2339999", "2339999")]
    [InlineData("2340000", "2340000")]
    [InlineData("2349999", "2349999")]
    [InlineData("2350000", "2350000")]
    [InlineData("2359999", "2359999")]
    [InlineData("2360000", "2360000")]
    [InlineData("2369999", "2369999")]
    [InlineData("2370000", "2370000")]
    [InlineData("2379999", "2379999")]
    [InlineData("2380000", "2380000")]
    [InlineData("2389999", "2389999")]
    [InlineData("2390000", "2390000")]
    [InlineData("2399999", "2399999")]
    [InlineData("2600000", "2600000")]
    [InlineData("2609999", "2609999")]
    [InlineData("2620000", "2620000")]
    [InlineData("2629999", "2629999")]
    [InlineData("2630000", "2630000")]
    [InlineData("2639999", "2639999")]
    [InlineData("2640000", "2640000")]
    [InlineData("2649999", "2649999")]
    [InlineData("2650000", "2650000")]
    [InlineData("2659999", "2659999")]
    [InlineData("2670000", "2670000")]
    [InlineData("2679999", "2679999")]
    [InlineData("2680000", "2680000")]
    [InlineData("2689999", "2689999")]
    [InlineData("2960000", "2960000")]
    [InlineData("2969999", "2969999")]
    [InlineData("3200000", "3200000")]
    [InlineData("3209999", "3209999")]
    [InlineData("3330000", "3330000")]
    [InlineData("3339999", "3339999")]
    [InlineData("3400000", "3400000")]
    [InlineData("3409999", "3409999")]
    [InlineData("3700000", "3700000")]
    [InlineData("3709999", "3709999")]
    [InlineData("3710000", "3710000")]
    [InlineData("3719999", "3719999")]
    [InlineData("3730000", "3730000")]
    [InlineData("3739999", "3739999")]
    [InlineData("3750000", "3750000")]
    [InlineData("3759999", "3759999")]
    [InlineData("3760000", "3760000")]
    [InlineData("3769999", "3769999")]
    [InlineData("3770000", "3770000")]
    [InlineData("3779999", "3779999")]
    [InlineData("3800000", "3800000")]
    [InlineData("3809999", "3809999")]
    [InlineData("3840000", "3840000")]
    [InlineData("3849999", "3849999")]
    [InlineData("3880000", "3880000")]
    [InlineData("3889999", "3889999")]
    [InlineData("3900000", "3900000")]
    [InlineData("3909999", "3909999")]
    [InlineData("3920000", "3920000")]
    [InlineData("3929999", "3929999")]
    [InlineData("3960000", "3960000")]
    [InlineData("3969999", "3969999")]
    [InlineData("3990000", "3990000")]
    [InlineData("3999999", "3999999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Liechtenstein, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("8002000", "8002000")]
    [InlineData("8002999", "8002999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Liechtenstein, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
