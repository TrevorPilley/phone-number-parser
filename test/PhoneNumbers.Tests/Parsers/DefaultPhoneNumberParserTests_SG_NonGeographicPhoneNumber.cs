using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for SG <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_SG_NonGeographicPhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.SG);

        [Theory]
        [InlineData("30000000", "30000000")]
        [InlineData("39999999", "39999999")]
        [InlineData("60000000", "60000000")]
        [InlineData("69999999", "69999999")]
        public void Parse_Known_NonGeographicPhoneNumber(string value, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Null(nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.SG, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}
