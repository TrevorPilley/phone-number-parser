using Xunit;

namespace PhoneNumbers.Tests
{
    public class NonGeographicPhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            CountryInfo countryInfo = CountryInfo.UK;
            var phoneNumber = new NonGeographicPhoneNumber(countryInfo, "7654", "112233");

            Assert.Equal("7654", phoneNumber.AreaCode);
            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.Equal("112233", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        }
    }
}
