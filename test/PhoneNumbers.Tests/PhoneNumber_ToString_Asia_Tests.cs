namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_Asia_Tests
{
    [Theory]
    [InlineData("+85229616333", "E.123", "+852 2961 6333")]
    [InlineData("+85229616333", "N", "2961 6333")]
    [InlineData("+85229616333", "RFC3966", "tel:+852-2961-6333")]
    [InlineData("+85229616333", "U", "29616333")]
    public void HongKong_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+85328000000", "E.123", "+853 2800 0000")]
    [InlineData("+85328000000", "N", "2800 0000")]
    [InlineData("+85328000000", "RFC3966", "tel:+853-2800-0000")]
    [InlineData("+85328000000", "U", "28000000")]
    public void Macau_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+6563773800", "E.123", "+65 6377 3800")]
    [InlineData("+6563773800", "N", "6377 3800")]
    [InlineData("+6563773800", "RFC3966", "tel:+65-6377-3800")]
    [InlineData("+6563773800", "U", "63773800")]
    public void Singapore_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+904441234", "E.123", "+90 444 12 34")]
    [InlineData("+903122947200", "E.123", "+90 312 294 72 00")]
    [InlineData("+904441234", "N", "(0444) 12 34")]
    [InlineData("+903122947200", "N", "(0312) 294 72 00")]
    [InlineData("+904441234", "RFC3966", "tel:+90-444-12-34")]
    [InlineData("+903122947200", "RFC3966", "tel:+90-312-294-72-00")]
    [InlineData("+904441234", "U", "04441234")]
    [InlineData("+903122947200", "U", "03122947200")]
    public void Turkey_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
