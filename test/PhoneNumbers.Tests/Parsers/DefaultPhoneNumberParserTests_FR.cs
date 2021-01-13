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
        [InlineData("0110000000", "110000000", "Île-de-France")]
        [InlineData("0199999999", "199999999", "Île-de-France")]
        [InlineData("0210000000", "210000000", "Nord-Ouest")]
        [InlineData("0261999999", "261999999", "Nord-Ouest")]
        [InlineData("0264000000", "264000000", "Nord-Ouest")]
        [InlineData("0268999999", "268999999", "Nord-Ouest")]
        [InlineData("0270000000", "270000000", "Nord-Ouest")]
        [InlineData("0299999999", "299999999", "Nord-Ouest")]
        [InlineData("0310000000", "310000000", "Nord-Est")]
        [InlineData("0399999999", "399999999", "Nord-Est")]
        [InlineData("0410000000", "410000000", "Sud-Est")]
        [InlineData("0499999999", "499999999", "Sud-Est")]
        [InlineData("0516000000", "516000000", "Sud-Ouest")]
        [InlineData("0589999999", "589999999", "Sud-Ouest")]
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
        [InlineData("0601000000", "601000000")]
        [InlineData("0638999999", "638999999")]
        [InlineData("0640000000", "640000000")]
        [InlineData("0652999999", "652999999")]
        [InlineData("0656000000", "656000000")]
        [InlineData("0689999999", "689999999")]
        [InlineData("0695000000", "695000000")]
        [InlineData("0695999999", "695999999")]
        [InlineData("0700000000", "700000000")]
        [InlineData("0700499999", "700499999")]
        [InlineData("0730000000", "730000000")]
        [InlineData("0789999999", "789999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string localNumber)
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
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0806000000", "806000000")]
        [InlineData("0899999999", "899999999")]
        [InlineData("0950000000", "950000000")]
        [InlineData("0975999999", "975999999")]
        [InlineData("0977000000", "977000000")]
        [InlineData("0998999999", "998999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0800000000", "800000000")]
        [InlineData("0805999999", "805999999")]
        public void Parse_Known_NonGeographicPhoneNumber_FreePhone(string value, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Fact]
        public void Parse_Returns_Failure_If_CallingCode_Invalid()
        {
            var result = _parser.Parse("+1111111111");
            Assert.Equal($"The value must be a FR phone number starting +33 or 0 and the national significant number of the phone number must be 9 digits in length.", result.ParseError);
        }

        [Theory]
        [InlineData("02")]
        [InlineData("020")]
        [InlineData("0201")]
        [InlineData("02011")]
        [InlineData("020111")]
        [InlineData("0201111")]
        [InlineData("02011111")]
        [InlineData("020111111")] // 8
        [InlineData("02011111111")] // 10
        public void Parse_Returns_Failure_If_Nsn_Incorrect_Length(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"The value must be a FR phone number starting +33 or 0 and the national significant number of the phone number must be 9 digits in length.", result.ParseError);
        }
    }
}
