namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Luxembourg <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LU_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Luxembourg);

    [Theory]
    [InlineData("2200", "2200")]
    [InlineData("2299", "2299")]
    [InlineData("2500", "2500")]
    [InlineData("2599", "2599")]
    [InlineData("2900", "2900")]
    [InlineData("2999", "2999")]
    [InlineData("3000", "3000")]
    [InlineData("5099", "5099")]
    [InlineData("7000", "7000")]
    [InlineData("7099", "7099")]
    [InlineData("8020", "8020")]
    [InlineData("8999", "8999")]
    [InlineData("9080", "9080")]
    [InlineData("9099", "9099")]
    [InlineData("9200", "9200")]
    [InlineData("9599", "9599")]
    [InlineData("9700", "9700")]
    [InlineData("9799", "9799")]
    [InlineData("9900", "9900")]
    [InlineData("9999", "9999")]
    [InlineData("22000", "22000")]
    [InlineData("22999", "22999")]
    [InlineData("25000", "25000")]
    [InlineData("25999", "25999")]
    [InlineData("29000", "29000")]
    [InlineData("29999", "29999")]
    [InlineData("30000", "30000")]
    [InlineData("50999", "50999")]
    [InlineData("70000", "70000")]
    [InlineData("70999", "70999")]
    [InlineData("80200", "80200")]
    [InlineData("89999", "89999")]
    [InlineData("90800", "90800")]
    [InlineData("90999", "90999")]
    [InlineData("92000", "92000")]
    [InlineData("95999", "95999")]
    [InlineData("97000", "97000")]
    [InlineData("97999", "97999")]
    [InlineData("99000", "99000")]
    [InlineData("99999", "99999")]
    [InlineData("220000", "220000")]
    [InlineData("229999", "229999")]
    [InlineData("250000", "250000")]
    [InlineData("259999", "259999")]
    [InlineData("290000", "290000")]
    [InlineData("299999", "299999")]
    [InlineData("300000", "300000")]
    [InlineData("509999", "509999")]
    [InlineData("700000", "700000")]
    [InlineData("709999", "709999")]
    [InlineData("802000", "802000")]
    [InlineData("899999", "899999")]
    [InlineData("908000", "908000")]
    [InlineData("909999", "909999")]
    [InlineData("920000", "920000")]
    [InlineData("959999", "959999")]
    [InlineData("970000", "970000")]
    [InlineData("979999", "979999")]
    [InlineData("990000", "990000")]
    [InlineData("999999", "999999")]
    [InlineData("2200000", "2200000")]
    [InlineData("2299999", "2299999")]
    [InlineData("2500000", "2500000")]
    [InlineData("2599999", "2599999")]
    [InlineData("2900000", "2900000")]
    [InlineData("2999999", "2999999")]
    [InlineData("3000000", "3000000")]
    [InlineData("5099999", "5099999")]
    [InlineData("7000000", "7000000")]
    [InlineData("7099999", "7099999")]
    [InlineData("8020000", "8020000")]
    [InlineData("8999999", "8999999")]
    [InlineData("9080000", "9080000")]
    [InlineData("9099999", "9099999")]
    [InlineData("9200000", "9200000")]
    [InlineData("9599999", "9599999")]
    [InlineData("9700000", "9700000")]
    [InlineData("9799999", "9799999")]
    [InlineData("9900000", "9900000")]
    [InlineData("9999999", "9999999")]
    [InlineData("20000000", "20000000")]
    [InlineData("20999999", "20999999")]
    [InlineData("22000000", "22000000")]
    [InlineData("22999999", "22999999")]
    [InlineData("23000000", "23000000")]
    [InlineData("24999999", "24999999")]
    [InlineData("25000000", "25000000")]
    [InlineData("25999999", "25999999")]
    [InlineData("26000000", "26000000")]
    [InlineData("28999999", "28999999")]
    [InlineData("29000000", "29000000")]
    [InlineData("29999999", "29999999")]
    [InlineData("30000000", "30000000")]
    [InlineData("50999999", "50999999")]
    [InlineData("70000000", "70000000")]
    [InlineData("70999999", "70999999")]
    [InlineData("80200000", "80200000")]
    [InlineData("89999999", "89999999")]
    [InlineData("90800000", "90800000")]
    [InlineData("90999999", "90999999")]
    [InlineData("92000000", "92000000")]
    [InlineData("95999999", "95999999")]
    [InlineData("97000000", "97000000")]
    [InlineData("97999999", "97999999")]
    [InlineData("99000000", "99000000")]
    [InlineData("99999999", "99999999")]
    [InlineData("220000000", "220000000")]
    [InlineData("229999999", "229999999")]
    [InlineData("250000000", "250000000")]
    [InlineData("259999999", "259999999")]
    [InlineData("290000000", "290000000")]
    [InlineData("299999999", "299999999")]
    [InlineData("300000000", "300000000")]
    [InlineData("509999999", "509999999")]
    [InlineData("700000000", "700000000")]
    [InlineData("709999999", "709999999")]
    [InlineData("802000000", "802000000")]
    [InlineData("899999999", "899999999")]
    [InlineData("908000000", "908000000")]
    [InlineData("909999999", "909999999")]
    [InlineData("920000000", "920000000")]
    [InlineData("959999999", "959999999")]
    [InlineData("970000000", "970000000")]
    [InlineData("979999999", "979999999")]
    [InlineData("990000000", "990000000")]
    [InlineData("999999999", "999999999")]
    [InlineData("2200000000", "2200000000")]
    [InlineData("2299999999", "2299999999")]
    [InlineData("2500000000", "2500000000")]
    [InlineData("2599999999", "2599999999")]
    [InlineData("2900000000", "2900000000")]
    [InlineData("2999999999", "2999999999")]
    [InlineData("3000000000", "3000000000")]
    [InlineData("5099999999", "5099999999")]
    [InlineData("7000000000", "7000000000")]
    [InlineData("7099999999", "7099999999")]
    [InlineData("8020000000", "8020000000")]
    [InlineData("8999999999", "8999999999")]
    [InlineData("9080000000", "9080000000")]
    [InlineData("9099999999", "9099999999")]
    [InlineData("9200000000", "9200000000")]
    [InlineData("9599999999", "9599999999")]
    [InlineData("9700000000", "9700000000")]
    [InlineData("9799999999", "9799999999")]
    [InlineData("9900000000", "9900000000")]
    [InlineData("9999999999", "9999999999")]
    [InlineData("22000000000", "22000000000")]
    [InlineData("22999999999", "22999999999")]
    [InlineData("25000000000", "25000000000")]
    [InlineData("25999999999", "25999999999")]
    [InlineData("29000000000", "29000000000")]
    [InlineData("29999999999", "29999999999")]
    [InlineData("30000000000", "30000000000")]
    [InlineData("50999999999", "50999999999")]
    [InlineData("70000000000", "70000000000")]
    [InlineData("70999999999", "70999999999")]
    [InlineData("80200000000", "80200000000")]
    [InlineData("89999999999", "89999999999")]
    [InlineData("90800000000", "90800000000")]
    [InlineData("90999999999", "90999999999")]
    [InlineData("92000000000", "92000000000")]
    [InlineData("95999999999", "95999999999")]
    [InlineData("97000000000", "97000000000")]
    [InlineData("97999999999", "97999999999")]
    [InlineData("99000000000", "99000000000")]
    [InlineData("99999999999", "99999999999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Luxembourg, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("80000000", "80000000")]
    [InlineData("80199999", "80199999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Luxembourg, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("90000000", "90000000")]
    [InlineData("90199999", "90199999")]
    [InlineData("90500000", "90500000")]
    [InlineData("90599999", "90599999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Luxembourg, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
