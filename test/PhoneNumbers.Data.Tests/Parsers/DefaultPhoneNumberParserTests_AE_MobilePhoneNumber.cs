namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United arab emirates <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AE_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.UnitedArabEmirates);

    [Theory]
    [InlineData("0500000000", "50", "0000000")]
    [InlineData("0509999999", "50", "9999999")]
    [InlineData("0520000000", "52", "0000000")]
    [InlineData("0529999999", "52", "9999999")]
    [InlineData("0550000000", "55", "0000000")]
    [InlineData("0559999999", "55", "9999999")]
    [InlineData("0560000000", "56", "0000000")]
    [InlineData("0569999999", "56", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
