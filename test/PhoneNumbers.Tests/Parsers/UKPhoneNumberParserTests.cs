using System;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="UKPhoneNumberParser"/> class.
    /// </summary>
    /// <remarks>
    /// All valid number tests use the local council number for the area code, or a public company/charity number for non geographic numbers.
    /// </remarks>
    public partial class UKPhoneNumberParserTests
    {
        [Fact]
        public void Parse_Throws_Exception_For_1XX_AreaCode_And_Local_Number_Not_7_Digits()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse("0113111222", CountryInfo.UK));
            Assert.Equal("The for the area code 113, the local number must be 7 digits.", exception.Message);
        }

        [Fact]
        public void Parse_Throws_Exception_For_2X_AreaCode_And_Local_Number_Not_8_Digits()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse("0201112222", CountryInfo.UK));
            Assert.Equal("The for the area code 20, the local number must be 8 digits.", exception.Message);
        }

        [Fact]
        public void Parse_Throws_Exception_For_3XX_AreaCode_And_Local_Number_Not_7_Digits()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse("0300111111", CountryInfo.UK));
            Assert.Equal("For a UK non-geographic number, the national significant number of the phone number must be 10 digits.", exception.Message);
        }

        [Fact]
        public void Parse_Throws_Exception_For_7XXX_AreaCode_And_Local_Number_Not_6_Digits()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse("0700012345", CountryInfo.UK));
            Assert.Equal("For a UK mobile phone, the national significant number of the phone number must be 10 digits.", exception.Message);
        }

        [Theory]
        [InlineData("01100000000", "110")]
        [InlineData("01110000000", "111")]
        [InlineData("01120000000", "112")]
        [InlineData("01190000000", "119")]
        [InlineData("01710000000", "171")]
        [InlineData("01810000000", "181")]
        [InlineData("02100000000", "21")]
        [InlineData("02200000000", "22")]
        [InlineData("02500000000", "25")]
        [InlineData("02600000000", "26")]
        [InlineData("02700000000", "27")]
        [InlineData("03100000000", "310")]
        [InlineData("03200000000", "320")]
        [InlineData("03500000000", "350")]
        [InlineData("03600000000", "360")]
        [InlineData("03800000000", "380")]
        [InlineData("03900000000", "390")]
        [InlineData("07200000000", "7200")]
        public void Parse_Throws_Exception_If_AreaCode_Invalid(string value, string areaCode)
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse(value, CountryInfo.UK));
            Assert.Equal($"The area code {areaCode} is invalid.", exception.Message);
        }

        [Fact]
        public void Parse_Throws_Exception_If_CallingCode_Invalid()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse("+1111111111", CountryInfo.UK));
            Assert.Equal($"The value must be a GB phone number starting {CountryInfo.UK.TrunkPrefix} or {CountryInfo.UK.CallingCode}.", exception.Message);
        }

        [Theory]
        [InlineData("07101111111")]
        public void Parse_Throws_Exception_If_LocalNumber_Invalid_For_AreaCode(string value)
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse(value, CountryInfo.UK));
            Assert.Equal($"The area code {value.Substring(1, 4)} is invalid.", exception.Message);
        }

        [Theory]
        [InlineData("02")]
        [InlineData("020")]
        [InlineData("0201")]
        [InlineData("02011")]
        [InlineData("020111")]
        [InlineData("0201111")]
        [InlineData("020111111")] // 8
        [InlineData("020111111111")] // 11
        public void Parse_Throws_Exception_If_Nsn_Incorrect_Length(string value)
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse(value, CountryInfo.UK));
            Assert.Equal("The national significant number of the phone number must be 7,9,10 in length.", exception.Message);
        }

        [Fact]
        public void Parse_Throws_Exception_If_ServiceType_Invalid()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse("0411111111", CountryInfo.UK));
        }

        [Fact]
        public void Parse_Throws_Exception_If_TrunkPrefix_Invalid()
        {
            var parser = new UKPhoneNumberParser();
            var exception = Assert.Throws<ArgumentException>(() => parser.Parse("1111111111", CountryInfo.UK));
            Assert.Equal($"The value must be a GB phone number starting {CountryInfo.UK.TrunkPrefix} or {CountryInfo.UK.CallingCode}.", exception.Message);
        }
    }
}
