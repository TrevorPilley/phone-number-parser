using System;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class MobilePhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var countryInfo = CountryInfo.UnitedKingdom;
            var phoneNumber = new MobilePhoneNumber(countryInfo, "7654", "112233", true, true, true);

            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.True(phoneNumber.IsDataOnly);
            Assert.True(phoneNumber.IsPager);
            Assert.True(phoneNumber.IsVirtual);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.PhoneNumberKind);
            Assert.Equal("7654", phoneNumber.NationalDiallingCode);
            Assert.Equal("112233", phoneNumber.SubscriberNumber);
        }

        [Fact]
        public void Constructor_Throws_If_CountryInfo_Null() =>
            Assert.Throws<ArgumentNullException>(() => new MobilePhoneNumber(null, "12345", "667788", true, true, true));

        [Fact]
        public void Constructor_Throws_If_SubscriberNumber_Empty() =>
            Assert.Throws<ArgumentException>(() => new MobilePhoneNumber(CountryInfo.UnitedKingdom, "12345", "", true, true, true));

        [Fact]
        public void Constructor_Throws_If_SubscriberNumber_Null() =>
            Assert.Throws<ArgumentException>(() => new MobilePhoneNumber(CountryInfo.UnitedKingdom, "12345", null, true, true, true));

        [Fact]
        public void Constructor_Throws_If_SubscriberNumber_Whitespace() =>
            Assert.Throws<ArgumentException>(() => new MobilePhoneNumber(CountryInfo.UnitedKingdom, "12345", " ", true, true, true));

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
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true, true, true);
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
        public void Equality_Same_Values_With_NationalDiallingCode()
        {
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true, true, true);
            var phoneNumber2 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true, true, true);

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Equality_Same_Values_Without_NationalDiallingCode()
        {
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, null, "112233", true, true, true);
            var phoneNumber2 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, null, "112233", true, true, true);

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Inequality()
        {
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true, true, true);
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
            var phoneNumber3 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7655", "112233", true, true, true);

            Assert.NotEqual(phoneNumber1, phoneNumber3);
            Assert.False(phoneNumber1.Equals(phoneNumber3));
            Assert.False(phoneNumber1 == phoneNumber3);
            Assert.True(phoneNumber1 != phoneNumber3);

            // change local number
            var phoneNumber4 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112234", true, true, true);

            Assert.NotEqual(phoneNumber1, phoneNumber4);
            Assert.False(phoneNumber1.Equals(phoneNumber4));
            Assert.False(phoneNumber1 == phoneNumber4);
            Assert.True(phoneNumber1 != phoneNumber4);

            // change is data only
            var phoneNumber5 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", false, true, true);

            Assert.NotEqual(phoneNumber1, phoneNumber5);
            Assert.False(phoneNumber1.Equals(phoneNumber5));
            Assert.False(phoneNumber1 == phoneNumber5);
            Assert.True(phoneNumber1 != phoneNumber5);

            // change is pager
            var phoneNumber6 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true, false, true);

            Assert.NotEqual(phoneNumber1, phoneNumber6);
            Assert.False(phoneNumber1.Equals(phoneNumber6));
            Assert.False(phoneNumber1 == phoneNumber6);
            Assert.True(phoneNumber1 != phoneNumber6);

            // change is virtual
            var phoneNumber7 = new MobilePhoneNumber(CountryInfo.UnitedKingdom, "7654", "112233", true, true, false);

            Assert.NotEqual(phoneNumber1, phoneNumber7);
            Assert.False(phoneNumber1.Equals(phoneNumber7));
            Assert.False(phoneNumber1 == phoneNumber7);
            Assert.True(phoneNumber1 != phoneNumber7);
        }
    }
}
