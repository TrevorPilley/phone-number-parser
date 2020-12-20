using System;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="UkPhoneNumberParser"/> class.
    /// </summary>
    /// <remarks>
    /// All valid number tests use the local council number for the area code.
    /// </remarks>
    public class UkPhoneNumberParserTests
    {
        [Theory]
        [InlineData("0113111222")] // 6 digit local number
        [InlineData("011311122222")] // 8 digit local number
        public void Parse_1XX_Local_Number_Not_7_Digits_Throws_Exception(string value)
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse(value));
        }

        [Theory]
        [InlineData("0200001111")] // 7 digit local number
        [InlineData("020000111111")] // 9 digit local number
        public void Parse_2X_Local_Number_Not_8_Digits_Throws_Exception(string value)
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse(value));
        }

        [Theory]
        [InlineData("0700012345")] // 5 digit local number
        [InlineData("070001234567")] // 7 digit local number
        public void Parse_7X_Local_Number_Not_6_Digits_Throws_Exception(string value)
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse(value));
        }

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
        [InlineData("01914277000", "191", "4277000", "Tyneside, Sunderland and Durham")]
        [InlineData("02076416000", "20", "76416000", "London")]
        [InlineData("02380833000", "23", "80833000", "Southampton")]
        [InlineData("02392822251", "23", "92822251", "Portsmouth")]
        [InlineData("02476832222", "24", "76832222", "Coventry")]
        [InlineData("02890320202", "28", "90320202", "Northern Ireland")] // Belfast
        [InlineData("02920872087", "29", "20872087", "Cardiff")]
        public void Parse_Known_GeographicPhoneNumber(string value, string areaCode, string localNumber, string geographicArea)
        {
            var parser = new UkPhoneNumberParser();
            var phoneNumber = parser.Parse(value);

            Assert.NotNull(phoneNumber);
            Assert.IsType<GeographicPhoneNumber>(phoneNumber);

            var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, geographicPhoneNumber.AreaCode);
            Assert.Equal("+44", geographicPhoneNumber.CallingCode);
            Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
            Assert.Equal(localNumber, geographicPhoneNumber.LocalNumber);
            Assert.Equal("0", geographicPhoneNumber.TrunkPrefix);
        }

        [Theory]
        [InlineData("07100112233", "7100", "112233")]
        [InlineData("07300112233", "7300", "112233")]
        [InlineData("07400112233", "7400", "112233")]
        [InlineData("07500112233", "7500", "112233")]
        [InlineData("07624112233", "7624", "112233")] // Isle of Man Mobile
        [InlineData("07700112233", "7700", "112233")]
        [InlineData("07800112233", "7800", "112233")]
        [InlineData("07900112233", "7900", "112233")]
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var parser = new UkPhoneNumberParser();
            var phoneNumber = parser.Parse(value);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal("+44", mobilePhoneNumber.CallingCode);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
            Assert.Equal("0", mobilePhoneNumber.TrunkPrefix);
        }

        [Theory]
        [InlineData("07911212345", "7911", "212345")]
        [InlineData("07911812345", "7911", "812345")]
        public void Parse_Known_MobilePhoneNumber_DataOnly(string value, string areaCode, string localNumber)
        {
            var parser = new UkPhoneNumberParser();
            var phoneNumber = parser.Parse(value);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal("+44", mobilePhoneNumber.CallingCode);
            Assert.True(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
            Assert.Equal("0", mobilePhoneNumber.TrunkPrefix);
        }

        [Theory]
        [InlineData("07600112233", "7600", "112233")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string areaCode, string localNumber)
        {
            var parser = new UkPhoneNumberParser();
            var phoneNumber = parser.Parse(value);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal("+44", mobilePhoneNumber.CallingCode);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
            Assert.Equal("0", mobilePhoneNumber.TrunkPrefix);
        }

        [Theory]
        [InlineData("07000112233", "7000", "112233")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var parser = new UkPhoneNumberParser();
            var phoneNumber = parser.Parse(value);

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal("+44", mobilePhoneNumber.CallingCode);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
            Assert.Equal("0", mobilePhoneNumber.TrunkPrefix);
        }

        [Theory]
        [InlineData("01100000000")]
        [InlineData("01110000000")]
        [InlineData("01120000000")]
        [InlineData("01190000000")]
        [InlineData("01710000000")]
        [InlineData("01810000000")]
        [InlineData("02100000000")]
        [InlineData("02200000000")]
        [InlineData("02500000000")]
        [InlineData("02600000000")]
        [InlineData("02700000000")]
        [InlineData("07200000000")]
        [InlineData("07911111111")]
        public void Parse_Unknown_AreaCode_Or_LocalNumber_Throws_Exception(string value)
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse(value));
        }

        [Fact]
        public void Parse_Throws_Exception_If_ServiceType_Invalid()
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse("0411111111"));
        }

        [Fact]
        public void Parse_Throws_Exception_If_TrunkPrefix_Invalid()
        {
            var parser = new UkPhoneNumberParser();
            var exception = Assert.Throws<NotSupportedException>(() => parser.Parse("1111111111"));
        }
    }
}
