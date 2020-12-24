using System;
using Xunit;

namespace PhoneNumbers.Tests
{
    public partial class CountryInfoTests
    {
        [Fact]
        public void AllSupported_Contains_All() =>
            Assert.Single(CountryInfo.AllSupported());

        [Fact]
        public void Find_Throws_For_Null_Country_Code() =>
            Assert.Throws<NotSupportedException>(() => CountryInfo.Find(null));

        [Fact]
        public void Find_Throws_For_Unknown_Country_Code() =>
            Assert.Throws<NotSupportedException>(() => CountryInfo.Find("ZZ"));
    }
}
