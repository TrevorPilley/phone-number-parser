namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Germany <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DE_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Germany);

    [Theory]
    [InlineData("01370000000", "137", "0000000")]
    [InlineData("01379999999", "137", "9999999")]
    [InlineData("018000000", "180", "00000")]
    [InlineData("01809999999", "180", "9999999")]
    [InlineData("018100000", "181", "00000")]
    [InlineData("018199999999999", "181", "99999999999")]
    [InlineData("018200000000", "182", "00000000")]
    [InlineData("018299999999", "182", "99999999")]
    [InlineData("018900000000", "189", "00000000")]
    [InlineData("018999999999", "189", "99999999")]
    [InlineData("01910", "191", "0")]
    [InlineData("0191999", "191", "999")]
    [InlineData("01940", "194", "0")]
    [InlineData("0194999", "194", "999")]
    [InlineData("01986000", "1986", "000")]
    [InlineData("01986999", "1986", "999")]
    [InlineData("01987000", "1987", "000")]
    [InlineData("01987999", "1987", "999")]
    [InlineData("0198800", "1988", "00")]
    [InlineData("0198899", "1988", "99")]
    [InlineData("0198900", "1989", "00")]
    [InlineData("0198999", "1989", "99")]
    [InlineData("01989000", "19890", "00")]
    [InlineData("01989099", "19890", "99")]
    public void Parse_Known_NonGeographicPhoneNumber_1XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("032000000000", "32", "000000000")]
    [InlineData("03299999999999", "32", "99999999999")]
    public void Parse_Known_NonGeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("08000000000", "800", "0000000")]
    [InlineData("08009999999", "800", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("09001000000", "9001", "000000")]
    [InlineData("09001999999", "9001", "999999")]
    [InlineData("09003000000", "9003", "000000")]
    [InlineData("09003999999", "9003", "999999")]
    [InlineData("09005000000", "9005", "000000")]
    [InlineData("09005999999", "9005", "999999")]
    [InlineData("090090000000", "9009", "0000000")]
    [InlineData("090099999999", "9009", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
