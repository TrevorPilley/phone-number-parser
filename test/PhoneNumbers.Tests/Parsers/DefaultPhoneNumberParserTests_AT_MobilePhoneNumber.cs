namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Austria <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AT_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Austria);

    [Theory]
    [InlineData("06500000", "650", "0000")]
    [InlineData("06509999999999", "650", "9999999999")]
    [InlineData("06530000", "653", "0000")]
    [InlineData("06539999999999", "653", "9999999999")]
    [InlineData("06550000", "655", "0000")]
    [InlineData("06559999999999", "655", "9999999999")]
    [InlineData("06570000", "657", "0000")]
    [InlineData("06579999999999", "657", "9999999999")]
    [InlineData("06590000", "659", "0000")]
    [InlineData("06599999999999", "659", "9999999999")]
    [InlineData("06610000", "661", "0000")]
    [InlineData("06619999999999", "661", "9999999999")]
    [InlineData("06630000", "663", "0000")]
    [InlineData("06639999999999", "663", "9999999999")]
    [InlineData("06690000", "669", "0000")]
    [InlineData("06699999999999", "669", "9999999999")]
    [InlineData("06700000", "67", "00000")]
    [InlineData("06799999999999", "67", "99999999999")]
    [InlineData("06900000", "69", "00000")]
    [InlineData("06999999999999", "69", "99999999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Austria, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
