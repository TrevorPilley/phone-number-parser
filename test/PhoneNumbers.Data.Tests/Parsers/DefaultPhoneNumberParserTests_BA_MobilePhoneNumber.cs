namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bosnia and herzegovina <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BA_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.BosniaAndHerzegovina);

    [Theory]
    [InlineData("0600000000", "60", "0000000")]
    [InlineData("0609999999", "60", "9999999")]
    [InlineData("061000000", "61", "000000")]
    [InlineData("061999999", "61", "999999")]
    [InlineData("063000000", "63", "000000")]
    [InlineData("063999999", "63", "999999")]
    [InlineData("0640000000", "64", "0000000")]
    [InlineData("0649999999", "64", "9999999")]
    [InlineData("065000000", "65", "000000")]
    [InlineData("065999999", "65", "999999")]
    [InlineData("066000000", "66", "000000")]
    [InlineData("066999999", "66", "999999")]
    [InlineData("0670000000", "67", "0000000")]
    [InlineData("0679999999", "67", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.BosniaAndHerzegovina, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
