using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for IM <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IM_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.IsleOfMan);

        [Theory]
        [InlineData("01624200000", "1624", "200000", "Isle of Man")]
        [InlineData("01624998999", "1624", "998999", "Isle of Man")]
        public void Parse_Known_GeographicPhoneNumber_1XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.IsleOfMan, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
