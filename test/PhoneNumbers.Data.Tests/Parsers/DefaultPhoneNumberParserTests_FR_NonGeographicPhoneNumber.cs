namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for France <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_FR_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.France);

    [Theory]
    [InlineData("0105000000", "105000000")]
    [InlineData("0105999999", "105999999")]
    [InlineData("0110000000", "110000000")]
    [InlineData("0189999999", "189999999")]
    [InlineData("0199010000", "199010000")]
    [InlineData("0199999999", "199999999")]
    [InlineData("0210000000", "210000000")]
    [InlineData("0260999999", "260999999")]
    [InlineData("0261000000", "261000000")]
    [InlineData("0261899999", "261899999")]
    [InlineData("0261900000", "261900000")]
    [InlineData("0261909999", "261909999")]
    [InlineData("0261920000", "261920000")]
    [InlineData("0261999999", "261999999")]
    [InlineData("0265000000", "265000000")]
    [InlineData("0267999999", "267999999")]
    [InlineData("0270000000", "270000000")]
    [InlineData("0280999999", "280999999")]
    [InlineData("0281000000", "281000000")]
    [InlineData("0281099999", "281099999")]
    [InlineData("0281100000", "281100000")]
    [InlineData("0281999999", "281999999")]
    [InlineData("0282000000", "282000000")]
    [InlineData("0299999999", "299999999")]
    [InlineData("0310000000", "310000000")]
    [InlineData("0340999999", "340999999")]
    [InlineData("0341000000", "341000000")]
    [InlineData("0341099999", "341099999")]
    [InlineData("0341100000", "341100000")]
    [InlineData("0341999999", "341999999")]
    [InlineData("0342000000", "342000000")]
    [InlineData("0349999999", "349999999")]
    [InlineData("0351000000", "351000000")]
    [InlineData("0352999999", "352999999")]
    [InlineData("0353000000", "353000000")]
    [InlineData("0353009999", "353009999")]
    [InlineData("0353020000", "353020000")]
    [InlineData("0353099999", "353099999")]
    [InlineData("0353100000", "353100000")]
    [InlineData("0353999999", "353999999")]
    [InlineData("0354000000", "354000000")]
    [InlineData("0399999999", "399999999")]
    [InlineData("0410000000", "410000000")]
    [InlineData("0440999999", "440999999")]
    [InlineData("0441000000", "441000000")]
    [InlineData("0441099999", "441099999")]
    [InlineData("0441100000", "441100000")]
    [InlineData("0441999999", "441999999")]
    [InlineData("0442000000", "442000000")]
    [InlineData("0459999999", "459999999")]
    [InlineData("0465000000", "465000000")]
    [InlineData("0465699999", "465699999")]
    [InlineData("0465700000", "465700000")]
    [InlineData("0465709999", "465709999")]
    [InlineData("0465720000", "465720000")]
    [InlineData("0465799999", "465799999")]
    [InlineData("0465800000", "465800000")]
    [InlineData("0465999999", "465999999")]
    [InlineData("0470000000", "470000000")]
    [InlineData("0499999999", "499999999")]
    [InlineData("0516000000", "516000000")]
    [InlineData("0521999999", "521999999")]
    [InlineData("0523500000", "523500000")]
    [InlineData("0523999999", "523999999")]
    [InlineData("0524000000", "524000000")]
    [InlineData("0525999999", "525999999")]
    [InlineData("0531000000", "531000000")]
    [InlineData("0535999999", "535999999")]
    [InlineData("0536000000", "536000000")]
    [InlineData("0536399999", "536399999")]
    [InlineData("0536400000", "536400000")]
    [InlineData("0536489999", "536489999")]
    [InlineData("0536500000", "536500000")]
    [InlineData("0536999999", "536999999")]
    [InlineData("0537000000", "537000000")]
    [InlineData("0540999999", "540999999")]
    [InlineData("0541000000", "541000000")]
    [InlineData("0541099999", "541099999")]
    [InlineData("0541100000", "541100000")]
    [InlineData("0541999999", "541999999")]
    [InlineData("0542000000", "542000000")]
    [InlineData("0589999999", "589999999")]
    [InlineData("0806000000", "806000000")]
    [InlineData("0809999999", "809999999")]
    [InlineData("0836000000", "836000000")]
    [InlineData("0836999999", "836999999")]
    [InlineData("0860000000", "860000000")]
    [InlineData("0860999999", "860999999")]
    [InlineData("0868000000", "868000000")]
    [InlineData("0868999999", "868999999")]
    [InlineData("0902000000", "902000000")]
    [InlineData("0938999999", "938999999")]
    [InlineData("0939000000", "939000000")]
    [InlineData("0939499999", "939499999")]
    [InlineData("0940000000", "940000000")]
    [InlineData("0941000000", "941000000")]
    [InlineData("0941099999", "941099999")]
    [InlineData("0941100000", "941100000")]
    [InlineData("0941999999", "941999999")]
    [InlineData("0942000000", "942000000")]
    [InlineData("0946999999", "946999999")]
    [InlineData("0946999999", "946999999")]
    [InlineData("0948000000", "948000000")]
    [InlineData("0975999999", "975999999")]
    [InlineData("0977000000", "977000000")]
    [InlineData("0998999999", "998999999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.France, nonGeographicPhoneNumber.Country);
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
        Assert.Equal(CountryInfo.France, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("07000000000000", "7000000000000")]
    [InlineData("07004999999999", "7004999999999")]
    [InlineData("09010000000000", "9010000000000")]
    [InlineData("09014999999999", "9014999999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.France, nonGeographicPhoneNumber.Country);
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
        Assert.Equal(CountryInfo.France, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
