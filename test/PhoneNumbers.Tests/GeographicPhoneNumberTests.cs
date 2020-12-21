using Xunit;

namespace PhoneNumbers.Tests
{
    public class GeographicPhoneNumberTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            CountryInfo countryInfo = CountryInfo.UK;
            var phoneNumber = new GeographicPhoneNumber(countryInfo, "12345", "667788", "N/A");

            Assert.Equal("12345", phoneNumber.AreaCode);
            Assert.Equal(countryInfo, phoneNumber.Country);
            Assert.Equal("N/A", phoneNumber.GeographicArea);
            Assert.Equal("667788", phoneNumber.LocalNumber);
            Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, phoneNumber.PhoneNumberKind);
        }
    }
}
