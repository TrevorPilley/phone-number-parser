using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Netherlands <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_NL_NonGeographicPhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Netherlands);

        [Theory]
        [InlineData("0840000000", "84", "0000000")]
        [InlineData("0849999999", "84", "9999999")]
        [InlineData("0850000000", "85", "0000000")]
        [InlineData("0859999999", "85", "9999999")]
        [InlineData("0870000000", "87", "0000000")]
        [InlineData("0879999999", "87", "9999999")]
        [InlineData("0880000000", "88", "0000000")]
        [InlineData("0889999999", "88", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0910000000", "91", "0000000")]
        [InlineData("0919999999", "91", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0800000000", "800", "000000")]
        [InlineData("0800999999", "800", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0900000000", "900", "000000")]
        [InlineData("0900999999", "900", "999999")]
        [InlineData("0906000000", "906", "000000")]
        [InlineData("0906999999", "906", "999999")]
        [InlineData("0909000000", "909", "000000")]
        [InlineData("0909999999", "909", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }
    }
}
