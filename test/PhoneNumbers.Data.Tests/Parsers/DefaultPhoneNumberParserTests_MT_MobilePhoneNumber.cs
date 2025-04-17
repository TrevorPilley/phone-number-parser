namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Malta <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MT_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Malta);

    [Theory]
    [InlineData("72100000", "72100000")]
    [InlineData("72109999", "72109999")]
    [InlineData("77000000", "77000000")]
    [InlineData("77999999", "77999999")]
    [InlineData("79000000", "79000000")]
    [InlineData("79119999", "79119999")]
    [InlineData("79130000", "79130000")]
    [InlineData("79149999", "79149999")]
    [InlineData("79170000", "79170000")]
    [InlineData("79799999", "79999999")]
    [InlineData("92100000", "92100000")]
    [InlineData("92119999", "92119999")]
    [InlineData("92310000", "92310000")]
    [InlineData("92319999", "92319999")]
    [InlineData("96960000", "96960000")]
    [InlineData("96969999", "96969999")]
    [InlineData("98110000", "98110000")]
    [InlineData("98139999", "98139999")]
    [InlineData("98890000", "98890000")]
    [InlineData("98899999", "98899999")]
    [InlineData("98970000", "98970000")]
    [InlineData("98979999", "98979999")]
    [InlineData("99000000", "99000000")]
    [InlineData("99999999", "99999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("71170000", "71170000")]
    [InlineData("71179999", "71179999")]
    public void Parse_Known_MobilePhoneNumber_Pager(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, mobilePhoneNumber.Country);
        Assert.True(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
