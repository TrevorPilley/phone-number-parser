using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    public partial class UKPhoneNumberParserTests
    {
        [Theory]
        [InlineData("01132224444", "113", "2224444", "Leeds")]
        [InlineData("01142734567", "114", "2734567", "Sheffield")]
        [InlineData("01159155555", "115", "9155555", "Nottingham")]
        [InlineData("01164541002", "116", "4541002", "Leicester")]
        [InlineData("01179222000", "117", "9222000", "Bristol")]
        [InlineData("01189373787", "118", "9373787", "Reading")]
        [InlineData("01216754806", "121", "6754806", "Birmingham")]
        [InlineData("01312002000", "131", "2002000", "Edinburgh")]
        [InlineData("01412872000", "141", "2872000", "Glasgow")]
        [InlineData("01512333000", "151", "2333000", "Liverpool")]
        [InlineData("01612343235", "161", "2343235", "Manchester")]
        [InlineData("01914277000", "191", "4277000", "Tyneside / Durham / Sunderland")]
        [InlineData("01339454545", "1339", "454545", "Aboyne / Ballater")]
        [InlineData("01339755997", "13397", "55997", "Ballater")]
        [InlineData("01339822334", "13398", "22334", "Aboyne")]
        [InlineData("01387272410", "1387", "272410", "Dumfries")]
        [InlineData("01387380357", "13873", "80357", "Langholm")]
        [InlineData("01733747474", "1733", "747474", "Peterborough")]
        [InlineData("02076416000", "20", "76416000", "London")]
        [InlineData("02380833000", "23", "80833000", "Southampton / Portsmouth")]
        [InlineData("02476832222", "24", "76832222", "Coventry")]
        [InlineData("02890320202", "28", "90320202", "Northern Ireland")] // Belfast
        [InlineData("02920872087", "29", "20872087", "Cardiff")]
        public void Parse_Known_GeographicPhoneNumber(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parser = new UKPhoneNumberParser();
            var phoneNumber = parser.Parse(value, CountryInfo.UK);

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, geographicPhoneNumber.Country);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
        }
    }
}
