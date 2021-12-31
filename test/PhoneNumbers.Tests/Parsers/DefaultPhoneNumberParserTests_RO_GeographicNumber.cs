using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Romania <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_RO_GeographicNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Romania);

        [Theory]
        [InlineData("0210000", "21", "0000", "Bucharest Municipality and Ilfov county")]
        [InlineData("0219999999", "21", "9999999", "Bucharest Municipality and Ilfov county")]
        public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Romania, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0230000", "230", "000", "Suceava county")]
        [InlineData("0230999999", "230", "999999", "Suceava county")]
        [InlineData("0231000", "231", "000", "Botosani county")]
        [InlineData("0231999999", "231", "999999", "Botosani county")]
        [InlineData("0232000", "232", "000", "Iasi county")]
        [InlineData("0232999999", "232", "999999", "Iasi county")]
        [InlineData("0233000", "233", "000", "Neamt county")]
        [InlineData("0233999999", "233", "999999", "Neamt county")]
        [InlineData("0234000", "234", "000", "Bacau county")]
        [InlineData("0234999999", "234", "999999", "Bacau county")]
        [InlineData("0235000", "235", "000", "Vaslui county")]
        [InlineData("0235999999", "235", "999999", "Vaslui county")]
        [InlineData("0236000", "236", "000", "Galati county")]
        [InlineData("0236999999", "236", "999999", "Galati county")]
        [InlineData("0237000", "237", "000", "Vrancea county")]
        [InlineData("0237999999", "237", "999999", "Vrancea county")]
        [InlineData("0238000", "238", "000", "Buzau county")]
        [InlineData("0238999999", "238", "999999", "Buzau county")]
        [InlineData("0239000", "239", "000", "Braila county")]
        [InlineData("0239999999", "239", "999999", "Braila county")]
        [InlineData("0240000", "240", "000", "Tulcea county")]
        [InlineData("0240999999", "240", "999999", "Tulcea county")]
        [InlineData("0241000", "241", "000", "Constanta county")]
        [InlineData("0241999999", "241", "999999", "Constanta county")]
        [InlineData("0242000", "242", "000", "Calarasi county")]
        [InlineData("0242999999", "242", "999999", "Calarasi county")]
        [InlineData("0243000", "243", "000", "Ialomita county")]
        [InlineData("0243999999", "243", "999999", "Ialomita county")]
        [InlineData("0244000", "244", "000", "Prahova county")]
        [InlineData("0244999999", "244", "999999", "Prahova county")]
        [InlineData("0245000", "245", "000", "Dambovita county")]
        [InlineData("0245999999", "245", "999999", "Dambovita county")]
        [InlineData("0246000", "246", "000", "Giurgiu county")]
        [InlineData("0246999999", "246", "999999", "Giurgiu county")]
        [InlineData("0247000", "247", "000", "Teleorman county")]
        [InlineData("0247999999", "247", "999999", "Teleorman county")]
        [InlineData("0248000", "248", "000", "Arges county")]
        [InlineData("0248999999", "248", "999999", "Arges county")]
        [InlineData("0249000", "249", "000", "Olt county")]
        [InlineData("0249999999", "249", "999999", "Olt county")]
        [InlineData("0250000", "250", "000", "Valcea county")]
        [InlineData("0250999999", "250", "999999", "Valcea county")]
        [InlineData("0251000", "251", "000", "Dolj county")]
        [InlineData("0251999999", "251", "999999", "Dolj county")]
        [InlineData("0252000", "252", "000", "Mehedinti county")]
        [InlineData("0252999999", "252", "999999", "Mehedinti county")]
        [InlineData("0253000", "253", "000", "Gorj county")]
        [InlineData("0253999999", "253", "999999", "Gorj county")]
        [InlineData("0254000", "254", "000", "Hunedoara county")]
        [InlineData("0254999999", "254", "999999", "Hunedoara county")]
        [InlineData("0255000", "255", "000", "Caras–Severin county")]
        [InlineData("0255999999", "255", "999999", "Caras–Severin county")]
        [InlineData("0256000", "256", "000", "Timis county")]
        [InlineData("0256999999", "256", "999999", "Timis county")]
        [InlineData("0257000", "257", "000", "Arad county")]
        [InlineData("0257999999", "257", "999999", "Arad county")]
        [InlineData("0258000", "258", "000", "Alba county")]
        [InlineData("0258999999", "258", "999999", "Alba county")]
        [InlineData("0259000", "259", "000", "Bihor county")]
        [InlineData("0259999999", "259", "999999", "Bihor county")]
        [InlineData("0260000", "260", "000", "Salaj county")]
        [InlineData("0260999999", "260", "999999", "Salaj county")]
        [InlineData("0261000", "261", "000", "Satu Mare county")]
        [InlineData("0261999999", "261", "999999", "Satu Mare county")]
        [InlineData("0262000", "262", "000", "Maramures county")]
        [InlineData("0262999999", "262", "999999", "Maramures county")]
        [InlineData("0263000", "263", "000", "Bistrita–Nasaud county")]
        [InlineData("0263999999", "263", "999999", "Bistrita–Nasaud county")]
        [InlineData("0264000", "264", "000", "Cluj county")]
        [InlineData("0264999999", "264", "999999", "Cluj county")]
        [InlineData("0265000", "265", "000", "Mures county")]
        [InlineData("0265999999", "265", "999999", "Mures county")]
        [InlineData("0266000", "266", "000", "Harghita county")]
        [InlineData("0266999999", "266", "999999", "Harghita county")]
        [InlineData("0267000", "267", "000", "Covasna county")]
        [InlineData("0267999999", "267", "999999", "Covasna county")]
        [InlineData("0268000", "268", "000", "Brasov county")]
        [InlineData("0268999999", "268", "999999", "Brasov county")]
        [InlineData("0269000", "269", "000", "Sibiu county")]
        [InlineData("0269999999", "269", "999999", "Sibiu county")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Romania, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0330000", "330", "000", "Suceava county")]
        [InlineData("0330999999", "330", "999999", "Suceava county")]
        [InlineData("0331000", "331", "000", "Botosani county")]
        [InlineData("0331999999", "331", "999999", "Botosani county")]
        [InlineData("0332000", "332", "000", "Iasi county")]
        [InlineData("0332999999", "332", "999999", "Iasi county")]
        [InlineData("0333000", "333", "000", "Neamt county")]
        [InlineData("0333999999", "333", "999999", "Neamt county")]
        [InlineData("0334000", "334", "000", "Bacau county")]
        [InlineData("0334999999", "334", "999999", "Bacau county")]
        [InlineData("0335000", "335", "000", "Vaslui county")]
        [InlineData("0335999999", "335", "999999", "Vaslui county")]
        [InlineData("0336000", "336", "000", "Galati county")]
        [InlineData("0336999999", "336", "999999", "Galati county")]
        [InlineData("0337000", "337", "000", "Vrancea county")]
        [InlineData("0337999999", "337", "999999", "Vrancea county")]
        [InlineData("0338000", "338", "000", "Buzau county")]
        [InlineData("0338999999", "338", "999999", "Buzau county")]
        [InlineData("0339000", "339", "000", "Braila county")]
        [InlineData("0339999999", "339", "999999", "Braila county")]
        [InlineData("0340000", "340", "000", "Tulcea county")]
        [InlineData("0340999999", "340", "999999", "Tulcea county")]
        [InlineData("0341000", "341", "000", "Constanta county")]
        [InlineData("0341999999", "341", "999999", "Constanta county")]
        [InlineData("0342000", "342", "000", "Calarasi county")]
        [InlineData("0342999999", "342", "999999", "Calarasi county")]
        [InlineData("0343000", "343", "000", "Ialomita county")]
        [InlineData("0343999999", "343", "999999", "Ialomita county")]
        [InlineData("0344000", "344", "000", "Prahova county")]
        [InlineData("0344999999", "344", "999999", "Prahova county")]
        [InlineData("0345000", "345", "000", "Dambovita county")]
        [InlineData("0345999999", "345", "999999", "Dambovita county")]
        [InlineData("0346000", "346", "000", "Giurgiu county")]
        [InlineData("0346999999", "346", "999999", "Giurgiu county")]
        [InlineData("0347000", "347", "000", "Teleorman county")]
        [InlineData("0347999999", "347", "999999", "Teleorman county")]
        [InlineData("0348000", "348", "000", "Arges county")]
        [InlineData("0348999999", "348", "999999", "Arges county")]
        [InlineData("0349000", "349", "000", "Olt county")]
        [InlineData("0349999999", "349", "999999", "Olt county")]
        [InlineData("0350000", "350", "000", "Valcea county")]
        [InlineData("0350999999", "350", "999999", "Valcea county")]
        [InlineData("0351000", "351", "000", "Dolj county")]
        [InlineData("0351999999", "351", "999999", "Dolj county")]
        [InlineData("0352000", "352", "000", "Mehedinti county")]
        [InlineData("0352999999", "352", "999999", "Mehedinti county")]
        [InlineData("0353000", "353", "000", "Gorj county")]
        [InlineData("0353999999", "353", "999999", "Gorj county")]
        [InlineData("0354000", "354", "000", "Hunedoara county")]
        [InlineData("0354999999", "354", "999999", "Hunedoara county")]
        [InlineData("0355000", "355", "000", "Caras–Severin county")]
        [InlineData("0355999999", "355", "999999", "Caras–Severin county")]
        [InlineData("0356000", "356", "000", "Timis county")]
        [InlineData("0356999999", "356", "999999", "Timis county")]
        [InlineData("0357000", "357", "000", "Arad county")]
        [InlineData("0357999999", "357", "999999", "Arad county")]
        [InlineData("0358000", "358", "000", "Alba county")]
        [InlineData("0358999999", "358", "999999", "Alba county")]
        [InlineData("0359000", "359", "000", "Bihor county")]
        [InlineData("0359999999", "359", "999999", "Bihor county")]
        [InlineData("0360000", "360", "000", "Salaj county")]
        [InlineData("0360999999", "360", "999999", "Salaj county")]
        [InlineData("0361000", "361", "000", "Satu Mare county")]
        [InlineData("0361999999", "361", "999999", "Satu Mare county")]
        [InlineData("0362000", "362", "000", "Maramures county")]
        [InlineData("0362999999", "362", "999999", "Maramures county")]
        [InlineData("0363000", "363", "000", "Bistrita–Nasaud county")]
        [InlineData("0363999999", "363", "999999", "Bistrita–Nasaud county")]
        [InlineData("0364000", "364", "000", "Cluj county")]
        [InlineData("0364999999", "364", "999999", "Cluj county")]
        [InlineData("0365000", "365", "000", "Mures county")]
        [InlineData("0365999999", "365", "999999", "Mures county")]
        [InlineData("0366000", "366", "000", "Harghita county")]
        [InlineData("0366999999", "366", "999999", "Harghita county")]
        [InlineData("0367000", "367", "000", "Covasna county")]
        [InlineData("0367999999", "367", "999999", "Covasna county")]
        [InlineData("0368000", "368", "000", "Brasov county")]
        [InlineData("0368999999", "368", "999999", "Brasov county")]
        [InlineData("0369000", "369", "000", "Sibiu county")]
        [InlineData("0369999999", "369", "999999", "Sibiu county")]
        public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Romania, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
