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
    }
}
