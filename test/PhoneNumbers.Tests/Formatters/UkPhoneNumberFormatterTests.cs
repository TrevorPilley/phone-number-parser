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
        [InlineData("01132224444", "0113 222 4444")]
        [InlineData("01142734567", "0114 273 4567")]
        [InlineData("01159155555", "0115 915 5555")]
        [InlineData("01164541002", "0116 454 1002")]
        [InlineData("01179222000", "0117 922 2000")]
        [InlineData("01189373787", "0118 937 3787")]
        public void Format_11X_Display(string value, string expected) =>
            Assert.Equal(expected, new UkPhoneNumberFormatter().Format(PhoneNumber.Parse("GB", value), "D"));

        [Theory]
        [InlineData("01132224444", "+441132224444")]
        [InlineData("01142734567", "+441142734567")]
        [InlineData("01159155555", "+441159155555")]
        [InlineData("01164541002", "+441164541002")]
        [InlineData("01179222000", "+441179222000")]
        [InlineData("01189373787", "+441189373787")]
        public void Format_11X_International(string value, string expected) =>
            Assert.Equal(expected, new UkPhoneNumberFormatter().Format(PhoneNumber.Parse("GB", value), "I"));

        [Theory]
        [InlineData("01132224444", "01132224444")]
        [InlineData("01142734567", "01142734567")]
        [InlineData("01159155555", "01159155555")]
        [InlineData("01164541002", "01164541002")]
        [InlineData("01179222000", "01179222000")]
        [InlineData("01189373787", "01189373787")]
        public void Format_11X_National(string value, string expected) =>
            Assert.Equal(expected, new UkPhoneNumberFormatter().Format(PhoneNumber.Parse("GB", value), "N"));
    }
}
