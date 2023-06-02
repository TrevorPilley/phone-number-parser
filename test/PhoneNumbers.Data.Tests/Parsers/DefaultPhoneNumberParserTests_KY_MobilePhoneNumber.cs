namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Cayman islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_KY_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CaymanIslands);

    [Theory]
    [InlineData("3453210000", "345", "3210000")]
    [InlineData("3453299999", "345", "3299999")]
    [InlineData("3454200000", "345", "4200000")]
    [InlineData("3454249999", "345", "4249999")]
    [InlineData("3455160000", "345", "5160000")]
    [InlineData("3455179999", "345", "5179999")]
    [InlineData("3455250000", "345", "5250000")]
    [InlineData("3455279999", "345", "5279999")]
    [InlineData("3455460000", "345", "5460000")]
    [InlineData("3455509999", "345", "5509999")]
    [InlineData("3458250000", "345", "8250000")]
    [InlineData("3458269999", "345", "8269999")]
    [InlineData("3459160000", "345", "9160000")]
    [InlineData("3459179999", "345", "9179999")]
    [InlineData("3459190000", "345", "9190000")]
    [InlineData("3459199999", "345", "9199999")]
    [InlineData("3459220000", "345", "9220000")]
    [InlineData("3459299999", "345", "9299999")]
    [InlineData("3459360000", "345", "9360000")]
    [InlineData("3459399999", "345", "9399999")]
    [InlineData("3459900000", "345", "9900000")]
    [InlineData("3459909999", "345", "9909999")]
    [InlineData("3459950000", "345", "9950000")]
    [InlineData("3459959999", "345", "9959999")]
    public void Parse_Known_MobilePhoneNumber_34X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.CaymanIslands, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
