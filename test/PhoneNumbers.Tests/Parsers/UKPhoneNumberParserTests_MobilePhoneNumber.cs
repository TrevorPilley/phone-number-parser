using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    public partial class UKPhoneNumberParserTests
    {
        [Theory]
        [InlineData("07106112233", "7106", "112233")] // UK Mobile
        [InlineData("07300112233", "7300", "112233")] // UK Mobile
        [InlineData("07400112233", "7400", "112233")] // UK Mobile
        [InlineData("07500112233", "7500", "112233")] // UK Mobile
        [InlineData("07700112233", "7700", "112233")] // UK Mobile
        [InlineData("07800112233", "7800", "112233")] // UK Mobile
        [InlineData("07900112233", "7900", "112233")] // UK Mobile
        [InlineData("07781112233", "7781", "112233")] // Guernsey Mobile
        [InlineData("07839112233", "7839", "112233")] // Guernsey Mobile
        [InlineData("07911112233", "7911", "112233")] // Guernsey Mobile
        [InlineData("07509112233", "7509", "112233")] // Jersey Mobile
        [InlineData("07797112233", "7797", "112233")] // Jersey Mobile
        [InlineData("07937112233", "7937", "112233")] // Jersey Mobile
        [InlineData("07829112233", "7829", "112233")] // Jersey Mobile
        [InlineData("07624112233", "7624", "112233")] // Isle of Man Mobile
        [InlineData("07924112233", "7924", "112233")] // Isle of Man Mobile
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var parser = new UKPhoneNumberParser();
            PhoneNumber phoneNumber = parser.Parse(value, CountryInfo.UK);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07911212345", "7911", "212345")]
        [InlineData("07911812345", "7911", "812345")]
        public void Parse_Known_MobilePhoneNumber_DataOnly(string value, string areaCode, string localNumber)
        {
            var parser = new UKPhoneNumberParser();
            PhoneNumber phoneNumber = parser.Parse(value, CountryInfo.UK);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.True(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07600112233", "7600", "112233")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string areaCode, string localNumber)
        {
            var parser = new UKPhoneNumberParser();
            PhoneNumber phoneNumber = parser.Parse(value, CountryInfo.UK);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07000112233", "7000", "112233")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var parser = new UKPhoneNumberParser();
            PhoneNumber phoneNumber = parser.Parse(value, CountryInfo.UK);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
