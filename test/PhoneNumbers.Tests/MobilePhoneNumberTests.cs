using Xunit;

namespace PhoneNumbers.Tests
{
    public class MobilePhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var phoneNumber = new MobilePhoneNumber("+292", "0", "7654", "112233", true, true, true);

            Assert.Equal("7654", phoneNumber.AreaCode);
            Assert.Equal("+292", phoneNumber.CallingCode);
            Assert.True(phoneNumber.IsDataOnly);
            Assert.True(phoneNumber.IsPager);
            Assert.True(phoneNumber.IsVirtual);
            Assert.Equal("112233", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.MobilePhoneNumber, phoneNumber.PhoneNumberKind);
            Assert.Equal("0", phoneNumber.TrunkPrefix);
        }
    }
}
