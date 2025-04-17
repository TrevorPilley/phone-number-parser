namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Malta <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MT_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Malta);

    [Theory]
    [InlineData("20100500", "20100500")]
    [InlineData("20100599", "20100599")]
    [InlineData("20102500", "20102500")]
    [InlineData("20102599", "20102599")]
    [InlineData("20104700", "20104700")]
    [InlineData("20104799", "20104799")]
    [InlineData("20105600", "20105600")]
    [InlineData("20105699", "20105699")]
    [InlineData("20106700", "20106700")]
    [InlineData("20106799", "20106799")]
    [InlineData("20108400", "20108400")]
    [InlineData("20108499", "20108499")]
    [InlineData("20109200", "20109200")]
    [InlineData("20109299", "20109299")]
    [InlineData("20109500", "20109500")]
    [InlineData("20109599", "20109599")]
    [InlineData("20110000", "20110000")]
    [InlineData("20189999", "20189999")]
    [InlineData("20310000", "20310000")]
    [InlineData("20349999", "20349999")]
    [InlineData("20602000", "20602000")]
    [InlineData("20602999", "20602999")]
    [InlineData("20605000", "20605000")]
    [InlineData("20605999", "20605999")]
    [InlineData("20650000", "20650000")]
    [InlineData("20659999", "20659999")]
    [InlineData("20690000", "20690000")]
    [InlineData("20699999", "20699999")]
    [InlineData("20900000", "20900000")]
    [InlineData("20999999", "20999999")]
    [InlineData("21210000", "21210000")]
    [InlineData("21269999", "21269999")]
    [InlineData("21310000", "21310000")]
    [InlineData("21389999", "21389999")]
    [InlineData("21410000", "21410000")]
    [InlineData("21499999", "21499999")]
    [InlineData("21520000", "21520000")]
    [InlineData("21529999", "21529999")]
    [InlineData("21550000", "21550000")]
    [InlineData("21589999", "21589999")]
    [InlineData("21620000", "21620000")]
    [InlineData("21699999", "21699999")]
    [InlineData("21720000", "21720000")]
    [InlineData("21749999", "21749999")]
    [InlineData("21800000", "21800000")]
    [InlineData("21809999", "21809999")]
    [InlineData("21820000", "21820000")]
    [InlineData("21829999", "21829999")]
    [InlineData("21860000", "21860000")]
    [InlineData("21869999", "21869999")]
    [InlineData("21880000", "21880000")]
    [InlineData("21899999", "21899999")]
    [InlineData("22000000", "22000000")]
    [InlineData("22119999", "22119999")]
    [InlineData("22150000", "22150000")]
    [InlineData("22169999", "22169999")]
    [InlineData("22190000", "22190000")]
    [InlineData("22209999", "22209999")]
    [InlineData("22220000", "22220000")]
    [InlineData("22279999", "22279999")]
    [InlineData("22290000", "22290000")]
    [InlineData("22299999", "22299999")]
    [InlineData("22350000", "22350000")]
    [InlineData("22359999", "22359999")]
    [InlineData("22400000", "22400000")]
    [InlineData("22409999", "22409999")]
    [InlineData("22440000", "22440000")]
    [InlineData("22459999", "22459999")]
    [InlineData("22470000", "22470000")]
    [InlineData("22509999", "22509999")]
    [InlineData("22560000", "22560000")]
    [InlineData("22569999", "22569999")]
    [InlineData("22580000", "22580000")]
    [InlineData("22589999", "22589999")]
    [InlineData("22600000", "22600000")]
    [InlineData("22609999", "22609999")]
    [InlineData("22620000", "22620000")]
    [InlineData("22629999", "22629999")]
    [InlineData("22640000", "22640000")]
    [InlineData("22659999", "22659999")]
    [InlineData("22690000", "22690000")]
    [InlineData("22819999", "22819999")]
    [InlineData("22890000", "22890000")]
    [InlineData("22999999", "22999999")]
    [InlineData("23100000", "23100000")]
    [InlineData("23249999", "23249999")]
    [InlineData("23260000", "23260000")]
    [InlineData("23349999", "23349999")]
    [InlineData("23380000", "23380000")]
    [InlineData("23579999", "23579999")]
    [InlineData("23590000", "23590000")]
    [InlineData("23649999", "23649999")]
    [InlineData("23660000", "23660000")]
    [InlineData("23890000", "23890000")]
    [InlineData("23910000", "23910000")]
    [InlineData("23999999", "23999999")]
    [InlineData("24002400", "24002400")]
    [InlineData("25220000", "25220000")]
    [InlineData("25229999", "25229999")]
    [InlineData("25400000", "25400000")]
    [InlineData("25709999", "25709999")]
    [InlineData("25760000", "25760000")]
    [InlineData("25799999", "25799999")]
    [InlineData("25900000", "25900000")]
    [InlineData("25999999", "25999999")]
    [InlineData("26000000", "26000000")]
    [InlineData("26099999", "26099999")]
    [InlineData("27000000", "27000000")]
    [InlineData("27999999", "27999999")]
    [InlineData("50100000", "50100000")]
    [InlineData("50199999", "50199999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
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
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("80002000", "80002000")]
    [InlineData("80002999", "80002999")]
    [InlineData("80034000", "80034000")]
    [InlineData("80034999", "80034999")]
    [InlineData("80036000", "80036000")]
    [InlineData("80036999", "80036999")]
    [InlineData("80037000", "80037000")]
    [InlineData("80037999", "80037999")]
    [InlineData("80049000", "80049000")]
    [InlineData("80049999", "80049999")]
    [InlineData("80062000", "80062000")]
    [InlineData("80062999", "80062999")]
    [InlineData("80065000", "80065000")]
    [InlineData("80065999", "80065999")]
    [InlineData("80072000", "80072000")]
    [InlineData("80076999", "80076999")]
    [InlineData("80078000", "80078000")]
    [InlineData("80078999", "80078999")]
    [InlineData("80090000", "80090000")]
    [InlineData("80090999", "80090999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string subscriberNumber)
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
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("4000100000", "4000100000")]
    [InlineData("4002599999", "4002599999")]
    [InlineData("4007900000", "4007900000")]
    [InlineData("4007999999", "4007999999")]
    [InlineData("4009900000", "4009900000")]
    [InlineData("4009999999", "4009999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Malta, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("50037000", "50037000")]
    [InlineData("50037999", "50037999")]
    [InlineData("50043000", "50043000")]
    [InlineData("50043999", "50043999")]
    [InlineData("50600000", "50600000")]
    [InlineData("50699999", "50699999")]
    [InlineData("50700000", "50700000")]
    [InlineData("50709999", "50709999")]
    [InlineData("50900000", "50900000")]
    [InlineData("50919999", "50919999")]
    [InlineData("51002000", "51002000")]
    [InlineData("51003000", "51003000")]
    [InlineData("51004000", "51004000")]
    [InlineData("51006000", "51006000")]
    [InlineData("52002199", "52002199")]
    [InlineData("52003099", "52003099")]
    [InlineData("52004099", "52004099")]
    [InlineData("52006099", "52006099")]
    [InlineData("54002000", "54002000")]
    [InlineData("54002199", "54002199")]
    [InlineData("54003000", "54003000")]
    [InlineData("54003099", "54003099")]
    [InlineData("54004000", "54004000")]
    [InlineData("54004099", "54004099")]
    [InlineData("54006000", "54006000")]
    [InlineData("54006099", "54006099")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string subscriberNumber)
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
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
