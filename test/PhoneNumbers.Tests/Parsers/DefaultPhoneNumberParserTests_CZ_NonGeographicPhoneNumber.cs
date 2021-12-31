using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Czech republic <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CZ_NonGeographicPhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CzechRepublic);

        [Theory]
        [InlineData("810000000", "81", "0000000")]
        [InlineData("819999999", "81", "9999999")]
        [InlineData("840000000", "84", "0000000")]
        [InlineData("849999999", "84", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.False(nonGeographicPhoneNumber.IsSharedCost);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("800000000", "800", "000000")]
        [InlineData("800999999", "800", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.False(nonGeographicPhoneNumber.IsSharedCost);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("900000000", "900", "000000")]
        [InlineData("900999999", "900", "999999")]
        [InlineData("905000000", "905", "000000")]
        [InlineData("905999999", "905", "999999")]
        [InlineData("906000000", "906", "000000")]
        [InlineData("906999999", "906", "999999")]
        [InlineData("908000000", "908", "000000")]
        [InlineData("908999999", "908", "999999")]
        [InlineData("909000000", "909", "000000")]
        [InlineData("909999999", "909", "999999")]
        public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
            Assert.False(nonGeographicPhoneNumber.IsSharedCost);
            Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
        }
    }
}
