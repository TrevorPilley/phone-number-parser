namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_Asia_Tests
{
    [Fact]
    public void Parse_Value_For_HongKong_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85229616333");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Macau_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85328000000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Singapore_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+6563773800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }
}
