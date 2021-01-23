using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="SGPhoneNumberFormatterTests"/> class.
    /// </summary>
    public class SGPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new SGPhoneNumberFormatter();

        [Theory]
        [InlineData("30000000", "3000 0000")]
        [InlineData("81000000", "8100 0000")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "SG"), "D"));

        [Theory]
        [InlineData("30000000", "+6530000000")]
        [InlineData("81000000", "+6581000000")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "SG"), "I"));

        [Theory]
        [InlineData("30000000", "30000000")]
        [InlineData("81000000", "81000000")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "SG"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+6530000000"), "C"));
    }
}
