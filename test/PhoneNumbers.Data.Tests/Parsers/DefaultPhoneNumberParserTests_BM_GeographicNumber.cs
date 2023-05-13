namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bermuda <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BM_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bermuda);

    [Theory]
    [InlineData("4412020000", "441", "2020000", "Bermuda")]
    [InlineData("4412020999", "441", "2020999", "Bermuda")]
    [InlineData("4412220000", "441", "2220000", "Bermuda")]
    [InlineData("4412229999", "441", "2229999", "Bermuda")]
    [InlineData("4412236000", "441", "2236000", "Bermuda")]
    [InlineData("4412236999", "441", "2236999", "Bermuda")]
    [InlineData("4412300000", "441", "2300000", "Bermuda")]
    [InlineData("4412499999", "441", "2499999", "Bermuda")]
    [InlineData("4412610000", "441", "2610000", "Bermuda")]
    [InlineData("4412619999", "441", "2619999", "Bermuda")]
    [InlineData("4412700000", "441", "2700000", "Bermuda")]
    [InlineData("4412799999", "441", "2799999", "Bermuda")]
    [InlineData("4412900000", "441", "2900000", "Bermuda")]
    [InlineData("4412999999", "441", "2999999", "Bermuda")]
    [InlineData("4413000000", "441", "3000000", "Bermuda")]
    [InlineData("4413999999", "441", "3999999", "Bermuda")]
    [InlineData("4414000000", "441", "4000000", "Bermuda")]
    [InlineData("4414999999", "441", "4999999", "Bermuda")]
    [InlineData("4415000000", "441", "5000000", "Bermuda")]
    [InlineData("4415109999", "441", "5109999", "Bermuda")]
    [InlineData("4415120000", "441", "5120000", "Bermuda")]
    [InlineData("4415399999", "441", "5399999", "Bermuda")]
    [InlineData("4415400000", "441", "5400000", "Bermuda")]
    [InlineData("4415499999", "441", "5499999", "Bermuda")]
    [InlineData("4415600000", "441", "5600000", "Bermuda")]
    [InlineData("4415609999", "441", "5609999", "Bermuda")]
    [InlineData("4415890000", "441", "5890000", "Bermuda")]
    [InlineData("4415899999", "441", "5899999", "Bermuda")]
    [InlineData("4415900000", "441", "5900000", "Bermuda")]
    [InlineData("4415999999", "441", "5999999", "Bermuda")]
    [InlineData("4416000000", "441", "6000000", "Bermuda")]
    [InlineData("4416029999", "441", "6029999", "Bermuda")]
    [InlineData("4416200000", "441", "6200000", "Bermuda")]
    [InlineData("4416219999", "441", "6219999", "Bermuda")]
    [InlineData("4416500000", "441", "6500000", "Bermuda")]
    [InlineData("4416599999", "441", "6599999", "Bermuda")]
    [InlineData("4416900000", "441", "6900000", "Bermuda")]
    [InlineData("4416999999", "441", "6999999", "Bermuda")]
    [InlineData("4417000000", "441", "7000000", "Bermuda")]
    [InlineData("4417999999", "441", "7999999", "Bermuda")]
    [InlineData("4418240000", "441", "8240000", "Bermuda")]
    [InlineData("4418249999", "441", "8249999", "Bermuda")]
    [InlineData("4418300000", "441", "8300000", "Bermuda")]
    [InlineData("4418399999", "441", "8399999", "Bermuda")]
    [InlineData("4418500000", "441", "8500000", "Bermuda")]
    [InlineData("4418599999", "441", "8599999", "Bermuda")]
    [InlineData("4418900000", "441", "8900000", "Bermuda")]
    [InlineData("4418999999", "441", "8999999", "Bermuda")]
    [InlineData("4419200000", "441", "9200000", "Bermuda")]
    [InlineData("4419299999", "441", "9299999", "Bermuda")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bermuda, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
