namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_NorthAmerica_Tests
{
    [Theory]
    [InlineData("+12644972442", "E.123", "+1 264-497-2442")]
    [InlineData("+12644972442", "N", "(264) 497-2442")]
    [InlineData("+12644972442", "RFC3966", "tel:+1-264-497-2442")]
    public void Anguilla_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+12684804405", "E.123", "+1 268-480-4405")]
    [InlineData("+12684804405", "N", "(268) 480-4405")]
    [InlineData("+12684804405", "RFC3966", "tel:+1-268-480-4405")]
    public void AntiguaAndBarbuda_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+12423930234", "E.123", "+1 242-393-0234")]
    [InlineData("+12423930234", "N", "(242) 393-0234")]
    [InlineData("+12423930234", "RFC3966", "tel:+1-242-393-0234")]
    public void Bahamas_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+12465352573", "E.123", "+1 246-535-2573")]
    [InlineData("+12465352573", "N", "(246) 535-2573")]
    [InlineData("+12465352573", "RFC3966", "tel:+1-246-535-2573")]
    public void Barbados_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+14414056000", "E.123", "+1 441-405-6000")]
    [InlineData("+14414056000", "N", "(441) 405-6000")]
    [InlineData("+14414056000", "RFC3966", "tel:+1-441-405-6000")]
    public void Bermuda_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+12844946786", "E.123", "+1 284-494-6786")]
    [InlineData("+12844946786", "N", "(284) 494-6786")]
    [InlineData("+12844946786", "RFC3966", "tel:+1-284-494-6786")]
    public void BritishVirginIslands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+16137020016", "E.123", "+1 613-702-0016")]
    [InlineData("+16137020016", "N", "(613) 702-0016")]
    [InlineData("+16137020016", "RFC3966", "tel:+1-613-702-0016")]
    public void Canada_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+13459464282", "E.123", "+1 345-946-4282")]
    [InlineData("+13459464282", "N", "(345) 946-4282")]
    [InlineData("+13459464282", "RFC3966", "tel:+1-345-946-4282")]
    public void CaymanIslands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+17677011252", "E.123", "+1 767-701-1252")]
    [InlineData("+17677011252", "N", "(767) 701-1252")]
    [InlineData("+17677011252", "RFC3966", "tel:+1-767-701-1252")]
    public void Dominica_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+14734081342", "E.123", "+1 473-408-1342")]
    [InlineData("+14734081342", "N", "(473) 408-1342")]
    [InlineData("+14734081342", "RFC3966", "tel:+1-473-408-1342")]
    public void Grenada_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+18769686053", "E.123", "+1 876-968-6053")]
    [InlineData("+18769686053", "N", "(876) 968-6053")]
    [InlineData("+18769686053", "RFC3966", "tel:+1-876-968-6053")]
    public void Jamaica_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+16644913789", "E.123", "+1 664-491-3789")]
    [InlineData("+16644913789", "N", "(664) 491-3789")]
    [InlineData("+16644913789", "RFC3966", "tel:+1-664-491-3789")]
    public void Montserrat_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+16702202200", "E.123", "+1 670-220-2200")]
    [InlineData("+16702202200", "N", "(670) 220-2200")]
    [InlineData("+16702202200", "RFC3966", "tel:+1-670-220-2200")]
    public void NorthernMarianaIsland_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+17877222977", "E.123", "+1 787-722-2977")]
    [InlineData("+17877222977", "N", "(787) 722-2977")]
    [InlineData("+17877222977", "RFC3966", "tel:+1-787-722-2977")]
    public void PuertoRico_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+18692291432", "E.123", "+1 869-229-1432")]
    [InlineData("+18692291432", "N", "(869) 229-1432")]
    [InlineData("+18692291432", "RFC3966", "tel:+1-869-229-1432")]
    public void SaintKittsAndNevis_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+17584581701", "E.123", "+1 758-458-1701")]
    [InlineData("+17584581701", "N", "(758) 458-1701")]
    [InlineData("+17584581701", "RFC3966", "tel:+1-758-458-1701")]
    public void SaintLucia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+17842664245", "E.123", "+1 784-266-4245")]
    [InlineData("+17842664245", "N", "(784) 266-4245")]
    [InlineData("+17842664245", "RFC3966", "tel:+1-784-266-4245")]
    public void SaintVincentAndTheGrenadines_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+17215425557", "E.123", "+1 721-542-5557")]
    [InlineData("+17215425557", "N", "(721) 542-5557")]
    [InlineData("+17215425557", "RFC3966", "tel:+1-721-542-5557")]
    public void SintMaarten_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+18686758288", "E.123", "+1 868-675-8288")]
    [InlineData("+18686758288", "N", "(868) 675-8288")]
    [InlineData("+18686758288", "RFC3966", "tel:+1-868-675-8288")]
    public void TrinidadAndTobago_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+16499461900", "E.123", "+1 649-946-1900")]
    [InlineData("+16499461900", "N", "(649) 946-1900")]
    [InlineData("+16499461900", "RFC3966", "tel:+1-649-946-1900")]
    public void TurksAndCaicosIslands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+13407731404", "E.123", "+1 340-773-1404")]
    [InlineData("+13407731404", "N", "(340) 773-1404")]
    [InlineData("+13407731404", "RFC3966", "tel:+1-340-773-1404")]
    public void UnitedStatesVirginIslands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+12124841200", "E.123", "+1 212-484-1200")]
    [InlineData("+12124841200", "N", "(212) 484-1200")]
    [InlineData("+12124841200", "RFC3966", "tel:+1-212-484-1200")]
    public void UnitedStates_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
