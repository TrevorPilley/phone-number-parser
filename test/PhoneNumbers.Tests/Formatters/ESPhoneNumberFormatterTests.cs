using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="ESPhoneNumberFormatter"/> class.
    /// </summary>
    public class ESPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new ESPhoneNumberFormatter();

        [Theory]
        [InlineData("600000000", "600 000 000")]
        [InlineData("810030000", "810 030 000")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "ES"), "D"));
    }
}
