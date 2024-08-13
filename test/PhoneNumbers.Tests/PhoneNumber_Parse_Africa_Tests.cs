namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_Africa_Tests
{
    [Fact]
    public void Parse_Value_For_Egypt_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+20235344239");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Egypt, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Kenya_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+25420424200");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kenya, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Nigeria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+2342094617000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Nigeria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_SouthAfrica_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+27215616800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SouthAfrica, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Tanzania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+255222199760");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Tanzania, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Turkey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+903122947200");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Turkey, phoneNumber.Country);
    }
}
