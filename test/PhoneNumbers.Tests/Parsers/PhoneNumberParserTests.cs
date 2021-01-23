using System;
using System.Reflection;
using Moq;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="PhoneNumberParser"/> class.
    /// </summary>
    public class PhoneNumberParserTests
    {
        [Fact]
        public void Constructor_Throws_For_Null_CountryInfo()
        {
            var exception = Assert.Throws<TargetInvocationException>(() => new Mock<PhoneNumberParser>(null) { CallBase = true }.Object);
            Assert.IsType<ArgumentNullException>(exception.InnerException);
        }

        [Fact]
        public void Parse_Throws_Exception_For_Empty_Value() =>
            Assert.Throws<ParseException>(() => GetParser().Parse(" ").ThrowIfFailure());

        [Fact]
        public void Parse_Throws_Exception_For_Null_Value() =>
            Assert.Throws<ParseException>(() => GetParser().Parse(null).ThrowIfFailure());

        private static PhoneNumberParser GetParser() =>
            new Mock<PhoneNumberParser>(CountryInfo.UnitedKingdom) { CallBase = true }.Object;
    }
}
