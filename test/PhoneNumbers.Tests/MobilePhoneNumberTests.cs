namespace PhoneNumbers.Tests;

public class MobilePhoneNumberTests
{
    [Fact]
    public void Constructor_Sets_Properties_Data()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new MobilePhoneNumber(countryInfo, PhoneNumberHint.Data, "7654112233", "7654", "112233");

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.True(phoneNumber.IsDataOnly);
        Assert.False(phoneNumber.IsPager);
        Assert.False(phoneNumber.IsVirtual);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.PhoneNumberKind);
        Assert.Equal("7654", phoneNumber.NationalDestinationCode);
        Assert.Equal("7654112233", phoneNumber.NationalSignificantNumber);
        Assert.Equal("112233", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_Pager()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new MobilePhoneNumber(countryInfo, PhoneNumberHint.Pager, "7654112233", "7654", "112233");

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsDataOnly);
        Assert.True(phoneNumber.IsPager);
        Assert.False(phoneNumber.IsVirtual);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.PhoneNumberKind);
        Assert.Equal("7654", phoneNumber.NationalDestinationCode);
        Assert.Equal("112233", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_Virtual()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new MobilePhoneNumber(countryInfo, PhoneNumberHint.Virtual, "7654112233", "7654", "112233");

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsDataOnly);
        Assert.False(phoneNumber.IsPager);
        Assert.True(phoneNumber.IsVirtual);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.PhoneNumberKind);
        Assert.Equal("7654", phoneNumber.NationalDestinationCode);
        Assert.Equal("112233", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Throws_If_CountryInfo_Null() =>
        Assert.Throws<ArgumentNullException>(
            () => new MobilePhoneNumber(null, PhoneNumberHint.None, "7654112233", "7654", "112233"));

    [Fact]
    public void Constructor_Throws_If_NationalSignificantNumber_Empty() =>
        Assert.Throws<ArgumentException>(
            () => new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "", "7654", "112233"));

    [Fact]
    public void Constructor_Throws_If_NationalSignificantNumber_Null() =>
        Assert.Throws<ArgumentException>(
            () => new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, null, "7654", "112233"));

    [Fact]
    public void Constructor_Throws_If_NationalSignificantNumber_Whitespace() =>
        Assert.Throws<ArgumentException>(
            () => new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, " ", "7654", "112233"));

    [Fact]
    public void Constructor_Throws_If_SubscriberNumber_Empty() =>
        Assert.Throws<ArgumentException>(
            () => new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654", "7654", ""));

    [Fact]
    public void Constructor_Throws_If_SubscriberNumber_Null() =>
        Assert.Throws<ArgumentException>(
            () => new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654", "7654", null));

    [Fact]
    public void Constructor_Throws_If_SubscriberNumber_Whitespace() =>
        Assert.Throws<ArgumentException>(
            () => new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654", "7654", " "));

    [Fact]
    public void Equality_Both_Null()
    {
        var phoneNumber1 = default(MobilePhoneNumber);
        var phoneNumber2 = default(MobilePhoneNumber);

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.True(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
        Assert.False(phoneNumber1 != (object)phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Instance()
    {
        var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654112233", "7654", "112233");
        var phoneNumber2 = phoneNumber1;

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.True(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
        Assert.False(phoneNumber1 != (object)phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Values_With_NationalDestinationCode()
    {
        var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654112233", "7654", "112233");
        var phoneNumber2 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654112233", "7654", "112233");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Values_Without_NationalDestinationCode()
    {
        var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "112233", null, "112233");
        var phoneNumber2 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "112233", null, "112233");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Inequality()
    {
        var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654112233", "7654", "112233");
        var phoneNumber2 = default(MobilePhoneNumber);

        Assert.NotEqual(phoneNumber1, phoneNumber2);
        Assert.NotEqual(phoneNumber2, phoneNumber1);
        Assert.False(phoneNumber1.Equals(phoneNumber2));
        Assert.False(phoneNumber1.Equals((object)phoneNumber2));
        Assert.False(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber2 == phoneNumber1);
        Assert.False(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber2 == (object)phoneNumber1);
        Assert.True(phoneNumber1 != phoneNumber2);
        Assert.True(phoneNumber2 != phoneNumber1);
        Assert.True(phoneNumber1 != (object)phoneNumber2);
        Assert.True(phoneNumber2 != (object)phoneNumber1);

        // Change area code
        var phoneNumber3 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7655112233", "7655", "112233");

        Assert.NotEqual(phoneNumber1, phoneNumber3);
        Assert.False(phoneNumber1.Equals(phoneNumber3));
        Assert.False(phoneNumber1 == phoneNumber3);
        Assert.True(phoneNumber1 != phoneNumber3);

        // change local number
        var phoneNumber4 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "7654112234", "7654", "112234");

        Assert.NotEqual(phoneNumber1, phoneNumber4);
        Assert.False(phoneNumber1.Equals(phoneNumber4));
        Assert.False(phoneNumber1 == phoneNumber4);
        Assert.True(phoneNumber1 != phoneNumber4);

        // change hint
        var phoneNumber5 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.Data, "7654112233", "7654", "112233");

        Assert.NotEqual(phoneNumber1, phoneNumber5);
        Assert.False(phoneNumber1.Equals(phoneNumber5));
        Assert.False(phoneNumber1 == phoneNumber5);
        Assert.True(phoneNumber1 != phoneNumber5);
    }
}
