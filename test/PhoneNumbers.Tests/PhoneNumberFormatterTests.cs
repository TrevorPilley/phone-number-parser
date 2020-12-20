using System;
using Moq;
using Xunit;

namespace PhoneNumbers.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="PhoneNumberFormatter"/> class.
    /// </summary>
    /// <remarks>
    /// All tests use unused calling codes and fake numbers.
    /// </remarks>
    public class PhoneNumberFormatterTests
    {
        [Fact]
        public void Format_Display() =>
            Assert.Equal("+292 12345 667788", GetFormatter().Format(GetPhoneNumber(), "D"));

        [Fact]
        public void Format_International() =>
            Assert.Equal("+29212345667788", GetFormatter().Format(GetPhoneNumber(), "I"));

        [Fact]
        public void Format_National() =>
            Assert.Equal("012345667788", GetFormatter().Format(GetPhoneNumber(), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format()
        {
            Assert.Throws<NotSupportedException>(
                () => GetFormatter().Format(GetPhoneNumber(), "C"));
        }

        private static PhoneNumberFormatter GetFormatter() =>
            new Mock<PhoneNumberFormatter> { CallBase = true }.Object;

        private static PhoneNumber GetPhoneNumber() =>
            new GeographicPhoneNumber("+292", "0", "12345", "667788", "N/A");
    }
}
