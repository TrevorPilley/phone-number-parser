using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    public partial class UKPhoneNumberParserTests
    {
        [Theory]
        [InlineData("03007999999", "300", "7999999")]
        [InlineData("03027999999", "302", "7999999")]
        [InlineData("03037999999", "303", "7999999")]
        [InlineData("03067999999", "306", "7999999")]
        [InlineData("03307999999", "330", "7999999")]
        [InlineData("03317999999", "331", "7999999")]
        [InlineData("03327999999", "332", "7999999")]
        [InlineData("03337999999", "333", "7999999")]
        [InlineData("03437999999", "343", "7999999")]
        [InlineData("03447999999", "344", "7999999")]
        [InlineData("03457999999", "345", "7999999")]
        [InlineData("03707999999", "370", "7999999")]
        [InlineData("03717999999", "371", "7999999")]
        [InlineData("03727999999", "372", "7999999")]
        [InlineData("08439999999", "843", "9999999")]
        [InlineData("08449999999", "844", "9999999")]
        [InlineData("08459999999", "845", "9999999")]
        [InlineData("08709999999", "870", "9999999")]
        [InlineData("08719999999", "871", "9999999")]
        [InlineData("08729999999", "872", "9999999")]
        [InlineData("08999999999", "899", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0800999999", "800", "999999")]
        [InlineData("08089999999", "808", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_FreePhone(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}
