using System;
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
            var result = _parser.Parse("0113111222");
            Assert.Equal($"The area code 113 and local number 111222 are not a valid combination.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_For_2X_AreaCode_And_Local_Number_Not_8_Digits()
        {
            var result = _parser.Parse("0201112222");
            Assert.Equal($"The area code 20 and local number 1112222 are not a valid combination.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_For_3XX_AreaCode_And_Local_Number_Not_7_Digits()
        {
            var result = _parser.Parse("0300111111");
            Assert.Equal($"The area code 300 and local number 111111 are not a valid combination.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_For_7XXX_AreaCode_And_Local_Number_Not_6_Digits()
        {
            var result = _parser.Parse("0770012345");
            Assert.Equal($"The area code 7700 and local number 12345 are not a valid combination.", result.ParseError);
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
            var result = _parser.Parse(value);
            Assert.Equal($"The area code {areaCode} and local number {value.Substring(value.IndexOf(areaCode, StringComparison.Ordinal) + areaCode.Length)} are not a valid combination.", result.ParseError);
        }

        [Fact]
        public void Parse_Returns_Failure_If_CallingCode_Invalid()
        {
            var result = _parser.Parse("+1111111111");
            Assert.Equal($"The value must be a GB phone number starting +44 or 0 and the national significant number of the phone number must be {string.Join(" or ", CountryInfo.UK.NsnLengths)} digits in length.", result.ParseError);
        }

        [Theory]
        [InlineData("07101111111")]
        public void Parse_Returns_Failure_If_LocalNumber_Invalid_For_AreaCode(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"The area code {value.Substring(1, 4)} and local number {value.Substring(5)} are not a valid combination.", result.ParseError);
        }

        [Theory]
        [InlineData("02")]
        [InlineData("020")]
        [InlineData("0201")]
        [InlineData("02011")]
        [InlineData("020111")]
        [InlineData("0201111")]
        [InlineData("020111111")]    // 8
        [InlineData("020111111111")] // 11
        public void Parse_Returns_Failure_If_Nsn_Incorrect_Length(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"The value must be a GB phone number starting +44 or 0 and the national significant number of the phone number must be {string.Join(" or ", CountryInfo.UK.NsnLengths)} digits in length.", result.ParseError);
        }

        [Theory]
        [InlineData("0411111111")]
        [InlineData("0511111111")]
        [InlineData("0611111111")]
        [InlineData("0911111111")]
        public void Parse_Returns_Failure_If_ServiceType_Invalid(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"A GB phone number cannot have a national significant number starting {value[1]}.", result.ParseError);
        }

        [Theory]
        [InlineData("1411111111")]
        [InlineData("2411111111")]
        [InlineData("3411111111")]
        [InlineData("4411111111")]
        [InlineData("5411111111")]
        [InlineData("6411111111")]
        [InlineData("7411111111")]
        [InlineData("8411111111")]
        [InlineData("9411111111")]
        public void Parse_Returns_Failure_If_TrunkPrefix_Invalid(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"The value must be a GB phone number starting +44 or 0 and the national significant number of the phone number must be {string.Join(" or ", CountryInfo.UK.NsnLengths)} digits in length.", result.ParseError);
        }
    }
}
