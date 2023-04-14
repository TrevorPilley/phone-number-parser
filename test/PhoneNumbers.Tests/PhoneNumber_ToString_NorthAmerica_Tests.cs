namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_NorthAmerica_Tests
{
    [Theory]
    [InlineData("+16137020016", "E.123", "+1 613-702-0016")]
    [InlineData("+16137020016", "N", "(613) 702-0016")]
    [InlineData("+16137020016", "RFC3966", "tel:+1-613-702-0016")]
    public void Canada_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+17877222977", "E.123", "+1 787-722-2977")]
    [InlineData("+17877222977", "N", "(787) 722-2977")]
    [InlineData("+17877222977", "RFC3966", "tel:+1-787-722-2977")]
    public void PuertoRico_Numbers(string input, string format, string expected) =>
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
