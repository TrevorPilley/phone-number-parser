namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_SouthAmerica_Tests
{
    [Fact]
    public void Parse_Value_For_Brazil_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+556123122026");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Brazil, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Colombia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+576013198300");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Colombia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_FalklandIslands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+50028459");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.FalklandIslands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_FrenchGuiana_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+594594299700");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.FrenchGuiana, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Peru_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+5113324079");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Peru, phoneNumber.Country);
    }
}
