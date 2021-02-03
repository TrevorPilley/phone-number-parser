using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="GroupedDigitPhoneNumberFormatter"/> class.
    /// </summary>
    public class GroupedDigitPhoneNumberFormatterTests
    {
        [Theory]
        [InlineData(null, null, "11223344", "11 22 33 44")]
        [InlineData("0", null, "122334455", "01 22 33 44 55")]
        [InlineData("0", "122", "334455", "01 22 33 44 55")]
        public void Spaced2Digits_Format_Display(string trunkPrefix, string ndc, string sn, string expected) =>
            Assert.Equal(
                expected,
                GroupedDigitPhoneNumberFormatter.Spaced2Digits.Format(
                    TestHelper.CreateNonGeographicPhoneNumber(trunkPrefix, ndc, sn), "D"));

        [Theory]
        [InlineData(null, null, "600000000", "600 000 000")]
        [InlineData(null, null, "810030000", "810 030 000")]
        public void Spaced3Digits_Format_Display(string trunkPrefix, string ndc, string sn, string expected) =>
            Assert.Equal(
                expected,
                GroupedDigitPhoneNumberFormatter.Spaced3Digits.Format(
                    TestHelper.CreateNonGeographicPhoneNumber(trunkPrefix, ndc, sn), "D"));

        [Theory]
        [InlineData(null, null, "29013000", "2901 3000")]
        [InlineData(null, null, "51015522", "5101 5522")]
        public void Spaced4Digits_Format_Display(string trunkPrefix, string ndc, string sn, string expected) =>
            Assert.Equal(
                expected,
                GroupedDigitPhoneNumberFormatter.Spaced4Digits.Format(
                    TestHelper.CreateNonGeographicPhoneNumber(trunkPrefix, ndc, sn), "D"));
    }
}
