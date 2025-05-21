namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Jordan <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_JO_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Jordan);

    [Theory]
    [InlineData("022010000", "2", "2010000")]
    [InlineData("022069999", "2", "2069999")]
    [InlineData("022090000", "2", "2090000")]
    [InlineData("022099999", "2", "2099999")]
    [InlineData("022110000", "2", "2110000")]
    [InlineData("022139999", "2", "2139999")]
    [InlineData("022150000", "2", "2150000")]
    [InlineData("022179999", "2", "2179999")]
    [InlineData("022200000", "2", "2200000")]
    [InlineData("022209999", "2", "2209999")]
    [InlineData("022240000", "2", "2240000")]
    [InlineData("022279999", "2", "2279999")]
    [InlineData("022300000", "2", "2300000")]
    [InlineData("022399999", "2", "2399999")]
    [InlineData("026200000", "2", "6200000")]
    [InlineData("026239999", "2", "6239999")]
    [InlineData("026250000", "2", "6250000")]
    [InlineData("026359999", "2", "6359999")]
    [InlineData("026370000", "2", "6370000")]
    [InlineData("026389999", "2", "6389999")]
    [InlineData("026420000", "2", "6420000")]
    [InlineData("026429999", "2", "6429999")]
    [InlineData("026440000", "2", "6440000")]
    [InlineData("026479999", "2", "6479999")]
    [InlineData("026500000", "2", "6500000")]
    [InlineData("026529999", "2", "6529999")]
    [InlineData("026540000", "2", "6540000")]
    [InlineData("026589999", "2", "6589999")]
    [InlineData("027010000", "2", "7010000")]
    [InlineData("027079999", "2", "7079999")]
    [InlineData("027200000", "2", "7200000")]
    [InlineData("027219999", "2", "7219999")]
    [InlineData("027240000", "2", "7240000")]
    [InlineData("027279999", "2", "7279999")]
    [InlineData("027300000", "2", "7300000")]
    [InlineData("027369999", "2", "7369999")]
    [InlineData("027380000", "2", "7380000")]
    [InlineData("027419999", "2", "7419999")]
    [InlineData("027490000", "2", "7490000")]
    [InlineData("027539999", "2", "7539999")]
    [InlineData("027550000", "2", "7550000")]
    [InlineData("027559999", "2", "7559999")]
    [InlineData("027570000", "2", "7570000")]
    [InlineData("027589999", "2", "7589999")]
    public void Parse_Known_NonGeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("053200000", "5", "3200000")]
    [InlineData("053259999", "5", "3259999")]
    [InlineData("053290000", "5", "3290000")]
    [InlineData("053299999", "5", "3299999")]
    [InlineData("053490000", "5", "3490000")]
    [InlineData("053539999", "5", "3539999")]
    [InlineData("053550000", "5", "3550000")]
    [InlineData("053599999", "5", "3599999")]
    [InlineData("053610000", "5", "3610000")]
    [InlineData("053619999", "5", "3619999")]
    [InlineData("053650000", "5", "3650000")]
    [InlineData("053659999", "5", "3659999")]
    [InlineData("053740000", "5", "3740000")]
    [InlineData("053759999", "5", "3759999")]
    [InlineData("053810000", "5", "3810000")]
    [InlineData("053869999", "5", "3869999")]
    [InlineData("053900000", "5", "3900000")]
    [InlineData("053939999", "5", "3939999")]
    [InlineData("053960000", "5", "3960000")]
    [InlineData("053999999", "5", "3999999")]
    public void Parse_Known_NonGeographicPhoneNumber_5_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("062000000", "6", "2000000")]
    [InlineData("062019999", "6", "2019999")]
    [InlineData("062500000", "6", "2500000")]
    [InlineData("062509999", "6", "2509999")]
    [InlineData("063000000", "6", "3000000")]
    [InlineData("063009999", "6", "3009999")]
    [InlineData("064000000", "6", "4000000")]
    [InlineData("064029999", "6", "4029999")]
    [InlineData("064050000", "6", "4050000")]
    [InlineData("064059999", "6", "4059999")]
    [InlineData("064120000", "6", "4120000")]
    [InlineData("064179999", "6", "4179999")]
    [InlineData("064200000", "6", "4200000")]
    [InlineData("064209999", "6", "4209999")]
    [InlineData("064250000", "6", "4250000")]
    [InlineData("064269999", "6", "4269999")]
    [InlineData("064290000", "6", "4290000")]
    [InlineData("064309999", "6", "4309999")]
    [InlineData("064370000", "6", "4370000")]
    [InlineData("064409999", "6", "4409999")]
    [InlineData("064420000", "6", "4420000")]
    [InlineData("064429999", "6", "4429999")]
    [InlineData("064450000", "6", "4450000")]
    [InlineData("064469999", "6", "4469999")]
    [InlineData("064480000", "6", "4480000")]
    [InlineData("064499999", "6", "4499999")]
    [InlineData("064600000", "6", "4600000")]
    [InlineData("064659999", "6", "4659999")]
    [InlineData("064680000", "6", "4680000")]
    [InlineData("064809999", "6", "4809999")]
    [InlineData("064870000", "6", "4870000")]
    [InlineData("064929999", "6", "4929999")]
    [InlineData("065000000", "6", "5000000")]
    [InlineData("065009999", "6", "5009999")]
    [InlineData("065100000", "6", "5100000")]
    [InlineData("065109999", "6", "5109999")]
    [InlineData("065150000", "6", "5150000")]
    [InlineData("065169999", "6", "5169999")]
    [InlineData("065200000", "6", "5200000")]
    [InlineData("065209999", "6", "5209999")]
    [InlineData("065230000", "6", "5230000")]
    [InlineData("065249999", "6", "5249999")]
    [InlineData("065300000", "6", "5300000")]
    [InlineData("065359999", "6", "5359999")]
    [InlineData("065370000", "6", "5370000")]
    [InlineData("065399999", "6", "5399999")]
    [InlineData("065410000", "6", "5410000")]
    [InlineData("065419999", "6", "5419999")]
    [InlineData("065470000", "6", "5470000")]
    [InlineData("065489999", "6", "5489999")]
    [InlineData("065500000", "6", "5500000")]
    [InlineData("065569999", "6", "5569999")]
    [InlineData("065600000", "6", "5600000")]
    [InlineData("065639999", "6", "5639999")]
    [InlineData("065650000", "6", "5650000")]
    [InlineData("065699999", "6", "5699999")]
    [InlineData("065710000", "6", "5710000")]
    [InlineData("065739999", "6", "5739999")]
    [InlineData("065770000", "6", "5770000")]
    [InlineData("065779999", "6", "5779999")]
    [InlineData("065790000", "6", "5790000")]
    [InlineData("065799999", "6", "5799999")]
    [InlineData("065880000", "6", "5880000")]
    [InlineData("065889999", "6", "5889999")]
    [InlineData("065900000", "6", "5900000")]
    [InlineData("065909999", "6", "5909999")]
    [InlineData("065920000", "6", "5920000")]
    [InlineData("065939999", "6", "5939999")]
    [InlineData("065990000", "6", "5990000")]
    [InlineData("065999999", "6", "5999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("082000000", "8", "2000000")]
    [InlineData("082009999", "8", "2009999")]
    [InlineData("087000000", "8", "7000000")]
    [InlineData("087009999", "8", "7009999")]
    [InlineData("087200000", "8", "7200000")]
    [InlineData("087209999", "8", "7209999")]
    [InlineData("087700000", "8", "7700000")]
    [InlineData("087709999", "8", "7709999")]
    [InlineData("087780000", "8", "7780000")]
    [InlineData("087789999", "8", "7789999")]
    [InlineData("087900000", "8", "7900000")]
    [InlineData("087909999", "8", "7909999")]
    [InlineData("087990000", "8", "7990000")]
    [InlineData("087999999", "8", "7999999")]
    public void Parse_Known_NonGeographicPhoneNumber_8_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("090000000", "9", "0000000")]
    [InlineData("099999999", "9", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("085000000", "8", "5000000")]
    [InlineData("085999999", "8", "5999999")]
    public void Parse_Known_NonGeographicPhoneNumber_SharedCost(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.True(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
