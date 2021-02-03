using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for NL <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_NL_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Netherlands);

        [Theory]
        [InlineData("0100000000", "10", "0000000", "Rotterdam")]
        [InlineData("0109999999", "10", "9999999", "Rotterdam")]
        [InlineData("0130000000", "13", "0000000", "Tilburg")]
        [InlineData("0139999999", "13", "9999999", "Tilburg")]
        [InlineData("0150000000", "15", "0000000", "Delft")]
        [InlineData("0159999999", "15", "9999999", "Delft")]
        public void Parse_Known_GeographicPhoneNumber_1X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0111000000", "111", "000000", "Zierikzee")]
        [InlineData("0111999999", "111", "999999", "Zierikzee")]
        [InlineData("0113000000", "113", "000000", "Goes")]
        [InlineData("0113999999", "113", "999999", "Goes")]
        [InlineData("0114000000", "114", "000000", "Hulst")]
        [InlineData("0114999999", "114", "999999", "Hulst")]
        [InlineData("0115000000", "115", "000000", "Terneuzen")]
        [InlineData("0115999999", "115", "999999", "Terneuzen")]
        [InlineData("0117000000", "117", "000000", "Sluis")]
        [InlineData("0117999999", "117", "999999", "Sluis")]
        [InlineData("0118000000", "118", "000000", "Middelburg")]
        [InlineData("0118999999", "118", "999999", "Middelburg")]
        [InlineData("0161000000", "161", "000000", "Gilze-Rijen")]
        [InlineData("0161999999", "161", "999999", "Gilze-Rijen")]
        [InlineData("0162000000", "162", "000000", "Oosterhout")]
        [InlineData("0162999999", "162", "999999", "Oosterhout")]
        [InlineData("0164000000", "164", "000000", "Bergen op Zoom")]
        [InlineData("0164999999", "164", "999999", "Bergen op Zoom")]
        [InlineData("0165000000", "165", "000000", "Roosendaal")]
        [InlineData("0165999999", "165", "999999", "Roosendaal")]
        [InlineData("0166000000", "166", "000000", "Tholen")]
        [InlineData("0166999999", "166", "999999", "Tholen")]
        [InlineData("0167000000", "167", "000000", "Steenbergen")]
        [InlineData("0167999999", "167", "999999", "Steenbergen")]
        [InlineData("0168000000", "168", "000000", "Zevenbergen")]
        [InlineData("0168999999", "168", "999999", "Zevenbergen")]
        [InlineData("0172000000", "172", "000000", "Alphen aan den Rijn")]
        [InlineData("0172999999", "172", "999999", "Alphen aan den Rijn")]
        [InlineData("0174000000", "174", "000000", "Naaldwijk")]
        [InlineData("0174999999", "174", "999999", "Naaldwijk")]
        [InlineData("0180000000", "180", "000000", "Ridderkerk and Zuidplas")]
        [InlineData("0180999999", "180", "999999", "Ridderkerk and Zuidplas")]
        [InlineData("0181000000", "181", "000000", "Spijkenisse")]
        [InlineData("0181999999", "181", "999999", "Spijkenisse")]
        [InlineData("0182000000", "182", "000000", "Gouda")]
        [InlineData("0182999999", "182", "999999", "Gouda")]
        [InlineData("0183000000", "183", "000000", "Gorinchem")]
        [InlineData("0183999999", "183", "999999", "Gorinchem")]
        [InlineData("0184000000", "184", "000000", "Sliedrecht")]
        [InlineData("0184999999", "184", "999999", "Sliedrecht")]
        [InlineData("0186000000", "186", "000000", "Oud-Beijerland")]
        [InlineData("0186999999", "186", "999999", "Oud-Beijerland")]
        [InlineData("0187000000", "187", "000000", "Middelharnis")]
        [InlineData("0187999999", "187", "999999", "Middelharnis")]
        public void Parse_Known_GeographicPhoneNumber_1XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0200000000", "20", "0000000", "Amsterdam")]
        [InlineData("0209999999", "20", "9999999", "Amsterdam")]
        [InlineData("0230000000", "23", "0000000", "Haarlem")]
        [InlineData("0239999999", "23", "9999999", "Haarlem")]
        [InlineData("0240000000", "24", "0000000", "Nijmegen")]
        [InlineData("0249999999", "24", "9999999", "Nijmegen")]
        [InlineData("0260000000", "26", "0000000", "Arnhem")]
        [InlineData("0269999999", "26", "9999999", "Arnhem")]
        public void Parse_Known_GeographicPhoneNumber_2X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0222000000", "222", "000000", "Texel")]
        [InlineData("0222999999", "222", "999999", "Texel")]
        [InlineData("0223000000", "223", "000000", "Den Helder")]
        [InlineData("0223999999", "223", "999999", "Den Helder")]
        [InlineData("0224000000", "224", "000000", "Schagen")]
        [InlineData("0224999999", "224", "999999", "Schagen")]
        [InlineData("0226000000", "226", "000000", "Harenkarspel")]
        [InlineData("0226999999", "226", "999999", "Harenkarspel")]
        [InlineData("0227000000", "227", "000000", "Medemblik")]
        [InlineData("0227999999", "227", "999999", "Medemblik")]
        [InlineData("0228000000", "228", "000000", "Enkhuizen")]
        [InlineData("0228999999", "228", "999999", "Enkhuizen")]
        [InlineData("0229000000", "229", "000000", "Hoorn")]
        [InlineData("0229999999", "229", "999999", "Hoorn")]
        [InlineData("0251000000", "251", "000000", "Beverwijk")]
        [InlineData("0251999999", "251", "999999", "Beverwijk")]
        [InlineData("0252000000", "252", "000000", "Hillegom")]
        [InlineData("0252999999", "252", "999999", "Hillegom")]
        [InlineData("0255000000", "255", "000000", "IJmuiden")]
        [InlineData("0255999999", "255", "999999", "IJmuiden")]
        [InlineData("0294000000", "294", "000000", "Weesp")]
        [InlineData("0294999999", "294", "999999", "Weesp")]
        [InlineData("0297000000", "297", "000000", "Aalsmeer")]
        [InlineData("0297999999", "297", "999999", "Aalsmeer")]
        [InlineData("0299000000", "299", "000000", "Purmerend")]
        [InlineData("0299999999", "299", "999999", "Purmerend")]
        public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0300000000", "30", "0000000", "Utrecht")]
        [InlineData("0309999999", "30", "9999999", "Utrecht")]
        [InlineData("0330000000", "33", "0000000", "Amersfoort")]
        [InlineData("0339999999", "33", "9999999", "Amersfoort")]
        [InlineData("0350000000", "35", "0000000", "Hilversum")]
        [InlineData("0359999999", "35", "9999999", "Hilversum")]
        [InlineData("0360000000", "36", "0000000", "Almere")]
        [InlineData("0369999999", "36", "9999999", "Almere")]
        [InlineData("0380000000", "38", "0000000", "Zwolle")]
        [InlineData("0389999999", "38", "9999999", "Zwolle")]
        public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0313000000", "313", "000000", "Dieren")]
        [InlineData("0313999999", "313", "999999", "Dieren")]
        [InlineData("0314000000", "314", "000000", "Doetinchem")]
        [InlineData("0314999999", "314", "999999", "Doetinchem")]
        [InlineData("0315000000", "315", "000000", "Terborg")]
        [InlineData("0315999999", "315", "999999", "Terborg")]
        [InlineData("0316000000", "316", "000000", "Zevenaar")]
        [InlineData("0316999999", "316", "999999", "Zevenaar")]
        [InlineData("0317000000", "317", "000000", "Wageningen")]
        [InlineData("0317999999", "317", "999999", "Wageningen")]
        [InlineData("0318000000", "318", "000000", "Ede / Veenendaal")]
        [InlineData("0318999999", "318", "999999", "Ede / Veenendaal")]
        [InlineData("0320000000", "320", "000000", "Lelystad")]
        [InlineData("0320999999", "320", "999999", "Lelystad")]
        [InlineData("0321000000", "321", "000000", "Dronten")]
        [InlineData("0321999999", "321", "999999", "Dronten")]
        [InlineData("0341000000", "341", "000000", "Harderwijk")]
        [InlineData("0341999999", "341", "999999", "Harderwijk")]
        [InlineData("0342000000", "342", "000000", "Barneveld")]
        [InlineData("0342999999", "342", "999999", "Barneveld")]
        [InlineData("0343000000", "343", "000000", "Doorn")]
        [InlineData("0343999999", "343", "999999", "Doorn")]
        [InlineData("0344000000", "344", "000000", "Tiel")]
        [InlineData("0344999999", "344", "999999", "Tiel")]
        [InlineData("0345000000", "345", "000000", "Culemborg")]
        [InlineData("0345999999", "345", "999999", "Culemborg")]
        [InlineData("0346000000", "346", "000000", "Maarssen")]
        [InlineData("0346999999", "346", "999999", "Maarssen")]
        [InlineData("0347000000", "347", "000000", "Vianen")]
        [InlineData("0347999999", "347", "999999", "Vianen")]
        [InlineData("0348000000", "348", "000000", "Woerden")]
        [InlineData("0348999999", "348", "999999", "Woerden")]
        public void Parse_Known_GeographicPhoneNumber_3XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0400000000", "40", "0000000", "Eindhoven")]
        [InlineData("0409999999", "40", "9999999", "Eindhoven")]
        [InlineData("0430000000", "43", "0000000", "Maastricht")]
        [InlineData("0439999999", "43", "9999999", "Maastricht")]
        [InlineData("0450000000", "45", "0000000", "Heerlen")]
        [InlineData("0459999999", "45", "9999999", "Heerlen")]
        [InlineData("0460000000", "46", "0000000", "Sittard")]
        [InlineData("0469999999", "46", "9999999", "Sittard")]
        public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0411000000", "411", "000000", "Boxtel")]
        [InlineData("0411999999", "411", "999999", "Boxtel")]
        [InlineData("0412000000", "412", "000000", "Oss")]
        [InlineData("0412999999", "412", "999999", "Oss")]
        [InlineData("0413000000", "413", "000000", "Veghel")]
        [InlineData("0413999999", "413", "999999", "Veghel")]
        [InlineData("0416000000", "416", "000000", "Waalwijk")]
        [InlineData("0416999999", "416", "999999", "Waalwijk")]
        [InlineData("0418000000", "418", "000000", "Zaltbommel")]
        [InlineData("0418999999", "418", "999999", "Zaltbommel")]
        [InlineData("0475000000", "475", "000000", "Roermond")]
        [InlineData("0475999999", "475", "999999", "Roermond")]
        [InlineData("0478000000", "478", "000000", "Venray")]
        [InlineData("0478999999", "478", "999999", "Venray")]
        [InlineData("0481000000", "481", "000000", "Bemmel")]
        [InlineData("0481999999", "481", "999999", "Bemmel")]
        [InlineData("0485000000", "485", "000000", "Cuijk")]
        [InlineData("0485999999", "485", "999999", "Cuijk")]
        [InlineData("0486000000", "486", "000000", "Grave")]
        [InlineData("0486999999", "486", "999999", "Grave")]
        [InlineData("0487000000", "487", "000000", "Druten")]
        [InlineData("0487999999", "487", "999999", "Druten")]
        [InlineData("0488000000", "488", "000000", "Zetten")]
        [InlineData("0488999999", "488", "999999", "Zetten")]
        [InlineData("0492000000", "492", "000000", "Helmond")]
        [InlineData("0492999999", "492", "999999", "Helmond")]
        [InlineData("0493000000", "493", "000000", "Deurne")]
        [InlineData("0493999999", "493", "999999", "Deurne")]
        [InlineData("0495000000", "495", "000000", "Weert")]
        [InlineData("0495999999", "495", "999999", "Weert")]
        [InlineData("0497000000", "497", "000000", "Eersel")]
        [InlineData("0497999999", "497", "999999", "Eersel")]
        [InlineData("0499000000", "499", "000000", "Best")]
        [InlineData("0499999999", "499", "999999", "Best")]
        public void Parse_Known_GeographicPhoneNumber_4XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0500000000", "50", "0000000", "Groningen")]
        [InlineData("0509999999", "50", "9999999", "Groningen")]
        [InlineData("0530000000", "53", "0000000", "Enschede")]
        [InlineData("0539999999", "53", "9999999", "Enschede")]
        [InlineData("0550000000", "55", "0000000", "Apeldoorn")]
        [InlineData("0559999999", "55", "9999999", "Apeldoorn")]
        [InlineData("0580000000", "58", "0000000", "Leeuwarden")]
        [InlineData("0589999999", "58", "9999999", "Leeuwarden")]
        public void Parse_Known_GeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0511000000", "511", "000000", "Veenwouden")]
        [InlineData("0511999999", "511", "999999", "Veenwouden")]
        [InlineData("0512000000", "512", "000000", "Drachten")]
        [InlineData("0512999999", "512", "999999", "Drachten")]
        [InlineData("0513000000", "513", "000000", "Heerenveen")]
        [InlineData("0513999999", "513", "999999", "Heerenveen")]
        [InlineData("0514000000", "514", "000000", "Balk")]
        [InlineData("0514999999", "514", "999999", "Balk")]
        [InlineData("0515000000", "515", "000000", "Sneek")]
        [InlineData("0515999999", "515", "999999", "Sneek")]
        [InlineData("0516000000", "516", "000000", "Oosterwolde")]
        [InlineData("0516999999", "516", "999999", "Oosterwolde")]
        [InlineData("0517000000", "517", "000000", "Franeker")]
        [InlineData("0517999999", "517", "999999", "Franeker")]
        [InlineData("0518000000", "518", "000000", "St. Annaparochie")]
        [InlineData("0518999999", "518", "999999", "St. Annaparochie")]
        [InlineData("0519000000", "519", "000000", "Dokkum")]
        [InlineData("0519999999", "519", "999999", "Dokkum")]
        [InlineData("0521000000", "521", "000000", "Steenwijk")]
        [InlineData("0521999999", "521", "999999", "Steenwijk")]
        [InlineData("0522000000", "522", "000000", "Meppel")]
        [InlineData("0522999999", "522", "999999", "Meppel")]
        [InlineData("0523000000", "523", "000000", "Hardenberg")]
        [InlineData("0523999999", "523", "999999", "Hardenberg")]
        [InlineData("0524000000", "524", "000000", "Coevorden")]
        [InlineData("0524999999", "524", "999999", "Coevorden")]
        [InlineData("0525000000", "525", "000000", "Elburg")]
        [InlineData("0525999999", "525", "999999", "Elburg")]
        [InlineData("0527000000", "527", "000000", "Emmeloord")]
        [InlineData("0527999999", "527", "999999", "Emmeloord")]
        [InlineData("0528000000", "528", "000000", "Hoogeveen")]
        [InlineData("0528999999", "528", "999999", "Hoogeveen")]
        [InlineData("0529000000", "529", "000000", "Ommen")]
        [InlineData("0529999999", "529", "999999", "Ommen")]
        [InlineData("0541000000", "541", "000000", "Oldenzaal")]
        [InlineData("0541999999", "541", "999999", "Oldenzaal")]
        [InlineData("0543000000", "543", "000000", "Winterswijk")]
        [InlineData("0543999999", "543", "999999", "Winterswijk")]
        [InlineData("0544000000", "544", "000000", "Groenlo")]
        [InlineData("0544999999", "544", "999999", "Groenlo")]
        [InlineData("0545000000", "545", "000000", "Neede")]
        [InlineData("0545999999", "545", "999999", "Neede")]
        [InlineData("0546000000", "546", "000000", "Almelo")]
        [InlineData("0546999999", "546", "999999", "Almelo")]
        [InlineData("0547000000", "547", "000000", "Goor")]
        [InlineData("0547999999", "547", "999999", "Goor")]
        [InlineData("0548000000", "548", "000000", "Rijssen")]
        [InlineData("0548999999", "548", "999999", "Rijssen")]
        [InlineData("0561000000", "561", "000000", "Wolvega")]
        [InlineData("0561999999", "561", "999999", "Wolvega")]
        [InlineData("0562000000", "562", "000000", "Terschelling/Vlieland")]
        [InlineData("0562999999", "562", "999999", "Terschelling/Vlieland")]
        [InlineData("0566000000", "566", "000000", "Irnsum")]
        [InlineData("0566999999", "566", "999999", "Irnsum")]
        [InlineData("0570000000", "570", "000000", "Deventer")]
        [InlineData("0570999999", "570", "999999", "Deventer")]
        [InlineData("0571000000", "571", "000000", "Voorst")]
        [InlineData("0571999999", "571", "999999", "Voorst")]
        [InlineData("0572000000", "572", "000000", "Raalte")]
        [InlineData("0572999999", "572", "999999", "Raalte")]
        [InlineData("0573000000", "573", "000000", "Lochem")]
        [InlineData("0573999999", "573", "999999", "Lochem")]
        [InlineData("0575000000", "575", "000000", "Zutphen")]
        [InlineData("0575999999", "575", "999999", "Zutphen")]
        [InlineData("0577000000", "577", "000000", "Uddel")]
        [InlineData("0577999999", "577", "999999", "Uddel")]
        [InlineData("0578000000", "578", "000000", "Epe")]
        [InlineData("0578999999", "578", "999999", "Epe")]
        [InlineData("0591000000", "591", "000000", "Emmen")]
        [InlineData("0591999999", "591", "999999", "Emmen")]
        [InlineData("0592000000", "592", "000000", "Assen")]
        [InlineData("0592999999", "592", "999999", "Assen")]
        [InlineData("0593000000", "593", "000000", "Beilen")]
        [InlineData("0593999999", "593", "999999", "Beilen")]
        [InlineData("0594000000", "594", "000000", "Zuidhorn")]
        [InlineData("0594999999", "594", "999999", "Zuidhorn")]
        [InlineData("0595000000", "595", "000000", "Warffum")]
        [InlineData("0595999999", "595", "999999", "Warffum")]
        [InlineData("0596000000", "596", "000000", "Appingedam")]
        [InlineData("0596999999", "596", "999999", "Appingedam")]
        [InlineData("0597000000", "597", "000000", "Winschoten")]
        [InlineData("0597999999", "597", "999999", "Winschoten")]
        [InlineData("0598000000", "598", "000000", "Hoogezand-Sappemeer")]
        [InlineData("0598999999", "598", "999999", "Hoogezand-Sappemeer")]
        [InlineData("0599000000", "599", "000000", "Stadskanaal")]
        [InlineData("0599999999", "599", "999999", "Stadskanaal")]
        public void Parse_Known_GeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("0700000000", "70", "0000000", "The Hague")]
        [InlineData("0709999999", "70", "9999999", "The Hague")]
        [InlineData("0710000000", "71", "0000000", "Leiden")]
        [InlineData("0719999999", "71", "9999999", "Leiden")]
        [InlineData("0720000000", "72", "0000000", "Alkmaar")]
        [InlineData("0729999999", "72", "9999999", "Alkmaar")]
        [InlineData("0730000000", "73", "0000000", "'s-Hertogenbosch")]
        [InlineData("0739999999", "73", "9999999", "'s-Hertogenbosch")]
        [InlineData("0740000000", "74", "0000000", "Hengelo")]
        [InlineData("0749999999", "74", "9999999", "Hengelo")]
        [InlineData("0750000000", "75", "0000000", "Zaandam")]
        [InlineData("0759999999", "75", "9999999", "Zaandam")]
        [InlineData("0760000000", "76", "0000000", "Breda")]
        [InlineData("0769999999", "76", "9999999", "Breda")]
        [InlineData("0770000000", "77", "0000000", "Venlo")]
        [InlineData("0779999999", "77", "9999999", "Venlo")]
        [InlineData("0780000000", "78", "0000000", "Dordrecht")]
        [InlineData("0789999999", "78", "9999999", "Dordrecht")]
        [InlineData("0790000000", "79", "0000000", "Zoetermeer")]
        [InlineData("0799999999", "79", "9999999", "Zoetermeer")]
        public void Parse_Known_GeographicPhoneNumber_7X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Netherlands, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
        }
    }
}
