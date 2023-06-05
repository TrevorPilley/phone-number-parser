namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Montserrat <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MS_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Montserrat);

    [Theory]
    [InlineData("6643490000", "664", "3490000")]
    [InlineData("6643499999", "664", "3499999")]
    [InlineData("6643920000", "664", "3920000")]
    [InlineData("6643969999", "664", "3969999")]
    [InlineData("6644920001", "664", "4920001")]
    [InlineData("6644920998", "664", "4920998")]
    [InlineData("6644921000", "664", "4921000")]
    [InlineData("6644922999", "664", "4922999")]
    [InlineData("6644923001", "664", "4923001")]
    [InlineData("6644927998", "664", "4927998")]
    [InlineData("6644928000", "664", "4928000")]
    [InlineData("6644969999", "664", "4969999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Montserrat, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
