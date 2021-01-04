using System.Linq;
using System.Reflection;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class ParseOptionsTests
    {
        [Fact]
        public void Default()
        {
            Assert.NotNull(ParseOptions.Default);

            var countryInfos = typeof(CountryInfo)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.PropertyType == typeof(CountryInfo))
                .Select(x => x.GetValue(null))
                .Cast<CountryInfo>()
                .ToList();

            Assert.Equal(countryInfos, ParseOptions.Default.Countries);
        }
    }
}
