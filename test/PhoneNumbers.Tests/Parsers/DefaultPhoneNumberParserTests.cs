using System;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/>.
    /// </summary>
    public class DefaultPhoneNumberParserTests
    {
        [Fact]
        public void Constructor_Throws_For_Null_CountryNumbers() =>
            Assert.Throws<ArgumentNullException>(() => new DefaultPhoneNumberParser(CountryInfo.UK, null));
    }
}
