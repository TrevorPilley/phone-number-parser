using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Spain <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_ES_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Spain);

        [Theory]
        [InlineData("600000000", "600", "000000")]
        [InlineData("600999999", "600", "999999")]
        [InlineData("699000000", "699", "000000")]
        [InlineData("699999999", "699", "999999")]
        [InlineData("710000000", "710", "000000")]
        [InlineData("710999999", "710", "999999")]
        [InlineData("799000000", "799", "000000")]
        [InlineData("799999999", "799", "999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Spain, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("700000000", "700", "000000")]
        [InlineData("700999999", "700", "999999")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Spain, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
