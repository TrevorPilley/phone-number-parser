using Xunit;

namespace PhoneNumbers.Tests
{
    public class GeographicPhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            var phoneNumber = new GeographicPhoneNumber("+292", "0", "12345", "667788", "N/A");

            Assert.Equal("12345", phoneNumber.AreaCode);
            Assert.Equal("+292", phoneNumber.CallingCode);
            Assert.Equal("N/A", phoneNumber.GeographicArea);
            Assert.Equal("667788", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, phoneNumber.PhoneNumberKind);
            Assert.Equal("0", phoneNumber.TrunkPrefix);
        }
    }
}
