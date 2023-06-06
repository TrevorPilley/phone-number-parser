namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint vincent and the grenadines <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VC_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintVincentAndTheGrenadines);

    [Theory]
    [InlineData("7842660000", "784", "2660000")]
    [InlineData("7842669999", "784", "2669999")]
    [InlineData("7843660000", "784", "3660000")]
    [InlineData("7843869999", "784", "3869999")]
    [InlineData("7844380000", "784", "4380000")]
    [InlineData("7844389999", "784", "4389999")]
    [InlineData("7844500000", "784", "4500000")]
    [InlineData("7844539999", "784", "4539999")]
    [InlineData("7844560000", "784", "4560000")]
    [InlineData("7844589999", "784", "4589999")]
    [InlineData("7844800000", "784", "4800000")]
    [InlineData("7844909999", "784", "4909999")]
    [InlineData("7845550000", "784", "5550000")]
    [InlineData("7845559999", "784", "5559999")]
    [InlineData("7846380000", "784", "6380000")]
    [InlineData("7846389999", "784", "6389999")]
    [InlineData("7847200000", "784", "7200000")]
    [InlineData("7847209999", "784", "7209999")]
    [InlineData("7847840000", "784", "7840000")]
    [InlineData("7847849999", "784", "7849999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintVincentAndTheGrenadines, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
