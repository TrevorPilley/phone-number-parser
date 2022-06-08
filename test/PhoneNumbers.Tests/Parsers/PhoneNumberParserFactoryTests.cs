namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="PhoneNumberParserFactory"/> class.
/// </summary>
public class PhoneNumberParserFactoryTests
{
    private readonly PhoneNumberParserFactory _factory = new();

    [Fact]
    public void GetParser_For_CountryInfo_Austria_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Austria));

    [Fact]
    public void GetParser_For_CountryInfo_Belarus_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Belarus));

    [Fact]
    public void GetParser_For_CountryInfo_Belgium_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Belgium));

    [Fact]
    public void GetParser_For_CountryInfo_Bulgaria_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Bulgaria));

    [Fact]
    public void GetParser_For_CountryInfo_Croatia_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Croatia));

    [Fact]
    public void GetParser_For_CountryInfo_CzechRepublic_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.CzechRepublic));

    [Fact]
    public void GetParser_For_CountryInfo_Estonia_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Estonia));

    [Fact]
    public void GetParser_For_CountryInfo_France_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.France));

    [Fact]
    public void GetParser_For_CountryInfo_Germany_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Germany));

    [Fact]
    public void GetParser_For_CountryInfo_Gibraltar_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Gibraltar));

    [Fact]
    public void GetParser_For_CountryInfo_Greece_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Greece));

    [Fact]
    public void GetParser_For_CountryInfo_Guernsey_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Guernsey));

    [Fact]
    public void GetParser_For_CountryInfo_HongKong_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.HongKong));

    [Fact]
    public void GetParser_For_CountryInfo_Ireland_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Ireland));

    [Fact]
    public void GetParser_For_CountryInfo_IsleOfMan_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.IsleOfMan));

    [Fact]
    public void GetParser_For_CountryInfo_Italy_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Italy));

    [Fact]
    public void GetParser_For_CountryInfo_Jersey_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Jersey));

    [Fact]
    public void GetParser_For_CountryInfo_Macau_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Macau));

    [Fact]
    public void GetParser_For_CountryInfo_Monaco_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Monaco));

    [Fact]
    public void GetParser_For_CountryInfo_Netherlands_Returns_GBPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Netherlands));

    [Fact]
    public void GetParser_For_CountryInfo_Poland_Returns_GBPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Poland));

    [Fact]
    public void GetParser_For_CountryInfo_Portugal_Returns_GBPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Portugal));

    [Fact]
    public void GetParser_For_CountryInfo_Romania_Returns_GBPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Romania));

    [Fact]
    public void GetParser_For_CountryInfo_SanMarino_Returns_GBPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.SanMarino));

    [Fact]
    public void GetParser_For_CountryInfo_Singapore_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Singapore));

    [Fact]
    public void GetParser_For_CountryInfo_Slovakia_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Slovakia));

    [Fact]
    public void GetParser_For_CountryInfo_Spain_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Spain));

    [Fact]
    public void GetParser_For_CountryInfo_Sweden_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Sweden));

    [Fact]
    public void GetParser_For_CountryInfo_Switzerland_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Switzerland));

    [Fact]
    public void GetParser_For_CountryInfo_Ukraine_Returns_DefaultPhoneNumberParser() =>
        Assert.IsType<DefaultPhoneNumberParser>(_factory.GetParser(CountryInfo.Ukraine));

    [Fact]
    public void GetParser_For_CountryInfo_UnitedKingdom_Returns_GBPhoneNumberParser() =>
        Assert.IsType<GBPhoneNumberParser>(_factory.GetParser(CountryInfo.UnitedKingdom));

    [Fact]
    public void GetParser_Returns_Same_Instance() =>
        Assert.Same(_factory.GetParser(CountryInfo.UnitedKingdom), _factory.GetParser(CountryInfo.UnitedKingdom));
}
