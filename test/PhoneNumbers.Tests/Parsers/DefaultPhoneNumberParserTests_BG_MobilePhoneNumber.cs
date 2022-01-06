namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bulgaria <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_BG_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bulgaria);

        [Theory]
        [InlineData("043700000", "437", "00000")]
        [InlineData("043799999", "437", "99999")]
        [InlineData("043900000", "439", "00000")]
        [InlineData("043999999", "439", "99999")]
        [InlineData("0870000000", "87", "0000000")]
        [InlineData("0879999999", "87", "9999999")]
        [InlineData("0890000000", "89", "0000000")]
        [InlineData("0899999999", "89", "9999999")]
        [InlineData("0984000000", "984", "000000")]
        [InlineData("0984999999", "984", "999999")]
        [InlineData("0989000000", "989", "000000")]
        [InlineData("0989999999", "989", "999999")]
        [InlineData("0990000000", "990", "000000")]
        [InlineData("0990999999", "990", "999999")]
        [InlineData("0999000000", "999", "000000")]
        [InlineData("0999999999", "999", "999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Bulgaria, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
