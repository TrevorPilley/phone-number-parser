using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="UKPhoneNumberParser"/> class.
    /// </summary>
    public partial class UKPhoneNumberParserTests
    {
        private readonly PhoneNumberParser _parser = UKPhoneNumberParser.Create();

        [Fact]
        public void Parse_Returns_Failure_For_1XX_AreaCode_And_Local_Number_Not_7_Digits()
        {
            var result = _parser.Parse("0113111222", CountryInfo.UK);
            Assert.Equal("The for the area code 113, the local number must be 7 digits in length.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_For_2X_AreaCode_And_Local_Number_Not_8_Digits()
        {
            var result = _parser.Parse("0201112222", CountryInfo.UK);
            Assert.Equal("The for the area code 20, the local number must be 8 digits in length.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_For_3XX_AreaCode_And_Local_Number_Not_7_Digits()
        {
            var result = _parser.Parse("0300111111", CountryInfo.UK);
            Assert.Equal("The for the area code 300, the local number must be 7 digits in length.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_For_7XXX_AreaCode_And_Local_Number_Not_6_Digits()
        {
            var result = _parser.Parse("0700012345", CountryInfo.UK);
            Assert.Equal("The for the area code 7000, the local number must be 6 digits in length.", result.ParseError);
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
        public void Parse_Returns_Failure_If_AreaCode_Invalid(string value, string areaCode)
        {
            var result = _parser.Parse(value, CountryInfo.UK);
            Assert.Equal($"The area code {areaCode} is invalid.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_If_CallingCode_Invalid()
        {
            var result = _parser.Parse("+1111111111", CountryInfo.UK);
            Assert.Equal($"The value must be a GB phone number starting {CountryInfo.UK.TrunkPrefix} or {CountryInfo.UK.CallingCode}.", result.ParseError);
        }

        [Theory]
        [InlineData("07101111111")]
        public void Parse_Returns_Failure_If_LocalNumber_Invalid_For_AreaCode(string value)
        {
            var result = _parser.Parse(value, CountryInfo.UK);
            Assert.Equal($"The area code {value.Substring(1, 4)} is invalid.", result.ParseError);
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
        public void Parse_Returns_Failure_If_Nsn_Incorrect_Length(string value)
        {
            var result = _parser.Parse(value, CountryInfo.UK);
            Assert.Equal("The national significant number of the phone number must be 7 or 9 or 10 digits in length.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_If_ServiceType_Invalid()
        {
            var result = _parser.Parse("0411111111", CountryInfo.UK);
            Assert.Equal($"A GB phone number cannot have a national significant number starting 4.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_If_TrunkPrefix_Invalid()
        {
            var result = _parser.Parse("1111111111", CountryInfo.UK);
            Assert.Equal($"The value must be a GB phone number starting {CountryInfo.UK.TrunkPrefix} or {CountryInfo.UK.CallingCode}.", result.ParseError);
        }
    }
}
