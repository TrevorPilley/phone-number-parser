using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="MCPhoneNumberFormatter"/> class.
    /// </summary>
    public class MCPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new MCPhoneNumberFormatter();

        [Theory]
        [InlineData("98988800", "98 98 88 00")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MC"), "D"));

        [Theory]
        [InlineData("98988800", "+37798988800")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MC"), "I"));

        [Theory]
        [InlineData("98988800", "98988800")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MC"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+37798988800"), "C"));
    }
}
