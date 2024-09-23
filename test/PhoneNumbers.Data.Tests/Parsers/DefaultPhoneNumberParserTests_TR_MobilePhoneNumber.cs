namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Turkey <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TR_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Turkey);

    [Theory]
    [InlineData("05010000000", "501", "0000000")]
    [InlineData("05019999999", "501", "9999999")]
    [InlineData("05050000000", "505", "0000000")]
    [InlineData("05059999999", "505", "9999999")]
    [InlineData("05070000000", "507", "0000000")]
    [InlineData("05079999999", "507", "9999999")]
    [InlineData("05300000000", "530", "0000000")]
    [InlineData("05309999999", "530", "9999999")]
    [InlineData("05490000000", "549", "0000000")]
    [InlineData("05499999999", "549", "9999999")]
    [InlineData("05510000000", "551", "0000000")]
    [InlineData("05519999999", "551", "9999999")]
    [InlineData("05550000000", "555", "0000000")]
    [InlineData("05559999999", "555", "9999999")]
    [InlineData("05590000000", "559", "0000000")]
    [InlineData("05599999999", "559", "9999999")]
    [InlineData("05920000000", "592", "0000000")]
    [InlineData("05929999999", "592", "9999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Turkey, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("08500000000", "850", "0000000")]
    [InlineData("08509999999", "850", "9999999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Turkey, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
