using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Gibraltar <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_GI_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Gibraltar);

        [Theory]
        [InlineData("20000000", "200", "00000", "Gibraltar")]
        [InlineData("20099999", "200", "99999", "Gibraltar")]
        [InlineData("21600000", "216", "00000", "Gibraltar")]
        [InlineData("21699999", "216", "99999", "Gibraltar")]
        [InlineData("22200000", "222", "00000", "Gibraltar")]
        [InlineData("22299999", "222", "99999", "Gibraltar")]
        [InlineData("22500000", "225", "00000", "Gibraltar")]
        [InlineData("22599999", "225", "99999", "Gibraltar")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Gibraltar, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
