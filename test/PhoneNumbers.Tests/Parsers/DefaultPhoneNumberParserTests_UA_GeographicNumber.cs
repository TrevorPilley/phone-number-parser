using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Ukraine <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_UA_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Ukraine);

        [Theory]
        [InlineData("0310000000", "31", "0000000", "Zakarpattia region")]
        [InlineData("0319999999", "31", "9999999", "Zakarpattia region")]
        [InlineData("0320000000", "32", "0000000", "Lviv region")]
        [InlineData("0329999999", "32", "9999999", "Lviv region")]
        [InlineData("0330000000", "33", "0000000", "Volyn region")]
        [InlineData("0339999999", "33", "9999999", "Volyn region")]
        [InlineData("0340000000", "34", "0000000", "Ivano-Frankivsk region")]
        [InlineData("0349999999", "34", "9999999", "Ivano-Frankivsk region")]
        [InlineData("0350000000", "35", "0000000", "Ternopil region")]
        [InlineData("0359999999", "35", "9999999", "Ternopil region")]
        [InlineData("0360000000", "36", "0000000", "Rivne region")]
        [InlineData("0369999999", "36", "9999999", "Rivne region")]
        [InlineData("0370000000", "37", "0000000", "Chernivtsi region")]
        [InlineData("0379999999", "37", "9999999", "Chernivtsi region")]
        [InlineData("0380000000", "38", "0000000", "Khmelnytskyi region")]
        [InlineData("0389999999", "38", "9999999", "Khmelnytskyi region")]
        public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Ukraine, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0410000000", "41", "0000000", "Zhytomyr region")]
        [InlineData("0419999999", "41", "9999999", "Zhytomyr region")]
        [InlineData("0430000000", "43", "0000000", "Vinnytsia region")]
        [InlineData("0439999999", "43", "9999999", "Vinnytsia region")]
        [InlineData("0440000000", "44", "0000000", "Kyiv city")]
        [InlineData("0449999999", "44", "9999999", "Kyiv city")]
        [InlineData("0450000000", "45", "0000000", "Kyiv region")]
        [InlineData("0459999999", "45", "9999999", "Kyiv region")]
        [InlineData("0460000000", "46", "0000000", "Chernihiv region")]
        [InlineData("0469999999", "46", "9999999", "Chernihiv region")]
        [InlineData("0470000000", "47", "0000000", "Cherkasy region")]
        [InlineData("0479999999", "47", "9999999", "Cherkasy region")]
        [InlineData("0480000000", "48", "0000000", "Odesa region")]
        [InlineData("0489999999", "48", "9999999", "Odesa region")]
        public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Ukraine, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0510000000", "51", "0000000", "Mykolayiv region")]
        [InlineData("0519999999", "51", "9999999", "Mykolayiv region")]
        [InlineData("0520000000", "52", "0000000", "Kirovohrad region")]
        [InlineData("0529999999", "52", "9999999", "Kirovohrad region")]
        [InlineData("0530000000", "53", "0000000", "Poltava region")]
        [InlineData("0539999999", "53", "9999999", "Poltava region")]
        [InlineData("0540000000", "54", "0000000", "Sumy region")]
        [InlineData("0549999999", "54", "9999999", "Sumy region")]
        [InlineData("0550000000", "55", "0000000", "Kherson region")]
        [InlineData("0559999999", "55", "9999999", "Kherson region")]
        [InlineData("0560000000", "56", "0000000", "Dnipropetrovsk region")]
        [InlineData("0569999999", "56", "9999999", "Dnipropetrovsk region")]
        [InlineData("0570000000", "57", "0000000", "Kharkiv region")]
        [InlineData("0579999999", "57", "9999999", "Kharkiv region")]
        public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Ukraine, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0610000000", "61", "0000000", "Zaporizhzhia region")]
        [InlineData("0619999999", "61", "9999999", "Zaporizhzhia region")]
        [InlineData("0620000000", "62", "0000000", "Donetsk region")]
        [InlineData("0629999999", "62", "9999999", "Donetsk region")]
        [InlineData("0640000000", "64", "0000000", "Luhansk region")]
        [InlineData("0649999999", "64", "9999999", "Luhansk region")]
        [InlineData("0650000000", "65", "0000000", "Crimea region")]
        [InlineData("0659999999", "65", "9999999", "Crimea region")]
        [InlineData("0690000000", "69", "0000000", "Sevastopol region")]
        [InlineData("0699999999", "69", "9999999", "Sevastopol region")]
        public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Ukraine, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
