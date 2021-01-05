using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="HKPhoneNumberParser"/> class.
    /// </summary>
    public class LocalOnlyPhoneNumberParserTests_HK
    {
        private readonly PhoneNumberParser _parser = LocalOnlyPhoneNumberParser.Create(CountryInfo.HK);

        [Theory]
        [InlineData("51000000")]
        [InlineData("79999999")]
        [InlineData("90100000")]
        [InlineData("98999999")]
        public void Parse_Known_MobilePhoneNumber(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.HK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(value, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("81000000")]
        [InlineData("83999999")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.HK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(value, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("20100000")]
        [InlineData("20699999")]
        [InlineData("21000000")]
        [InlineData("29999999")]
        [InlineData("31000000")]
        [InlineData("31999999")]
        [InlineData("34000000")]
        [InlineData("39999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.HK, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(value, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("80000000")]
        [InlineData("80099999")]
        public void Parse_Known_NonGeographicPhoneNumber_FreePhone(string value)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.HK, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(value, nonGeographicPhoneNumber.LocalNumber);
        }

        [Fact]
        public void Parse_Returns_Failure_If_CallingCode_Invalid()
        {
            var result = _parser.Parse("+1111111111");
            Assert.Equal($"The value must be a HK phone number starting +852 and the national significant number of the phone number must be 8 digits in length.", result.ParseError);
        }

        [Theory]
        [InlineData("11111111")]
        [InlineData("20000000")]
        [InlineData("20700000")]
        [InlineData("30000000")]
        [InlineData("32000000")]
        [InlineData("41111111")]
        [InlineData("50000000")]
        [InlineData("90000000")]
        public void Parse_Returns_Failure_If_LocalNumber_Invalid(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"{value} is not a valid HK phone number.", result.ParseError);
        }

        [Theory]
        [InlineData("20")]
        [InlineData("201")]
        [InlineData("2011")]
        [InlineData("20111")]
        [InlineData("201111")]
        [InlineData("2011111")]
        [InlineData("201111111")]  // 9
        [InlineData("2011111111")] // 10
        public void Parse_Returns_Failure_If_Nsn_Incorrect_Length(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"The value must be a HK phone number starting +852 and the national significant number of the phone number must be 8 digits in length.", result.ParseError);
        }
    }
}
