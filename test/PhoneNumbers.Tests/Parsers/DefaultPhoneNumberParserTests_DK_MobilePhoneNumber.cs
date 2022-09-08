namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Denmark <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DK_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Denmark);

    [Theory]
    [InlineData("20000000", "20000000")]
    [InlineData("31999999", "31999999")]
    [InlineData("40000000", "40000000")]
    [InlineData("42999999", "42999999")]
    [InlineData("50000000", "50000000")]
    [InlineData("53999999", "53999999")]
    [InlineData("60000000", "60000000")]
    [InlineData("61999999", "61999999")]
    [InlineData("71000000", "71000000")]
    [InlineData("71999999", "71999999")]
    [InlineData("91000000", "91000000")]
    [InlineData("93999999", "93999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Denmark, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
