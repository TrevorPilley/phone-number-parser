using System;
using Moq;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="PhoneNumberParser"/> class.
    /// </summary>
    /// <remarks>
    /// All tests use unused calling codes and fake numbers.
    /// </remarks>
    public class PhoneNumberParserTests
    {
        [Fact]
        public void Parse_Throws_Exception_For_Empty_Value() =>
            Assert.Throws<ArgumentException>(() => GetParser().Parse(" ", CountryInfo.UK));

        [Fact]
        public void Parse_Throws_Exception_For_Null_CountryInfo() =>
            Assert.Throws<ArgumentNullException>(() => GetParser().Parse("012345667788", null));

        [Fact]
        public void Parse_Throws_Exception_For_Null_Value() =>
            Assert.Throws<ArgumentException>(() => GetParser().Parse(null, CountryInfo.UK));

        private static PhoneNumberParser GetParser() =>
            new Mock<PhoneNumberParser> { CallBase = true }.Object;
    }
}
