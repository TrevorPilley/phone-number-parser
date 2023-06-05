namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Grenada <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_GD_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Grenada);

    [Theory]
    [InlineData("4734020000", "473", "4020000")]
    [InlineData("4734079999", "473", "4079999")]
    [InlineData("4734090000", "473", "4090000")]
    [InlineData("4734109999", "473", "4109999")]
    [InlineData("4734140000", "473", "4140000")]
    [InlineData("4734209999", "473", "4209999")]
    [InlineData("4734580000", "473", "4580000")]
    [InlineData("4734589999", "473", "4589999")]
    [InlineData("4735200000", "473", "5200000")]
    [InlineData("4735219999", "473", "5219999")]
    [InlineData("4735330000", "473", "5330000")]
    [InlineData("4735389999", "473", "5389999")]
    [InlineData("4739010000", "473", "9010000")]
    [InlineData("4739019999", "473", "9019999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Grenada, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
