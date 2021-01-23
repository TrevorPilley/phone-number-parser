using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="GBPhoneNumberFormatter"/> class.
    /// </summary>
    public class GBPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = GBPhoneNumberFormatter.Instance;

        [Theory]
        [InlineData("01132224444", "0113 222 4444")] // 11X
        [InlineData("01216754806", "0121 675 4806")] // 1X1
        [InlineData("01733223344", "01733 223344")]  // 1XXX 6 digit local number
        [InlineData("01697745678", "016977 45678")]  // 1XXXX 5 digit local number
        [InlineData("0169772345", "016977 2345")]    // 1XXXX 4 digit local number
        [InlineData("02076416000", "020 7641 6000")] // 2X
        [InlineData("03001212123", "0300 121 2123")] // 3XX
        [InlineData("07106112233", "07106 112233")]  // 7XXX
        [InlineData("0800121121", "0800 121 121")]   // 8XX
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "GB"), "D"));
    }
}
