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
            Assert.Same(ParseOptions.Default, ParseOptions.Default);

            var countryInfos = typeof(CountryInfo)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.PropertyType == typeof(CountryInfo))
                .Select(x => x.GetValue(null))
                .Cast<CountryInfo>()
                .ToList();

            Assert.True(countryInfos.Count > 0);
            Assert.Equal(countryInfos, ParseOptions.Default.Countries);
        }

        [Fact]
        public void Remove_Country()
        {
            var parseOptions = new ParseOptions();

            Assert.Contains(CountryInfo.UK, parseOptions.Countries);

            parseOptions.Countries.Remove(CountryInfo.UK);

            Assert.DoesNotContain(CountryInfo.UK, parseOptions.Countries);
        }
    }
}
