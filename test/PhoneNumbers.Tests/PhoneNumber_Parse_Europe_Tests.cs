namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_Europe_Tests
{
    [Fact]
    public void Parse_Value_For_Albania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35542259571");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Albania, phoneNumber.Country);
    }
    
    [Fact]
    public void Parse_Value_For_Andorra_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+376301115");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Andorra, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Austria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+431580580");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Belarus_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+375172171185");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Belgium_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3250444646");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_BosniaAndHerzegovina_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38733250600");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.BosniaAndHerzegovina, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Bulgaria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35929492760");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Croatia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38517007007");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Cyprus_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35722693000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Cyprus, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_CzechRepublic_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+420224004111");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Denmark_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4533926700");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Denmark, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Estonia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3726672072");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_FaroeIslands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+298356020");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.FaroeIslands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Finland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+358295390361");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Finland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_France_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+33140477283");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Germany_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+49228141177");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Gibraltar_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35020074636");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Greece_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+302106151000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Guernsey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441481717000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Hungary_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3614680666");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Iceland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3545101500");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Iceland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Ireland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35318049600");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_IsleOfMan_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441624696300");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Theory]
    [InlineData("+393492525255")]
    [InlineData("+390549082555")] // San Marino country code and the Italian area code fixed line starting 0
    [InlineData("+390549882555")] // San Marino country code and the Italian area code fixed line starting 8
    [InlineData("+390549892555")] // San Marino country code and the Italian area code fixed line starting 9
    public void Parse_Value_For_Italy_CallingCode(string value)
    {
        var phoneNumber = PhoneNumber.Parse(value);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Jersey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441534716800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Kosovo_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38338212345");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kosovo, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Latvia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37167028398");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Latvia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Liechtenstein_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4232366488");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Liechtenstein, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Lithuania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37052105664");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Lithuania, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Luxembourg_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35228228228");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Luxembourg, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Malta_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35621336840");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Malta, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Moldova_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37322251317");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Moldova, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Monaco_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37798988800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Montenegro_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38220406700");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Montenegro, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Netherlands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+31702140214");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_NorthMacedonia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38923289200");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.NorthMacedonia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Norway_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4722824600");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Norway, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Poland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+48222455856");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Portugal_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+351217211000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Romania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+40372845414");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Theory]
    [InlineData("+378882555")] // San Marino international
    [InlineData("+3780549882555")] // San Marino country code and the Italian area code
    public void Parse_Value_For_SanMarino_CallingCode(string value)
    {
        var phoneNumber = PhoneNumber.Parse(value);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Serbia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+381112026828");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Serbia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Slovakia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+421257881101");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Slovenia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38615836300");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovenia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Spain_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+34912582852");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Sweden_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4686785500");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Switzerland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+41584605511");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Ukraine_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+380442819196");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_UnitedKingdom_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+442079813000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }
}
