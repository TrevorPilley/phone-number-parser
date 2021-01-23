using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for JE <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_JE_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Jersey);

        [Theory]
        [InlineData("01534200000", "1534", "200000", "Jersey")]
        [InlineData("01534998999", "1534", "998999", "Jersey")]
        public void Parse_Known_GeographicPhoneNumber_1XXX_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Jersey, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }
    }
}
