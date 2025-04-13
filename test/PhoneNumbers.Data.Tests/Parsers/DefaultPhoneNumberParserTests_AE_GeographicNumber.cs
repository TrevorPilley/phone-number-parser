namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for United arab emirates <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AE_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.UnitedArabEmirates);

    [Theory]
    [InlineData("022010000", "2", "2010000", "Abu Dhabi Region")]
    [InlineData("022990000", "2", "2990000", "Abu Dhabi Region")]
    [InlineData("023010000", "2", "3010000", "Abu Dhabi Region")]
    [InlineData("023990000", "2", "3990000", "Abu Dhabi Region")]
    [InlineData("024010000", "2", "4010000", "Abu Dhabi Region")]
    [InlineData("024990000", "2", "4990000", "Abu Dhabi Region")]
    [InlineData("025010000", "2", "5010000", "Abu Dhabi Region")]
    [InlineData("025990000", "2", "5990000", "Abu Dhabi Region")]
    [InlineData("026010000", "2", "6010000", "Abu Dhabi Region")]
    [InlineData("026990000", "2", "6990000", "Abu Dhabi Region")]
    [InlineData("027010000", "2", "7010000", "Abu Dhabi Region")]
    [InlineData("027990000", "2", "7990000", "Abu Dhabi Region")]
    [InlineData("028010000", "2", "8010000", "Abu Dhabi Region")]
    [InlineData("028990000", "2", "8990000", "Abu Dhabi Region")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("032010000", "3", "2010000", "Al Ain Region")]
    [InlineData("032990000", "3", "2990000", "Al Ain Region")]
    [InlineData("033010000", "3", "3010000", "Al Ain Region")]
    [InlineData("033990000", "3", "3990000", "Al Ain Region")]
    [InlineData("034010000", "3", "4010000", "Al Ain Region")]
    [InlineData("034990000", "3", "4990000", "Al Ain Region")]
    [InlineData("035010000", "3", "5010000", "Al Ain Region")]
    [InlineData("035990000", "3", "5990000", "Al Ain Region")]
    [InlineData("036010000", "3", "6010000", "Al Ain Region")]
    [InlineData("036990000", "3", "6990000", "Al Ain Region")]
    [InlineData("037010000", "3", "7010000", "Al Ain Region")]
    [InlineData("037990000", "3", "7990000", "Al Ain Region")]
    [InlineData("038010000", "3", "8010000", "Al Ain Region")]
    [InlineData("038990000", "3", "8990000", "Al Ain Region")]
    public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("042010000", "4", "2010000", "Dubai Region")]
    [InlineData("042990000", "4", "2990000", "Dubai Region")]
    [InlineData("043010000", "4", "3010000", "Dubai Region")]
    [InlineData("043990000", "4", "3990000", "Dubai Region")]
    [InlineData("044010000", "4", "4010000", "Dubai Region")]
    [InlineData("044990000", "4", "4990000", "Dubai Region")]
    [InlineData("045010000", "4", "5010000", "Dubai Region")]
    [InlineData("045990000", "4", "5990000", "Dubai Region")]
    [InlineData("046010000", "4", "6010000", "Dubai Region")]
    [InlineData("046990000", "4", "6990000", "Dubai Region")]
    [InlineData("047010000", "4", "7010000", "Dubai Region")]
    [InlineData("047990000", "4", "7990000", "Dubai Region")]
    [InlineData("048010000", "4", "8010000", "Dubai Region")]
    [InlineData("048990000", "4", "8990000", "Dubai Region")]
    public void Parse_Known_GeographicPhoneNumber_4_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("062010000", "6", "2010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("062990000", "6", "2990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("063010000", "6", "3010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("063990000", "6", "3990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("064010000", "6", "4010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("064990000", "6", "4990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("065010000", "6", "5010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("065990000", "6", "5990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("066010000", "6", "6010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("066990000", "6", "6990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("067010000", "6", "7010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("067990000", "6", "7990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("068010000", "6", "8010000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    [InlineData("068990000", "6", "8990000", "West Coast Region (Sharjah, Ajman and Umm Al-Qaiwain)")]
    public void Parse_Known_GeographicPhoneNumber_6_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("072010000", "7", "2010000", "Ras Al Khai mah Region")]
    [InlineData("072990000", "7", "2990000", "Ras Al Khai mah Region")]
    [InlineData("073010000", "7", "3010000", "Ras Al Khai mah Region")]
    [InlineData("073990000", "7", "3990000", "Ras Al Khai mah Region")]
    [InlineData("074010000", "7", "4010000", "Ras Al Khai mah Region")]
    [InlineData("074990000", "7", "4990000", "Ras Al Khai mah Region")]
    [InlineData("075010000", "7", "5010000", "Ras Al Khai mah Region")]
    [InlineData("075990000", "7", "5990000", "Ras Al Khai mah Region")]
    [InlineData("076010000", "7", "6010000", "Ras Al Khai mah Region")]
    [InlineData("076990000", "7", "6990000", "Ras Al Khai mah Region")]
    [InlineData("077010000", "7", "7010000", "Ras Al Khai mah Region")]
    [InlineData("077990000", "7", "7990000", "Ras Al Khai mah Region")]
    [InlineData("078010000", "7", "8010000", "Ras Al Khai mah Region")]
    [InlineData("078990000", "7", "8990000", "Ras Al Khai mah Region")]
    public void Parse_Known_GeographicPhoneNumber_7_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("092010000", "9", "2010000", "East Coast Region (Fujairah)")]
    [InlineData("092990000", "9", "2990000", "East Coast Region (Fujairah)")]
    [InlineData("093010000", "9", "3010000", "East Coast Region (Fujairah)")]
    [InlineData("093990000", "9", "3990000", "East Coast Region (Fujairah)")]
    [InlineData("094010000", "9", "4010000", "East Coast Region (Fujairah)")]
    [InlineData("094990000", "9", "4990000", "East Coast Region (Fujairah)")]
    [InlineData("095010000", "9", "5010000", "East Coast Region (Fujairah)")]
    [InlineData("095990000", "9", "5990000", "East Coast Region (Fujairah)")]
    [InlineData("096010000", "9", "6010000", "East Coast Region (Fujairah)")]
    [InlineData("096990000", "9", "6990000", "East Coast Region (Fujairah)")]
    [InlineData("097010000", "9", "7010000", "East Coast Region (Fujairah)")]
    [InlineData("097990000", "9", "7990000", "East Coast Region (Fujairah)")]
    [InlineData("098010000", "9", "8010000", "East Coast Region (Fujairah)")]
    [InlineData("098990000", "9", "8990000", "East Coast Region (Fujairah)")]
    public void Parse_Known_GeographicPhoneNumber_9_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.UnitedArabEmirates, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
