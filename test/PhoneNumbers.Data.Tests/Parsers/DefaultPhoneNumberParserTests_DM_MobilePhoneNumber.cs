namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Dominica <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DM_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Dominica);

    [Theory]
    [InlineData("7672250000", "767", "2250000")]
    [InlineData("7672259999", "767", "2259999")]
    [InlineData("7672350000", "767", "2350000")]
    [InlineData("7672359999", "767", "2359999")]
    [InlineData("7672450000", "767", "2450000")]
    [InlineData("7672459999", "767", "2459999")]
    [InlineData("7672650000", "767", "2650000")]
    [InlineData("7672659999", "767", "2659999")]
    [InlineData("7672750000", "767", "2750000")]
    [InlineData("7672779999", "767", "2779999")]
    [InlineData("7672850000", "767", "2850000")]
    [InlineData("7672859999", "767", "2859999")]
    [InlineData("7672950000", "767", "2950000")]
    [InlineData("7672959999", "767", "2959999")]
    [InlineData("7673150000", "767", "3150000")]
    [InlineData("7673179999", "767", "3179999")]
    [InlineData("7676120000", "767", "6120000")]
    [InlineData("7676179999", "767", "6179999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Dominica, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
