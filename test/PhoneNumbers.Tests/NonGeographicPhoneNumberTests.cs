namespace PhoneNumbers.Tests;

public class NonGeographicPhoneNumberTests
{
    [Fact]
    public void Constructor_Sets_Properties_Freephone()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(countryInfo, PhoneNumberHint.Freephone, "12345667788", "12345", "667788");

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.True(phoneNumber.IsFreephone);
        Assert.False(phoneNumber.IsPremiumRate);
        Assert.False(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_PremiumRate()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(countryInfo, PhoneNumberHint.PremiumRate, "12345667788", "12345", "667788");

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsFreephone);
        Assert.True(phoneNumber.IsPremiumRate);
        Assert.False(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_SharedCost()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(countryInfo, PhoneNumberHint.SharedCost, "12345667788", "12345", "667788");

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsFreephone);
        Assert.False(phoneNumber.IsPremiumRate);
        Assert.True(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Throws_If_CountryInfo_Null() =>
        Assert.Throws<ArgumentNullException>(
            () => new NonGeographicPhoneNumber(null, PhoneNumberHint.None, "12345667788", "12345", "667788"));

    [Fact]
    public void Constructor_Throws_If_NationalSignificantNumber_Empty() =>
        Assert.Throws<ArgumentException>(
            () => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "", "12345", "667788"));

    [Fact]
    public void Constructor_Throws_If_NationalSignificantNumber_Null() =>
        Assert.Throws<ArgumentException>(
            () => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, null, "12345", "667788"));

    [Fact]
    public void Constructor_Throws_If_NationalSignificantNumber_Whitespace() =>
        Assert.Throws<ArgumentException>(
            () => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, " ", "12345", "667788"));

    [Fact]
    public void Constructor_Throws_If_SubscriberNumber_Empty() =>
        Assert.Throws<ArgumentException>(
            () => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345", "12345", ""));

    [Fact]
    public void Constructor_Throws_If_SubscriberNumber_Null() =>
        Assert.Throws<ArgumentException>(
            () => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345", "12345", null));

    [Fact]
    public void Constructor_Throws_If_SubscriberNumber_Whitespace() =>
        Assert.Throws<ArgumentException>(
            () => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345", "12345", " "));

    [Fact]
    public void Equality_Both_Null()
    {
        var phoneNumber1 = default(NonGeographicPhoneNumber);
        var phoneNumber2 = default(NonGeographicPhoneNumber);

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.True(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
        Assert.False(phoneNumber1 != (object)phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Instance()
    {
        var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345667788", "12345", "112233");
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
        var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345667788", "12345", "112233");
        var phoneNumber2 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345667788", "12345", "112233");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Values_Without_NationalDestinationCode()
    {
        var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "667788", null, "112233");
        var phoneNumber2 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "667788", null, "112233");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Inequality()
    {
        var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345667788", "12345", "667788");
        var phoneNumber2 = default(NonGeographicPhoneNumber);

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
        var phoneNumber3 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12346667788", "12346", "667788");

        Assert.NotEqual(phoneNumber1, phoneNumber3);
        Assert.False(phoneNumber1.Equals(phoneNumber3));
        Assert.False(phoneNumber1 == phoneNumber3);
        Assert.True(phoneNumber1 != phoneNumber3);

        // change local number
        var phoneNumber4 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.None, "12345667789", "12345", "667789");

        Assert.NotEqual(phoneNumber1, phoneNumber4);
        Assert.False(phoneNumber1.Equals(phoneNumber4));
        Assert.False(phoneNumber1 == phoneNumber4);
        Assert.True(phoneNumber1 != phoneNumber4);

        // change hint
        var phoneNumber5 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, PhoneNumberHint.Freephone, "12345667788", "12345", "667788");

        Assert.NotEqual(phoneNumber1, phoneNumber5);
        Assert.False(phoneNumber1.Equals(phoneNumber5));
        Assert.False(phoneNumber1 == phoneNumber5);
        Assert.True(phoneNumber1 != phoneNumber5);
    }
}
