namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Gibraltar <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_GI_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Gibraltar);

        [Theory]
        [InlineData("20000000", "200", "00000", "Gibraltar")]
        [InlineData("20049999", "200", "49999", "Gibraltar")]
        [InlineData("20050000", "200", "50000", "Gibraltar")]
        [InlineData("20050999", "200", "50999", "Gibraltar")]
        [InlineData("20051000", "200", "51000", "Gibraltar")]
        [InlineData("20051999", "200", "51999", "Gibraltar")]
        [InlineData("20052000", "200", "52000", "Gibraltar")]
        [InlineData("20052999", "200", "52999", "Gibraltar")]
        [InlineData("20053000", "200", "53000", "Gibraltar")]
        [InlineData("20053999", "200", "53999", "Gibraltar")]
        [InlineData("20054000", "200", "54000", "Gibraltar")]
        [InlineData("20054999", "200", "54999", "Gibraltar")]
        [InlineData("20055000", "200", "55000", "Gibraltar")]
        [InlineData("20055999", "200", "55999", "Gibraltar")]
        [InlineData("20056000", "200", "56000", "Gibraltar")]
        [InlineData("20056999", "200", "56999", "Gibraltar")]
        [InlineData("20057000", "200", "57000", "Gibraltar")]
        [InlineData("20057999", "200", "57999", "Gibraltar")]
        [InlineData("20058000", "200", "58000", "Gibraltar")]
        [InlineData("20058999", "200", "58999", "Gibraltar")]
        [InlineData("20059000", "200", "59000", "Gibraltar")]
        [InlineData("20059999", "200", "59999", "Gibraltar")]
        [InlineData("20060000", "200", "60000", "Gibraltar")]
        [InlineData("20099999", "200", "99999", "Gibraltar")]
        [InlineData("21600000", "216", "00000", "Gibraltar")]
        [InlineData("21699999", "216", "99999", "Gibraltar")]
        [InlineData("22200000", "222", "00000", "Gibraltar")]
        [InlineData("22299999", "222", "99999", "Gibraltar")]
        [InlineData("22500000", "225", "00000", "Gibraltar")]
        [InlineData("22599999", "225", "99999", "Gibraltar")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Gibraltar, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
