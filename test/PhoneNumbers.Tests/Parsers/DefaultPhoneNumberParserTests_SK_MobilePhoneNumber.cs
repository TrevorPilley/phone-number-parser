using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Slovakia <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_SK_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Slovakia);

        [Theory]
        [InlineData("901000000", "901", "000000")]
        [InlineData("901999999", "901", "999999")]
        [InlineData("908000000", "908", "000000")]
        [InlineData("908999999", "908", "999999")]
        [InlineData("910000000", "910", "000000")]
        [InlineData("910999999", "910", "999999")]
        [InlineData("912000000", "912", "000000")]
        [InlineData("912999999", "912", "999999")]
        [InlineData("914000000", "914", "000000")]
        [InlineData("914999999", "914", "999999")]
        [InlineData("919000000", "919", "000000")]
        [InlineData("919999999", "919", "999999")]
        [InlineData("940000000", "940", "000000")]
        [InlineData("940999999", "940", "999999")]
        [InlineData("944000000", "944", "000000")]
        [InlineData("944999999", "944", "999999")]
        [InlineData("949000000", "949", "000000")]
        [InlineData("949999999", "949", "999999")]
        [InlineData("950000000", "950", "000000")]
        [InlineData("950999999", "950", "999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Slovakia, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("9090000", "9090", "000")]
        [InlineData("9090999", "9090", "999")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Slovakia, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
