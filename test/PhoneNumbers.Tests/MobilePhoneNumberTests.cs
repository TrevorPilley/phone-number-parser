namespace PhoneNumbers.Tests;

public class MobilePhoneNumberTests
{
    [Fact]
    public void Constructor_Sets_Properties_Pager()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new MobilePhoneNumber(PhoneNumberHint.Pager)
        {
            Country = countryInfo,
            NationalDestinationCode = "7654",
            NationalSignificantNumber = "7654112233",
            SubscriberNumber = "112233",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.True(phoneNumber.IsPager);
        Assert.False(phoneNumber.IsVirtual);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.Kind);
        Assert.Equal("7654", phoneNumber.NationalDestinationCode);
        Assert.Equal("112233", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_Virtual()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new MobilePhoneNumber(PhoneNumberHint.Virtual)
        {
            Country = countryInfo,
            NationalDestinationCode = "7654",
            NationalSignificantNumber = "7654112233",
            SubscriberNumber = "112233",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsPager);
        Assert.True(phoneNumber.IsVirtual);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.Kind);
        Assert.Equal("7654", phoneNumber.NationalDestinationCode);
        Assert.Equal("112233", phoneNumber.SubscriberNumber);
    }

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
        var phoneNumber1 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");
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
        var phoneNumber1 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        var phoneNumber2 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Values_Without_NationalDestinationCode()
    {
        var phoneNumber1 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: default,
            sn: "667788");

        var phoneNumber2 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: default,
            sn: "667788");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Inequality()
    {
        var phoneNumber1 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

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

        // Change national destination code
        var phoneNumber3 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: "12346",
            sn: "667788");

        Assert.NotEqual(phoneNumber1, phoneNumber3);
        Assert.False(phoneNumber1.Equals(phoneNumber3));
        Assert.False(phoneNumber1 == phoneNumber3);
        Assert.True(phoneNumber1 != phoneNumber3);

        // change subscriber number
        var phoneNumber4 = TestHelper.CreateMobilePhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667789");

        Assert.NotEqual(phoneNumber1, phoneNumber4);
        Assert.False(phoneNumber1.Equals(phoneNumber4));
        Assert.False(phoneNumber1 == phoneNumber4);
        Assert.True(phoneNumber1 != phoneNumber4);

        // change country
        var phoneNumber5 = new MobilePhoneNumber(PhoneNumberHint.None)
        {
            Country = CountryInfo.France,
            NationalDestinationCode = phoneNumber1.NationalDestinationCode,
            NationalSignificantNumber = phoneNumber1.NationalSignificantNumber,
            SubscriberNumber = phoneNumber1.SubscriberNumber,
        };

        Assert.NotEqual(phoneNumber1, phoneNumber5);
        Assert.False(phoneNumber1.Equals(phoneNumber5));
        Assert.False(phoneNumber1 == phoneNumber5);
        Assert.True(phoneNumber1 != phoneNumber5);
    }
}
