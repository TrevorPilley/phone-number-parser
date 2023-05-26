namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Malta <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MT_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Malta);

    [Theory]
    [InlineData("20100500", "20", "100500")]
    [InlineData("20100599", "20", "100599")]
    [InlineData("20102500", "20", "102500")]
    [InlineData("20102599", "20", "102599")]
    [InlineData("20104700", "20", "104700")]
    [InlineData("20104799", "20", "104799")]
    [InlineData("20106700", "20", "106700")]
    [InlineData("20106799", "20", "106799")]
    [InlineData("20108400", "20", "108400")]
    [InlineData("20108499", "20", "108499")]
    [InlineData("20109200", "20", "109200")]
    [InlineData("20109299", "20", "109299")]
    [InlineData("20109500", "20", "109500")]
    [InlineData("20109599", "20", "109599")]
    [InlineData("20110000", "20", "110000")]
    [InlineData("20189999", "20", "189999")]
    [InlineData("20310000", "20", "310000")]
    [InlineData("20349999", "20", "349999")]
    [InlineData("20602000", "20", "602000")]
    [InlineData("20602999", "20", "602999")]
    [InlineData("20605000", "20", "605000")]
    [InlineData("20605999", "20", "605999")]
    [InlineData("20650000", "20", "650000")]
    [InlineData("20659999", "20", "659999")]
    [InlineData("20690000", "20", "690000")]
    [InlineData("20699999", "20", "699999")]
    [InlineData("20900000", "20", "900000")]
    [InlineData("20999999", "20", "999999")]
    [InlineData("21210000", "21", "210000")]
    [InlineData("21269999", "21", "269999")]
    [InlineData("21310000", "21", "310000")]
    [InlineData("21389999", "21", "389999")]
    [InlineData("21410000", "21", "410000")]
    [InlineData("21499999", "21", "499999")]
    [InlineData("21520000", "21", "520000")]
    [InlineData("21529999", "21", "529999")]
    [InlineData("21550000", "21", "550000")]
    [InlineData("21589999", "21", "589999")]
    [InlineData("21620000", "21", "620000")]
    [InlineData("21699999", "21", "699999")]
    [InlineData("21720000", "21", "720000")]
    [InlineData("21749999", "21", "749999")]
    [InlineData("21800000", "21", "800000")]
    [InlineData("21809999", "21", "809999")]
    [InlineData("21820000", "21", "820000")]
    [InlineData("21829999", "21", "829999")]
    [InlineData("21880000", "21", "880000")]
    [InlineData("21899999", "21", "899999")]
    [InlineData("22110000", "22", "110000")]
    [InlineData("22119999", "22", "119999")]
    [InlineData("22150000", "22", "150000")]
    [InlineData("22169999", "22", "169999")]
    [InlineData("22190000", "22", "190000")]
    [InlineData("22209999", "22", "209999")]
    [InlineData("22220000", "22", "220000")]
    [InlineData("22279999", "22", "279999")]
    [InlineData("22290000", "22", "290000")]
    [InlineData("22299999", "22", "299999")]
    [InlineData("22350000", "22", "350000")]
    [InlineData("22359999", "22", "359999")]
    [InlineData("22400000", "22", "400000")]
    [InlineData("22409999", "22", "409999")]
    [InlineData("22440000", "22", "440000")]
    [InlineData("22459999", "22", "459999")]
    [InlineData("22470000", "22", "470000")]
    [InlineData("22509999", "22", "509999")]
    [InlineData("22560000", "22", "560000")]
    [InlineData("22569999", "22", "569999")]
    [InlineData("22580000", "22", "580000")]
    [InlineData("22589999", "22", "589999")]
    [InlineData("22600000", "22", "600000")]
    [InlineData("22609999", "22", "609999")]
    [InlineData("22620000", "22", "620000")]
    [InlineData("22629999", "22", "629999")]
    [InlineData("22640000", "22", "640000")]
    [InlineData("22659999", "22", "659999")]
    [InlineData("22690000", "22", "690000")]
    [InlineData("22819999", "22", "819999")]
    [InlineData("22890000", "22", "890000")]
    [InlineData("22999999", "22", "999999")]
    [InlineData("23100000", "23", "100000")]
    [InlineData("23249999", "23", "249999")]
    [InlineData("23260000", "23", "260000")]
    [InlineData("23349999", "23", "349999")]
    [InlineData("23380000", "23", "380000")]
    [InlineData("23579999", "23", "579999")]
    [InlineData("23590000", "23", "590000")]
    [InlineData("23649999", "23", "649999")]
    [InlineData("23660000", "23", "660000")]
    [InlineData("23890000", "23", "890000")]
    [InlineData("23910000", "23", "910000")]
    [InlineData("23999999", "23", "999999")]
    [InlineData("25220000", "25", "220000")]
    [InlineData("25229999", "25", "229999")]
    [InlineData("25490000", "25", "490000")]
    [InlineData("25709999", "25", "709999")]
    [InlineData("25760000", "25", "760000")]
    [InlineData("25799999", "25", "799999")]
    [InlineData("25900000", "25", "900000")]
    [InlineData("25999999", "25", "999999")]
    [InlineData("26000000", "26", "000000")]
    [InlineData("26099999", "26", "099999")]
    [InlineData("27000000", "27", "000000")]
    [InlineData("27999999", "27", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("50100000", "50", "100000")]
    [InlineData("50199999", "50", "199999")]
    public void Parse_Known_NonGeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("80002000", "80", "002000")]
    [InlineData("80002999", "80", "002999")]
    [InlineData("80034000", "80", "034000")]
    [InlineData("80034999", "80", "034999")]
    [InlineData("80036000", "80", "036000")]
    [InlineData("80036999", "80", "036999")]
    [InlineData("80037000", "80", "037000")]
    [InlineData("80037999", "80", "037999")]
    [InlineData("80049000", "80", "049000")]
    [InlineData("80049999", "80", "049999")]
    [InlineData("80062000", "80", "062000")]
    [InlineData("80062999", "80", "062999")]
    [InlineData("80065000", "80", "065000")]
    [InlineData("80065999", "80", "065999")]
    [InlineData("80072000", "80", "072000")]
    [InlineData("80076999", "80", "076999")]
    [InlineData("80078000", "80", "078000")]
    [InlineData("80078999", "80", "078999")]
    [InlineData("80090000", "80", "090000")]
    [InlineData("80090999", "80", "090999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("50037000", "50", "037000")]
    [InlineData("50037999", "50", "037999")]
    [InlineData("50043000", "50", "043000")]
    [InlineData("50043999", "50", "043999")]
    [InlineData("50600000", "50", "600000")]
    [InlineData("50699999", "50", "699999")]
    [InlineData("50700000", "50", "700000")]
    [InlineData("50709999", "50", "709999")]
    [InlineData("50900000", "50", "900000")]
    [InlineData("50919999", "50", "919999")]
    [InlineData("51002000", "51", "002000")]
    [InlineData("51002199", "51", "002199")]
    [InlineData("51003000", "51", "003000")]
    [InlineData("51003099", "51", "003099")]
    [InlineData("51004000", "51", "004000")]
    [InlineData("51004099", "51", "004099")]
    [InlineData("51006000", "51", "006000")]
    [InlineData("51006099", "51", "006099")]
    [InlineData("52002000", "52", "002000")]
    [InlineData("52002199", "52", "002199")]
    [InlineData("52003000", "52", "003000")]
    [InlineData("52003099", "52", "003099")]
    [InlineData("52004000", "52", "004000")]
    [InlineData("52004099", "52", "004099")]
    [InlineData("52006000", "52", "006000")]
    [InlineData("52006099", "52", "006099")]
    [InlineData("54002000", "54", "002000")]
    [InlineData("54002199", "54", "002199")]
    [InlineData("54003000", "54", "003000")]
    [InlineData("54003099", "54", "003099")]
    [InlineData("54004000", "54", "004000")]
    [InlineData("54004099", "54", "004099")]
    [InlineData("54006000", "54", "006000")]
    [InlineData("54006099", "54", "006099")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
