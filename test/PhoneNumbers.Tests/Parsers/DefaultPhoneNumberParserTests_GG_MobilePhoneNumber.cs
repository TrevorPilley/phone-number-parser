using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for GG <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_GG_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Guernsey);

        [Theory]
        [InlineData("07781000000", "7781", "000000")]
        [InlineData("07781999999", "7781", "999999")]
        [InlineData("07839100000", "7839", "100000")]
        [InlineData("07839299999", "7839", "299999")]
        [InlineData("07839700000", "7839", "700000")]
        [InlineData("07839899999", "7839", "899999")]
        [InlineData("07911000000", "7911", "000000")]
        [InlineData("07911199999", "7911", "199999")]
        [InlineData("07911700000", "7911", "700000")]
        [InlineData("07911799999", "7911", "799999")]
        public void Parse_Known_MobilePhoneNumber(string value, string nationalDiallingCode, string subscriberNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Guernsey, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(nationalDiallingCode, mobilePhoneNumber.NationalDiallingCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
