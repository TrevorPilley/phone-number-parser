using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for CH <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CH_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = DefaultPhoneNumberParser.Create(CountryInfo.Switzerland);

        [Theory]
        [InlineData("0730000000", "73", "0000000")]
        [InlineData("0739999999", "73", "9999999")]
        [InlineData("0750000000", "75", "0000000")]
        [InlineData("0759999999", "75", "9999999")]
        [InlineData("0790000000", "79", "0000000")]
        [InlineData("0799999999", "79", "9999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0740220000", "74", "0220000")]
        [InlineData("0748119999", "74", "8119999")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0878000000", "878", "000000")]
        [InlineData("0878999999", "878", "999999")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.Switzerland, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
