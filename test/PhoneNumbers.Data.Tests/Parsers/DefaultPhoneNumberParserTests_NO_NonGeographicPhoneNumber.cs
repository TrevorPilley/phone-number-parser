namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Norway <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_NO_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Norway);

    [Theory]
    [InlineData("21000000", "21000000")]
    [InlineData("24999999", "24999999")]
    [InlineData("31000000", "31000000")]
    [InlineData("33999999", "33999999")]
    [InlineData("35000000", "35000000")]
    [InlineData("35999999", "35999999")]
    [InlineData("37000000", "37000000")]
    [InlineData("38999999", "38999999")]
    [InlineData("51000000", "51000000")]
    [InlineData("53999999", "53999999")]
    [InlineData("55000000", "55000000")]
    [InlineData("57999999", "57999999")]
    [InlineData("61000000", "61000000")]
    [InlineData("64999999", "64999999")]
    [InlineData("66000000", "66000000")]
    [InlineData("67999999", "67999999")]
    [InlineData("69000000", "69000000")]
    [InlineData("79999999", "79999999")]
    [InlineData("80010000", "80010000")]
    [InlineData("80019999", "80019999")]
    [InlineData("81000000", "81000000")]
    [InlineData("81089999", "81089999")]
    [InlineData("81100000", "81100000")]
    [InlineData("81589999", "81589999")]
    [InlineData("81900000", "81900000")]
    [InlineData("82099999", "82099999")]
    [InlineData("82200000", "82200000")]
    [InlineData("82209999", "82209999")]
    [InlineData("82900000", "82900000")]
    [InlineData("82999999", "82999999")]
    [InlineData("85000000", "85000000")]
    [InlineData("85256999", "85256999")]
    [InlineData("85258000", "85258000")]
    [InlineData("85275999", "85275999")]
    [InlineData("85290000", "85290000")]
    [InlineData("85299999", "85299999")]
    [InlineData("85310000", "85310000")]
    [InlineData("85319999", "85319999")]
    [InlineData("85322000", "85322000")]
    [InlineData("85390000", "85390000")]
    [InlineData("85444999", "85444999")]
    [InlineData("85449999", "85449999")]
    [InlineData("85500000", "85500000")]
    [InlineData("85519999", "85519999")]
    [InlineData("87800000", "87800000")]
    [InlineData("88099999", "88099999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Norway, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("59000000", "59000000")]
    [InlineData("59999999", "59999999")]
    [InlineData("580000000000", "580000000000")]
    [InlineData("589999999999", "589999999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Norway, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
