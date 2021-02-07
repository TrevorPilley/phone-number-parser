using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Italy <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IT_NonGeographicPhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Italy);

        [Theory]
        [InlineData("840000000", "840", "000000")]
        [InlineData("840999999", "840", "999999")]
        [InlineData("841000", "841", "000")]
        [InlineData("841999", "841", "999")]
        [InlineData("847000", "847", "000")]
        [InlineData("847999", "847", "999")]
        [InlineData("848000000", "848", "000000")]
        [InlineData("848999999", "848", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_8XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Italy, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("800000000", "800", "000000")]
        [InlineData("800999999", "800", "999999")]
        [InlineData("803000", "803", "000")]
        [InlineData("803999", "803", "999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Italy, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }
    }
}
