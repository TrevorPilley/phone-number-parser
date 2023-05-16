namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bahamas <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BS_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bahamas);

    [Theory]
    [InlineData("2423570000", "242", "3570000")]
    [InlineData("2423579999", "242", "3579999")]
    [InlineData("2423590000", "242", "3590000")]
    [InlineData("2423599999", "242", "3599999")]
    [InlineData("2423750000", "242", "3750000")]
    [InlineData("2423769999", "242", "3769999")]
    [InlineData("2423950000", "242", "3950000")]
    [InlineData("2423959999", "242", "3959999")]
    [InlineData("2424210000", "242", "4210000")]
    [InlineData("2424299999", "242", "4299999")]
    [InlineData("2424310000", "242", "4310000")]
    [InlineData("2424399999", "242", "4399999")]
    [InlineData("2424410000", "242", "4410000")]
    [InlineData("2424499999", "242", "4499999")]
    [InlineData("2424510000", "242", "4510000")]
    [InlineData("2424589999", "242", "4589999")]
    [InlineData("2424620000", "242", "4620000")]
    [InlineData("2424689999", "242", "4689999")]
    [InlineData("2424700000", "242", "4700000")]
    [InlineData("2424799999", "242", "4799999")]
    [InlineData("2424810000", "242", "4810000")]
    [InlineData("2424819999", "242", "4819999")]
    [InlineData("2425240000", "242", "5240000")]
    [InlineData("2425259999", "242", "5259999")]
    [InlineData("2425330000", "242", "5330000")]
    [InlineData("2425339999", "242", "5339999")]
    [InlineData("2425350000", "242", "5350000")]
    [InlineData("2425359999", "242", "5359999")]
    [InlineData("2425440000", "242", "5440000")]
    [InlineData("2425449999", "242", "5449999")]
    [InlineData("2425510000", "242", "5510000")]
    [InlineData("2425549999", "242", "5549999")]
    [InlineData("2425560000", "242", "5560000")]
    [InlineData("2425599999", "242", "5599999")]
    [InlineData("2425650000", "242", "5650000")]
    [InlineData("2425659999", "242", "5659999")]
    [InlineData("2425770000", "242", "5770000")]
    [InlineData("2425779999", "242", "5779999")]
    [InlineData("2427270000", "242", "7270000")]
    [InlineData("2427279999", "242", "7279999")]
    [InlineData("2427380000", "242", "7380000")]
    [InlineData("2427389999", "242", "7389999")]
    [InlineData("2428010000", "242", "8010000")]
    [InlineData("2428109999", "242", "8109999")]
    [InlineData("2428120000", "242", "8120000")]
    [InlineData("2428299999", "242", "8299999")]
    [InlineData("2428890000", "242", "8890000")]
    [InlineData("2428899999", "242", "8899999")]
    public void Parse_Known_MobilePhoneNumber_24X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bahamas, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
