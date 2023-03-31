namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United states <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_US_MobilePhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.UnitedStates);

    [Theory]
    [InlineData("5002000000", "500", "2000000")]
    [InlineData("5009999999", "500", "9999999")]
    [InlineData("5212000000", "521", "2000000")]
    [InlineData("5219999999", "521", "9999999")]
    [InlineData("5292000000", "529", "2000000")]
    [InlineData("5299999999", "529", "9999999")]
    [InlineData("5332000000", "533", "2000000")]
    [InlineData("5339999999", "533", "9999999")]
    [InlineData("5442000000", "544", "2000000")]
    [InlineData("5449999999", "544", "9999999")]
    [InlineData("5662000000", "566", "2000000")]
    [InlineData("5669999999", "566", "9999999")]
    [InlineData("5772000000", "577", "2000000")]
    [InlineData("5779999999", "577", "9999999")]
    [InlineData("5882000000", "588", "2000000")]
    [InlineData("5889999999", "588", "9999999")]
    public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedStates, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
    }
}
