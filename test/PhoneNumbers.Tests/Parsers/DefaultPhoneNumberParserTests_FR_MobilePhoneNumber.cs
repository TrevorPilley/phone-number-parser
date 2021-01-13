using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for FR <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_FR_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.FR);

        [Theory]
        [InlineData("0601000000", "601000000")]
        [InlineData("0638999999", "638999999")]
        [InlineData("0640000000", "640000000")]
        [InlineData("0652999999", "652999999")]
        [InlineData("0656000000", "656000000")]
        [InlineData("0689999999", "689999999")]
        [InlineData("0695000000", "695000000")]
        [InlineData("0695999999", "695999999")]
        [InlineData("0700000000", "700000000")]
        [InlineData("0700499999", "700499999")]
        [InlineData("0730000000", "730000000")]
        [InlineData("0789999999", "789999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Null(mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
