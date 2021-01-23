using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="FRPhoneNumberFormatter"/> class.
    /// </summary>
    public class FRPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = new FRPhoneNumberFormatter();

        [Theory]
        [InlineData("0122334455", "01 22 33 44 55")]
        [InlineData("0730334455", "07 30 33 44 55")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "FR"), "D"));
    }
}
