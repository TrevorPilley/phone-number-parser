namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Ireland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IE_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Ireland);

    [Theory]
    [InlineData("0830000000", "83", "0000000")]
    [InlineData("0839999999", "83", "9999999")]
    [InlineData("0870000000", "87", "0000000")]
    [InlineData("0879999999", "87", "9999999")]
    [InlineData("0890000000", "89", "0000000")]
    [InlineData("0899999999", "89", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Ireland, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0822000000", "822", "000000")]
    [InlineData("0822999999", "822", "999999")]
    public void Parse_Known_MobilePhoneNumber_Pager(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Ireland, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.True(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0700000000", "700", "000000")]
    [InlineData("0700999999", "700", "999999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Ireland, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
