using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="UkPhoneNumberFormatter"/> class.
    /// </summary>
    /// <remarks>
    /// All valid number tests use the local council number for the area code.
    /// </remarks>
    public class UkPhoneNumberFormatterTests
    {
        [Theory]
        [InlineData("01132224444", "0113 222 4444")] // 11X
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, new UkPhoneNumberFormatter().Format(PhoneNumber.Parse("GB", value), "D"));

        [Theory]
        [InlineData("01132224444", "+441132224444")] // 11X
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, new UkPhoneNumberFormatter().Format(PhoneNumber.Parse("GB", value), "I"));

        [Theory]
        [InlineData("01132224444", "01132224444")] // 11X
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, new UkPhoneNumberFormatter().Format(PhoneNumber.Parse("GB", value), "N"));
    }
}
