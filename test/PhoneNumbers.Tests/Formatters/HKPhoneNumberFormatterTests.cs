using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="HKPhoneNumberFormatterTests"/> class.
    /// </summary>
    public class HKPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new HKPhoneNumberFormatter();

        [Theory]
        [InlineData("29013000", "2901 3000")]
        [InlineData("51015522", "5101 5522")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "HK"), "D"));

        [Theory]
        [InlineData("29013000", "+85229013000")]
        [InlineData("51015522", "+85251015522")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "HK"), "I"));

        [Theory]
        [InlineData("29013000", "29013000")]
        [InlineData("51015522", "51015522")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "HK"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+85229013000"), "C"));
    }
}
