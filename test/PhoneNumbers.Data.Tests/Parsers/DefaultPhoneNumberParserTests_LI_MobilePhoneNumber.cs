namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Liechtenstein <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LI_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Liechtenstein);

    [Theory]
    [InlineData("7700000", "7700000")]
    [InlineData("7999999", "7999999")]
    [InlineData("645000000", "645000000")]
    [InlineData("661099999", "661099999")]
    [InlineData("661100000", "661100000")]
    [InlineData("661199999", "661199999")]
    [InlineData("662000000", "662000000")]
    [InlineData("662099999", "662099999")]
    [InlineData("662100000", "662100000")]
    [InlineData("662199999", "662199999")]
    [InlineData("662200000", "662200000")]
    [InlineData("662299999", "662299999")]
    [InlineData("662300000", "662300000")]
    [InlineData("662399999", "662399999")]
    [InlineData("662400000", "662400000")]
    [InlineData("662499999", "662499999")]
    [InlineData("662500000", "662500000")]
    [InlineData("662599999", "662599999")]
    [InlineData("662600000", "662600000")]
    [InlineData("662699999", "662699999")]
    [InlineData("662700000", "662700000")]
    [InlineData("662799999", "662799999")]
    [InlineData("662800000", "662800000")]
    [InlineData("662899999", "662899999")]
    [InlineData("662900000", "662900000")]
    [InlineData("662999999", "662999999")]
    [InlineData("663700000", "663700000")]
    [InlineData("663799999", "663799999")]
    [InlineData("663800000", "663800000")]
    [InlineData("663899999", "663899999")]
    [InlineData("663900000", "663900000")]
    [InlineData("663999999", "663999999")]
    [InlineData("664000000", "664000000")]
    [InlineData("666999999", "666999999")]
    [InlineData("667000000", "667000000")]
    [InlineData("667099999", "667099999")]
    [InlineData("668000000", "668000000")]
    [InlineData("668999999", "668999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Liechtenstein, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
