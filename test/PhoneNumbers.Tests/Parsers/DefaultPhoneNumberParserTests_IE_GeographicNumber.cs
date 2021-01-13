using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for IE <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IE_GeographicNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.IE);

        [Theory]
        [InlineData("012000000", "1", "2000000", "Dublin")]
        [InlineData("019989999", "1", "9989999", "Dublin")]
        public void Parse_Known_GeographicPhoneNumber_1_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0212000000", "21", "2000000", "Cork, Coachford and Kinsale")]
        [InlineData("0219989999", "21", "9989999", "Cork, Coachford and Kinsale")]
        [InlineData("02220000", "22", "20000", "Mallow")]
        [InlineData("02299899", "22", "99899", "Mallow")]
        [InlineData("02320000", "23", "20000", "Bandon")]
        [InlineData("02399899", "23", "99899", "Bandon")]
        [InlineData("0232000000", "23", "2000000", "Bandon")]
        [InlineData("0239989999", "23", "9989999", "Bandon")]
        [InlineData("02420000", "24", "20000", "Youghal")]
        [InlineData("02499899", "24", "99899", "Youghal")]
        [InlineData("02520000", "25", "20000", "Fermoy")]
        [InlineData("02599899", "25", "99899", "Fermoy")]
        [InlineData("02620000", "26", "20000", "Macroom")]
        [InlineData("02699899", "26", "99899", "Macroom")]
        [InlineData("02720000", "27", "20000", "Bantry")]
        [InlineData("02799899", "27", "99899", "Bantry")]
        [InlineData("02820000", "28", "20000", "Skibbereen")]
        [InlineData("02899899", "28", "99899", "Skibbereen")]
        [InlineData("02920000", "29", "20000", "Kanturk")]
        [InlineData("02999899", "29", "99899", "Kanturk")]
        public void Parse_Known_GeographicPhoneNumber_2X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0412000000", "41", "2000000", "Drogheda, Ardee")]
        [InlineData("0419989999", "41", "9989999", "Drogheda, Ardee")]
        [InlineData("0422000000", "42", "2000000", "Dundalk, Carrickmacross, Castleblaney")]
        [InlineData("0429989999", "42", "9989999", "Dundalk, Carrickmacross, Castleblaney")]
        [InlineData("04320000", "43", "20000", "Longford, Granard")]
        [InlineData("04399899", "43", "99899", "Longford, Granard")]
        [InlineData("0432000000", "43", "2000000", "Longford, Granard")]
        [InlineData("0439989999", "43", "9989999", "Longford, Granard")]
        [InlineData("0442000000", "44", "2000000", "Mullingar, Castlepollard, Tyrellspass")]
        [InlineData("0449989999", "44", "9989999", "Mullingar, Castlepollard, Tyrellspass")]
        [InlineData("045200000", "45", "200000", "Naas, Kildare, The Curragh")]
        [InlineData("045998999", "45", "998999", "Naas, Kildare, The Curragh")]
        [InlineData("0462000000", "46", "2000000", "Navan, Kells, Trim, Enfield, Edenderry")]
        [InlineData("0469989999", "46", "9989999", "Navan, Kells, Trim, Enfield, Edenderry")]
        [InlineData("04720000", "47", "20000", "Monaghan, Clones")]
        [InlineData("04799899", "47", "99899", "Monaghan, Clones")]
        [InlineData("0492000000", "49", "2000000", "Cavan, Cootehill, Oldcastle, Belturbet")]
        [InlineData("0499989999", "49", "9989999", "Cavan, Cootehill, Oldcastle, Belturbet")]
        public void Parse_Known_GeographicPhoneNumber_4X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("040220000", "402", "20000", "Arklow")]
        [InlineData("040299899", "402", "99899", "Arklow")]
        [InlineData("040420000", "404", "20000", "Wicklow")]
        [InlineData("040499899", "404", "99899", "Wicklow")]
        public void Parse_Known_GeographicPhoneNumber_4XX_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("051200000", "51", "200000", "Waterford, Carrick-on-Suir, New Ross, Kilmacthomas")]
        [InlineData("051998999", "51", "998999", "Waterford, Carrick-on-Suir, New Ross, Kilmacthomas")]
        [InlineData("05220000", "52", "20000", "Clonmel, Cahir, Killenaule")]
        [InlineData("05299899", "52", "99899", "Clonmel, Cahir, Killenaule")]
        [InlineData("0522000000", "52", "2000000", "Clonmel, Cahir, Killenaule")]
        [InlineData("0529989999", "52", "9989999", "Clonmel, Cahir, Killenaule")]
        [InlineData("0532000000", "53", "2000000", "Wexford, Enniscorthy, Ferns, Gorey")]
        [InlineData("0539989999", "53", "9989999", "Wexford, Enniscorthy, Ferns, Gorey")]
        [InlineData("0562000000", "56", "2000000", "Kilkenny, Castlecomer, Freshford")]
        [InlineData("0569989999", "56", "9989999", "Kilkenny, Castlecomer, Freshford")]
        [InlineData("0572000000", "57", "2000000", "Portlaoise, Abbeyleix, Tullamore, Birr")]
        [InlineData("0579989999", "57", "9989999", "Portlaoise, Abbeyleix, Tullamore, Birr")]
        [InlineData("05820000", "58", "20000", "Dungarvan")]
        [InlineData("05899899", "58", "99899", "Dungarvan")]
        [InlineData("0592000000", "59", "2000000", "Carlow, Muine Bheag, Athy, Baltinglass")]
        [InlineData("0599989999", "59", "9989999", "Carlow, Muine Bheag, Athy, Baltinglass")]
        public void Parse_Known_GeographicPhoneNumber_5X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("050420000", "504", "20000", "Thurles")]
        [InlineData("050499899", "504", "99899", "Thurles")]
        [InlineData("050520000", "505", "20000", "Roscrea")]
        [InlineData("050599899", "505", "99899", "Roscrea")]
        public void Parse_Known_GeographicPhoneNumber_5XX_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("061200000", "61", "200000", "Limerick, Scarriff")]
        [InlineData("061998999", "61", "998999", "Limerick, Scarriff")]
        [InlineData("06220000", "62", "20000", "Tipperary, Cashel")]
        [InlineData("06299899", "62", "99899", "Tipperary, Cashel")]
        [InlineData("06320000", "63", "20000", "Charleville")]
        [InlineData("06399899", "63", "99899", "Charleville")]
        [InlineData("06420000", "64", "20000", "Killarney, Rathmore")]
        [InlineData("06499899", "64", "99899", "Killarney, Rathmore")]
        [InlineData("0642000000", "64", "2000000", "Killarney, Rathmore")]
        [InlineData("0649989999", "64", "9989999", "Killarney, Rathmore")]
        [InlineData("0652000000", "65", "2000000", "Ennis, Ennistymon, Kilrush")]
        [InlineData("0659989999", "65", "9989999", "Ennis, Ennistymon, Kilrush")]
        [InlineData("0662000000", "66", "2000000", "Tralee, Dingle, Killorglin, Cahirciveen")]
        [InlineData("0669989999", "66", "9989999", "Tralee, Dingle, Killorglin, Cahirciveen")]
        [InlineData("06720000", "67", "20000", "Nenagh")]
        [InlineData("06799899", "67", "99899", "Nenagh")]
        [InlineData("06820000", "68", "20000", "Listowel")]
        [InlineData("06899899", "68", "99899", "Listowel")]
        [InlineData("06920000", "69", "20000", "Newcastle West")]
        [InlineData("06999899", "69", "99899", "Newcastle West")]
        public void Parse_Known_GeographicPhoneNumber_6X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0712000000", "71", "2000000", "Sligo, Manorhamilton, Carrick-on- Shannon")]
        [InlineData("0719989999", "71", "9989999", "Sligo, Manorhamilton, Carrick-on- Shannon")]
        [InlineData("0742000000", "74", "2000000", "Letterkenny, Donegal, Dungloe, Buncrana")]
        [InlineData("0749989999", "74", "9989999", "Letterkenny, Donegal, Dungloe, Buncrana")]
        public void Parse_Known_GeographicPhoneNumber_7X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0902000000", "90", "2000000", "Athlone, Roscommon, Ballinasloe, Portumna")]
        [InlineData("0909989999", "90", "9989999", "Athlone, Roscommon, Ballinasloe, Portumna")]
        [InlineData("091200000", "91", "200000", "Galway, Loughrea, Gort")]
        [InlineData("091998999", "91", "998999", "Galway, Loughrea, Gort")]
        [InlineData("09320000", "93", "20000", "Tuam")]
        [InlineData("09399899", "93", "99899", "Tuam")]
        [InlineData("0942000000", "94", "2000000", "Ballinrobe, Castlebar, Claremorris, Castlerea")]
        [InlineData("0949989999", "94", "9989999", "Ballinrobe, Castlebar, Claremorris, Castlerea")]
        [InlineData("09520000", "95", "20000", "Clifden")]
        [InlineData("09599899", "95", "99899", "Clifden")]
        [InlineData("09620000", "96", "20000", "Ballina")]
        [InlineData("09699899", "96", "99899", "Ballina")]
        [InlineData("09720000", "97", "20000", "Belmullet")]
        [InlineData("09799899", "97", "99899", "Belmullet")]
        [InlineData("09820000", "98", "20000", "Westport")]
        [InlineData("09899899", "98", "99899", "Westport")]
        [InlineData("09920000", "99", "20000", "Kilronan")]
        [InlineData("09999899", "99", "99899", "Kilronan")]
        public void Parse_Known_GeographicPhoneNumber_9X_AreaCode(string value, string areaCode, string localNumber, string geographicArea)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }
    }
}
