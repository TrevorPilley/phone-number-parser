namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Antigua and barbuda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AG_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.AntiguaAndBarbuda);

    [Theory]
    [InlineData("2684640000", "268", "4640000")]
    [InlineData("2684649999", "268", "4649999")]
    [InlineData("2687200000", "268", "7200000")]
    [InlineData("2687299999", "268", "7299999")]
    [InlineData("2687640000", "268", "7640000")]
    [InlineData("2687649999", "268", "7649999")]
    [InlineData("2687700000", "268", "7700000")]
    [InlineData("2687759999", "268", "7759999")]
    [InlineData("2687830000", "268", "7830000")]
    [InlineData("2687839999", "268", "7839999")]
    [InlineData("2687850000", "268", "7850000")]
    [InlineData("2687859999", "268", "7859999")]
    [InlineData("2687880000", "268", "7880000")]
    [InlineData("2687889999", "268", "7889999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.AntiguaAndBarbuda, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("2684060000", "268", "4060000")]
    [InlineData("2684069999", "268", "4069999")]
    [InlineData("2684090000", "268", "4090000")]
    [InlineData("2684099999", "268", "4099999")]
    public void Parse_Known_MobilePhoneNumber_Pager(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.AntiguaAndBarbuda, mobilePhoneNumber.Country);
        Assert.True(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
