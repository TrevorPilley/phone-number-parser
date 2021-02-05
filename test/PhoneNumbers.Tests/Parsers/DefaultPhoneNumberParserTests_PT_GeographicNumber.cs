using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for PT <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_PT_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Portugal);

        [Theory]
        [InlineData("210000000", "210", "000000", "Lisboa")]
        [InlineData("210999999", "210", "999999", "Lisboa")]
        [InlineData("219000000", "219", "000000", "Lisboa")]
        [InlineData("219999999", "219", "999999", "Lisboa")]
        [InlineData("220000000", "220", "000000", "Porto")]
        [InlineData("220999999", "220", "999999", "Porto")]
        [InlineData("229000000", "229", "000000", "Porto")]
        [InlineData("229999999", "229", "999999", "Porto")]
        [InlineData("231000000", "231", "000000", "Mealhada")]
        [InlineData("231999999", "231", "999999", "Mealhada")]
        [InlineData("232000000", "232", "000000", "Viseu")]
        [InlineData("232999999", "232", "999999", "Viseu")]
        [InlineData("233000000", "233", "000000", "Figueira da Foz")]
        [InlineData("233999999", "233", "999999", "Figueira da Foz")]
        [InlineData("234000000", "234", "000000", "Aveiro")]
        [InlineData("234999999", "234", "999999", "Aveiro")]
        [InlineData("235000000", "235", "000000", "Arganil")]
        [InlineData("235999999", "235", "999999", "Arganil")]
        [InlineData("236000000", "236", "000000", "Pombal")]
        [InlineData("236999999", "236", "999999", "Pombal")]
        [InlineData("238000000", "238", "000000", "Seia")]
        [InlineData("238999999", "238", "999999", "Seia")]
        [InlineData("239000000", "239", "000000", "Coimbra")]
        [InlineData("239999999", "239", "999999", "Coimbra")]
        [InlineData("241000000", "241", "000000", "Abrantes")]
        [InlineData("241999999", "241", "999999", "Abrantes")]
        [InlineData("242000000", "242", "000000", "Ponte de Sôr")]
        [InlineData("242999999", "242", "999999", "Ponte de Sôr")]
        [InlineData("243000000", "243", "000000", "Santarém")]
        [InlineData("243999999", "243", "999999", "Santarém")]
        [InlineData("244000000", "244", "000000", "Leiria")]
        [InlineData("244999999", "244", "999999", "Leiria")]
        [InlineData("245000000", "245", "000000", "Portalegre")]
        [InlineData("245999999", "245", "999999", "Portalegre")]
        [InlineData("249000000", "249", "000000", "Torres Novas")]
        [InlineData("249999999", "249", "999999", "Torres Novas")]
        [InlineData("251000000", "251", "000000", "Valença")]
        [InlineData("251999999", "251", "999999", "Valença")]
        [InlineData("252000000", "252", "000000", "Vila Nova de Famalicão")]
        [InlineData("252999999", "252", "999999", "Vila Nova de Famalicão")]
        [InlineData("253000000", "253", "000000", "Braga")]
        [InlineData("253999999", "253", "999999", "Braga")]
        [InlineData("254000000", "254", "000000", "Peso da Régua")]
        [InlineData("254999999", "254", "999999", "Peso da Régua")]
        [InlineData("255000000", "255", "000000", "Penafiel")]
        [InlineData("255999999", "255", "999999", "Penafiel")]
        [InlineData("256000000", "256", "000000", "São João da Madeira")]
        [InlineData("256999999", "256", "999999", "São João da Madeira")]
        [InlineData("257000000", "257", "000000", "Braga")]
        [InlineData("257999999", "257", "999999", "Braga")]
        [InlineData("258000000", "258", "000000", "Viana do Castelo")]
        [InlineData("258999999", "258", "999999", "Viana do Castelo")]
        [InlineData("259000000", "259", "000000", "Vila Real")]
        [InlineData("259999999", "259", "999999", "Vila Real")]
        [InlineData("261000000", "261", "000000", "Torres Vedras")]
        [InlineData("261999999", "261", "999999", "Torres Vedras")]
        [InlineData("262000000", "262", "000000", "Caldas da Rainha")]
        [InlineData("262999999", "262", "999999", "Caldas da Rainha")]
        [InlineData("263000000", "263", "000000", "Vila Franca de Xira")]
        [InlineData("263999999", "263", "999999", "Vila Franca de Xira")]
        [InlineData("265000000", "265", "000000", "Setúbal")]
        [InlineData("265999999", "265", "999999", "Setúbal")]
        [InlineData("266000000", "266", "000000", "Évora")]
        [InlineData("266999999", "266", "999999", "Évora")]
        [InlineData("268000000", "268", "000000", "Estremoz")]
        [InlineData("268999999", "268", "999999", "Estremoz")]
        [InlineData("269000000", "269", "000000", "Santiago do Cacém")]
        [InlineData("269999999", "269", "999999", "Santiago do Cacém")]
        [InlineData("271000000", "271", "000000", "Guarda")]
        [InlineData("271999999", "271", "999999", "Guarda")]
        [InlineData("272000000", "272", "000000", "Castelo Branco")]
        [InlineData("272999999", "272", "999999", "Castelo Branco")]
        [InlineData("273000000", "273", "000000", "Bragança")]
        [InlineData("273999999", "273", "999999", "Bragança")]
        [InlineData("274000000", "274", "000000", "Proença-a-Nova")]
        [InlineData("274999999", "274", "999999", "Proença-a-Nova")]
        [InlineData("275000000", "275", "000000", "Covilhã")]
        [InlineData("275999999", "275", "999999", "Covilhã")]
        [InlineData("276000000", "276", "000000", "Chaves")]
        [InlineData("276999999", "276", "999999", "Chaves")]
        [InlineData("277000000", "277", "000000", "Idanha-a-Nova")]
        [InlineData("277999999", "277", "999999", "Idanha-a-Nova")]
        [InlineData("278000000", "278", "000000", "Mirandela")]
        [InlineData("278999999", "278", "999999", "Mirandela")]
        [InlineData("279000000", "279", "000000", "Moncorvo")]
        [InlineData("279999999", "279", "999999", "Moncorvo")]
        [InlineData("281000000", "281", "000000", "Tavira")]
        [InlineData("281999999", "281", "999999", "Tavira")]
        [InlineData("282000000", "282", "000000", "Portimão")]
        [InlineData("282999999", "282", "999999", "Portimão")]
        [InlineData("283000000", "283", "000000", "Odemira")]
        [InlineData("283999999", "283", "999999", "Odemira")]
        [InlineData("284000000", "284", "000000", "Beja")]
        [InlineData("284999999", "284", "999999", "Beja")]
        [InlineData("285000000", "285", "000000", "Moura")]
        [InlineData("285999999", "285", "999999", "Moura")]
        [InlineData("286000000", "286", "000000", "Castro Verde")]
        [InlineData("286999999", "286", "999999", "Castro Verde")]
        [InlineData("289000000", "289", "000000", "Faro")]
        [InlineData("289999999", "289", "999999", "Faro")]
        [InlineData("291000000", "291", "000000", "Funchal")]
        [InlineData("291999999", "291", "999999", "Funchal")]
        [InlineData("292000000", "292", "000000", "Horta")]
        [InlineData("292999999", "292", "999999", "Horta")]
        [InlineData("295000000", "295", "000000", "Angra do Heroísmo")]
        [InlineData("295999999", "295", "999999", "Angra do Heroísmo")]
        [InlineData("296000000", "296", "000000", "Ponta Delgada")]
        [InlineData("296999999", "296", "999999", "Ponta Delgada")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Portugal, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
