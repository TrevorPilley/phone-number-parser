using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="IEPhoneNumberFormatter"/> class.
    /// </summary>
    public class IEPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new IEPhoneNumberFormatter();

        [Theory]
        [InlineData("012222222", "01 222 2222")]
        [InlineData("0214924000", "021 492 4000")]
        [InlineData("040226969", "0402 26969")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "IE"), "D"));

        [Theory]
        [InlineData("012222222", "+35312222222")]
        [InlineData("0214924000", "+353214924000")]
        [InlineData("040226969", "+35340226969")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "IE"), "I"));

        [Theory]
        [InlineData("012222222", "012222222")]
        [InlineData("0214924000", "0214924000")]
        [InlineData("040226969", "040226969")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "IE"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+441132224444"), "C"));
    }
}
