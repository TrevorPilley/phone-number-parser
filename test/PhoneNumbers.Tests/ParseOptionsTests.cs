using System.Reflection;

namespace PhoneNumbers.Tests;

public class ParseOptionsTests
{
    [Fact]
    public void AddingCountryMultipleTimesOnlyOnceInList()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.Countries.Add(CountryInfo.UnitedKingdom);
        parseOptions.Countries.Add(CountryInfo.UnitedKingdom);

        Assert.Single(parseOptions.Countries);
    }

    [Fact]
    public void AllowAfricanCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowAfricanCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.Africa, x.Continent));
    }

    [Fact]
    public void AllowAsianCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowAsianCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.Asia, x.Continent));
    }

    [Fact]
    public void AllowEuropeanCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowEuropeanCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.Europe, x.Continent));
    }

    [Fact]
    public void AllowEuropeanUnionCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowEuropeanUnionCountries();

        Assert.Equal(27, parseOptions.Countries.Count);
        Assert.All(parseOptions.Countries, x => Assert.True(x.IsEuropeanUnionMember));
    }

    [Fact]
    public void AllowNatoCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowNatoCountries();

        Assert.Equal(32, parseOptions.Countries.Count);
        Assert.All(parseOptions.Countries, x => Assert.True(x.IsNatoMember));
    }

    [Fact]
    public void AllowNorthAmericanCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowNorthAmericanCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.NorthAmerica, x.Continent));
    }

    [Fact]
    public void AllowNorthAmericanNumberingPlanCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowNorthAmericanNumberingPlanCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.NanpCallingCode, x.CallingCode));
    }

    [Fact]
    public void AllowOceanianCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowOceanianCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.Oceania, x.Continent));
    }

    [Fact]
    public void AllowOecdCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowOecdCountries();

        Assert.Equal(32, parseOptions.Countries.Count);
        Assert.All(parseOptions.Countries, x => Assert.True(x.IsOecdMember));
    }

    [Fact]
    public void AllowSouthAmericanCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowSouthAmericanCountries();

        Assert.True(parseOptions.Countries.Count > 0);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.SouthAmerica, x.Continent));
    }

    [Fact]
    public void AllowUnitedKingdomNumberingPlanCountries()
    {
        var parseOptions = new ParseOptions();
        parseOptions.Countries.Clear();
        parseOptions.AllowUnitedKingdomNumberingPlanCountries();

        Assert.Equal(4, parseOptions.Countries.Count);
        Assert.All(parseOptions.Countries, x => Assert.Equal(CountryInfo.UnitedKingdom.CallingCode, x.CallingCode));
        Assert.Contains(CountryInfo.Guernsey, parseOptions.Countries);
        Assert.Contains(CountryInfo.IsleOfMan, parseOptions.Countries);
        Assert.Contains(CountryInfo.Jersey, parseOptions.Countries);
        Assert.Contains(CountryInfo.UnitedKingdom, parseOptions.Countries);
    }

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
            .OrderBy(x => x.Name);

        Assert.True(countryInfos.Count() > 0);
        Assert.Equal(countryInfos, ParseOptions.Default.Countries.OrderBy(x => x.Name));
    }

    [Fact]
    public void Extensions_Throw_If_ParseOptions_Null()
    {
        var parseOptions = default(ParseOptions);

        typeof(ParseOptionsExtensions)
            .GetMethods(BindingFlags.Static | BindingFlags.Public)
            .Where(x => x.GetParameters().Length == 1 && x.GetParameters()[0].ParameterType == typeof(ParseOptions))
            .ToList()
            .ForEach(x =>
            {
                var exception = Assert.Throws<TargetInvocationException>(() => x.Invoke(null, [parseOptions]));
                Assert.IsType<ArgumentNullException>(exception.InnerException);
                var argumentNullException = (ArgumentNullException)exception.InnerException;
                Assert.Equal("parseOptions", argumentNullException.ParamName);
            });
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
        Assert.All(countryInfos, x => Assert.Equal("44", x.CallingCode));
    }

    [Fact]
    public void GetCountryInfos_Single_Result()
    {
        var countryInfos = ParseOptions.Default.GetCountryInfos("+35340226969");
        Assert.Single(countryInfos);
        Assert.Same(CountryInfo.Ireland, countryInfos.Single());
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
