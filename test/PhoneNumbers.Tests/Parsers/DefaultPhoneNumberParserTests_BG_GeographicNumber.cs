namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bulgaria <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BG_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bulgaria);

    [Theory]
    [InlineData("022000000", "2", "2000000", "Sofia")]
    [InlineData("029999999", "2", "9999999", "Sofia")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("030200000", "30", "200000", "Smolyan, Smolyan region and Plovdiv region")]
    [InlineData("030999999", "30", "999999", "Smolyan, Smolyan region and Plovdiv region")]
    [InlineData("031200000", "31", "200000", "Plovdiv region")]
    [InlineData("031999999", "31", "999999", "Plovdiv region")]
    [InlineData("032200000", "32", "200000", "Plovdiv")]
    [InlineData("032999999", "32", "999999", "Plovdiv")]
    [InlineData("033200000", "33", "200000", "Plovdiv region")]
    [InlineData("033999999", "33", "999999", "Plovdiv region")]
    [InlineData("034200000", "34", "200000", "Pazardzhik")]
    [InlineData("034999999", "34", "999999", "Pazardzhik")]
    [InlineData("035200000", "35", "200000", "Pazardzhik region")]
    [InlineData("035999999", "35", "999999", "Pazardzhik region")]
    [InlineData("036200000", "36", "200000", "Kardzhali, Kardzhali region and Haskovo region")]
    [InlineData("036999999", "36", "999999", "Kardzhali, Kardzhali region and Haskovo region")]
    [InlineData("037200000", "37", "200000", "Haskovo region")]
    [InlineData("037999999", "37", "999999", "Haskovo region")]
    [InlineData("038200000", "38", "200000", "Haskovo")]
    [InlineData("038999999", "38", "999999", "Haskovo")]
    [InlineData("039200000", "39", "200000", "Haskovo region")]
    [InlineData("039999999", "39", "999999", "Haskovo region")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("041200000", "41", "200000", "Stara Zagora region")]
    [InlineData("041999999", "41", "999999", "Stara Zagora region")]
    [InlineData("042200000", "42", "200000", "Stara Zagora")]
    [InlineData("042999999", "42", "999999", "Stara Zagora")]
    [InlineData("044200000", "44", "200000", "Sliven")]
    [InlineData("044999999", "44", "999999", "Sliven")]
    [InlineData("045200000", "45", "200000", "Sliven region")]
    [InlineData("045999999", "45", "999999", "Sliven region")]
    [InlineData("046200000", "46", "200000", "Yambol")]
    [InlineData("046999999", "46", "999999", "Yambol")]
    [InlineData("047200000", "47", "200000", "Yambol region and Haskovo region")]
    [InlineData("047999999", "47", "999999", "Yambol region and Haskovo region")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("043120000", "431", "20000", "Stara Zagora region")]
    [InlineData("043199999", "431", "99999", "Stara Zagora region")]
    [InlineData("043620000", "436", "20000", "Stara Zagora region")]
    [InlineData("043699999", "436", "99999", "Stara Zagora region")]
    public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("051200000", "51", "200000", "Varna region")]
    [InlineData("051999999", "51", "999999", "Varna region")]
    [InlineData("052200000", "52", "200000", "Varna")]
    [InlineData("052999999", "52", "999999", "Varna")]
    [InlineData("053200000", "53", "200000", "Shumen region")]
    [InlineData("053999999", "53", "999999", "Shumen region")]
    [InlineData("054200000", "54", "200000", "Shumen")]
    [InlineData("054999999", "54", "999999", "Shumen")]
    [InlineData("055200000", "55", "200000", "Burgas region")]
    [InlineData("055999999", "55", "999999", "Burgas region")]
    [InlineData("056200000", "56", "200000", "Burgas")]
    [InlineData("056999999", "56", "999999", "Burgas")]
    [InlineData("057200000", "57", "200000", "Dobrich region")]
    [InlineData("057999999", "57", "999999", "Dobrich region")]
    [InlineData("058200000", "58", "200000", "Dobrich")]
    [InlineData("058999999", "58", "999999", "Dobrich")]
    [InlineData("059200000", "59", "200000", "Burgas region")]
    [InlineData("059999999", "59", "999999", "Burgas region")]
    public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("060200000", "60", "200000", "Targovishte and Targovishte region")]
    [InlineData("060999999", "60", "999999", "Targovishte and Targovishte region")]
    [InlineData("061200000", "61", "200000", "Veliko Tarnovo region")]
    [InlineData("061999999", "61", "999999", "Veliko Tarnovo region")]
    [InlineData("062200000", "62", "200000", "Veliko Tarnovo")]
    [InlineData("062999999", "62", "999999", "Veliko Tarnovo")]
    [InlineData("063200000", "63", "200000", "Veliko Tarnovo region")]
    [InlineData("063999999", "63", "999999", "Veliko Tarnovo region")]
    [InlineData("064200000", "64", "200000", "Pleven")]
    [InlineData("064999999", "64", "999999", "Pleven")]
    [InlineData("065200000", "65", "200000", "Pleven region")]
    [InlineData("065999999", "65", "999999", "Pleven region")]
    [InlineData("066200000", "66", "200000", "Gabrovo")]
    [InlineData("066999999", "66", "999999", "Gabrovo")]
    [InlineData("067200000", "67", "200000", "Gabrovo region and Lovech region")]
    [InlineData("067999999", "67", "999999", "Gabrovo region and Lovech region")]
    [InlineData("068200000", "68", "200000", "Lovech")]
    [InlineData("068999999", "68", "999999", "Lovech")]
    [InlineData("069200000", "69", "200000", "Lovech region")]
    [InlineData("069999999", "69", "999999", "Lovech region")]
    public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("071200000", "71", "200000", "Sofia region")]
    [InlineData("071999999", "71", "999999", "Sofia region")]
    [InlineData("072200000", "72", "200000", "Sofia region")]
    [InlineData("072999999", "72", "999999", "Sofia region")]
    [InlineData("073200000", "73", "200000", "Blagoevgrad")]
    [InlineData("073999999", "73", "999999", "Blagoevgrad")]
    [InlineData("074200000", "74", "200000", "Blagoevgrad region")]
    [InlineData("074999999", "74", "999999", "Blagoevgrad region")]
    [InlineData("075200000", "75", "200000", "Blagoevgrad region and Sofia region")]
    [InlineData("075999999", "75", "999999", "Blagoevgrad region and Sofia region")]
    [InlineData("076200000", "76", "200000", "Pernik")]
    [InlineData("076999999", "76", "999999", "Pernik")]
    [InlineData("077200000", "77", "200000", "Pernik region")]
    [InlineData("077999999", "77", "999999", "Pernik region")]
    [InlineData("078200000", "78", "200000", "Kyustendil")]
    [InlineData("078999999", "78", "999999", "Kyustendil")]
    [InlineData("079200000", "79", "200000", "Kyustendil region")]
    [InlineData("079999999", "79", "999999", "Kyustendil region")]
    public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("070120000", "701", "20000", "Kyustendil region")]
    [InlineData("070199999", "701", "99999", "Kyustendil region")]
    [InlineData("070720000", "707", "20000", "Kyustendil region")]
    [InlineData("070799999", "707", "99999", "Kyustendil region")]
    public void Parse_Known_GeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("081200000", "81", "200000", "Ruse region")]
    [InlineData("081999999", "81", "999999", "Ruse region")]
    [InlineData("082200000", "82", "200000", "Ruse")]
    [InlineData("082999999", "82", "999999", "Ruse")]
    [InlineData("084200000", "84", "200000", "Razgrad and Razgrad region")]
    [InlineData("084999999", "84", "999999", "Razgrad and Razgrad region")]
    [InlineData("086200000", "86", "200000", "Silistra and Silistra region")]
    [InlineData("086999999", "86", "999999", "Silistra and Silistra region")]
    public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("091200000", "91", "200000", "Vratsa region")]
    [InlineData("091999999", "91", "999999", "Vratsa region")]
    [InlineData("092200000", "92", "200000", "Vratsa")]
    [InlineData("092999999", "92", "999999", "Vratsa")]
    [InlineData("093200000", "93", "200000", "Vidin region")]
    [InlineData("093999999", "93", "999999", "Vidin region")]
    [InlineData("094200000", "94", "200000", "Vidin")]
    [InlineData("094999999", "94", "999999", "Vidin")]
    [InlineData("095200000", "95", "200000", "Montana region")]
    [InlineData("095999999", "95", "999999", "Montana region")]
    [InlineData("096200000", "96", "200000", "Montana")]
    [InlineData("096999999", "96", "999999", "Montana")]
    [InlineData("097200000", "97", "200000", "Montana region and Vratsa region")]
    [InlineData("097999999", "97", "999999", "Montana region and Vratsa region")]
    public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bulgaria, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
