namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Colombia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CO_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Colombia);

    [Theory]
    [InlineData("3002000000", "300", "2000000")]
    [InlineData("3009999999", "300", "9999999")]
    [InlineData("3022000000", "302", "2000000")]
    [InlineData("3029999999", "302", "9999999")]
    [InlineData("3042000000", "304", "2000000")]
    [InlineData("3049999999", "304", "9999999")]
    [InlineData("3052000000", "305", "2000000")]
    [InlineData("3059999999", "305", "9999999")]
    [InlineData("3102000000", "310", "2000000")]
    [InlineData("3109999999", "310", "9999999")]
    [InlineData("3242000000", "324", "2000000")]
    [InlineData("3249999999", "324", "9999999")]
    [InlineData("3332000000", "333", "2000000")]
    [InlineData("3339999999", "333", "9999999")]
    [InlineData("3502000000", "350", "2000000")]
    [InlineData("3509999999", "350", "9999999")]
    [InlineData("3512000000", "351", "2000000")]
    [InlineData("3519999999", "351", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Colombia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
