namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Estonia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_EE_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Estonia);

    [Theory]
    [InlineData("5000000", "50", "00000")]
    [InlineData("50999999", "50", "999999")]
    [InlineData("5900000", "59", "00000")]
    [InlineData("59999999", "59", "999999")]
    [InlineData("81000000", "81", "000000")]
    [InlineData("81999999", "81", "999999")]
    [InlineData("84000000", "84", "000000")]
    [InlineData("84999999", "84", "999999")]
    [InlineData("89000000", "89", "000000")]
    [InlineData("89999999", "89", "999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Estonia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("70000000", "700", "00000")]
    [InlineData("70099999", "700", "99999")]
    [InlineData("70200000", "702", "00000")]
    [InlineData("70299999", "702", "99999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Estonia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
