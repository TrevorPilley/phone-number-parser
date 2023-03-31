namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Greece <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GR_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Greece);

    [Theory]
    [InlineData("6850000000", "685", "0000000")]
    [InlineData("6859999999", "685", "9999999")]
    [InlineData("6890000000", "689", "0000000")]
    [InlineData("6899999999", "689", "9999999")]
    [InlineData("6900000000", "690", "0000000")]
    [InlineData("6909999999", "690", "9999999")]
    [InlineData("6910000000", "691", "0000000")]
    [InlineData("6919999999", "691", "9999999")]
    [InlineData("6930000000", "693", "0000000")]
    [InlineData("6939999999", "693", "9999999")]
    [InlineData("6950000000", "695", "0000000")]
    [InlineData("6959999999", "695", "9999999")]
    [InlineData("6970000000", "697", "0000000")]
    [InlineData("6979999999", "697", "9999999")]
    [InlineData("6990000000", "699", "0000000")]
    [InlineData("6999999999", "699", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Greece, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("7000000000", "70", "00000000")]
    [InlineData("7099999999", "70", "99999999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Greece, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
