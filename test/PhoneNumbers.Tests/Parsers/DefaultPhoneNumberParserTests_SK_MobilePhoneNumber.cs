namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Slovakia <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_SK_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Slovakia);

        [Theory]
        [InlineData("0901000000", "901", "000000")]
        [InlineData("0901999999", "901", "999999")]
        [InlineData("0908000000", "908", "000000")]
        [InlineData("0908999999", "908", "999999")]
        [InlineData("0910000000", "910", "000000")]
        [InlineData("0910999999", "910", "999999")]
        [InlineData("0912000000", "912", "000000")]
        [InlineData("0912999999", "912", "999999")]
        [InlineData("0914000000", "914", "000000")]
        [InlineData("0914999999", "914", "999999")]
        [InlineData("0919000000", "919", "000000")]
        [InlineData("0919999999", "919", "999999")]
        [InlineData("0940000000", "940", "000000")]
        [InlineData("0940999999", "940", "999999")]
        [InlineData("0944000000", "944", "000000")]
        [InlineData("0944999999", "944", "999999")]
        [InlineData("0949000000", "949", "000000")]
        [InlineData("0949999999", "949", "999999")]
        [InlineData("0950000000", "950", "000000")]
        [InlineData("0950999999", "950", "999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Slovakia, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }

        [Theory]
        [InlineData("09090000", "9090", "000")]
        [InlineData("09090999", "9090", "999")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Slovakia, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
