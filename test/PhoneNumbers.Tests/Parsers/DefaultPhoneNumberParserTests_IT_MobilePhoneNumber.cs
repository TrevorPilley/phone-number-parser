using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for IT <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IT_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.IT);

        [Theory]
        [InlineData("3100000000", "31", "00000000")]
        [InlineData("3199999999", "31", "99999999")]
        [InlineData("320000000", "32", "0000000")]
        [InlineData("3299999999", "32", "99999999")]
        [InlineData("330000000", "33", "0000000")]
        [InlineData("3399999999", "33", "99999999")]
        [InlineData("340000000", "34", "0000000")]
        [InlineData("3499999999", "34", "99999999")]
        [InlineData("350000000", "35", "0000000")]
        [InlineData("3599999999", "35", "99999999")]
        [InlineData("360000000", "36", "0000000")]
        [InlineData("3699999999", "36", "99999999")]
        [InlineData("370000000", "37", "0000000")]
        [InlineData("3799999999", "37", "99999999")]
        [InlineData("380000000", "38", "0000000")]
        [InlineData("3899999999", "38", "99999999")]
        [InlineData("390000000", "39", "0000000")]
        [InlineData("3999999999", "39", "99999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IT, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
