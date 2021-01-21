using System;
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

        [Theory]
        [InlineData("01132224444", "+441132224444")] // 11X
        [InlineData("01216754806", "+441216754806")] // 1X1
        [InlineData("01733223344", "+441733223344")] // 1XXX
        [InlineData("02076416000", "+442076416000")] // 2X
        [InlineData("03001212123", "+443001212123")] // 3XX
        [InlineData("07106112233", "+447106112233")] // 7XXX
        [InlineData("0800121121", "+44800121121")] // 8XX
        public void Format_International(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "GB"), "I"));

        [Theory]
        [InlineData("01132224444", "01132224444")] // 11X
        [InlineData("01216754806", "01216754806")] // 1X1
        [InlineData("01733223344", "01733223344")] // 1XXX
        [InlineData("02076416000", "02076416000")] // 2X
        [InlineData("03001212123", "03001212123")] // 3XX
        [InlineData("07106112233", "07106112233")] // 7XXX
        [InlineData("0800121121", "0800121121")] // 8XX
        public void Format_National(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "GB"), "N"));

        [Fact]
        public void Format_Throws_Exception_For_Invalid_Format() =>
            Assert.Throws<FormatException>(() => _formatter.Format(PhoneNumber.Parse("+441132224444"), "C"));
    }
}
