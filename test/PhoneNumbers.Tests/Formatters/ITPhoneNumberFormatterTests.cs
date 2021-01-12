using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="ITPhoneNumberFormatter"/> class.
    /// </summary>
    public class ITPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new ITPhoneNumberFormatter();

        [Theory]
        [InlineData("0642200001", "06 4220 0001")]
        [InlineData("0552768028", "055 276 8028")]
        [InlineData("034525011", "0345 25011")]
        [InlineData("3492525255", "349 2525255")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "IT"), "D"));

        [Theory]
        [InlineData("0642200001", "+390642200001")]
        [InlineData("0552768028", "+390552768028")]
        [InlineData("034525011", "+39034525011")]
        [InlineData("3492525255", "+393492525255")]
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "IT"), "I"));

        [Theory]
        [InlineData("0642200001", "0642200001")]
        [InlineData("0552768028", "0552768028")]
        [InlineData("034525011", "034525011")]
        [InlineData("3492525255", "3492525255")]
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "IT"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+441132224444"), "C"));
    }
}
