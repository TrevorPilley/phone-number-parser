namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Monaco <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_MC_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Monaco);

        [Theory]
        [InlineData("30000000", "30000000")]
        [InlineData("39999999", "39999999")]
        [InlineData("44000000", "44000000")]
        [InlineData("44999999", "44999999")]
        [InlineData("45100000", "45100000")]
        [InlineData("45999999", "45999999")]
        [InlineData("46000000", "46000000")]
        [InlineData("46999999", "46999999")]
        [InlineData("600000000", "600000000")]
        [InlineData("699999999", "699999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.Monaco, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Null(mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
