namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Jordan <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_JO_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Jordan);

    [Theory]
    [InlineData("026600000", "2", "6600000", "Mafraq")]
    [InlineData("026609999", "2", "6609999", "Mafraq")]
    [InlineData("026620000", "2", "6620000", "Mafraq")]
    [InlineData("026639999", "2", "6639999", "Mafraq")]
    [InlineData("026700000", "2", "6700000", "Jarash")]
    [InlineData("026709999", "2", "6709999", "Jarash")]
    [InlineData("026720000", "2", "6720000", "Jarash")]
    [InlineData("026739999", "2", "6739999", "Jarash")]
    [InlineData("026800000", "2", "6800000", "Ajloun")]
    [InlineData("026809999", "2", "6809999", "Ajloun")]
    [InlineData("026820000", "2", "6820000", "Ajloun")]
    [InlineData("026839999", "2", "6839999", "Ajloun")]
    [InlineData("026900000", "2", "6900000", "Irbid")]
    [InlineData("026939999", "2", "6939999", "Irbid")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("032220000", "3", "2220000", "Tafileh")]
    [InlineData("032229999", "3", "2229999", "Tafileh")]
    [InlineData("032400000", "3", "2400000", "Aqaba")]
    [InlineData("032439999", "3", "2439999", "Aqaba")]
    [InlineData("032500000", "3", "2500000", "Maan")]
    [InlineData("032509999", "3", "2509999", "Maan")]
    [InlineData("032520000", "3", "2520000", "Maan")]
    [InlineData("032539999", "3", "2539999", "Maan")]
    [InlineData("032600000", "3", "2600000", "Tafileh")]
    [InlineData("032609999", "3", "2609999", "Tafileh")]
    [InlineData("032700000", "3", "2700000", "Karak")]
    [InlineData("032709999", "3", "2709999", "Karak")]
    [InlineData("032720000", "3", "2720000", "Karak")]
    [InlineData("032739999", "3", "2739999", "Karak")]
    public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("053000000", "5", "3000000", "Zarqa")]
    [InlineData("053039999", "5", "3039999", "Zarqa")]
    [InlineData("053100000", "5", "3100000", "Madaba")]
    [InlineData("053109999", "5", "3109999", "Madaba")]
    [InlineData("053120000", "5", "3120000", "Madaba")]
    [InlineData("053139999", "5", "3139999", "Madaba")]
    [InlineData("053300000", "5", "3300000", "Balqa")]
    [InlineData("053309999", "5", "3309999", "Balqa")]
    [InlineData("053320000", "5", "3320000", "Balqa")]
    [InlineData("053339999", "5", "3339999", "Balqa")]
    public void Parse_Known_GeographicPhoneNumber_5_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("062220000", "6", "2220000", "Amman")]
    [InlineData("062229999", "6", "2229999", "Amman")]
    [InlineData("063330000", "6", "3330000", "Amman")]
    [InlineData("063339999", "6", "3339999", "Amman")]
    public void Parse_Known_GeographicPhoneNumber_6_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Jordan, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
