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
        public void Format_Display_With_TrunkPrefix_With_NationalDiallingCode() =>
            Assert.Equal("+422 (0) 12345 667788", _formatter.Format(GetPhoneNumber("0", "12345", "667788"), "D"));

        [Fact]
        public void Format_Display_With_TrunkPrefix_Without_NationalDiallingCode() =>
            Assert.Equal("+422 (0) 667788", _formatter.Format(GetPhoneNumber("0", null, "667788"), "D"));

        [Fact]
        public void Format_Display_Without_TrunkPrefix_With_NationalDiallingCode() =>
            Assert.Equal("+422 12345 667788", _formatter.Format(GetPhoneNumber(null, "12345", "667788"), "D"));

        [Fact]
        public void Format_Display_Without_TrunkPrefix_Without_NationalDiallingCode() =>
            Assert.Equal("+422 667788", _formatter.Format(GetPhoneNumber(null, null, "667788"), "D"));

        [Fact]
        public void Format_E164() =>
            Assert.Equal("+42212345667788", _formatter.Format(GetPhoneNumber("0", "12345", "667788"), "E"));

        [Fact]
        public void Format_International() =>
            Assert.Equal("+42212345667788", _formatter.Format(GetPhoneNumber("0", "12345", "667788"), "I"));

        [Fact]
        public void Format_National_With_TrunkPrefix() =>
            Assert.Equal("012345667788", _formatter.Format(GetPhoneNumber("0", "12345", "667788"), "N"));

        [Fact]
        public void Format_National_Without_TrunkPrefix() =>
            Assert.Equal("12345667788", _formatter.Format(GetPhoneNumber(null, "12345", "667788"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(GetPhoneNumber(null, "12345", "667788"), "C"));

        [Fact]
        public void Format_Throws_Exception_For_Null_PhoneNumber() =>
            Assert.Throws<ArgumentNullException>(() => _formatter.Format(null, "I"));

        private static PhoneNumber GetPhoneNumber(string trunkPrefix, string areaCode, string localNumber) =>
            new NonGeographicPhoneNumber(TestHelper.CreateCountryInfo(trunkPrefix: trunkPrefix), PhoneNumberHint.None, areaCode, localNumber);
    }
}
