using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for CH <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CH_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Switzerland);

        [Theory]
        [InlineData("0210000000", "21", "0000000", "Lausanne")]
        [InlineData("0219999999", "21", "9999999", "Lausanne")]
        [InlineData("0220000000", "22", "0000000", "Genève")]
        [InlineData("0229999999", "22", "9999999", "Genève")]
        [InlineData("0240000000", "24", "0000000", "Yverdon / Aigle")]
        [InlineData("0249999999", "24", "9999999", "Yverdon / Aigle")]
        [InlineData("0260000000", "26", "0000000", "Fribourg")]
        [InlineData("0269999999", "26", "9999999", "Fribourg")]
        [InlineData("0270000000", "27", "0000000", "Sion")]
        [InlineData("0279999999", "27", "9999999", "Sion")]
        public void Parse_Known_GeographicPhoneNumber_2X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0310000000", "31", "0000000", "Bern")]
        [InlineData("0319999999", "31", "9999999", "Bern")]
        [InlineData("0320000000", "32", "0000000", "Beil")]
        [InlineData("0329999999", "32", "9999999", "Beil")]
        [InlineData("0330000000", "33", "0000000", "Thun")]
        [InlineData("0339999999", "33", "9999999", "Thun")]
        [InlineData("0340000000", "34", "0000000", "Nurgdorf")]
        [InlineData("0349999999", "34", "9999999", "Nurgdorf")]
        public void Parse_Known_GeographicPhoneNumber_3X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0410000000", "41", "0000000", "Luzern")]
        [InlineData("0419999999", "41", "9999999", "Luzern")]
        [InlineData("0430000000", "43", "0000000", "Zürich")]
        [InlineData("0439999999", "43", "9999999", "Zürich")]
        [InlineData("0440000000", "44", "0000000", "Zürich")]
        [InlineData("0449999999", "44", "9999999", "Zürich")]
        public void Parse_Known_GeographicPhoneNumber_4X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0520000000", "52", "0000000", "Winterthur")]
        [InlineData("0529999999", "52", "9999999", "Winterthur")]
        [InlineData("0550000000", "55", "0000000", "Rapperswil")]
        [InlineData("0559999999", "55", "9999999", "Rapperswil")]
        [InlineData("0560000000", "56", "0000000", "Baden")]
        [InlineData("0569999999", "56", "9999999", "Baden")]
        public void Parse_Known_GeographicPhoneNumber_5X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0610000000", "61", "0000000", "Basel")]
        [InlineData("0619999999", "61", "9999999", "Basel")]
        [InlineData("0620000000", "62", "0000000", "Olten")]
        [InlineData("0629999999", "62", "9999999", "Olten")]
        public void Parse_Known_GeographicPhoneNumber_6X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0710000000", "71", "0000000", "St. Gallen")]
        [InlineData("0719999999", "71", "9999999", "St. Gallen")]
        public void Parse_Known_GeographicPhoneNumber_7X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0810000000", "81", "0000000", "Chur")]
        [InlineData("0819999999", "81", "9999999", "Chur")]
        public void Parse_Known_GeographicPhoneNumber_8X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0910000000", "91", "0000000", "Bellinzona")]
        [InlineData("0919999999", "91", "9999999", "Bellinzona")]
        public void Parse_Known_GeographicPhoneNumber_9X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }
    }
}
