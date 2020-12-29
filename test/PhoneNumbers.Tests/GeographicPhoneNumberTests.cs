using Xunit;

namespace PhoneNumbers.Tests
{
    public class GeographicPhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var countryInfo = CountryInfo.UK;
            var phoneNumber = new GeographicPhoneNumber(countryInfo, "12345", "667788", "N/A");

            Assert.Equal("12345", phoneNumber.AreaCode);
            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.Equal("N/A", phoneNumber.GeographicArea);
            Assert.Equal("667788", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, phoneNumber.PhoneNumberKind);
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
            var phoneNumber1 = new GeographicPhoneNumber(CountryInfo.UK, "12345", "667788", "N/A");
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
        public void Equality_Same_Values_With_AreaCode()
        {
            var phoneNumber1 = new GeographicPhoneNumber(CountryInfo.UK, "12345", "667788", "N/A");
            var phoneNumber2 = new GeographicPhoneNumber(CountryInfo.UK, "12345", "667788", "N/A");

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Equality_Same_Values_Without_AreaCode()
        {
            var phoneNumber1 = new GeographicPhoneNumber(CountryInfo.UK, null, "667788", "N/A");
            var phoneNumber2 = new GeographicPhoneNumber(CountryInfo.UK, null, "667788", "N/A");

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Inequality()
        {
            var phoneNumber1 = new GeographicPhoneNumber(CountryInfo.UK, "12345", "667788", "N/A");
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

            var phoneNumber3 = new GeographicPhoneNumber(CountryInfo.UK, "12345", "667789", "N/A");

            Assert.NotEqual(phoneNumber1, phoneNumber3);
            Assert.False(phoneNumber1.Equals(phoneNumber3));
            Assert.False(phoneNumber1 == phoneNumber3);
            Assert.True(phoneNumber1 != phoneNumber3);

            var phoneNumber4 = new GeographicPhoneNumber(CountryInfo.UK, "12346", "667789", "N/A");

            Assert.NotEqual(phoneNumber1, phoneNumber4);
            Assert.False(phoneNumber1.Equals(phoneNumber4));
            Assert.False(phoneNumber1 == phoneNumber4);
            Assert.True(phoneNumber1 != phoneNumber4);

            var phoneNumber5 = new GeographicPhoneNumber(CountryInfo.UK, "12346", "667789", "N/B");

            Assert.NotEqual(phoneNumber1, phoneNumber5);
            Assert.False(phoneNumber1.Equals(phoneNumber5));
            Assert.False(phoneNumber1 == phoneNumber5);
            Assert.True(phoneNumber1 != phoneNumber5);
        }
    }
}
