using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="FRPhoneNumberFormatter"/> class.
    /// </summary>
    public class FRPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new FRPhoneNumberFormatter();

        [Theory]
        [InlineData("0122334455", "01 22 33 44 55")]
        [InlineData("0722334455", "07 22 33 44 55")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "FR"), "D"));

        [Theory]
        [InlineData("0122334455", "+33122334455")]
        [InlineData("0722334455", "+33722334455")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "FR"), "I"));

        [Theory]
        [InlineData("0122334455", "0122334455")]
        [InlineData("0722334455", "0722334455")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "FR"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+33122334455"), "C"));
    }
}
