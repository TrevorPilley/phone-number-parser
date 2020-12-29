using Xunit;

namespace PhoneNumbers.Tests
{
    public class MobilePhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var countryInfo = CountryInfo.UK;
            var phoneNumber = new MobilePhoneNumber(countryInfo, "7654", "112233", true, true, true);

            Assert.Equal("7654", phoneNumber.AreaCode);
            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.True(phoneNumber.IsDataOnly);
            Assert.True(phoneNumber.IsPager);
            Assert.True(phoneNumber.IsVirtual);
            Assert.Equal("112233", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.PhoneNumberKind);
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
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UK, "7654", "112233", true, true, true);
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
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UK, "7654", "112233", true, true, true);
            var phoneNumber2 = new MobilePhoneNumber(CountryInfo.UK, "7654", "112233", true, true, true);

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Equality_Same_Values_Without_AreaCode()
        {
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UK, null, "112233", true, true, true);
            var phoneNumber2 = new MobilePhoneNumber(CountryInfo.UK, null, "112233", true, true, true);

            Assert.Equal(phoneNumber1, phoneNumber2);
            Assert.True(phoneNumber1.Equals(phoneNumber2));
            Assert.True(phoneNumber1.Equals((object)phoneNumber2));
            Assert.True(phoneNumber1 == phoneNumber2);
            Assert.False(phoneNumber1 != phoneNumber2);
        }

        [Fact]
        public void Inequality()
        {
            var phoneNumber1 = new MobilePhoneNumber(CountryInfo.UK, "7654", "112233", true, true, true);
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

            var phoneNumber3 = new MobilePhoneNumber(CountryInfo.UK, "7654", "112234", true, true, true);

            Assert.NotEqual(phoneNumber1, phoneNumber3);
            Assert.False(phoneNumber1.Equals(phoneNumber3));
            Assert.False(phoneNumber1 == phoneNumber3);
            Assert.True(phoneNumber1 != phoneNumber3);

            var phoneNumber4 = new MobilePhoneNumber(CountryInfo.UK, "7655", "112234", true, true, true);

            Assert.NotEqual(phoneNumber1, phoneNumber4);
            Assert.False(phoneNumber1.Equals(phoneNumber4));
            Assert.False(phoneNumber1 == phoneNumber4);
            Assert.True(phoneNumber1 != phoneNumber4);

            var phoneNumber5 = new MobilePhoneNumber(CountryInfo.UK, "7655", "112234", false, true, true);

            Assert.NotEqual(phoneNumber1, phoneNumber5);
            Assert.False(phoneNumber1.Equals(phoneNumber5));
            Assert.False(phoneNumber1 == phoneNumber5);
            Assert.True(phoneNumber1 != phoneNumber5);

            var phoneNumber6 = new MobilePhoneNumber(CountryInfo.UK, "7655", "112234", true, false, true);

            Assert.NotEqual(phoneNumber1, phoneNumber6);
            Assert.False(phoneNumber1.Equals(phoneNumber6));
            Assert.False(phoneNumber1 == phoneNumber6);
            Assert.True(phoneNumber1 != phoneNumber6);

            var phoneNumber7 = new MobilePhoneNumber(CountryInfo.UK, "7655", "112234", true, true, false);

            Assert.NotEqual(phoneNumber1, phoneNumber7);
            Assert.False(phoneNumber1.Equals(phoneNumber7));
            Assert.False(phoneNumber1 == phoneNumber7);
            Assert.True(phoneNumber1 != phoneNumber7);
        }
    }
}
