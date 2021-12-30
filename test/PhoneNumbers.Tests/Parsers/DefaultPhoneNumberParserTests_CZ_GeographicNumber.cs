using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Czech republic <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CZ_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CzechRepublic);

        [Theory]
        [InlineData("220000000", "2", "20000000", "Capital Praha and Region Stredocesky")]
        [InlineData("299999999", "2", "99999999", "Capital Praha and Region Stredocesky")]
        public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("312000000", "31", "2000000", "Capital Praha and Region Stredocesky")]
        [InlineData("319999999", "31", "9999999", "Capital Praha and Region Stredocesky")]
        [InlineData("322000000", "32", "2000000", "Capital Praha and Region Stredocesky")]
        [InlineData("329999999", "32", "9999999", "Capital Praha and Region Stredocesky")]
        [InlineData("352000000", "35", "2000000", "Region Karlovarsky")]
        [InlineData("359999999", "35", "9999999", "Region Karlovarsky")]
        [InlineData("372000000", "37", "2000000", "Region Plzensky")]
        [InlineData("379999999", "37", "9999999", "Region Plzensky")]
        [InlineData("382000000", "38", "2000000", "Region Jihocesky")]
        [InlineData("389999999", "38", "9999999", "Region Jihocesky")]
        [InlineData("392000000", "39", "2000000", "Region Jihocesky")]
        [InlineData("399999999", "39", "9999999", "Region Jihocesky")]
        public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("412000000", "41", "2000000", "Region Ustecky")]
        [InlineData("419999999", "41", "9999999", "Region Ustecky")]
        [InlineData("462000000", "46", "2000000", "Region Pardubicky")]
        [InlineData("469999999", "46", "9999999", "Region Pardubicky")]
        [InlineData("472000000", "47", "2000000", "Region Ustecky")]
        [InlineData("479999999", "47", "9999999", "Region Ustecky")]
        [InlineData("482000000", "48", "2000000", "Region Liberecky")]
        [InlineData("489999999", "48", "9999999", "Region Liberecky")]
        [InlineData("492000000", "49", "2000000", "Region Kralovehradecky")]
        [InlineData("499999999", "49", "9999999", "Region Kralovehradecky")]
        public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("512000000", "51", "2000000", "Region Jihomoravsky")]
        [InlineData("519999999", "51", "9999999", "Region Jihomoravsky")]
        [InlineData("532000000", "53", "2000000", "Region Jihomoravsky")]
        [InlineData("539999999", "53", "9999999", "Region Jihomoravsky")]
        [InlineData("552000000", "55", "2000000", "Region Moravskoslezsky")]
        [InlineData("559999999", "55", "9999999", "Region Moravskoslezsky")]
        [InlineData("562000000", "56", "2000000", "Region Vysocina")]
        [InlineData("569999999", "56", "9999999", "Region Vysocina")]
        [InlineData("572000000", "57", "2000000", "Region Zlinsky")]
        [InlineData("579999999", "57", "9999999", "Region Zlinsky")]
        [InlineData("582000000", "58", "2000000", "Region Olomoucky")]
        [InlineData("589999999", "58", "9999999", "Region Olomoucky")]
        [InlineData("592000000", "59", "2000000", "Region Moravskoslezsky")]
        [InlineData("599999999", "59", "9999999", "Region Moravskoslezsky")]
        public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
