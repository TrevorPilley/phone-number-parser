using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Singapore <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_SG_NonGeographicPhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Singapore);

        [Theory]
        [InlineData("30000000", "30000000")]
        [InlineData("39999999", "39999999")]
        [InlineData("60000000", "60000000")]
        [InlineData("69999999", "69999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Singapore, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }
    }
}
