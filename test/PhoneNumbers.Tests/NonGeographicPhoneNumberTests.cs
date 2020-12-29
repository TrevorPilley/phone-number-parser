using Xunit;

namespace PhoneNumbers.Tests
{
    public class NonGeographicPhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var countryInfo = CountryInfo.UK;
            var phoneNumber = new NonGeographicPhoneNumber(countryInfo, "7654", "112233");

            Assert.Equal("7654", phoneNumber.AreaCode);
            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.Equal("112233", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        }

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
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UK, "7654", "112233");
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
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UK, "7654", "112233");
            var phoneNumber2 = new NonGeographicPhoneNumber(CountryInfo.UK, "7654", "112233");

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Equality_Same_Values_Without_AreaCode()
        {
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UK, null, "112233");
            var phoneNumber2 = new NonGeographicPhoneNumber(CountryInfo.UK, null, "112233");

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Inequality()
        {
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UK, "7654", "112233");
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

            var phoneNumber3 = new NonGeographicPhoneNumber(CountryInfo.UK, "7654", "112234");

            Assert.NotEqual(phoneNumber1, phoneNumber3);
            Assert.False(phoneNumber1.Equals(phoneNumber3));
            Assert.False(phoneNumber1 == phoneNumber3);
            Assert.True(phoneNumber1 != phoneNumber3);

            var phoneNumber4 = new NonGeographicPhoneNumber(CountryInfo.UK, "7655", "112234");

            Assert.NotEqual(phoneNumber1, phoneNumber4);
            Assert.False(phoneNumber1.Equals(phoneNumber4));
            Assert.False(phoneNumber1 == phoneNumber4);
            Assert.True(phoneNumber1 != phoneNumber4);
        }
    }
}
