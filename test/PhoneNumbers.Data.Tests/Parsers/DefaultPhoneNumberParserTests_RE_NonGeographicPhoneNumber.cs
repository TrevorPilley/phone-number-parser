namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Reunion <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_RE_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Reunion);

    [Theory]
    [InlineData("0262010000", "262010000")]
    [InlineData("0262999999", "262999999")]
    [InlineData("0263000000", "263000000")]
    [InlineData("0263999999", "263999999")]
    [InlineData("0268700000", "268700000")]
    [InlineData("0268749999", "268749999")]
    [InlineData("0268800000", "268800000")]
    [InlineData("0268899999", "268899999")]
    [InlineData("0806000000", "806000000")]
    [InlineData("0809999999", "809999999")]
    [InlineData("0836000000", "836000000")]
    [InlineData("0836999999", "836999999")]
    [InlineData("0860000000", "860000000")]
    [InlineData("0860999999", "860999999")]
    [InlineData("0868000000", "868000000")]
    [InlineData("0868999999", "868999999")]
    [InlineData("0939900000", "939900000")]
    [InlineData("0939999999", "939999999")]
    [InlineData("0947060000", "947060000")]
    [InlineData("0947079999", "947079999")]
    [InlineData("0947900000", "947900000")]
    [InlineData("0947999999", "947999999")]
    [InlineData("0976200000", "976200000")]
    [InlineData("0976399999", "976399999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Reunion, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0800000000", "800000000")]
    [InlineData("0805999999", "805999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Reunion, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0700900000000", "700900000000")]
    [InlineData("0700999999999", "700999999999")]
    [InlineData("0901900000000", "901900000000")]
    [InlineData("0901999999999", "901999999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Reunion, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0810000000", "810000000")]
    [InlineData("0829999999", "829999999")]
    [InlineData("0890000000", "890000000")]
    [InlineData("0899999999", "899999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Reunion, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
