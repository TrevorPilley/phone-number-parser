using System;
using System.Collections.ObjectModel;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/>.
    /// </summary>
    public class DefaultPhoneNumberParserTests
    {
        [Fact]
        public void Constructor_Throws_For_Null_CountryNumbers() =>
            Assert.Throws<ArgumentNullException>(() => new DefaultPhoneNumberParser(CountryInfo.UnitedKingdom, null));

        [Fact]
        public void Parse_Fails_For_Unsupported_NSN_Length_With_TrunkPrefix()
        {
            var countryInfo = TestHelper.CreateCountryInfo(trunkPrefix: "0", nsnLengths: new[] { 8, 9 });
            var parser = new DefaultPhoneNumberParser(countryInfo, new ReadOnlyCollection<CountryNumber>(Array.Empty<CountryNumber>()));
            var parseResult = parser.Parse("8010");

            Assert.Equal(
                $"The value must be a {countryInfo.Name} phone number starting {countryInfo.CallingCode} or {countryInfo.TrunkPrefix} and the national significant number of the phone number must be 8 or 9 digits in length.",
                parseResult.ParseError);
        }

        [Fact]
        public void Parse_Fails_For_Unsupported_NSN_Length_Without_TrunkPrefix()
        {
            var countryInfo = TestHelper.CreateCountryInfo(nsnLengths: new[] { 8, 9 });
            var parser = new DefaultPhoneNumberParser(countryInfo, new ReadOnlyCollection<CountryNumber>(Array.Empty<CountryNumber>()));
            var parseResult = parser.Parse("8010");

            Assert.Equal(
                $"The value must be a {countryInfo.Name} phone number starting {countryInfo.CallingCode} and the national significant number of the phone number must be 8 or 9 digits in length.",
                parseResult.ParseError);
        }
    }
}
