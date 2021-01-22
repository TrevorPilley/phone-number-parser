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
        public void GetParser_For_CountryInfo_France_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.France));

        [Fact]
        public void GetParser_For_CountryInfo_HongKong_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.HongKong));

        [Fact]
        public void GetParser_For_CountryInfo_Ireland_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Ireland));

        [Fact]
        public void GetParser_For_CountryInfo_Italy_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Italy));

        [Fact]
        public void GetParser_For_CountryInfo_Singapore_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.SG));

        [Fact]
        public void GetParser_For_CountryInfo_Spain_Returns_DefaultPhoneNumberParser() =>
            Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Spain));

        [Fact]
        public void GetParser_For_CountryInfo_UnitedKingdom_Returns_GBPhoneNumberParser() =>
            Assert.IsType<GBPhoneNumberParser>(_factory.GetParser(CountryInfo.UnitedKingdom));

        [Fact]
        public void GetParser_Returns_Same_Instance() =>
            Assert.Same(_factory.GetParser(CountryInfo.UnitedKingdom), _factory.GetParser(CountryInfo.UnitedKingdom));
    }
}
