namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Trinidad and tobago <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TT_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.TrinidadAndTobago);

    [Theory]
    [InlineData("8682500000", "868", "2500000")]
    [InlineData("8682659999", "868", "2659999")]
    [InlineData("8682710000", "868", "2710000")]
    [InlineData("8682999999", "868", "2999999")]
    [InlineData("8683010000", "868", "3010000")]
    [InlineData("8683109999", "868", "3109999")]
    [InlineData("8683120000", "868", "3120000")]
    [InlineData("8683999999", "868", "3999999")]
    [InlineData("8684300000", "868", "4300000")]
    [InlineData("8684369999", "868", "4369999")]
    [InlineData("8684600000", "868", "4600000")]
    [InlineData("8684699999", "868", "4699999")]
    [InlineData("8684700000", "868", "4700000")]
    [InlineData("8684849999", "868", "4849999")]
    [InlineData("8684900000", "868", "4900000")]
    [InlineData("8684999999", "868", "4999999")]
    [InlineData("8686200000", "868", "6200000")]
    [InlineData("8686209999", "868", "6209999")]
    [InlineData("8686800000", "868", "6800000")]
    [InlineData("8686899999", "868", "6899999")]
    [InlineData("8687100000", "868", "7100000")]
    [InlineData("8687109999", "868", "7109999")]
    [InlineData("8687120000", "868", "7120000")]
    [InlineData("8687999999", "868", "7999999")]
    public void Parse_Known_MobilePhoneNumber_86X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.TrinidadAndTobago, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
