using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="PairedDigitPhoneNumberFormatter"/> class.
    /// </summary>
    public class PairedDigitPhoneNumberFormatterTests
    {
        private readonly PhoneNumberFormatter _formatter = PairedDigitPhoneNumberFormatter.Instance;

        [Theory]
        [InlineData(null, null, "11223344", "11 22 33 44")]
        [InlineData("0", null, "122334455", "01 22 33 44 55")]
        [InlineData("0", "122", "334455", "01 22 33 44 55")]
        public void Format_Display(string trunkPrefix, string areaCode, string localNumber, string expected) =>
            Assert.Equal(expected, _formatter.Format(GetPhoneNumber(trunkPrefix, areaCode, localNumber), "D"));

        private static PhoneNumber GetPhoneNumber(string trunkPrefix, string areaCode, string localNumber) =>
            new NonGeographicPhoneNumber(TestHelper.CreateCountryInfo(trunkPrefix: trunkPrefix), areaCode, localNumber, false);
    }
}
