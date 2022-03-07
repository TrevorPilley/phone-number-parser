namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Croatia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_HR_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Croatia);

    [Theory]
    [InlineData("0901000000", "901", "000000")]
    [InlineData("0901999999", "901", "999999")]
    [InlineData("0909000000", "909", "000000")]
    [InlineData("0909999999", "909", "999999")]
    public void Parse_Known_MobilePhoneNumber_90X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0910000000", "91", "0000000")]
    [InlineData("0919999999", "91", "9999999")]
    public void Parse_Known_MobilePhoneNumber_91_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0960000000", "96", "0000000")]
    [InlineData("0969999999", "96", "9999999")]
    public void Parse_Known_MobilePhoneNumber_96_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0970000000", "970", "000000")]
    [InlineData("0970999999", "970", "999999")]
    [InlineData("0974000000", "974", "000000")]
    [InlineData("0974999999", "974", "999999")]
    [InlineData("0975100000", "9751", "00000")]
    [InlineData("0975199999", "9751", "99999")]
    [InlineData("0975900000", "9759", "00000")]
    [InlineData("0975999999", "9759", "99999")]
    [InlineData("0976000000", "976", "000000")]
    [InlineData("0976999999", "976", "999999")]
    [InlineData("0979000000", "979", "000000")]
    [InlineData("0979999999", "979", "999999")]
    public void Parse_Known_MobilePhoneNumber_97X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0980000000", "98", "0000000")]
    [InlineData("0989999999", "98", "9999999")]
    public void Parse_Known_MobilePhoneNumber_98_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0990000000", "99", "0000000")]
    [InlineData("0999999999", "99", "9999999")]
    public void Parse_Known_MobilePhoneNumber_99_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Croatia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
