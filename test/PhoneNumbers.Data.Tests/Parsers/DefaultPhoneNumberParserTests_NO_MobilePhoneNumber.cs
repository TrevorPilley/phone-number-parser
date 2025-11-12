namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Norway <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_NO_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Norway);

    [Theory]
    [InlineData("40000000", "40000000")]
    [InlineData("41999999", "41999999")]
    [InlineData("45000000", "45000000")]
    [InlineData("45359999", "45359999")]
    [InlineData("45370000", "45370000")]
    [InlineData("48999999", "48999999")]
    [InlineData("90000000", "90000000")]
    [InlineData("99999999", "99999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Norway, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
