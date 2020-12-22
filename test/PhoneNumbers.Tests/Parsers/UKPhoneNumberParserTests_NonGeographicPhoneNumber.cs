using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    public partial class UKPhoneNumberParserTests
    {
        [Theory]
        [InlineData("03001212123", "300", "1212123")]
        [InlineData("03021212123", "302", "1212123")]
        [InlineData("03031212123", "303", "1212123")]
        [InlineData("03061212123", "306", "1212123")]
        [InlineData("03301212123", "330", "1212123")]
        [InlineData("03311212123", "331", "1212123")]
        [InlineData("03321212123", "332", "1212123")]
        [InlineData("03331212123", "333", "1212123")]
        [InlineData("03431212123", "343", "1212123")]
        [InlineData("03441212123", "344", "1212123")]
        [InlineData("03451212123", "345", "1212123")]
        [InlineData("03701212123", "370", "1212123")]
        [InlineData("03711212123", "371", "1212123")]
        [InlineData("03721212123", "372", "1212123")]
        [InlineData("08001212123", "800", "1212123")]
        [InlineData("08081212123", "808", "1212123")]
        [InlineData("08431212123", "843", "1212123")]
        [InlineData("08441212123", "844", "1212123")]
        [InlineData("08451212123", "845", "1212123")]
        [InlineData("08701212123", "870", "1212123")]
        [InlineData("08711212123", "871", "1212123")]
        [InlineData("08721212123", "872", "1212123")]
        [InlineData("08991212123", "899", "1212123")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string areaCode, string localNumber)
        {
            var parser = new UKPhoneNumberParser();
            PhoneNumber phoneNumber = parser.Parse(value, CountryInfo.UK);

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, nonGeographicPhoneNumber.Country);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}
