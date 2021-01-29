using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for MC <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_MC_NonGeographicPhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Monaco);

        [Theory]
        [InlineData("87000000", "87000000")]
        [InlineData("87099999", "87099999")]
        [InlineData("90000000", "90000000")]
        [InlineData("99999999", "99999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Monaco, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Null(nonGeographicPhoneNumber.NationalDiallingCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }
    }
}
