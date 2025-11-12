namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Oman <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_OM_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Oman);

    [Theory]
    [InlineData("71000000", "71000000")]
    [InlineData("72999999", "72999999")]
    [InlineData("74000000", "74000000")]
    [InlineData("79999999", "79999999")]
    [InlineData("90100000", "90100000")]
    [InlineData("90999999", "90999999")]
    [InlineData("91000000", "91000000")]
    [InlineData("99999999", "99999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Oman, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
