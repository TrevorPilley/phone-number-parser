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
    [InlineData("+556123122026", "U", "06123122026")]
    [InlineData("+5541732649808", "U", "041732649808")]
    public void Brazil_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+576013198300", "E.123", "+57 601 3198300")]
    [InlineData("+576013198300", "N", "601 3198300")]
    [InlineData("+576013198300", "RFC3966", "tel:+57-601-3198300")]
    [InlineData("+576013198300", "U", "6013198300")]
    public void Colombia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+50028459", "E.123", "+500 28459")]
    [InlineData("+50028459", "N", "28459")]
    [InlineData("+50028459", "RFC3966", "tel:+500-28459")]
    [InlineData("+50028459", "U", "28459")]
    public void FalklandIslands_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+5113324079", "E.123", "+51 1 332 4079")]
    [InlineData("+5113324079", "N", "01 332 4079")]
    [InlineData("+5113324079", "RFC3966", "tel:+51-1-332-4079")]
    [InlineData("+5113324079", "U", "13324079")]
    public void Peru_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
