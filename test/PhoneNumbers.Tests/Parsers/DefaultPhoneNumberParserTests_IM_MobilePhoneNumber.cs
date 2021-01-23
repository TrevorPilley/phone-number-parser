using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for IM <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IM_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.IsleOfMan);

        [Theory]
        [InlineData("07418400000", "7418", "400000")]
        [InlineData("07418499999", "7418", "499999")]
        [InlineData("07451000000", "7451", "000000")]
        [InlineData("07451699999", "7451", "699999")]
        [InlineData("07457600000", "7457", "600000")]
        [InlineData("07457699999", "7457", "699999")]
        [InlineData("07624000000", "7624", "000000")]
        [InlineData("07624499999", "7624", "499999")]
        [InlineData("07624500000", "7624", "500000")]
        [InlineData("07624509999", "7624", "509999")]
        [InlineData("07624560000", "7624", "560000")]
        [InlineData("07624569999", "7624", "569999")]
        [InlineData("07624600000", "7624", "600000")]
        [InlineData("07624999999", "7624", "999999")]
        [InlineData("07924000000", "7924", "000000")]
        [InlineData("07924999999", "7924", "999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IsleOfMan, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
