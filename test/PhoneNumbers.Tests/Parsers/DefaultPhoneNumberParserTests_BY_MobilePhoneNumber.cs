namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Belarus <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BY_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Belarus);

    [Theory]
    [InlineData("0255000000", "25", "5000000")]
    [InlineData("0257999999", "25", "7999999")]
    [InlineData("0259000000", "25", "9000000")]
    [InlineData("0259999999", "25", "9999999")]
    [InlineData("0291000000", "29", "1000000")]
    [InlineData("0293999999", "29", "3999999")]
    [InlineData("0295000000", "29", "5000000")]
    [InlineData("0299999999", "29", "9999999")]
    [InlineData("0330000000", "33", "0000000")]
    [InlineData("0339999999", "33", "9999999")]
    [InlineData("0440000000", "44", "0000000")]
    [InlineData("0449999999", "44", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Belarus, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
