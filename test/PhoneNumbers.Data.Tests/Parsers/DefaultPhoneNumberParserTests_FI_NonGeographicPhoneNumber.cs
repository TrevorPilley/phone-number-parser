namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Finland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_FI_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Finland);

    [Theory]
    [InlineData("01000000", "100", "0000")]
    [InlineData("0100999999", "100", "999999")]
    [InlineData("010100000", "101", "00000")]
    [InlineData("01019999999", "101", "9999999")]
    [InlineData("010900000", "109", "00000")]
    [InlineData("01099999999", "109", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_1XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("02000000", "200", "0000")]
    [InlineData("0200999999", "200", "999999")]
    [InlineData("020100000", "201", "00000")]
    [InlineData("02019999999", "201", "9999999")]
    [InlineData("020200000", "2020", "0000")]
    [InlineData("0202099999", "2020", "99999")]
    [InlineData("020210000", "2021", "0000")]
    [InlineData("02021999999", "2021", "999999")]
    [InlineData("020220000", "2022", "0000")]
    [InlineData("0202299999", "2022", "99999")]
    [InlineData("020230000", "2023", "0000")]
    [InlineData("0202399999", "2023", "99999")]
    [InlineData("020240000", "2024", "0000")]
    [InlineData("02024999999", "2024", "999999")]
    [InlineData("020290000", "2029", "0000")]
    [InlineData("02029999999", "2029", "999999")]
    [InlineData("020300000", "203", "00000")]
    [InlineData("02039999999", "203", "9999999")]
    [InlineData("020800000", "208", "00000")]
    [InlineData("02089999999", "208", "9999999")]
    [InlineData("020900000", "2090", "0000")]
    [InlineData("02090999999", "2090", "999999")]
    [InlineData("020970000", "2097", "0000")]
    [InlineData("02097999999", "2097", "999999")]
    [InlineData("020980", "2098", "0")]
    [InlineData("02098999999", "2098", "999999")]
    [InlineData("020990", "2099", "0")]
    [InlineData("02099999999", "2099", "999999")]
    [InlineData("029000000", "29", "000000")]
    [InlineData("02999999999", "29", "99999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0300000", "300", "000")]
    [InlineData("03009999999", "300", "9999999")]
    [InlineData("030100000", "301", "00000")]
    [InlineData("03019999999", "301", "9999999")]
    [InlineData("030900000", "309", "00000")]
    [InlineData("03099999999", "309", "9999999")]
    [InlineData("039000000", "39", "000000")]
    [InlineData("03999999999", "39", "99999999")]
    public void Parse_Known_NonGeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("070000000", "700", "00000")]
    [InlineData("0700999999", "700", "999999")]
    [InlineData("07070000000", "707", "0000000")]
    [InlineData("07079999999", "707", "9999999")]
    [InlineData("07080000000", "708", "0000000")]
    [InlineData("07089999999", "708", "9999999")]
    [InlineData("070990000", "7099", "0000")]
    [InlineData("0709999999", "7099", "99999")]
    [InlineData("0710000000", "71", "0000000")]
    [InlineData("0719999999", "71", "9999999")]
    [InlineData("07300000000", "73", "00000000")]
    [InlineData("07399999999", "73", "99999999")]
    [InlineData("075000000", "750", "00000")]
    [InlineData("0750999999", "750", "999999")]
    [InlineData("075100", "751", "00")]
    [InlineData("075199", "751", "99")]
    [InlineData("075200", "752", "00")]
    [InlineData("075299", "752", "99")]
    [InlineData("075300000", "753", "00000")]
    [InlineData("0753999999", "753", "999999")]
    [InlineData("075900000", "759", "00000")]
    [InlineData("0759999999", "759", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("060000000", "600", "00000")]
    [InlineData("0600999999", "600", "999999")]
    [InlineData("060200000", "602", "00000")]
    [InlineData("0602999999", "602", "999999")]
    [InlineData("06060000000", "606", "0000000")]
    [InlineData("06069999999", "606", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("080000000", "800", "00000")]
    [InlineData("0800999999", "800", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
