using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="PhoneNumberParserFactory"/> class.
    /// </summary>
    public class PhoneNumberParserFactoryTests
    {
        private readonly PhoneNumberParserFactory _factory = new();

        [Fact]
        public void GetParser_For_CountryInfo_ES_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.ES));

        [Fact]
        public void GetParser_For_CountryInfo_FR_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.FR));

        [Fact]
        public void GetParser_For_CountryInfo_IE_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.IE));

        [Fact]
        public void GetParser_For_CountryInfo_IT_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.IT));

        [Fact]
        public void GetParser_For_CountryInfo_UK_Returns_GBPhoneNumberParser() =>
            Assert.IsType<GBPhoneNumberParser>(_factory.GetParser(CountryInfo.UK));

        [Fact]
        public void GetParser_Returns_Same_Instance() =>
            Assert.Same(_factory.GetParser(CountryInfo.UK), _factory.GetParser(CountryInfo.UK));
    }
}
