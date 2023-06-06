namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint lucia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_LC_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintLucia);

    [Theory]
    [InlineData("7582840000", "758", "2840000")]
    [InlineData("7582879999", "758", "2879999")]
    [InlineData("7583840000", "758", "3840000")]
    [InlineData("7583849999", "758", "3849999")]
    [InlineData("7584600000", "758", "4600000")]
    [InlineData("7584619999", "758", "4619999")]
    [InlineData("7584840000", "758", "4840000")]
    [InlineData("7584899999", "758", "4899999")]
    [InlineData("7585180000", "758", "5180000")]
    [InlineData("7585209999", "758", "5209999")]
    [InlineData("7585840000", "758", "5840000")]
    [InlineData("7585849999", "758", "5849999")]
    [InlineData("7586380000", "758", "6380000")]
    [InlineData("7586839999", "758", "6839999")]
    [InlineData("7587120000", "758", "7120000")]
    [InlineData("7587289999", "758", "7289999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintLucia, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
