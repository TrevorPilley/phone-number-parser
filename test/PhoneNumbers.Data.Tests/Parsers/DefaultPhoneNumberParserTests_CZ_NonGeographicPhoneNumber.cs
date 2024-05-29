namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Czech republic <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CZ_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CzechRepublic);

    [Theory]
    [InlineData("820000000", "820", "000000")]
    [InlineData("820999999", "820", "999999")]
    [InlineData("829000000", "829", "000000")]
    [InlineData("829999999", "829", "999999")]
    [InlineData("840000000", "840", "000000")]
    [InlineData("840999999", "840", "999999")]
    [InlineData("842000000", "842", "000000")]
    [InlineData("842999999", "842", "999999")]
    [InlineData("847000000", "847", "000000")]
    [InlineData("847999999", "847", "999999")]
    [InlineData("849000000", "849", "000000")]
    [InlineData("849999999", "849", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("910000000", "910", "000000")]
    [InlineData("910999999", "910", "999999")]
    [InlineData("93000000000", "93", "000000000")]
    [InlineData("93999999999", "93", "999999999")]
    [InlineData("950000000", "95", "0000000")]
    [InlineData("959999999", "95", "9999999")]
    [InlineData("960000000", "960", "000000")]
    [InlineData("960999999999", "960", "999999999")]
    [InlineData("969000000", "969", "000000")]
    [InlineData("969999999999", "969", "999999999")]
    [InlineData("971000000", "971", "000000")]
    [InlineData("971999999", "971", "999999")]
    [InlineData("972000000", "972", "000000")]
    [InlineData("972999999", "972", "999999")]
    [InlineData("974000000", "974", "000000")]
    [InlineData("974999999", "974", "999999")]
    [InlineData("976000000", "976", "000000")]
    [InlineData("976999999", "976", "999999")]
    [InlineData("977000000", "977", "000000")]
    [InlineData("977999999", "977", "999999")]
    [InlineData("980000000", "980", "000000")]
    [InlineData("980999999999", "980", "999999999")]
    [InlineData("9830000", "983", "0000")]
    [InlineData("9839999", "983", "9999")]
    [InlineData("989000000", "989", "000000")]
    [InlineData("989999999", "989", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_9XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("800000000", "800", "000000")]
    [InlineData("800999999", "800", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("900000000", "900", "000000")]
    [InlineData("900999999", "900", "999999")]
    [InlineData("905000000", "905", "000000")]
    [InlineData("905999999", "905", "999999")]
    [InlineData("906000000", "906", "000000")]
    [InlineData("906999999", "906", "999999")]
    [InlineData("908000000", "908", "000000")]
    [InlineData("908999999", "908", "999999")]
    [InlineData("909000000", "909", "000000")]
    [InlineData("909999999", "909", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("810000000", "810", "000000")]
    [InlineData("810999999", "810", "999999")]
    [InlineData("819000000", "819", "000000")]
    [InlineData("819999999", "819", "999999")]
    [InlineData("830000000", "830", "000000")]
    [InlineData("830999999", "830", "999999")]
    [InlineData("839000000", "839", "000000")]
    [InlineData("839999999", "839", "999999")]
    [InlineData("843000000", "843", "000000")]
    [InlineData("843999999", "843", "999999")]
    [InlineData("846000000", "846", "000000")]
    [InlineData("846999999", "846", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_SharedCost(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.True(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
