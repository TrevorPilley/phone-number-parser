using System;
using System.Linq;
using Xunit;

namespace PhoneNumbers.Tests
{
    public partial class CountryInfoTests
    {
        [Fact]
        public void AllSupported_Contains_All() =>
            Assert.Equal(1, CountryInfo.AllSupported().Count());

        [Fact]
        public void Find_Throws_For_Null_Country_Code() =>
            Assert.Throws<NotSupportedException>(() => CountryInfo.Find(null));

        [Fact]
        public void Find_Throws_For_Unknown_Country_Code() =>
            Assert.Throws<NotSupportedException>(() => CountryInfo.Find("ZZ"));
    }
}
