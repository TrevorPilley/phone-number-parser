namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Croatia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_HR_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Croatia);

    [Theory]
    [InlineData("0900000000", "90", "0000000")]
    [InlineData("0909999999", "90", "9999999")]
    [InlineData("0960000000", "96", "0000000")]
    [InlineData("0969999999", "96", "9999999")]
    [InlineData("0970000000", "970", "000000")]
    [InlineData("0970999999", "970", "999999")]
    [InlineData("0975000000", "975", "000000")]
    [InlineData("0975999999", "975", "999999")]
    [InlineData("0977000000", "977", "000000")]
    [InlineData("0977999999", "977", "999999")]
    [InlineData("0979000000", "979", "000000")]
    [InlineData("0979999999", "979", "999999")]
    [InlineData("0980000000", "98", "0000000")]
    [InlineData("0989999999", "98", "9999999")]
    [InlineData("0990000000", "99", "0000000")]
    [InlineData("0999999999", "99", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
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
