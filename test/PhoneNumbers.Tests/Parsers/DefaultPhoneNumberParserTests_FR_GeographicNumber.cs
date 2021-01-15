using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for FR <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_FR_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.FR);

        [Theory]
        [InlineData("0110000000", "110000000", "Île-de-France")]
        [InlineData("0199999999", "199999999", "Île-de-France")]
        [InlineData("0210000000", "210000000", "Nord-Ouest")]
        [InlineData("0261999999", "261999999", "Nord-Ouest")]
        [InlineData("0264000000", "264000000", "Nord-Ouest")]
        [InlineData("0268999999", "268999999", "Nord-Ouest")]
        [InlineData("0270000000", "270000000", "Nord-Ouest")]
        [InlineData("0299999999", "299999999", "Nord-Ouest")]
        [InlineData("0310000000", "310000000", "Nord-Est")]
        [InlineData("0399999999", "399999999", "Nord-Est")]
        [InlineData("0410000000", "410000000", "Sud-Est")]
        [InlineData("0499999999", "499999999", "Sud-Est")]
        [InlineData("0516000000", "516000000", "Sud-Ouest")]
        [InlineData("0589999999", "589999999", "Sud-Ouest")]
        public void Parse_Known_GeographicPhoneNumber(string value, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Null(geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.FR, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }
    }
}
