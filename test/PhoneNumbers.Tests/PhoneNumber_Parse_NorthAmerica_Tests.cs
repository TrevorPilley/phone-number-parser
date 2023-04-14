namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_NorthAmerica_Tests
{
    [Fact]
    public void Parse_Value_For_Canada_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+16137020016");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Canada, phoneNumber.Country);
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
