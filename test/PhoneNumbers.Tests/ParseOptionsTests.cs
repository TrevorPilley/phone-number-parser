using System;
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
                .Where(x => x.PropertyType == typeof(CountryInfo) && x.GetCustomAttribute<ObsoleteAttribute>() == null)
                .Select(x => x.GetValue(null))
                .Cast<CountryInfo>()
                .OrderBy(x => x.SharesCallingCode)
                .ToList();

            Assert.True(countryInfos.Count > 0);
            Assert.Equal(countryInfos, ParseOptions.Default.Countries);
        }

        [Fact]
        public void Remove_Country()
        {
            var parseOptions = new ParseOptions();

            Assert.Contains(CountryInfo.UnitedKingdom, parseOptions.Countries);

            parseOptions.Countries.Remove(CountryInfo.UnitedKingdom);

            Assert.DoesNotContain(CountryInfo.UnitedKingdom, parseOptions.Countries);
        }
    }
}
