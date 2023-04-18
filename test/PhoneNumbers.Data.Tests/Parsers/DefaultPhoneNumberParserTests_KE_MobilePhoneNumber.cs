namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Kenya <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KE_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Kenya);

    [Theory]
    [InlineData("0100000000", "100", "000000")]
    [InlineData("0100999999", "100", "999999")]
    [InlineData("0106000000", "106", "000000")]
    [InlineData("0106999999", "106", "999999")]
    [InlineData("0110000000", "110", "000000")]
    [InlineData("0110999999", "110", "999999")]
    [InlineData("0115000000", "115", "000000")]
    [InlineData("0115999999", "115", "999999")]
    [InlineData("0120000000", "120", "000000")]
    [InlineData("0120999999", "120", "999999")]
    [InlineData("0121000000", "121", "000000")]
    [InlineData("0121999999", "121", "999999")]
    [InlineData("0124000000", "124", "000000")]
    [InlineData("0124999999", "124", "999999")]
    [InlineData("0700000000", "700", "000000")]
    [InlineData("0700999999", "700", "999999")]
    [InlineData("0799000000", "799", "000000")]
    [InlineData("0799999999", "799", "999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Kenya, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
