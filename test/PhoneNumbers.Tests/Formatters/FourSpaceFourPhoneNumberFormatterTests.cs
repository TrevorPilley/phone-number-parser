using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="FourSpaceFourPhoneNumberFormatter"/> class.
    /// </summary>
    public class FourSpaceFourPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = FourSpaceFourPhoneNumberFormatter.Instance;

        [Theory]
        [InlineData("29013000", "2901 3000")]
        [InlineData("51015522", "5101 5522")]
        public void Format_Display(string value, string expected) =>
            Assert.Equal(expected, _formatter.Format(PhoneNumber.Parse(value, "HK"), "D"));
    }
}
