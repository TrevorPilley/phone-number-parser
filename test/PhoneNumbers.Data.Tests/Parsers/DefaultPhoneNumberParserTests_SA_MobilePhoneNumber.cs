namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saudi arabia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SA_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaudiArabia);

    [Theory]
    [InlineData("0500000000", "50", "0000000")]
    [InlineData("0509999999", "50", "9999999")]
    [InlineData("0510000000", "51", "0000000")]
    [InlineData("0519999999", "51", "9999999")]
    [InlineData("0530000000", "53", "0000000")]
    [InlineData("0539999999", "53", "9999999")]
    [InlineData("0590000000", "59", "0000000")]
    [InlineData("0599999999", "59", "9999999")]
    [InlineData("0831000000000", "831", "000000000")]
    [InlineData("0831999999999", "831", "999999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaudiArabia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
