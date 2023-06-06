namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Saint vincent and the grenadines <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_VC_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SaintVincentAndTheGrenadines);

    [Theory]
    [InlineData("7844300000", "784", "4300000")]
    [InlineData("7844349999", "784", "4349999")]
    [InlineData("7844540000", "784", "4540000")]
    [InlineData("7844559999", "784", "4559999")]
    [InlineData("7844910000", "784", "4910000")]
    [InlineData("7844989999", "784", "4989999")]
    [InlineData("7845260000", "784", "5260000")]
    [InlineData("7845349999", "784", "5349999")]
    [InlineData("7845930000", "784", "5930000")]
    [InlineData("7845939999", "784", "5939999")]
    public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SaintVincentAndTheGrenadines, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
