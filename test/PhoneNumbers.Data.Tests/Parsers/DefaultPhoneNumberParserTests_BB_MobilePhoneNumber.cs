namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Barbados <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BB_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Barbados);

    [Theory]
    [InlineData("2462300000", "246", "2300000")]
    [InlineData("2462459999", "246", "2459999")]
    [InlineData("2462470000", "246", "2470000")]
    [InlineData("2462699999", "246", "2699999")]
    [InlineData("2462800000", "246", "2800000")]
    [InlineData("2462879999", "246", "2879999")]
    [InlineData("2462890000", "246", "2890000")]
    [InlineData("2462899999", "246", "2899999")]
    [InlineData("2463520000", "246", "3520000")]
    [InlineData("2463669999", "246", "3669999")]
    [InlineData("2464460000", "246", "4460000")]
    [InlineData("2464469999", "246", "4469999")]
    [InlineData("2465211000", "246", "5211000")]
    [InlineData("2465211999", "246", "5211999")]
    [InlineData("2465214000", "246", "5214000")]
    [InlineData("2465214999", "246", "5214999")]
    [InlineData("2465217000", "246", "5217000")]
    [InlineData("2465217999", "246", "5217999")]
    [InlineData("2465220000", "246", "5220000")]
    [InlineData("2465220999", "246", "5220999")]
    [InlineData("2466950000", "246", "6950000")]
    [InlineData("2466979999", "246", "6979999")]
    [InlineData("2468200000", "246", "8200000")]
    [InlineData("2468599999", "246", "8599999")]
    [InlineData("2468830000", "246", "8830000")]
    [InlineData("2468839999", "246", "8839999")]
    public void Parse_Known_MobilePhoneNumber_24X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Barbados, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
