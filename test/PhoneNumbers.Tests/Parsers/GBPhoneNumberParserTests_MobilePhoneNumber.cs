using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="GBPhoneNumberParser"/> class for GB <see cref="PhoneNumber"/>s.
    /// </summary>
    public class GBPhoneNumberParserTests_MobilePhoneNumber
    {
        private readonly PhoneNumberParser _parser = GBPhoneNumberParser.Create();

        [Theory]
        [InlineData("07106000000", "7106", "000000")]
        [InlineData("07106999999", "7106", "999999")]
        [InlineData("07199000000", "7199", "000000")]
        [InlineData("07199999999", "7199", "999999")]
        public void Parse_Known_MobilePhoneNumber_71XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07300000000", "7300", "000000")]
        [InlineData("07300999999", "7300", "999999")]
        public void Parse_Known_MobilePhoneNumber_73XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07599000000", "7599", "000000")]
        [InlineData("07599999999", "7599", "999999")]
        public void Parse_Known_MobilePhoneNumber_75XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07624000000", "7624", "000000")]
        [InlineData("07624499999", "7624", "499999")]
        [InlineData("07624500000", "7624", "500000")]
        [InlineData("07624509999", "7624", "509999")]
        [InlineData("07624560000", "7624", "560000")]
        [InlineData("07624569999", "7624", "569999")]
        [InlineData("07624600000", "7624", "600000")]
        [InlineData("07624999999", "7624", "999999")]
        public void Parse_Known_MobilePhoneNumber_76XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07700000000", "7700", "000000")]
        [InlineData("07700999999", "7700", "999999")]
        public void Parse_Known_MobilePhoneNumber_77XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07910000000", "7910", "000000")]
        [InlineData("07910999999", "7910", "999999")]
        [InlineData("07911000000", "7911", "000000")]
        [InlineData("07911199999", "7911", "199999")]
        [InlineData("07911700000", "7911", "700000")]
        [InlineData("07911799999", "7911", "799999")]
        [InlineData("07912000000", "7912", "000000")]
        [InlineData("07912999999", "7912", "999999")]
        [InlineData("07999000000", "7999", "000000")]
        [InlineData("07999999999", "7999", "999999")]
        public void Parse_Known_MobilePhoneNumber_79XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07911200000", "7911", "200000")]
        [InlineData("07911299999", "7911", "299999")]
        [InlineData("07911800000", "7911", "800000")]
        [InlineData("07911899999", "7911", "899999")]
        public void Parse_Known_MobilePhoneNumber_DataOnly(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07600000000", "7600", "000000")]
        [InlineData("07600999999", "7600", "999999")]
        [InlineData("07623000000", "7623", "000000")]
        [InlineData("07623999999", "7623", "999999")]
        [InlineData("07625000000", "7625", "000000")]
        [InlineData("07625999999", "7625", "999999")]
        [InlineData("07699000000", "7699", "000000")]
        [InlineData("07699999999", "7699", "999999")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
        [InlineData("07000000000", "7000", "000000")]
        [InlineData("07000999999", "7000", "999999")]
        [InlineData("07099000000", "7099", "000000")]
        [InlineData("07099999999", "7099", "999999")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

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
