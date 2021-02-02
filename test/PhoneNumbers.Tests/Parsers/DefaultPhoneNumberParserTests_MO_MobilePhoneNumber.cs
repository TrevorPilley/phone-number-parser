using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for MO <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_MO_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Macau);

        [Theory]
        [InlineData("60000000", "60000000")]
        [InlineData("69999999", "69999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Macau, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Null(mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
