using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for FR phone numbers.
    /// </summary>
    public class DefaultPhoneNumberParserTests_FR
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.FR);

        [Theory]
        [InlineData("0100000000", "100000000", "Île-de-France")]
        [InlineData("0199999999", "199999999", "Île-de-France")]
        [InlineData("0200000000", "200000000", "Northwest France")]
        [InlineData("0299999999", "299999999", "Northwest France")]
        [InlineData("0300000000", "300000000", "Northeast France")]
        [InlineData("0399999999", "399999999", "Northeast France")]
        [InlineData("0400000000", "400000000", "Southeast France")]
        [InlineData("0499999999", "499999999", "Southeast France")]
        [InlineData("0500000000", "500000000", "Southwest France")]
        [InlineData("0599999999", "599999999", "Southwest France")]
        public void Parse_Known_GeographicPhoneNumber(string value, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Null(geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0600000000")]
        [InlineData("0799999999")]
        public void Parse_Known_MobilePhoneNumber(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(value, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0810000000")]
        [InlineData("0899999999")]
        [InlineData("0900000000")]
        [InlineData("0999999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(value, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0800000000")]
        [InlineData("0800999999")]
        public void Parse_Known_NonGeographicPhoneNumber_FreePhone(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(value, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}
