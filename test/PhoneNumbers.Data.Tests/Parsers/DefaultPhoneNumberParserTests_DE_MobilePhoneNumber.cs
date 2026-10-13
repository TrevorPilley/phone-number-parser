namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Germany <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_DE_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Germany);

    [Theory]
    [InlineData("015019000000", "15019", "000000")]
    [InlineData("015019999999", "15019", "999999")]
    [InlineData("015020000000", "15020", "000000")]
    [InlineData("015020999999", "15020", "999999")]
    [InlineData("015110000000", "1511", "0000000")]
    [InlineData("015119999999", "1511", "9999999")]
    [InlineData("015120000000", "1512", "0000000")]
    [InlineData("015129999999", "1512", "9999999")]
    [InlineData("015140000000", "1514", "0000000")]
    [InlineData("015149999999", "1514", "9999999")]
    [InlineData("015170000000", "1517", "0000000")]
    [InlineData("015179999999", "1517", "9999999")]
    [InlineData("015180000000", "15180", "000000")]
    [InlineData("015180999999", "15180", "999999")]
    [InlineData("015189000000", "15189", "000000")]
    [InlineData("015189999999", "15189", "999999")]
    [InlineData("015200000000", "1520", "0000000")]
    [InlineData("015209999999", "1520", "9999999")]
    [InlineData("015230000000", "1523", "0000000")]
    [InlineData("015239999999", "1523", "9999999")]
    [InlineData("015250000000", "1525", "0000000")]
    [InlineData("015259999999", "1525", "9999999")]
    [InlineData("015260000000", "1526", "0000000")]
    [InlineData("015269999999", "1526", "9999999")]
    [InlineData("015290000000", "1529", "0000000")]
    [InlineData("015299999999", "1529", "9999999")]
    [InlineData("015310000000", "15310", "000000")]
    [InlineData("015310999999", "15310", "999999")]
    [InlineData("015333000000", "15333", "000000")]
    [InlineData("015333999999", "15333", "999999")]
    [InlineData("015410000000", "15410", "000000")]
    [InlineData("015410999999", "15410", "999999")]
    [InlineData("015510000000", "15510", "000000")]
    [InlineData("015510999999", "15510", "999999")]
    [InlineData("015511000000", "15511", "000000")]
    [InlineData("015511999999", "15511", "999999")]
    [InlineData("015550000000", "15550", "000000")]
    [InlineData("015550999999", "15550", "999999")]
    [InlineData("015569000000", "15569", "000000")]
    [InlineData("015569999999", "15569", "999999")]
    [InlineData("015591000000", "15591", "000000")]
    [InlineData("015591999999", "15591", "999999")]
    [InlineData("015630000000", "15630", "000000")]
    [InlineData("015630999999", "15630", "999999")]
    [InlineData("015636000000", "15636", "000000")]
    [InlineData("015636999999", "15636", "999999")]
    [InlineData("015678000000", "15678", "000000")]
    [InlineData("015678999999", "15678", "999999")]
    [InlineData("015679000000", "15679", "000000")]
    [InlineData("015679999999", "15679", "999999")]
    [InlineData("015700000000", "15700", "000000")]
    [InlineData("015700999999", "15700", "999999")]
    [InlineData("015704000000", "15704", "000000")]
    [InlineData("015704999999", "15704", "999999")]
    [InlineData("015706000000", "15706", "000000")]
    [InlineData("015706999999", "15706", "999999")]
    [InlineData("015730000000", "1573", "0000000")]
    [InlineData("015739999999", "1573", "9999999")]
    [InlineData("015750000000", "1575", "0000000")]
    [InlineData("015759999999", "1575", "9999999")]
    [InlineData("015770000000", "1577", "0000000")]
    [InlineData("015779999999", "1577", "9999999")]
    [InlineData("015790000000", "1579", "0000000")]
    [InlineData("015799999999", "1579", "9999999")]
    [InlineData("015888000000", "15888", "000000")]
    [InlineData("015888999999", "15888", "999999")]
    [InlineData("015900000000", "1590", "0000000")]
    [InlineData("015909999999", "1590", "9999999")]
    public void Parse_Known_MobilePhoneNumber_15XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("016000000000", "160", "00000000")]
    [InlineData("016099999999", "160", "99999999")]
    [InlineData("016200000000", "162", "00000000")]
    [InlineData("016299999999", "162", "99999999")]
    [InlineData("016300000000", "163", "00000000")]
    [InlineData("016399999999", "163", "99999999")]
    public void Parse_Known_MobilePhoneNumber_16X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("017000000000", "170", "00000000")]
    [InlineData("017099999999", "170", "99999999")]
    [InlineData("017600000000", "176", "00000000")]
    [InlineData("017699999999", "176", "99999999")]
    [InlineData("017900000000", "179", "00000000")]
    [InlineData("017999999999", "179", "99999999")]
    public void Parse_Known_MobilePhoneNumber_17X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("01640", "164", "0")]
    [InlineData("01649999999999", "164", "9999999999")]
    [InlineData("01680", "168", "0")]
    [InlineData("016899999999999", "168", "99999999999")]
    [InlineData("01690", "169", "0")]
    [InlineData("016999999999999", "169", "99999999999")]
    public void Parse_Known_MobilePhoneNumber_Pager(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Germany, mobilePhoneNumber.Country);
        Assert.True(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
