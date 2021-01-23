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
    }
}
