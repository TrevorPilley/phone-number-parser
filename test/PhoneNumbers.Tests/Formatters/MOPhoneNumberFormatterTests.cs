using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="MOPhoneNumberFormatterTests"/> class.
    /// </summary>
    public class MOPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new MOPhoneNumberFormatter();

        [Theory]
        [InlineData("28000000", "2800 0000")]
        [InlineData("60000000", "6000 0000")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MO"), "D"));

        [Theory]
        [InlineData("28000000", "+85328000000")]
        [InlineData("60000000", "+85360000000")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MO"), "I"));

        [Theory]
        [InlineData("28000000", "28000000")]
        [InlineData("60000000", "60000000")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "MO"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+85328000000"), "C"));
    }
}
