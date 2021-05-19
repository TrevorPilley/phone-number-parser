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

        [Fact]
        public void GetCountryInfo_Does_Not_Exist() =>
            Assert.Null(ParseOptions.Default.GetCountryInfo("ZZ"));

        [Fact]
        public void GetCountryInfo_Exists() =>
            Assert.Same(CountryInfo.UnitedKingdom, ParseOptions.Default.GetCountryInfo("GB"));

        [Fact]
        public void GetCountryInfos_Does_Not_Exist() =>
            Assert.Empty(ParseOptions.Default.GetCountryInfos("+422123456789"));

        [Fact]
        public void GetCountryInfos_Multiple_Results()
        {
            var countryInfos = ParseOptions.Default.GetCountryInfos("+441624696300");
            Assert.Equal(4, countryInfos.Count());
            Assert.All(countryInfos, x => Assert.Equal("+44", x.CallingCode));
        }

        [Fact]
        public void GetCountryInfos_Single_Result()
        {
            var countryInfos = ParseOptions.Default.GetCountryInfos("+35340226969");
            Assert.Single(countryInfos);
            Assert.Same(CountryInfo.Ireland, countryInfos.Single());
        }
    }
}
