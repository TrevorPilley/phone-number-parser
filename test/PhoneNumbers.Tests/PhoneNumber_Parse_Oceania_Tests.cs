namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_Oceania_Tests
{
    [Fact]
    public void Parse_Value_For_AmericanSamoa_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+16846339805");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.AmericanSamoa, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Australia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+61399636800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Australia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Guam_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+16716323365");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guam, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_PapuaNewGuinea_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+6753033201");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.PapuaNewGuinea, phoneNumber.Country);
    }
}
