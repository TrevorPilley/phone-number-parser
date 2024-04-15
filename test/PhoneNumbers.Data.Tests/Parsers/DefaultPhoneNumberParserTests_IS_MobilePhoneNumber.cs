namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Iceland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IS_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Iceland);

    [Theory]
    [InlineData("6110000", "6110000")]
    [InlineData("6189999", "6189999")]
    [InlineData("6200000", "6200000")]
    [InlineData("6269999", "6269999")]
    [InlineData("6300000", "6300000")]
    [InlineData("6309999", "6309999")]
    [InlineData("6320000", "6320000")]
    [InlineData("6329999", "6329999")]
    [InlineData("6360000", "6360000")]
    [InlineData("6419999", "6419999")]
    [InlineData("6440000", "6440000")]
    [InlineData("6449999", "6449999")]
    [InlineData("6460000", "6460000")]
    [InlineData("6479999", "6479999")]
    [InlineData("6490000", "6490000")]
    [InlineData("6519999", "6519999")]
    [InlineData("6550000", "6550000")]
    [InlineData("6559999", "6559999")]
    [InlineData("6590000", "6590000")]
    [InlineData("6669999", "6669999")]
    [InlineData("6690000", "6690000")]
    [InlineData("6709999", "6709999")]
    [InlineData("6800000", "6800000")]
    [InlineData("6809999", "6809999")]
    [InlineData("6860000", "6860000")]
    [InlineData("6999999", "6999999")]
    [InlineData("7600000", "7600000")]
    [InlineData("7939999", "7939999")]
    [InlineData("8200000", "8200000")]
    [InlineData("8259999", "8259999")]
    [InlineData("8290000", "8290000")]
    [InlineData("8689999", "8689999")]
    [InlineData("8820000", "8820000")]
    [InlineData("8839999", "8839999")]
    [InlineData("8880000", "8880000")]
    [InlineData("8889999", "8889999")]
    [InlineData("8900000", "8900000")]
    [InlineData("8999999", "8999999")]
    [InlineData("358000000", "358000000")]
    [InlineData("358999999", "358999999")]
    [InlineData("388000000", "388000000")]
    [InlineData("389999999", "389999999")]
    public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Iceland, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
