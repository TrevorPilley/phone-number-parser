namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for British virgin islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VG_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.BritishVirginIslands);

    [Theory]
    [InlineData("2843000000", "284", "3000000")]
    [InlineData("2843039999", "284", "3039999")]
    [InlineData("2844400000", "284", "4400000")]
    [InlineData("2844459999", "284", "4459999")]
    [InlineData("2844680000", "284", "4680000")]
    [InlineData("2844689999", "284", "4689999")]
    [InlineData("2844966000", "284", "4966000")]
    [InlineData("2844969999", "284", "4969999")]
    [InlineData("2844990000", "284", "4990000")]
    [InlineData("2844999999", "284", "4999999")]
    [InlineData("2845400000", "284", "5400000")]
    [InlineData("2845449999", "284", "5449999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BritishVirginIslands, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
