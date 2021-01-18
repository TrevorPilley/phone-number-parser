using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for ES <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_ES_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.ES);

        [Theory]
        [InlineData("600000000", "600", "000000")]
        [InlineData("600999999", "600", "999999")]
        [InlineData("601000000", "601", "000000")]
        [InlineData("601999999", "601", "999999")]
        [InlineData("602000000", "602", "000000")]
        [InlineData("602999999", "602", "999999")]
        [InlineData("603000000", "603", "000000")]
        [InlineData("603999999", "603", "999999")]
        [InlineData("604000000", "604", "000000")]
        [InlineData("604999999", "604", "999999")]
        [InlineData("605000000", "605", "000000")]
        [InlineData("605999999", "605", "999999")]
        [InlineData("606000000", "606", "000000")]
        [InlineData("606999999", "606", "999999")]
        [InlineData("607000000", "607", "000000")]
        [InlineData("607999999", "607", "999999")]
        [InlineData("608000000", "608", "000000")]
        [InlineData("608999999", "608", "999999")]
        [InlineData("609000000", "609", "000000")]
        [InlineData("609999999", "609", "999999")]
        public void Parse_Known_MobilePhoneNumber_60X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("610000000", "610", "000000")]
        [InlineData("610999999", "610", "999999")]
        [InlineData("611000000", "611", "000000")]
        [InlineData("611999999", "611", "999999")]
        [InlineData("612000000", "612", "000000")]
        [InlineData("612999999", "612", "999999")]
        [InlineData("613000000", "613", "000000")]
        [InlineData("613999999", "613", "999999")]
        [InlineData("614000000", "614", "000000")]
        [InlineData("614999999", "614", "999999")]
        [InlineData("615000000", "615", "000000")]
        [InlineData("615999999", "615", "999999")]
        [InlineData("616000000", "616", "000000")]
        [InlineData("616999999", "616", "999999")]
        [InlineData("617000000", "617", "000000")]
        [InlineData("617999999", "617", "999999")]
        [InlineData("618000000", "618", "000000")]
        [InlineData("618999999", "618", "999999")]
        [InlineData("619000000", "619", "000000")]
        [InlineData("619999999", "619", "999999")]
        public void Parse_Known_MobilePhoneNumber_61X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("620000000", "620", "000000")]
        [InlineData("620999999", "620", "999999")]
        [InlineData("621000000", "621", "000000")]
        [InlineData("621999999", "621", "999999")]
        [InlineData("622000000", "622", "000000")]
        [InlineData("622999999", "622", "999999")]
        [InlineData("623000000", "623", "000000")]
        [InlineData("623999999", "623", "999999")]
        [InlineData("624000000", "624", "000000")]
        [InlineData("624999999", "624", "999999")]
        [InlineData("625000000", "625", "000000")]
        [InlineData("625999999", "625", "999999")]
        [InlineData("626000000", "626", "000000")]
        [InlineData("626999999", "626", "999999")]
        [InlineData("627000000", "627", "000000")]
        [InlineData("627999999", "627", "999999")]
        [InlineData("628000000", "628", "000000")]
        [InlineData("628999999", "628", "999999")]
        [InlineData("629000000", "629", "000000")]
        [InlineData("629999999", "629", "999999")]
        public void Parse_Known_MobilePhoneNumber_62X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("630000000", "630", "000000")]
        [InlineData("630999999", "630", "999999")]
        [InlineData("631000000", "631", "000000")]
        [InlineData("631999999", "631", "999999")]
        [InlineData("632000000", "632", "000000")]
        [InlineData("632999999", "632", "999999")]
        [InlineData("633000000", "633", "000000")]
        [InlineData("633999999", "633", "999999")]
        [InlineData("634000000", "634", "000000")]
        [InlineData("634999999", "634", "999999")]
        [InlineData("635000000", "635", "000000")]
        [InlineData("635999999", "635", "999999")]
        [InlineData("636000000", "636", "000000")]
        [InlineData("636999999", "636", "999999")]
        [InlineData("637000000", "637", "000000")]
        [InlineData("637999999", "637", "999999")]
        [InlineData("638000000", "638", "000000")]
        [InlineData("638999999", "638", "999999")]
        [InlineData("639000000", "639", "000000")]
        [InlineData("639999999", "639", "999999")]
        public void Parse_Known_MobilePhoneNumber_63X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("640000000", "640", "000000")]
        [InlineData("640999999", "640", "999999")]
        [InlineData("641000000", "641", "000000")]
        [InlineData("641999999", "641", "999999")]
        [InlineData("642000000", "642", "000000")]
        [InlineData("642999999", "642", "999999")]
        [InlineData("643000000", "643", "000000")]
        [InlineData("643999999", "643", "999999")]
        [InlineData("644000000", "644", "000000")]
        [InlineData("644999999", "644", "999999")]
        [InlineData("645000000", "645", "000000")]
        [InlineData("645999999", "645", "999999")]
        [InlineData("646000000", "646", "000000")]
        [InlineData("646999999", "646", "999999")]
        [InlineData("647000000", "647", "000000")]
        [InlineData("647999999", "647", "999999")]
        [InlineData("648000000", "648", "000000")]
        [InlineData("648999999", "648", "999999")]
        [InlineData("649000000", "649", "000000")]
        [InlineData("649999999", "649", "999999")]
        public void Parse_Known_MobilePhoneNumber_64X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("650000000", "650", "000000")]
        [InlineData("650999999", "650", "999999")]
        [InlineData("651000000", "651", "000000")]
        [InlineData("651999999", "651", "999999")]
        [InlineData("652000000", "652", "000000")]
        [InlineData("652999999", "652", "999999")]
        [InlineData("653000000", "653", "000000")]
        [InlineData("653999999", "653", "999999")]
        [InlineData("654000000", "654", "000000")]
        [InlineData("654999999", "654", "999999")]
        [InlineData("655000000", "655", "000000")]
        [InlineData("655999999", "655", "999999")]
        [InlineData("656000000", "656", "000000")]
        [InlineData("656999999", "656", "999999")]
        [InlineData("657000000", "657", "000000")]
        [InlineData("657999999", "657", "999999")]
        [InlineData("658000000", "658", "000000")]
        [InlineData("658999999", "658", "999999")]
        [InlineData("659000000", "659", "000000")]
        [InlineData("659999999", "659", "999999")]
        public void Parse_Known_MobilePhoneNumber_65X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("660000000", "660", "000000")]
        [InlineData("660999999", "660", "999999")]
        [InlineData("661000000", "661", "000000")]
        [InlineData("661999999", "661", "999999")]
        [InlineData("662000000", "662", "000000")]
        [InlineData("662999999", "662", "999999")]
        [InlineData("663000000", "663", "000000")]
        [InlineData("663999999", "663", "999999")]
        [InlineData("664000000", "664", "000000")]
        [InlineData("664999999", "664", "999999")]
        [InlineData("665000000", "665", "000000")]
        [InlineData("665999999", "665", "999999")]
        [InlineData("666000000", "666", "000000")]
        [InlineData("666999999", "666", "999999")]
        [InlineData("667000000", "667", "000000")]
        [InlineData("667999999", "667", "999999")]
        [InlineData("668000000", "668", "000000")]
        [InlineData("668999999", "668", "999999")]
        [InlineData("669000000", "669", "000000")]
        [InlineData("669999999", "669", "999999")]
        public void Parse_Known_MobilePhoneNumber_66X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("670000000", "670", "000000")]
        [InlineData("670999999", "670", "999999")]
        [InlineData("671000000", "671", "000000")]
        [InlineData("671999999", "671", "999999")]
        [InlineData("672000000", "672", "000000")]
        [InlineData("672999999", "672", "999999")]
        [InlineData("673000000", "673", "000000")]
        [InlineData("673999999", "673", "999999")]
        [InlineData("674000000", "674", "000000")]
        [InlineData("674999999", "674", "999999")]
        [InlineData("675000000", "675", "000000")]
        [InlineData("675999999", "675", "999999")]
        [InlineData("676000000", "676", "000000")]
        [InlineData("676999999", "676", "999999")]
        [InlineData("677000000", "677", "000000")]
        [InlineData("677999999", "677", "999999")]
        [InlineData("678000000", "678", "000000")]
        [InlineData("678999999", "678", "999999")]
        [InlineData("679000000", "679", "000000")]
        [InlineData("679999999", "679", "999999")]
        public void Parse_Known_MobilePhoneNumber_67X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("680000000", "680", "000000")]
        [InlineData("680999999", "680", "999999")]
        [InlineData("681000000", "681", "000000")]
        [InlineData("681999999", "681", "999999")]
        [InlineData("682000000", "682", "000000")]
        [InlineData("682999999", "682", "999999")]
        [InlineData("683000000", "683", "000000")]
        [InlineData("683999999", "683", "999999")]
        [InlineData("684000000", "684", "000000")]
        [InlineData("684999999", "684", "999999")]
        [InlineData("685000000", "685", "000000")]
        [InlineData("685999999", "685", "999999")]
        [InlineData("686000000", "686", "000000")]
        [InlineData("686999999", "686", "999999")]
        [InlineData("687000000", "687", "000000")]
        [InlineData("687999999", "687", "999999")]
        [InlineData("688000000", "688", "000000")]
        [InlineData("688999999", "688", "999999")]
        [InlineData("689000000", "689", "000000")]
        [InlineData("689999999", "689", "999999")]
        public void Parse_Known_MobilePhoneNumber_68X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("690000000", "690", "000000")]
        [InlineData("690999999", "690", "999999")]
        [InlineData("691000000", "691", "000000")]
        [InlineData("691999999", "691", "999999")]
        [InlineData("692000000", "692", "000000")]
        [InlineData("692999999", "692", "999999")]
        [InlineData("693000000", "693", "000000")]
        [InlineData("693999999", "693", "999999")]
        [InlineData("694000000", "694", "000000")]
        [InlineData("694999999", "694", "999999")]
        [InlineData("695000000", "695", "000000")]
        [InlineData("695999999", "695", "999999")]
        [InlineData("696000000", "696", "000000")]
        [InlineData("696999999", "696", "999999")]
        [InlineData("697000000", "697", "000000")]
        [InlineData("697999999", "697", "999999")]
        [InlineData("698000000", "698", "000000")]
        [InlineData("698999999", "698", "999999")]
        [InlineData("699000000", "699", "000000")]
        [InlineData("699999999", "699", "999999")]
        public void Parse_Known_MobilePhoneNumber_69X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("710000000", "710", "000000")]
        [InlineData("710999999", "710", "999999")]
        [InlineData("711000000", "711", "000000")]
        [InlineData("711999999", "711", "999999")]
        [InlineData("712000000", "712", "000000")]
        [InlineData("712999999", "712", "999999")]
        [InlineData("713000000", "713", "000000")]
        [InlineData("713999999", "713", "999999")]
        [InlineData("714000000", "714", "000000")]
        [InlineData("714999999", "714", "999999")]
        [InlineData("715000000", "715", "000000")]
        [InlineData("715999999", "715", "999999")]
        [InlineData("716000000", "716", "000000")]
        [InlineData("716999999", "716", "999999")]
        [InlineData("717000000", "717", "000000")]
        [InlineData("717999999", "717", "999999")]
        [InlineData("718000000", "718", "000000")]
        [InlineData("718999999", "718", "999999")]
        [InlineData("719000000", "719", "000000")]
        [InlineData("719999999", "719", "999999")]
        public void Parse_Known_MobilePhoneNumber_71X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("720000000", "720", "000000")]
        [InlineData("720999999", "720", "999999")]
        [InlineData("721000000", "721", "000000")]
        [InlineData("721999999", "721", "999999")]
        [InlineData("722000000", "722", "000000")]
        [InlineData("722999999", "722", "999999")]
        [InlineData("723000000", "723", "000000")]
        [InlineData("723999999", "723", "999999")]
        [InlineData("724000000", "724", "000000")]
        [InlineData("724999999", "724", "999999")]
        [InlineData("725000000", "725", "000000")]
        [InlineData("725999999", "725", "999999")]
        [InlineData("726000000", "726", "000000")]
        [InlineData("726999999", "726", "999999")]
        [InlineData("727000000", "727", "000000")]
        [InlineData("727999999", "727", "999999")]
        [InlineData("728000000", "728", "000000")]
        [InlineData("728999999", "728", "999999")]
        [InlineData("729000000", "729", "000000")]
        [InlineData("729999999", "729", "999999")]
        public void Parse_Known_MobilePhoneNumber_72X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("730000000", "730", "000000")]
        [InlineData("730999999", "730", "999999")]
        [InlineData("731000000", "731", "000000")]
        [InlineData("731999999", "731", "999999")]
        [InlineData("732000000", "732", "000000")]
        [InlineData("732999999", "732", "999999")]
        [InlineData("733000000", "733", "000000")]
        [InlineData("733999999", "733", "999999")]
        [InlineData("734000000", "734", "000000")]
        [InlineData("734999999", "734", "999999")]
        [InlineData("735000000", "735", "000000")]
        [InlineData("735999999", "735", "999999")]
        [InlineData("736000000", "736", "000000")]
        [InlineData("736999999", "736", "999999")]
        [InlineData("737000000", "737", "000000")]
        [InlineData("737999999", "737", "999999")]
        [InlineData("738000000", "738", "000000")]
        [InlineData("738999999", "738", "999999")]
        [InlineData("739000000", "739", "000000")]
        [InlineData("739999999", "739", "999999")]
        public void Parse_Known_MobilePhoneNumber_73X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("740000000", "740", "000000")]
        [InlineData("740999999", "740", "999999")]
        [InlineData("741000000", "741", "000000")]
        [InlineData("741999999", "741", "999999")]
        [InlineData("742000000", "742", "000000")]
        [InlineData("742999999", "742", "999999")]
        [InlineData("743000000", "743", "000000")]
        [InlineData("743999999", "743", "999999")]
        [InlineData("744000000", "744", "000000")]
        [InlineData("744999999", "744", "999999")]
        [InlineData("745000000", "745", "000000")]
        [InlineData("745999999", "745", "999999")]
        [InlineData("746000000", "746", "000000")]
        [InlineData("746999999", "746", "999999")]
        [InlineData("747000000", "747", "000000")]
        [InlineData("747999999", "747", "999999")]
        [InlineData("748000000", "748", "000000")]
        [InlineData("748999999", "748", "999999")]
        [InlineData("749000000", "749", "000000")]
        [InlineData("749999999", "749", "999999")]
        public void Parse_Known_MobilePhoneNumber_74X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("750000000", "750", "000000")]
        [InlineData("750999999", "750", "999999")]
        [InlineData("751000000", "751", "000000")]
        [InlineData("751999999", "751", "999999")]
        [InlineData("752000000", "752", "000000")]
        [InlineData("752999999", "752", "999999")]
        [InlineData("753000000", "753", "000000")]
        [InlineData("753999999", "753", "999999")]
        [InlineData("754000000", "754", "000000")]
        [InlineData("754999999", "754", "999999")]
        [InlineData("755000000", "755", "000000")]
        [InlineData("755999999", "755", "999999")]
        [InlineData("756000000", "756", "000000")]
        [InlineData("756999999", "756", "999999")]
        [InlineData("757000000", "757", "000000")]
        [InlineData("757999999", "757", "999999")]
        [InlineData("758000000", "758", "000000")]
        [InlineData("758999999", "758", "999999")]
        [InlineData("759000000", "759", "000000")]
        [InlineData("759999999", "759", "999999")]
        public void Parse_Known_MobilePhoneNumber_75X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("760000000", "760", "000000")]
        [InlineData("760999999", "760", "999999")]
        [InlineData("761000000", "761", "000000")]
        [InlineData("761999999", "761", "999999")]
        [InlineData("762000000", "762", "000000")]
        [InlineData("762999999", "762", "999999")]
        [InlineData("763000000", "763", "000000")]
        [InlineData("763999999", "763", "999999")]
        [InlineData("764000000", "764", "000000")]
        [InlineData("764999999", "764", "999999")]
        [InlineData("765000000", "765", "000000")]
        [InlineData("765999999", "765", "999999")]
        [InlineData("766000000", "766", "000000")]
        [InlineData("766999999", "766", "999999")]
        [InlineData("767000000", "767", "000000")]
        [InlineData("767999999", "767", "999999")]
        [InlineData("768000000", "768", "000000")]
        [InlineData("768999999", "768", "999999")]
        [InlineData("769000000", "769", "000000")]
        [InlineData("769999999", "769", "999999")]
        public void Parse_Known_MobilePhoneNumber_76X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("770000000", "770", "000000")]
        [InlineData("770999999", "770", "999999")]
        [InlineData("771000000", "771", "000000")]
        [InlineData("771999999", "771", "999999")]
        [InlineData("772000000", "772", "000000")]
        [InlineData("772999999", "772", "999999")]
        [InlineData("773000000", "773", "000000")]
        [InlineData("773999999", "773", "999999")]
        [InlineData("774000000", "774", "000000")]
        [InlineData("774999999", "774", "999999")]
        [InlineData("775000000", "775", "000000")]
        [InlineData("775999999", "775", "999999")]
        [InlineData("776000000", "776", "000000")]
        [InlineData("776999999", "776", "999999")]
        [InlineData("777000000", "777", "000000")]
        [InlineData("777999999", "777", "999999")]
        [InlineData("778000000", "778", "000000")]
        [InlineData("778999999", "778", "999999")]
        [InlineData("779000000", "779", "000000")]
        [InlineData("779999999", "779", "999999")]
        public void Parse_Known_MobilePhoneNumber_77X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("780000000", "780", "000000")]
        [InlineData("780999999", "780", "999999")]
        [InlineData("781000000", "781", "000000")]
        [InlineData("781999999", "781", "999999")]
        [InlineData("782000000", "782", "000000")]
        [InlineData("782999999", "782", "999999")]
        [InlineData("783000000", "783", "000000")]
        [InlineData("783999999", "783", "999999")]
        [InlineData("784000000", "784", "000000")]
        [InlineData("784999999", "784", "999999")]
        [InlineData("785000000", "785", "000000")]
        [InlineData("785999999", "785", "999999")]
        [InlineData("786000000", "786", "000000")]
        [InlineData("786999999", "786", "999999")]
        [InlineData("787000000", "787", "000000")]
        [InlineData("787999999", "787", "999999")]
        [InlineData("788000000", "788", "000000")]
        [InlineData("788999999", "788", "999999")]
        [InlineData("789000000", "789", "000000")]
        [InlineData("789999999", "789", "999999")]
        public void Parse_Known_MobilePhoneNumber_78X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("790000000", "790", "000000")]
        [InlineData("790999999", "790", "999999")]
        [InlineData("791000000", "791", "000000")]
        [InlineData("791999999", "791", "999999")]
        [InlineData("792000000", "792", "000000")]
        [InlineData("792999999", "792", "999999")]
        [InlineData("793000000", "793", "000000")]
        [InlineData("793999999", "793", "999999")]
        [InlineData("794000000", "794", "000000")]
        [InlineData("794999999", "794", "999999")]
        [InlineData("795000000", "795", "000000")]
        [InlineData("795999999", "795", "999999")]
        [InlineData("796000000", "796", "000000")]
        [InlineData("796999999", "796", "999999")]
        [InlineData("797000000", "797", "000000")]
        [InlineData("797999999", "797", "999999")]
        [InlineData("798000000", "798", "000000")]
        [InlineData("798999999", "798", "999999")]
        [InlineData("799000000", "799", "000000")]
        [InlineData("799999999", "799", "999999")]
        public void Parse_Known_MobilePhoneNumber_79X_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("700000000", "700", "000000")]
        [InlineData("700999999", "700", "999999")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.ES, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
