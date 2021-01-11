using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for IE PhoneNumbers.
    /// </summary>
    public class DefaultPhoneNumberParserTests_IE_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.IE);

        [Theory]
        [InlineData("0830000000", "83", "0000000")]
        [InlineData("0839999999", "83", "9999999")]
        [InlineData("0840000000", "84", "0000000")]
        [InlineData("0849999999", "84", "9999999")]
        [InlineData("0850000000", "85", "0000000")]
        [InlineData("0859999999", "85", "9999999")]
        [InlineData("0860000000", "86", "0000000")]
        [InlineData("0869999999", "86", "9999999")]
        [InlineData("0870000000", "87", "0000000")]
        [InlineData("0879999999", "87", "9999999")]
        [InlineData("0880000000", "88", "0000000")]
        [InlineData("0889999999", "88", "9999999")]
        [InlineData("0890000000", "89", "0000000")]
        [InlineData("0899999999", "89", "9999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0822000000", "822", "000000")]
        [InlineData("0822999999", "822", "999999")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0700000000", "700", "000000")]
        [InlineData("0700999999", "700", "999999")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.IE, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
