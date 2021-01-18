using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="ESPhoneNumberFormatter"/> class.
    /// </summary>
    public class ESPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new ESPhoneNumberFormatter();

        [Theory]
        [InlineData("600000000", "600 000 000")]
        [InlineData("810030000", "810 030 000")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "ES"), "D"));

        [Theory]
        [InlineData("600000000", "+34600000000")]
        [InlineData("810030000", "+34810030000")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "ES"), "I"));

        [Theory]
        [InlineData("600000000", "600000000")]
        [InlineData("810030000", "810030000")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "ES"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+34600000000"), "C"));
    }
}
