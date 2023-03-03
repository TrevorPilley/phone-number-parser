namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Serbia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_RS_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Serbia);

    [Theory]
    [InlineData("060000000", "60", "000000")]
    [InlineData("0609999999", "60", "9999999")]
    [InlineData("066000000", "66", "000000")]
    [InlineData("0669999999", "66", "9999999")]
    [InlineData("067000000", "670", "00000")]
    [InlineData("0670999999", "670", "999999")]
    [InlineData("067900000", "679", "00000")]
    [InlineData("0679999999", "679", "999999")]
    [InlineData("068000000", "68", "000000")]
    [InlineData("0689999999", "68", "9999999")]
    [InlineData("069000000", "69", "000000")]
    [InlineData("0699999999", "69", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Serbia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
