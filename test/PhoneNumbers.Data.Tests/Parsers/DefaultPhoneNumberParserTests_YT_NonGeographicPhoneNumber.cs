namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Mayotte <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_YT_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Mayotte);

    [Theory]
    [InlineData("0268750000", "268750000")]
    [InlineData("0268799999", "268799999")]
    [InlineData("0268900000", "268900000")]
    [InlineData("0268999999", "268999999")]
    [InlineData("0269000000", "269000000")]
    [InlineData("0269999999", "269999999")]
    [InlineData("0806000000", "806000000")]
    [InlineData("0809999999", "809999999")]
    [InlineData("0836000000", "836000000")]
    [InlineData("0836999999", "836999999")]
    [InlineData("0860000000", "860000000")]
    [InlineData("0860999999", "860999999")]
    [InlineData("0868000000", "868000000")]
    [InlineData("0868999999", "868999999")]
    [InlineData("0939800000", "939800000")]
    [InlineData("0939899999", "939899999")]
    [InlineData("0947080000", "947080000")]
    [InlineData("0947099999", "947099999")]
    [InlineData("0947800000", "947800000")]
    [InlineData("0947899999", "947899999")]
    [InlineData("0976900000", "976900000")]
    [InlineData("0976999999", "976999999")]
    [InlineData("0990000000", "990000000")]
    [InlineData("0990099999", "990099999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Mayotte, nonGeographicPhoneNumber.Country);
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
        Assert.Equal(CountryInfo.Mayotte, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0700800000000", "700800000000")]
    [InlineData("0700899999999", "700899999999")]
    [InlineData("0901800000000", "901800000000")]
    [InlineData("0901899999999", "901899999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Mayotte, nonGeographicPhoneNumber.Country);
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
        Assert.Equal(CountryInfo.Mayotte, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
