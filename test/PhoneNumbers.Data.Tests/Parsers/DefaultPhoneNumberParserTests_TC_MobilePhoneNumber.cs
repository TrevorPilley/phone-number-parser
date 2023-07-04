namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Turks and caicos islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TC_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.TurksAndCaicosIslands);

    [Theory]
    [InlineData("6492310000", "649", "2310000")]
    [InlineData("6492329999", "649", "2329999")]
    [InlineData("6492380000", "649", "2380000")]
    [InlineData("6492399999", "649", "2399999")]
    [InlineData("6492410000", "649", "2410000")]
    [InlineData("6492459999", "649", "2459999")]
    [InlineData("6493310000", "649", "3310000")]
    [InlineData("6493339999", "649", "3339999")]
    [InlineData("6493390000", "649", "3390000")]
    [InlineData("6493399999", "649", "3399999")]
    [InlineData("6493410000", "649", "3410000")]
    [InlineData("6493459999", "649", "3459999")]
    [InlineData("6493470000", "649", "3470000")]
    [InlineData("6493489999", "649", "3489999")]
    [InlineData("6494310000", "649", "4310000")]
    [InlineData("6494339999", "649", "4339999")]
    [InlineData("6494410000", "649", "4410000")]
    [InlineData("6494439999", "649", "4439999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.TurksAndCaicosIslands, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
