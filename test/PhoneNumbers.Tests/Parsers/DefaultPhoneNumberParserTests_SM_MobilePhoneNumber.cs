using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for SM <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_SM_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.SanMarino);

        [Theory]
        [InlineData("600000", "600000")]
        [InlineData("699999", "699999")]
        [InlineData("6000000", "6000000")]
        [InlineData("6999999", "6999999")]
        [InlineData("60000000", "60000000")]
        [InlineData("69999999", "69999999")]
        [InlineData("600000000", "600000000")]
        [InlineData("699999999", "699999999")]
        [InlineData("6000000000", "6000000000")]
        [InlineData("6999999999", "6999999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.SanMarino, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Null(mobilePhoneNumber.NationalDiallingCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
