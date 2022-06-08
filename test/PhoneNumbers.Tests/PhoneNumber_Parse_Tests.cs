namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_Tests
{
    [Fact]
    public void Parse_Value_With_Austria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+43171100");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Belarus_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+375172171185");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Belgium_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3250444646");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Bulgaria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35929492760");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Croatia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38517007007");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_CzechRepublic_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+420224004111");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Estonia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3726672072");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_France_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+33140477283");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Germany_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+49228141177");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Gibraltar_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35020074636");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Greece_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+302106151000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Guernsey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441481717000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_HongKong_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85229616333");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Hungary_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3614680666");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Ireland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35318049600");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_IsleOfMan_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441624696300");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Italy_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+393492525255");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Jersey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441534716800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Macau_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85328000000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Monaco_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37798988800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Netherlands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+31702140214");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Poland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+48222455856");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Portugal_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+351217211000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Romania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+40372845414");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_SanMarino_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3780549882555");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Singapore_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+6563773800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Slovakia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+421257881101");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Spain_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+34912582852");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Sweden_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4686785500");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Switzerland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+41584605511");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_Ukraine_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+380442819196");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_With_UnitedKingdom_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+442079813000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }
}
