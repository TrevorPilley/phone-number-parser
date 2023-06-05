namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Grenada <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GD_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Grenada);

    [Theory]
    [InlineData("4732300000", "473", "2300000")]
    [InlineData("4732329999", "473", "2329999")]
    [InlineData("4732690000", "473", "2690000")]
    [InlineData("4732699999", "473", "2699999")]
    [InlineData("4733280000", "473", "3280000")]
    [InlineData("4733299999", "473", "3299999")]
    [InlineData("4733860000", "473", "3860000")]
    [InlineData("4733869999", "473", "3869999")]
    [InlineData("4734080000", "473", "4080000")]
    [InlineData("4734089999", "473", "4089999")]
    [InlineData("4734350000", "473", "4350000")]
    [InlineData("4734449999", "473", "4449999")]
    [InlineData("4734490000", "473", "4490000")]
    [InlineData("4734499999", "473", "4499999")]
    [InlineData("4734550000", "473", "4550000")]
    [InlineData("4734579999", "473", "4579999")]
    [InlineData("4734590000", "473", "4590000")]
    [InlineData("4734599999", "473", "4599999")]
    [InlineData("4734680000", "473", "4680000")]
    [InlineData("4734689999", "473", "4689999")]
    [InlineData("4734730000", "473", "4730000")]
    [InlineData("4734739999", "473", "4739999")]
    [InlineData("4734900000", "473", "4900000")]
    [InlineData("4734909999", "473", "4909999")]
    [InlineData("4736360000", "473", "6360000")]
    [InlineData("4736369999", "473", "6369999")]
    [InlineData("4736380000", "473", "6380000")]
    [InlineData("4736389999", "473", "6389999")]
    [InlineData("4737580000", "473", "7580000")]
    [InlineData("4737589999", "473", "7589999")]
    [InlineData("4737840000", "473", "7840000")]
    [InlineData("4737849999", "473", "7849999")]
    [InlineData("4738002000", "473", "8002000")]
    [InlineData("4738005999", "473", "8005999")]
    [InlineData("4738007000", "473", "8007000")]
    [InlineData("4738007999", "473", "8007999")]
    [InlineData("4739380000", "473", "9380000")]
    [InlineData("4739389999", "473", "9389999")]
    public void Parse_Known_NonGeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Grenada, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
