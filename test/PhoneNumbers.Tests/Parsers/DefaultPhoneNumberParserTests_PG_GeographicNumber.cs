namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Papua new guinea <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_PG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.PapuaNewGuinea);

    [Theory]
    [InlineData("3000000", "300", "0000", "Port Moresby")]
    [InlineData("3009999", "300", "9999", "Port Moresby")]
    [InlineData("3120000", "312", "0000", "Port Moresby")]
    [InlineData("3129999", "312", "9999", "Port Moresby")]
    [InlineData("3200000", "320", "0000", "Port Moresby")]
    [InlineData("3209999", "320", "9999", "Port Moresby")]
    [InlineData("3280000", "328", "0000", "Port Moresby")]
    [InlineData("3289999", "328", "9999", "Port Moresby")]
    [InlineData("3290000", "329", "0000", "Central Rural")]
    [InlineData("3299999", "329", "9999", "Central Rural")]
    public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PapuaNewGuinea, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("4220000", "422", "0000", "Madang")]
    [InlineData("4229999", "422", "9999", "Madang")]
    [InlineData("4240000", "424", "0000", "Madang")]
    [InlineData("4249999", "424", "9999", "Madang")]
    [InlineData("4500000", "450", "0000", "East Sepik")]
    [InlineData("4509999", "450", "9999", "East Sepik")]
    [InlineData("4560000", "456", "0000", "East Sepik")]
    [InlineData("4569999", "456", "9999", "East Sepik")]
    [InlineData("4570000", "457", "0000", "Sandaun")]
    [InlineData("4579999", "457", "9999", "Sandaun")]
    [InlineData("4590000", "459", "0000", "Sandaun")]
    [InlineData("4599999", "459", "9999", "Sandaun")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PapuaNewGuinea, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("5300000", "530", "0000", "Eastern Highlands")]
    [InlineData("5309999", "530", "9999", "Eastern Highlands")]
    [InlineData("5320000", "532", "0000", "Eastern Highlands")]
    [InlineData("5329999", "532", "9999", "Eastern Highlands")]
    [InlineData("5350000", "535", "0000", "Chimbu")]
    [InlineData("5359999", "535", "9999", "Chimbu")]
    [InlineData("5370000", "537", "0000", "Eastern Highlands")]
    [InlineData("5379999", "537", "9999", "Eastern Highlands")]
    [InlineData("5400000", "540", "0000", "Southern Highlands")]
    [InlineData("5409999", "540", "9999", "Southern Highlands")]
    [InlineData("5410000", "541", "0000", "Western Highlands")]
    [InlineData("5419999", "541", "9999", "Western Highlands")]
    [InlineData("5420000", "542", "0000", "Western Highlands")]
    [InlineData("5429999", "542", "9999", "Western Highlands")]
    [InlineData("5450000", "545", "0000", "Western Highlands")]
    [InlineData("5459999", "545", "9999", "Western Highlands")]
    [InlineData("5460000", "546", "0000", "Western Highlands")]
    [InlineData("5469999", "546", "9999", "Western Highlands")]
    [InlineData("5470000", "547", "0000", "Enga")]
    [InlineData("5479999", "547", "9999", "Enga")]
    [InlineData("5490000", "549", "0000", "Southern Highlands")]
    [InlineData("5499999", "549", "9999", "Southern Highlands")]
    public void Parse_Known_GeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PapuaNewGuinea, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("6410000", "641", "0000", "Milne Bay")]
    [InlineData("6419999", "641", "9999", "Milne Bay")]
    [InlineData("6420000", "642", "0000", "Oro")]
    [InlineData("6429999", "642", "9999", "Oro")]
    [InlineData("6430000", "643", "0000", "Milne Bay")]
    [InlineData("6439999", "643", "9999", "Milne Bay")]
    [InlineData("6440000", "644", "0000", "MobileSAT")]
    [InlineData("6449999", "644", "9999", "MobileSAT")]
    [InlineData("6450000", "645", "0000", "Western")]
    [InlineData("6459999", "645", "9999", "Western")]
    [InlineData("6460000", "646", "0000", "Western")]
    [InlineData("6469999", "646", "9999", "Western")]
    [InlineData("6480000", "648", "0000", "Gulf")]
    [InlineData("6489999", "648", "9999", "Gulf")]
    [InlineData("6490000", "649", "0000", "Tabubil/Kiunga")]
    [InlineData("6499999", "649", "9999", "Tabubil/Kiunga")]
    public void Parse_Known_GeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PapuaNewGuinea, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("9700000", "970", "0000", "Manus")]
    [InlineData("9709999", "970", "9999", "Manus")]
    [InlineData("9730000", "973", "0000", "North Solomons")]
    [InlineData("9739999", "973", "9999", "North Solomons")]
    [InlineData("9750000", "975", "0000", "North Solomons")]
    [InlineData("9759999", "975", "9999", "North Solomons")]
    [InlineData("9760000", "976", "0000", "North Solomons")]
    [InlineData("9769999", "976", "9999", "North Solomons")]
    [InlineData("9800000", "980", "0000", "East New Britain")]
    [InlineData("9809999", "980", "9999", "East New Britain")]
    [InlineData("9820000", "982", "0000", "East New Britain")]
    [InlineData("9829999", "982", "9999", "East New Britain")]
    [InlineData("9830000", "983", "0000", "New Ireland")]
    [InlineData("9839999", "983", "9999", "New Ireland")]
    [InlineData("9840000", "984", "0000", "West New Britain")]
    [InlineData("9849999", "984", "9999", "West New Britain")]
    [InlineData("9850000", "985", "0000", "East New Britain")]
    [InlineData("9859999", "985", "9999", "East New Britain")]
    [InlineData("9870000", "987", "0000", "East New Britain")]
    [InlineData("9879999", "987", "9999", "East New Britain")]
    [InlineData("9890000", "989", "0000", "East New Britain")]
    [InlineData("9899999", "989", "9999", "East New Britain")]
    public void Parse_Known_GeographicPhoneNumber_9XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.PapuaNewGuinea, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
