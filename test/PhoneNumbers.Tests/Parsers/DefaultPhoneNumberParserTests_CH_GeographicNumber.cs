using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Switzerland <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CH_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Switzerland);

        [Theory]
        [InlineData("0212100000", "21", "2100000", "Lausanne")]
        [InlineData("0219999999", "21", "9999999", "Lausanne")]
        [InlineData("0223000000", "22", "3000000", "Genève")]
        [InlineData("0229999999", "22", "9999999", "Genève")]
        [InlineData("0244200000", "24", "4200000", "Yverdon / Aigle")]
        [InlineData("0245889999", "24", "5889999", "Yverdon / Aigle")]
        [InlineData("0263000000", "26", "3000000", "Fribourg")]
        [InlineData("0269299999", "26", "9299999", "Fribourg")]
        [InlineData("0272020000", "27", "2020000", "Valais")]
        [InlineData("0279799999", "27", "9799999", "Valais")]
        public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0313000000", "31", "3000000", "Bern")]
        [InlineData("0319989999", "31", "9989999", "Bern")]
        [InlineData("0323100000", "32", "3100000", "Biel/Bienne, Neuchâtel, Solothurn, Jura")]
        [InlineData("0329699999", "32", "9699999", "Biel/Bienne, Neuchâtel, Solothurn, Jura")]
        [InlineData("0332210000", "33", "2210000", "Bernese Oberland")]
        [InlineData("0339829999", "33", "9829999", "Bernese Oberland")]
        [InlineData("0344000000", "34", "4000000", "Bern-Emme")]
        [InlineData("0345889999", "34", "5889999", "Bern-Emme")]
        public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0412000000", "41", "2000000", "Luzern, Zug")]
        [InlineData("0419899999", "41", "9899999", "Luzern, Zug")]
        [InlineData("0432000000", "43", "2000000", "Zürich")]
        [InlineData("0439999999", "43", "9999999", "Zürich")]
        [InlineData("0442000000", "44", "2000000", "Zürich")]
        [InlineData("0449999999", "44", "9999999", "Zürich")]
        public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0522020000", "52", "2020000", "Winterthur, Schaffhausen")]
        [InlineData("0527779999", "52", "7779999", "Winterthur, Schaffhausen")]
        [InlineData("0552100000", "55", "2100000", "Rapperswil")]
        [InlineData("0556549999", "55", "6549999", "Rapperswil")]
        [InlineData("0562000000", "56", "2000000", "Baden, Zurzach")]
        [InlineData("0566789999", "56", "6789999", "Baden, Zurzach")]
        public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0612000000", "61", "2000000", "Basel")]
        [InlineData("0619999999", "61", "9999999", "Basel")]
        [InlineData("0622000000", "62", "2000000", "Olten-Langenthal(Oberaargau)-Aargau-West")]
        [InlineData("0629689999", "62", "9689999", "Olten-Langenthal(Oberaargau)-Aargau-West")]
        public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0712200000", "71", "2200000", "St. Gallen")]
        [InlineData("0719999999", "71", "9999999", "St. Gallen")]
        public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0812500000", "81", "2500000", "Chur")]
        [InlineData("0819499999", "81", "9499999", "Chur")]
        public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0912000000", "91", "2000000", "Ticino, Moesa")]
        [InlineData("0919999999", "91", "9999999", "Ticino, Moesa")]
        public void Parse_Known_GeographicPhoneNumber_9X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
