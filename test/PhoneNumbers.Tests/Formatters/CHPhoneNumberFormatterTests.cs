using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="CHPhoneNumberFormatter"/> class.
    /// </summary>
    public class CHPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new CHPhoneNumberFormatter();

        [Theory]
        [InlineData("0327654321", "032 765 43 21")]
        [InlineData("0878000000", "0878 000 000")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "CH"), "D"));
    }
}
