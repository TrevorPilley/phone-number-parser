namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for South africa <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_ZA_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SouthAfrica);

    [Theory]
    [InlineData("0500000000", "50", "0000000")]
    [InlineData("0509999999", "50", "9999999")]
    [InlineData("0520000000", "52", "0000000")]
    [InlineData("0529999999", "52", "9999999")]
    [InlineData("0550000000", "55", "0000000")]
    [InlineData("0559999999", "55", "9999999")]
    [InlineData("0590000000", "59", "0000000")]
    [InlineData("0599999999", "59", "9999999")]
    [InlineData("0600000000", "60", "0000000")]
    [InlineData("0609999999", "60", "9999999")]
    [InlineData("0790000000", "79", "0000000")]
    [InlineData("0799999999", "79", "9999999")]
    [InlineData("0810000000", "81", "0000000")]
    [InlineData("0819999999", "81", "9999999")]
    [InlineData("0850000000", "85", "0000000")]
    [InlineData("0859999999", "85", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SouthAfrica, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
