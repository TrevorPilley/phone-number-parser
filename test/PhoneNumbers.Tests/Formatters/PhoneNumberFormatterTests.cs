using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="PhoneNumberFormatter"/> class.
    /// </summary>
    /// <remarks>
    /// All tests use unused calling codes and fake numbers.
    /// </remarks>
    public class PhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = PhoneNumberFormatter.Default;

        [Fact]
        public void Default()
        {
            Assert.NotNull(PhoneNumberFormatter.Default);
            Assert.Same(PhoneNumberFormatter.Default, PhoneNumberFormatter.Default);
        }

        [Fact]
        public void Format_Display() =>
            Assert.Equal("+44 12345 667788", _formatter.Format(GetPhoneNumber(), "D"));

        [Fact]
        public void Format_International() =>
            Assert.Equal("+4412345667788", _formatter.Format(GetPhoneNumber(), "I"));

        [Fact]
        public void Format_National() =>
            Assert.Equal("012345667788", _formatter.Format(GetPhoneNumber(), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(GetPhoneNumber(), "C"));

        private static PhoneNumber GetPhoneNumber() =>
            new GeographicPhoneNumber(CountryInfo.UK, "12345", "667788", "N/A");
    }
}
