namespace PhoneNumbers.Tests;

public class GeographicPhoneNumberTests
{
    [Fact]
    public void Constructor_Sets_Properties_NationalDiallingOnly()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new GeographicPhoneNumber(PhoneNumberHint.NationalDiallingOnly)
        {
            Country = countryInfo,
            GeographicArea = "N/A",
            NationalDestinationCode = "12345",
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.Equal("N/A", phoneNumber.GeographicArea);
        Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, phoneNumber.Kind);
        Assert.True(phoneNumber.HasNationalDestinationCode);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.True(phoneNumber.NationalDiallingOnly);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_With_NationalDestinationCode()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new GeographicPhoneNumber(PhoneNumberHint.None)
        {
            Country = countryInfo,
            GeographicArea = "N/A",
            NationalDestinationCode = "12345",
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.Equal("N/A", phoneNumber.GeographicArea);
        Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, phoneNumber.Kind);
        Assert.True(phoneNumber.HasNationalDestinationCode);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.False(phoneNumber.NationalDiallingOnly);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_Without_NationalDestinationCode()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new GeographicPhoneNumber(PhoneNumberHint.None)
        {
            Country = countryInfo,
            GeographicArea = "N/A",
            NationalDestinationCode = null,
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.Equal("N/A", phoneNumber.GeographicArea);
        Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, phoneNumber.Kind);
        Assert.False(phoneNumber.HasNationalDestinationCode);
        Assert.Null(phoneNumber.NationalDestinationCode);
        Assert.False(phoneNumber.NationalDiallingOnly);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Equality_Both_Null()
    {
        var phoneNumber1 = default(GeographicPhoneNumber);
        var phoneNumber2 = default(GeographicPhoneNumber);

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.True(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
        Assert.False(phoneNumber1 != (object)phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Instance()
    {
        var phoneNumber1 = TestHelper.CreateGeographicPhoneNumber(
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
        var phoneNumber1 = TestHelper.CreateGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        var phoneNumber2 = TestHelper.CreateGeographicPhoneNumber(
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
        var phoneNumber1 = TestHelper.CreateGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: default,
            sn: "667788");

        var phoneNumber2 = TestHelper.CreateGeographicPhoneNumber(
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
        var phoneNumber1 = TestHelper.CreateGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        var phoneNumber2 = default(GeographicPhoneNumber);

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
        var phoneNumber3 = TestHelper.CreateGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12346",
            sn: "667788");

        Assert.NotEqual(phoneNumber1, phoneNumber3);
        Assert.False(phoneNumber1.Equals(phoneNumber3));
        Assert.False(phoneNumber1 == phoneNumber3);
        Assert.True(phoneNumber1 != phoneNumber3);

        // change subscriber number
        var phoneNumber4 = TestHelper.CreateGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667789");

        Assert.NotEqual(phoneNumber1, phoneNumber4);
        Assert.False(phoneNumber1.Equals(phoneNumber4));
        Assert.False(phoneNumber1 == phoneNumber4);
        Assert.True(phoneNumber1 != phoneNumber4);

        // change country
        var phoneNumber5 = new GeographicPhoneNumber(PhoneNumberHint.None)
        {
            Country = CountryInfo.France,
            GeographicArea = phoneNumber1.GeographicArea,
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
