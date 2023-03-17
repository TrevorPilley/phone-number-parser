namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United states <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_US_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.UnitedStates);

    [Theory]
    [InlineData("5002000000", "500", "2000000")]
    [InlineData("5009999999", "500", "9999999")]
    [InlineData("5212000000", "521", "2000000")]
    [InlineData("5219999999", "521", "9999999")]
    [InlineData("5292000000", "529", "2000000")]
    [InlineData("5299999999", "529", "9999999")]
    [InlineData("5332000000", "533", "2000000")]
    [InlineData("5339999999", "533", "9999999")]
    [InlineData("5442000000", "544", "2000000")]
    [InlineData("5449999999", "544", "9999999")]
    [InlineData("5662000000", "566", "2000000")]
    [InlineData("5669999999", "566", "9999999")]
    [InlineData("5772000000", "577", "2000000")]
    [InlineData("5779999999", "577", "9999999")]
    [InlineData("5882000000", "588", "2000000")]
    [InlineData("5889999999", "588", "9999999")]
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
    [InlineData("7102000000", "710", "2000000")]
    [InlineData("7102109999", "710", "2109999")]
    [InlineData("7102120000", "710", "2120000")]
    [InlineData("7103109999", "710", "3109999")]
    [InlineData("7103120000", "710", "3120000")]
    [InlineData("7104109999", "710", "4109999")]
    [InlineData("7104120000", "710", "4120000")]
    [InlineData("7105109999", "710", "5109999")]
    [InlineData("7105120000", "710", "5120000")]
    [InlineData("7106109999", "710", "6109999")]
    [InlineData("7106120000", "710", "6120000")]
    [InlineData("7107109999", "710", "7109999")]
    [InlineData("7107120000", "710", "7120000")]
    [InlineData("7108109999", "710", "8109999")]
    [InlineData("7108120000", "710", "8120000")]
    [InlineData("7109109999", "710", "9109999")]
    [InlineData("7109120000", "710", "9120000")]
    [InlineData("7109999999", "710", "9999999")]
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
    [InlineData("8000000000", "800", "0000000")]
    [InlineData("8002709999", "800", "2709999")]
    [InlineData("8002720000", "800", "2720000")]
    [InlineData("8003889999", "800", "3889999")]
    [InlineData("8003900000", "800", "3900000")]
    [InlineData("8004149999", "800", "4149999")]
    [InlineData("8004160000", "800", "4160000")]
    [InlineData("8004839999", "800", "4839999")]
    [InlineData("8004850000", "800", "4850000")]
    [InlineData("8005339999", "800", "5339999")]
    [InlineData("8005350000", "800", "5350000")]
    [InlineData("8006229999", "800", "6229999")]
    [InlineData("8006240000", "800", "6240000")]
    [InlineData("8007029999", "800", "7029999")]
    [InlineData("8007040000", "800", "7040000")]
    [InlineData("8007439999", "800", "7439999")]
    [InlineData("8007450000", "800", "7450000")]
    [InlineData("8007509999", "800", "7509999")]
    [InlineData("8007520000", "800", "7520000")]
    [InlineData("8009039999", "800", "9039999")]
    [InlineData("8009050000", "800", "9050000")]
    [InlineData("8009069999", "800", "9069999")]
    [InlineData("8009080000", "800", "9080000")]
    [InlineData("8009109999", "800", "9109999")]
    [InlineData("8009129999", "800", "9129999")]
    [InlineData("8009999999", "800", "9999999")]
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
    [InlineData("9002220000", "900", "2220000")]
    [InlineData("9002229999", "900", "2229999")]
    [InlineData("9002440000", "900", "2440000")]
    [InlineData("9002449999", "900", "2449999")]
    [InlineData("9002860000", "900", "2860000")]
    [InlineData("9002869999", "900", "2869999")]
    [InlineData("9003320000", "900", "3320000")]
    [InlineData("9003329999", "900", "3329999")]
    [InlineData("9003460000", "900", "3460000")]
    [InlineData("9003469999", "900", "3469999")]
    [InlineData("9003600000", "900", "3600000")]
    [InlineData("9003609999", "900", "3609999")]
    [InlineData("9003730000", "900", "3730000")]
    [InlineData("9003739999", "900", "3739999")]
    [InlineData("9003820000", "900", "3820000")]
    [InlineData("9003829999", "900", "3829999")]
    [InlineData("9003860000", "900", "3860000")]
    [InlineData("9003869999", "900", "3869999")]
    [InlineData("9004140000", "900", "4140000")]
    [InlineData("9004149999", "900", "4149999")]
    [InlineData("9004260000", "900", "4260000")]
    [InlineData("9004269999", "900", "4269999")]
    [InlineData("9004290000", "900", "4290000")]
    [InlineData("9004299999", "900", "4299999")]
    [InlineData("9004440000", "900", "4440000")]
    [InlineData("9004449999", "900", "4449999")]
    [InlineData("9005000000", "900", "5000000")]
    [InlineData("9005009999", "900", "5009999")]
    [InlineData("9006390000", "900", "6390000")]
    [InlineData("9006399999", "900", "6399999")]
    [InlineData("9006990000", "900", "6990000")]
    [InlineData("9006999999", "900", "6999999")]
    [InlineData("9007520000", "900", "7520000")]
    [InlineData("9007529999", "900", "7529999")]
    [InlineData("9007770000", "900", "7770000")]
    [InlineData("9007779999", "900", "7779999")]
    [InlineData("9008470000", "900", "8470000")]
    [InlineData("9008479999", "900", "8479999")]
    [InlineData("9008790000", "900", "8790000")]
    [InlineData("9008799999", "900", "8799999")]
    [InlineData("9009370000", "900", "9370000")]
    [InlineData("9009379999", "900", "9379999")]
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
