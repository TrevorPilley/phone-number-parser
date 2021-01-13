using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for IT PhoneNumbers.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IT_NonGeographicPhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.IT);

        [Theory]
        [InlineData("840000000", "840", "000000")]
        [InlineData("840999999", "840", "999999")]
        [InlineData("841000", "841", "000")]
        [InlineData("841999", "841", "999")]
        [InlineData("847000", "847", "000")]
        [InlineData("847999", "847", "999")]
        [InlineData("848000000", "848", "000000")]
        [InlineData("848999999", "848", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_8XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IT, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("800000000", "800", "000000")]
        [InlineData("800999999", "800", "999999")]
        [InlineData("803000", "803", "000")]
        [InlineData("803999", "803", "999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IT, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}
