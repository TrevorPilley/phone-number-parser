namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Moldova <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MD_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Moldova);

    [Theory]
    [InlineData("060000000", "60", "000000")]
    [InlineData("060999999", "60", "999999")]
    [InlineData("069000000", "69", "000000")]
    [InlineData("069999999", "69", "999999")]
    [InlineData("071000000", "71", "000000")]
    [InlineData("071999999", "71", "999999")]
    [InlineData("076000000", "76", "000000")]
    [InlineData("076999999", "76", "999999")]
    [InlineData("079000000", "79", "000000")]
    [InlineData("079999999", "79", "999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Moldova, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsDataOnly);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
