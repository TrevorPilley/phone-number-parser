namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Czech republic <see cref="PhoneNumber"/>s.
    /// </summary>
    public class DefaultPhoneNumberParserTests_CZ_MobilePhoneNumber
    {
        private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.CzechRepublic);

        [Theory]
        [InlineData("601000000", "601", "000000")]
        [InlineData("601999999", "601", "999999")]
        [InlineData("608000000", "608", "000000")]
        [InlineData("608999999", "608", "999999")]
        [InlineData("702000000", "702", "000000")]
        [InlineData("702999999", "702", "999999")]
        [InlineData("705000000", "705", "000000")]
        [InlineData("705999999", "705", "999999")]
        [InlineData("720000000", "72", "0000000")]
        [InlineData("729999999", "72", "9999999")]
        [InlineData("730000000", "73", "0000000")]
        [InlineData("739999999", "73", "9999999")]
        [InlineData("770000000", "77", "0000000")]
        [InlineData("779999999", "77", "9999999")]
        [InlineData("790000000", "79", "0000000")]
        [InlineData("799999999", "79", "9999999")]
        public void Parse_Known_MobilePhoneNumber(string value, string NationalDestinationCode, string subscriberNumber)
        {
            var parseResult = s_parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(CountryInfo.CzechRepublic, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(NationalDestinationCode, mobilePhoneNumber.NationalDestinationCode);
            Assert.Equal(subscriberNumber, mobilePhoneNumber.SubscriberNumber);
        }
    }
}
