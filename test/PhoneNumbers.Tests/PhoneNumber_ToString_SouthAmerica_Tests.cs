namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_SouthAmerica_Tests
{
    [Theory]
    [InlineData("+556123122026", "E.123", "+55 61 2312-2026")]
    [InlineData("+5541732649808", "E.123", "+55 41 73264-9808")]
    [InlineData("+556123122026", "N", "(061) 2312-2026")]
    [InlineData("+5541732649808", "N", "(041) 73264-9808")]
    [InlineData("+556123122026", "RFC3966", "tel:+55-61-2312-2026")]
    [InlineData("+5541732649808", "RFC3966", "tel:+55-41-73264-9808")]
    public void Brazil_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
