namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Finland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_FI_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Finland);

    [Theory]
    [InlineData("040000000", "40", "000000")]
    [InlineData("04099999999", "40", "99999999")]
    [InlineData("044000000", "44", "000000")]
    [InlineData("04499999999", "44", "99999999")]
    [InlineData("045000000", "45", "000000")]
    [InlineData("045999999", "45", "999999")]
    [InlineData("0450000000", "45", "0000000")]
    [InlineData("0456999999", "45", "6999999")]
    [InlineData("0457100000", "45", "7100000")]
    [InlineData("0457199999", "45", "7199999")]
    [InlineData("04500000000", "45", "00000000")]
    [InlineData("04599999999", "45", "99999999")]
    [InlineData("046000000", "46", "000000")]
    [InlineData("04699999999", "46", "99999999")]
    [InlineData("048000000", "48", "000000")]
    [InlineData("04899999999", "48", "99999999")]
    [InlineData("050000000", "50", "000000")]
    [InlineData("05099999999", "50", "99999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Finland, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
