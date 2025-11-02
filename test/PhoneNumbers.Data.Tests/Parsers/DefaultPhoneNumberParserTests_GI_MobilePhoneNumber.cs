namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Gibraltar <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GI_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Gibraltar);

    [Theory]
    [InlineData("51000000", "51", "000000")]
    [InlineData("51099999", "51", "099999")]
    [InlineData("52500000", "52", "500000")]
    [InlineData("52514999", "52", "514999")]
    [InlineData("54000000", "54", "000000")]
    [InlineData("54999999", "54", "999999")]
    [InlineData("56000000", "56", "000000")]
    [InlineData("56999999", "56", "999999")]
    [InlineData("58000000", "58", "000000")]
    [InlineData("58999999", "58", "999999")]
    [InlineData("60100000", "60", "100000")]
    [InlineData("60119999", "60", "119999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Gibraltar, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
