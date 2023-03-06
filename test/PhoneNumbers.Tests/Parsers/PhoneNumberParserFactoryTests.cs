namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="PhoneNumberParserFactory"/> class.
/// </summary>
public class PhoneNumberParserFactoryTests
{
    private readonly PhoneNumberParserFactory _factory = new();

    [Fact]
    public void GetParser_Rerurns_Correct_Parser()
    {
        foreach (var countryInfo in CountryInfo.GetCountries())
        {
            if (countryInfo == CountryInfo.UnitedKingdom)
            {
                Assert.IsType<GBPhoneNumberParser>(_factory.GetParser(countryInfo));
            }
            else
            {
                Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(countryInfo));
            }
        }
    }

    [Fact]
    public void GetParser_Returns_Same_Instance() =>
        Assert.Same(_factory.GetParser(CountryInfo.UnitedKingdom), _factory.GetParser(CountryInfo.UnitedKingdom));
}
