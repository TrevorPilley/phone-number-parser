namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Dominican republic <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DO_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.DominicanRepublic);

    [Theory]
    [InlineData("8092000000", "809", "2000000")]
    [InlineData("8092109999", "809", "2109999")]
    [InlineData("8092120000", "809", "2120000")]
    [InlineData("8093109999", "809", "3109999")]
    [InlineData("8093120000", "809", "3120000")]
    [InlineData("8094109999", "809", "4109999")]
    [InlineData("8094120000", "809", "4120000")]
    [InlineData("8095109999", "809", "5109999")]
    [InlineData("8095120000", "809", "5120000")]
    [InlineData("8096109999", "809", "6109999")]
    [InlineData("8096120000", "809", "6120000")]
    [InlineData("8097109999", "809", "7109999")]
    [InlineData("8097120000", "809", "7120000")]
    [InlineData("8098109999", "809", "8109999")]
    [InlineData("8098120000", "809", "8120000")]
    [InlineData("8099109999", "809", "9109999")]
    [InlineData("8099120000", "809", "9120000")]
    [InlineData("8099999999", "809", "9999999")]
    [InlineData("8292000000", "829", "2000000")]
    [InlineData("8292109999", "829", "2109999")]
    [InlineData("8292120000", "829", "2120000")]
    [InlineData("8293109999", "829", "3109999")]
    [InlineData("8293120000", "829", "3120000")]
    [InlineData("8294109999", "829", "4109999")]
    [InlineData("8294120000", "829", "4120000")]
    [InlineData("8295109999", "829", "5109999")]
    [InlineData("8295120000", "829", "5120000")]
    [InlineData("8296109999", "829", "6109999")]
    [InlineData("8296120000", "829", "6120000")]
    [InlineData("8297109999", "829", "7109999")]
    [InlineData("8297120000", "829", "7120000")]
    [InlineData("8298109999", "829", "8109999")]
    [InlineData("8298120000", "829", "8120000")]
    [InlineData("8299109999", "829", "9109999")]
    [InlineData("8299120000", "829", "9120000")]
    [InlineData("8299999999", "829", "9999999")]
    [InlineData("8492000000", "849", "2000000")]
    [InlineData("8492109999", "849", "2109999")]
    [InlineData("8492120000", "849", "2120000")]
    [InlineData("8493109999", "849", "3109999")]
    [InlineData("8493120000", "849", "3120000")]
    [InlineData("8494109999", "849", "4109999")]
    [InlineData("8494120000", "849", "4120000")]
    [InlineData("8495109999", "849", "5109999")]
    [InlineData("8495120000", "849", "5120000")]
    [InlineData("8496109999", "849", "6109999")]
    [InlineData("8496120000", "849", "6120000")]
    [InlineData("8497109999", "849", "7109999")]
    [InlineData("8497120000", "849", "7120000")]
    [InlineData("8498109999", "849", "8109999")]
    [InlineData("8498120000", "849", "8120000")]
    [InlineData("8499109999", "849", "9109999")]
    [InlineData("8499120000", "849", "9120000")]
    [InlineData("8499999999", "849", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.DominicanRepublic, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
