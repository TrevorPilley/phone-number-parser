namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United states <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_US_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.UnitedStates);

    [Theory]
    [InlineData("15002000000", "500", "2000000")]
    [InlineData("15009999999", "500", "9999999")]
    [InlineData("15212000000", "521", "2000000")]
    [InlineData("15219999999", "521", "9999999")]
    [InlineData("15292000000", "529", "2000000")]
    [InlineData("15299999999", "529", "9999999")]
    [InlineData("15332000000", "533", "2000000")]
    [InlineData("15339999999", "533", "9999999")]
    [InlineData("15442000000", "544", "2000000")]
    [InlineData("15449999999", "544", "9999999")]
    [InlineData("15662000000", "566", "2000000")]
    [InlineData("15669999999", "566", "9999999")]
    [InlineData("15772000000", "577", "2000000")]
    [InlineData("15779999999", "577", "9999999")]
    [InlineData("15882000000", "588", "2000000")]
    [InlineData("15889999999", "588", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedStates, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("17102000000", "710", "2000000")]
    [InlineData("17102109999", "710", "2109999")]
    [InlineData("17102120000", "710", "2120000")]
    [InlineData("17103109999", "710", "3109999")]
    [InlineData("17103120000", "710", "3120000")]
    [InlineData("17104109999", "710", "4109999")]
    [InlineData("17104120000", "710", "4120000")]
    [InlineData("17105109999", "710", "5109999")]
    [InlineData("17105120000", "710", "5120000")]
    [InlineData("17106109999", "710", "6109999")]
    [InlineData("17106120000", "710", "6120000")]
    [InlineData("17107109999", "710", "7109999")]
    [InlineData("17107120000", "710", "7120000")]
    [InlineData("17108109999", "710", "8109999")]
    [InlineData("17108120000", "710", "8120000")]
    [InlineData("17109109999", "710", "9109999")]
    [InlineData("17109120000", "710", "9120000")]
    [InlineData("17109999999", "710", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedStates, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("18000000000", "800", "0000000")]
    [InlineData("18002709999", "800", "2709999")]
    [InlineData("18002720000", "800", "2720000")]
    [InlineData("18003889999", "800", "3889999")]
    [InlineData("18003900000", "800", "3900000")]
    [InlineData("18004149999", "800", "4149999")]
    [InlineData("18004160000", "800", "4160000")]
    [InlineData("18004839999", "800", "4839999")]
    [InlineData("18004850000", "800", "4850000")]
    [InlineData("18005339999", "800", "5339999")]
    [InlineData("18005350000", "800", "5350000")]
    [InlineData("18006229999", "800", "6229999")]
    [InlineData("18006240000", "800", "6240000")]
    [InlineData("18007029999", "800", "7029999")]
    [InlineData("18007040000", "800", "7040000")]
    [InlineData("18007439999", "800", "7439999")]
    [InlineData("18007450000", "800", "7450000")]
    [InlineData("18007509999", "800", "7509999")]
    [InlineData("18007520000", "800", "7520000")]
    [InlineData("18009039999", "800", "9039999")]
    [InlineData("18009050000", "800", "9050000")]
    [InlineData("18009069999", "800", "9069999")]
    [InlineData("18009080000", "800", "9080000")]
    [InlineData("18009109999", "800", "9109999")]
    [InlineData("18009129999", "800", "9129999")]
    [InlineData("18009999999", "800", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedStates, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("19002220000", "900", "2220000")]
    [InlineData("19002229999", "900", "2229999")]
    [InlineData("19002440000", "900", "2440000")]
    [InlineData("19002449999", "900", "2449999")]
    [InlineData("19002860000", "900", "2860000")]
    [InlineData("19002869999", "900", "2869999")]
    [InlineData("19003320000", "900", "3320000")]
    [InlineData("19003329999", "900", "3329999")]
    [InlineData("19003460000", "900", "3460000")]
    [InlineData("19003469999", "900", "3469999")]
    [InlineData("19003600000", "900", "3600000")]
    [InlineData("19003609999", "900", "3609999")]
    [InlineData("19003730000", "900", "3730000")]
    [InlineData("19003739999", "900", "3739999")]
    [InlineData("19003820000", "900", "3820000")]
    [InlineData("19003829999", "900", "3829999")]
    [InlineData("19003860000", "900", "3860000")]
    [InlineData("19003869999", "900", "3869999")]
    [InlineData("19004140000", "900", "4140000")]
    [InlineData("19004149999", "900", "4149999")]
    [InlineData("19004260000", "900", "4260000")]
    [InlineData("19004269999", "900", "4269999")]
    [InlineData("19004290000", "900", "4290000")]
    [InlineData("19004299999", "900", "4299999")]
    [InlineData("19004440000", "900", "4440000")]
    [InlineData("19004449999", "900", "4449999")]
    [InlineData("19005000000", "900", "5000000")]
    [InlineData("19005009999", "900", "5009999")]
    [InlineData("19006390000", "900", "6390000")]
    [InlineData("19006399999", "900", "6399999")]
    [InlineData("19006990000", "900", "6990000")]
    [InlineData("19006999999", "900", "6999999")]
    [InlineData("19007520000", "900", "7520000")]
    [InlineData("19007529999", "900", "7529999")]
    [InlineData("19007770000", "900", "7770000")]
    [InlineData("19007779999", "900", "7779999")]
    [InlineData("19008470000", "900", "8470000")]
    [InlineData("19008479999", "900", "8479999")]
    [InlineData("19008790000", "900", "8790000")]
    [InlineData("19008799999", "900", "8799999")]
    [InlineData("19009370000", "900", "9370000")]
    [InlineData("19009379999", "900", "9379999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedStates, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
