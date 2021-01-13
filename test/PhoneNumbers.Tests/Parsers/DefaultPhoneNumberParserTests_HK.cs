using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for HK <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_HK
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.HK);

        [Fact]
        public void Parse_Returns_Failure_If_CallingCode_Invalid()
        {
            var result = _parser.Parse("+1111111111");
            Assert.Equal($"The value must be a HK phone number starting +852 and the national significant number of the phone number must be 8 or 9 digits in length.", result.ParseError);
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
            Assert.Equal($"The national significant number {value} is not valid for a HK phone number.", result.ParseError);
        }

        [Theory]
        [InlineData("20")]
        [InlineData("201")]
        [InlineData("2011")]
        [InlineData("20111")]
        [InlineData("201111")]
        [InlineData("2011111")]
        [InlineData("2011111111")] // 10
        public void Parse_Returns_Failure_If_Nsn_Incorrect_Length(string value)
        {
            var result = _parser.Parse(value);
            Assert.Equal($"The value must be a HK phone number starting +852 and the national significant number of the phone number must be 8 or 9 digits in length.", result.ParseError);
        }
    }
}
