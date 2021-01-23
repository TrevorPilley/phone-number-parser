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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07417000000", "7417", "000000")]
        [InlineData("07417999999", "7417", "999999")]
        [InlineData("07418000000", "7418", "000000")]
        [InlineData("07418399999", "7418", "399999")]
        [InlineData("07418500000", "7418", "500000")]
        [InlineData("07418999999", "7418", "999999")]
        [InlineData("07419000000", "7419", "000000")]
        [InlineData("07419999999", "7419", "999999")]
        [InlineData("07451000000", "7451", "000000")]
        [InlineData("07451999999", "7451", "999999")]
        [InlineData("07452700000", "7452", "700000")]
        [InlineData("07452999999", "7452", "999999")]
        [InlineData("07453000000", "7453", "000000")]
        [InlineData("07453999999", "7453", "999999")]
        [InlineData("07456000000", "7456", "000000")]
        [InlineData("07456999999", "7456", "999999")]
        [InlineData("07457000000", "7457", "000000")]
        [InlineData("07457599999", "7457", "599999")]
        [InlineData("07457700000", "7457", "700000")]
        [InlineData("07457999999", "7457", "999999")]
        [InlineData("07458000000", "7458", "000000")]
        [InlineData("07458999999", "7458", "999999")]
        public void Parse_Known_MobilePhoneNumber_74XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07700000000", "7700", "000000")]
        [InlineData("07700199999", "7700", "199999")]
        [InlineData("07700700000", "7700", "700000")]
        [InlineData("07700999999", "7700", "999999")]
        [InlineData("07701000000", "7701", "000000")]
        [InlineData("07701999999", "7701", "999999")]
        [InlineData("07780000000", "7780", "000000")]
        [InlineData("07780999999", "7780", "999999")]
        [InlineData("07782000000", "7782", "000000")]
        [InlineData("07782999999", "7782", "999999")]
        [InlineData("07796000000", "7796", "000000")]
        [InlineData("07796999999", "7796", "999999")]
        [InlineData("07798000000", "7798", "000000")]
        [InlineData("07798999999", "7798", "999999")]
        public void Parse_Known_MobilePhoneNumber_77XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07828000000", "7828", "000000")]
        [InlineData("07828999999", "7828", "999999")]
        [InlineData("07830000000", "7830", "000000")]
        [InlineData("07830999999", "7830", "999999")]
        [InlineData("07838000000", "7838", "000000")]
        [InlineData("07838999999", "7838", "999999")]
        [InlineData("07840000000", "7840", "000000")]
        [InlineData("07840999999", "7840", "999999")]
        public void Parse_Known_MobilePhoneNumber_78XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07910000000", "7910", "000000")]
        [InlineData("07910999999", "7910", "999999")]
        [InlineData("07912000000", "7912", "000000")]
        [InlineData("07912999999", "7912", "999999")]
        [InlineData("07923000000", "7923", "000000")]
        [InlineData("07923999999", "7923", "999999")]
        [InlineData("07925000000", "7925", "000000")]
        [InlineData("07925999999", "7925", "999999")]
        [InlineData("07936000000", "7936", "000000")]
        [InlineData("07936999999", "7936", "999999")]
        [InlineData("07938000000", "7938", "000000")]
        [InlineData("07938999999", "7938", "999999")]
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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
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
            Assert.Equal(CountryInfo.UnitedKingdom, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
