namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Nigeria <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_NG_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Nigeria);

    [Theory]
    [InlineData("07010000000", "701", "0000000")]
    [InlineData("07019999999", "701", "9999999")]
    [InlineData("07060000000", "706", "0000000")]
    [InlineData("07069999999", "706", "9999999")]
    [InlineData("07080000000", "708", "0000000")]
    [InlineData("07089999999", "708", "9999999")]
    [InlineData("08010000000", "801", "0000000")]
    [InlineData("08019999999", "801", "9999999")]
    [InlineData("08180000000", "818", "0000000")]
    [InlineData("08189999999", "818", "9999999")]
    [InlineData("09010000000", "901", "0000000")]
    [InlineData("09019999999", "901", "9999999")]
    [InlineData("09090000000", "909", "0000000")]
    [InlineData("09099999999", "909", "9999999")]
    [InlineData("09110000000", "911", "0000000")]
    [InlineData("09119999999", "911", "9999999")]
    [InlineData("09160000000", "916", "0000000")]
    [InlineData("09169999999", "916", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("07000000000", "700", "0000000")]
    [InlineData("07009999999", "700", "9999999")]
    [InlineData("07100000000", "710", "0000000")]
    [InlineData("07109999999", "710", "9999999")]
    [InlineData("07290000000", "729", "0000000")]
    [InlineData("07299999999", "729", "9999999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Nigeria, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
