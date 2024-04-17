namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Hong kong <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_HK_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.HongKong);

    [Theory]
    [InlineData("40400000", "40400000")]
    [InlineData("40499999", "40499999")]
    [InlineData("40600000", "40600000")]
    [InlineData("40699999", "40699999")]
    [InlineData("40930000", "40930000")]
    [InlineData("40999999", "40999999")]
    [InlineData("42000000", "42000000")]
    [InlineData("42099999", "42099999")]
    [InlineData("42200000", "42200000")]
    [InlineData("42999999", "42999999")]
    [InlineData("43300000", "43300000")]
    [InlineData("44909999", "44909999")]
    [InlineData("45100000", "45100000")]
    [InlineData("47999999", "47999999")]
    [InlineData("48100000", "48100000")]
    [InlineData("48199999", "48199999")]
    [InlineData("48210000", "48210000")]
    [InlineData("48299999", "48299999")]
    [InlineData("48600000", "48600000")]
    [InlineData("48699999", "48699999")]
    [InlineData("48900000", "48900000")]
    [InlineData("48999999", "48999999")]
    [InlineData("49230000", "49230000")]
    [InlineData("49299999", "49299999")]
    [InlineData("49520000", "49520000")]
    [InlineData("49599999", "49599999")]
    [InlineData("49800000", "49800000")]
    [InlineData("49899999", "49899999")]
    [InlineData("51000000", "51000000")]
    [InlineData("57999999", "57999999")]
    [InlineData("59000000", "59000000")]
    [InlineData("59999999", "59999999")]
    [InlineData("60100000", "60100000")]
    [InlineData("69999999", "69999999")]
    [InlineData("70100000", "70100000")]
    [InlineData("73999999", "73999999")]
    [InlineData("81500000", "81500000")]
    [InlineData("81599999", "81599999")]
    [InlineData("81672000", "81672000")]
    [InlineData("81672999", "81672999")]
    [InlineData("81800000", "81800000")]
    [InlineData("81899999", "81899999")]
    [InlineData("82400000", "82400000")]
    [InlineData("82599999", "82599999")]
    [InlineData("82679000", "82679000")]
    [InlineData("82679999", "82679999")]
    [InlineData("82700000", "82700000")]
    [InlineData("82999999", "82999999")]
    [InlineData("83100000", "83100000")]
    [InlineData("83199999", "83199999")]
    [InlineData("83201000", "83201000")]
    [InlineData("83289999", "83289999")]
    [InlineData("83500000", "83500000")]
    [InlineData("83699999", "83699999")]
    [InlineData("83760000", "83760000")]
    [InlineData("85199999", "85199999")]
    [InlineData("85300000", "85300000")]
    [InlineData("87999999", "87999999")]
    [InlineData("89000000", "89000000")]
    [InlineData("89999999", "89999999")]
    [InlineData("90100000", "90100000")]
    [InlineData("91099999", "91099999")]
    [InlineData("91200000", "91200000")]
    [InlineData("98999999", "98999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.HongKong, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("81000000", "81000000")]
    [InlineData("81499999", "81499999")]
    [InlineData("81600000", "81600000")]
    [InlineData("81671999", "81671999")]
    [InlineData("81673000", "81673000")]
    [InlineData("81799999", "81799999")]
    [InlineData("81900000", "81900000")]
    [InlineData("82399999", "82399999")]
    [InlineData("82600000", "82600000")]
    [InlineData("82678999", "82678999")]
    [InlineData("82680000", "82680000")]
    [InlineData("82699999", "82699999")]
    [InlineData("83000000", "83000000")]
    [InlineData("83099999", "83099999")]
    [InlineData("83200000", "83200000")]
    [InlineData("83200999", "83200999")]
    [InlineData("83290000", "83290000")]
    [InlineData("83499999", "83499999")]
    [InlineData("83700000", "83700000")]
    [InlineData("83705999", "83705999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.HongKong, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
