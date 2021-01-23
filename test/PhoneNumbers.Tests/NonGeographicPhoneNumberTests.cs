using System;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class NonGeographicPhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var countryInfo = CountryInfo.UnitedKingdom;
            var phoneNumber = new NonGeographicPhoneNumber(countryInfo, "7654", "112233", true);

            Assert.Equal("7654", phoneNumber.AreaCode);
            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.True(phoneNumber.IsFreephone);
            Assert.Equal("112233", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        }

        [Fact]
        public void Constructor_Throws_If_CountryInfo_Null() =>
            Assert.Throws<ArgumentNullException>(() => new NonGeographicPhoneNumber(null, "12345", "667788", true));

        [Fact]
        public void Constructor_Throws_If_LocalNumber_Empty() =>
            Assert.Throws<ArgumentException>(() => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "12345", "", true));

        [Fact]
        public void Constructor_Throws_If_LocalNumber_Null() =>
            Assert.Throws<ArgumentException>(() => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "12345", null, true));

        [Fact]
        public void Constructor_Throws_If_LocalNumber_Whitespace() =>
            Assert.Throws<ArgumentException>(() => new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "12345", " ", true));

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
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true);
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
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true);
            var phoneNumber2 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true);

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Equality_Same_Values_Without_AreaCode()
        {
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, null, "112233", true);
            var phoneNumber2 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, null, "112233", true);

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Inequality()
        {
            var phoneNumber1 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true);
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
            var phoneNumber3 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7655", "112233", true);

            Assert.NotEqual(phoneNumber1, phoneNumber3);
            Assert.False(phoneNumber1.Equals(phoneNumber3));
            Assert.False(phoneNumber1 == phoneNumber3);
            Assert.True(phoneNumber1 != phoneNumber3);

            // change local number
            var phoneNumber4 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7654", "112234", true);

            Assert.NotEqual(phoneNumber1, phoneNumber4);
            Assert.False(phoneNumber1.Equals(phoneNumber4));
            Assert.False(phoneNumber1 == phoneNumber4);
            Assert.True(phoneNumber1 != phoneNumber4);

            // change is freephone
            var phoneNumber5 = new NonGeographicPhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", false);

            Assert.NotEqual(phoneNumber1, phoneNumber5);
            Assert.False(phoneNumber1.Equals(phoneNumber5));
            Assert.False(phoneNumber1 == phoneNumber5);
            Assert.True(phoneNumber1 != phoneNumber5);
        }
    }
}
