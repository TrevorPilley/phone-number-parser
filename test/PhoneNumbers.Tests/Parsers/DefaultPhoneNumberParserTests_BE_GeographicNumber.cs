namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Belgium <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_BE_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Belgium);

        [Theory]
        [InlineData("010000000", "10", "000000", "Wavre")]
        [InlineData("010999999", "10", "999999", "Wavre")]
        [InlineData("011000000", "11", "000000", "Hasselt")]
        [InlineData("011999999", "11", "999999", "Hasselt")]
        [InlineData("012000000", "12", "000000", "Tongeren")]
        [InlineData("012999999", "12", "999999", "Tongeren")]
        [InlineData("013000000", "13", "000000", "Diest")]
        [InlineData("013999999", "13", "999999", "Diest")]
        [InlineData("014000000", "14", "000000", "Geel, Herentals, Turnhout")]
        [InlineData("014999999", "14", "999999", "Geel, Herentals, Turnhout")]
        [InlineData("015000000", "15", "000000", "Mechelen")]
        [InlineData("015999999", "15", "999999", "Mechelen")]
        [InlineData("016000000", "16", "000000", "Leuven, Tienen")]
        [InlineData("016999999", "16", "999999", "Leuven, Tienen")]
        [InlineData("019000000", "19", "000000", "Waremme")]
        [InlineData("019999999", "19", "999999", "Waremme")]
        public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("022000000", "2", "2000000", "Brussels")]
        [InlineData("028999999", "2", "8999999", "Brussels")]
        public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("032000000", "3", "2000000", "Antwerp, Sint-Niklaas")]
        [InlineData("038999999", "3", "8999999", "Antwerp, Sint-Niklaas")]
        public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("042000000", "4", "2000000", "Liège, Voeren")]
        [InlineData("043999999", "4", "3999999", "Liège, Voeren")]
        public void Parse_Known_GeographicPhoneNumber_4_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("050000000", "50", "000000", "Bruges, Zeebrugge")]
        [InlineData("050999999", "50", "999999", "Bruges, Zeebrugge")]
        [InlineData("051000000", "51", "000000", "Roeselare")]
        [InlineData("051999999", "51", "999999", "Roeselare")]
        [InlineData("052000000", "52", "000000", "Dendermonde")]
        [InlineData("052999999", "52", "999999", "Dendermonde")]
        [InlineData("053000000", "53", "000000", "Aalst")]
        [InlineData("053999999", "53", "999999", "Aalst")]
        [InlineData("054000000", "54", "000000", "Ninove")]
        [InlineData("054999999", "54", "999999", "Ninove")]
        [InlineData("055000000", "55", "000000", "Ronse")]
        [InlineData("055999999", "55", "999999", "Ronse")]
        [InlineData("056000000", "56", "000000", "Kortrijk, Comines-Warneton, Mouscron")]
        [InlineData("056999999", "56", "999999", "Kortrijk, Comines-Warneton, Mouscron")]
        [InlineData("057000000", "57", "000000", "Ypres")]
        [InlineData("057999999", "57", "999999", "Ypres")]
        [InlineData("058000000", "58", "000000", "Veurne")]
        [InlineData("058999999", "58", "999999", "Veurne")]
        [InlineData("059000000", "59", "000000", "Ostend, Bredene, Gistel")]
        [InlineData("059999999", "59", "999999", "Ostend, Bredene, Gistel")]
        public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("060000000", "60", "000000", "Chimay")]
        [InlineData("060999999", "60", "999999", "Chimay")]
        [InlineData("061000000", "61", "000000", "Bastogne, Libramont-Chevigny")]
        [InlineData("061999999", "61", "999999", "Bastogne, Libramont-Chevigny")]
        [InlineData("063000000", "63", "000000", "Arlon")]
        [InlineData("063999999", "63", "999999", "Arlon")]
        [InlineData("064000000", "64", "000000", "La Louvière")]
        [InlineData("064999999", "64", "999999", "La Louvière")]
        [InlineData("065000000", "65", "000000", "Mons, Casteau")]
        [InlineData("065999999", "65", "999999", "Mons, Casteau")]
        [InlineData("067000000", "67", "000000", "Nivelles, Soignies")]
        [InlineData("067999999", "67", "999999", "Nivelles, Soignies")]
        [InlineData("068000000", "68", "000000", "Ath")]
        [InlineData("068999999", "68", "999999", "Ath")]
        [InlineData("069000000", "69", "000000", "Tournai")]
        [InlineData("069999999", "69", "999999", "Tournai")]
        public void Parse_Known_GeographicPhoneNumber_6X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("071000000", "71", "000000", "Charleroi")]
        [InlineData("071999999", "71", "999999", "Charleroi")]
        public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("080100000", "80", "100000", "Stavelot")]
        [InlineData("080999999", "80", "999999", "Stavelot")]
        [InlineData("081000000", "81", "000000", "Namur")]
        [InlineData("081999999", "81", "999999", "Namur")]
        [InlineData("082000000", "82", "000000", "Dinant")]
        [InlineData("082999999", "82", "999999", "Dinant")]
        [InlineData("083000000", "83", "000000", "Ciney")]
        [InlineData("083999999", "83", "999999", "Ciney")]
        [InlineData("084000000", "84", "000000", "Marche-en-Famenne")]
        [InlineData("084999999", "84", "999999", "Marche-en-Famenne")]
        [InlineData("085000000", "85", "000000", "Huy")]
        [InlineData("085999999", "85", "999999", "Huy")]
        [InlineData("086000000", "86", "000000", "Durbuy")]
        [InlineData("086999999", "86", "999999", "Durbuy")]
        [InlineData("087000000", "87", "000000", "Verviers")]
        [InlineData("087999999", "87", "999999", "Verviers")]
        [InlineData("089000000", "89", "000000", "Genk")]
        [InlineData("089999999", "89", "999999", "Genk")]
        public void Parse_Known_GeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("092000000", "9", "2000000", "Ghent")]
        [InlineData("094999999", "9", "4999999", "Ghent")]
        public void Parse_Known_GeographicPhoneNumber_9_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Belgium, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
