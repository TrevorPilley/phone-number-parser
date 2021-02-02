using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for JE <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_JE_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Jersey);

        [Theory]
        [InlineData("07509000000", "7509", "000000")]
        [InlineData("07509999999", "7509", "999999")]
        [InlineData("07700300000", "7700", "300000")]
        [InlineData("07700399999", "7700", "399999")]
        [InlineData("07700700000", "7700", "700000")]
        [InlineData("07700899999", "7700", "899999")]
        [InlineData("07797000000", "7797", "000000")]
        [InlineData("07797999999", "7797", "999999")]
        [InlineData("07829000000", "7829", "000000")]
        [InlineData("07829999999", "7829", "999999")]
        [InlineData("07937000000", "7937", "000000")]
        [InlineData("07937999999", "7937", "999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Jersey, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
