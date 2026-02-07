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
    public void Parse_Value_For_Jordan_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+96265501120");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jordan, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Kazakhstan_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+77172613325");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kazakhstan, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Macau_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85328000000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Oman_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+96824222163");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Oman, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Qatar_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+97444994081");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Qatar, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_SaudiArabia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+966114618281");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SaudiArabia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Singapore_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+6563773800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Turkey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+903122947200");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Turkey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_UnitedArabEmirates_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+97126212222");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedArabEmirates, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Yemen_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+967777002345");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Yemen, phoneNumber.Country);
    }
}
