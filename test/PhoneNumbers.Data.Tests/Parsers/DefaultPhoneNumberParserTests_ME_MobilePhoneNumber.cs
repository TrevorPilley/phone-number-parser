namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Montenegro <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_ME_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Montenegro);

    [Theory]
    [InlineData("06000", "60", "00")]
    [InlineData("0609999999999", "60", "9999999999")]
    [InlineData("063000", "63", "000")]
    [InlineData("0639999999999", "63", "9999999999")]
    [InlineData("066000", "66", "000")]
    [InlineData("0669999999999", "66", "9999999999")]
    [InlineData("067000", "67", "000")]
    [InlineData("0679999999999", "67", "9999999999")]
    [InlineData("06800", "68", "00")]
    [InlineData("0689999999999", "68", "9999999999")]
    [InlineData("069000", "69", "000")]
    [InlineData("0699999999999", "69", "9999999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montenegro, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
