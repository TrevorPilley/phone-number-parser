namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Cayman islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KY_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CaymanIslands);

    [Theory]
    [InlineData("3452220000", "345", "2220000")]
    [InlineData("3452229999", "345", "2229999")]
    [InlineData("3452320000", "345", "2320000")]
    [InlineData("3452339999", "345", "2339999")]
    [InlineData("3452440000", "345", "2440000")]
    [InlineData("3452449999", "345", "2449999")]
    [InlineData("3452660000", "345", "2660000")]
    [InlineData("3452669999", "345", "2669999")]
    [InlineData("3453330000", "345", "3330000")]
    [InlineData("3453339999", "345", "3339999")]
    [InlineData("3454440000", "345", "4440000")]
    [InlineData("3454449999", "345", "4449999")]
    [InlineData("3456230000", "345", "6230000")]
    [InlineData("3456239999", "345", "6239999")]
    [InlineData("3456380000", "345", "6380000")]
    [InlineData("3456389999", "345", "6389999")]
    [InlineData("3456400000", "345", "6400000")]
    [InlineData("3456409999", "345", "6409999")]
    [InlineData("3456490000", "345", "6490000")]
    [InlineData("3456499999", "345", "6499999")]
    [InlineData("3457430000", "345", "7430000")]
    [InlineData("3457439999", "345", "7439999")]
    [InlineData("3457450000", "345", "7450000")]
    [InlineData("3457479999", "345", "7479999")]
    [InlineData("3457490000", "345", "7490000")]
    [InlineData("3457499999", "345", "7499999")]
    [InlineData("3457660000", "345", "7660000")]
    [InlineData("3457669999", "345", "7669999")]
    [InlineData("3457680000", "345", "7680000")]
    [InlineData("3457699999", "345", "7699999")]
    [InlineData("3457770000", "345", "7770000")]
    [InlineData("3457779999", "345", "7779999")]
    [InlineData("3458000000", "345", "8000000")]
    [InlineData("3458009999", "345", "8009999")]
    [InlineData("3458140000", "345", "8140000")]
    [InlineData("3458159999", "345", "8159999")]
    [InlineData("3458480000", "345", "8480000")]
    [InlineData("3458499999", "345", "8499999")]
    [InlineData("3458880000", "345", "8880000")]
    [InlineData("3458889999", "345", "8889999")]
    [InlineData("3459140000", "345", "9140000")]
    [InlineData("3459149999", "345", "9149999")]
    [InlineData("3459450000", "345", "9450000")]
    [InlineData("3459499999", "345", "9499999")]
    public void Parse_Known_NonGeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CaymanIslands, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("3459760000", "345", "9760000")]
    [InlineData("3459769999", "345", "9769999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CaymanIslands, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
