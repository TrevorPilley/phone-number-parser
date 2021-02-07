using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Belgium <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_BE_NonGeographicPhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Belgium);

        [Theory]
        [InlineData("070000000", "70", "000000")]
        [InlineData("070999999", "70", "999999")]
        [InlineData("078000000", "78", "000000")]
        [InlineData("078999999", "78", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("090000000", "90", "000000")]
        [InlineData("090099999", "90", "099999")]
        public void Parse_Known_NonGeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("080000000", "800", "00000")]
        [InlineData("080099999", "800", "99999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }
    }
}
