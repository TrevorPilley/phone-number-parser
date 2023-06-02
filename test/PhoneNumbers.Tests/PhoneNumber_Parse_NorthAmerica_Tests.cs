namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_NorthAmerica_Tests
{
    [Fact]
    public void Parse_Value_For_Anguilla_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+12644972442");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Anguilla, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_AntiguaAndBarbuda_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+12684804405");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.AntiguaAndBarbuda, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Bahamas_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+12423930234");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bahamas, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Barbados_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+12465352573");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Barbados, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Bermuda_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+14414056000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bermuda, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_BritishVirginIslands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+12844946786");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.BritishVirginIslands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Canada_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+16137020016");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Canada, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_CaymanIslands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+13459464282");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CaymanIslands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Dominica_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+17677011252");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Dominica, phoneNumber.Country);
    }


    [Fact]
    public void Parse_Value_For_PuertoRico_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+17877222977");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.PuertoRico, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_UnitedStatesVirginIslands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+13407731404");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedStatesVirginIslands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_UnitedStates_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+12124841200");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedStates, phoneNumber.Country);
    }
}
