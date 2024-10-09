namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_Oceania_Tests
{
    [Theory]
    [InlineData("+16846339805", "E.123", "+1 684-633-9805")]
    [InlineData("+16846339805", "N", "(684) 633-9805")]
    [InlineData("+16846339805", "RFC3966", "tel:+1-684-633-9805")]
    [InlineData("+16846339805", "U", "6846339805")]
    public void AmericanSamoa_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+61131234", "E.123", "+61 13 1234")]
    [InlineData("+61399636800", "E.123", "+61 3 9963 6800")]
    [InlineData("+61436986301", "E.123", "+61 436 986 301")]
    [InlineData("+611800900090", "E.123", "+61 1800 900 090")]
    [InlineData("+61131234", "N", "013 1234")]
    [InlineData("+61399636800", "N", "(03) 9963 6800")]
    [InlineData("+61436986301", "N", "0436 986 301")]
    [InlineData("+611800900090", "N", "1800 900 090")]
    [InlineData("+61131234", "RFC3966", "tel:+61-13-1234")]
    [InlineData("+61399636800", "RFC3966", "tel:+61-3-9963-6800")]
    [InlineData("+61436986301", "RFC3966", "tel:+61-436-986-301")]
    [InlineData("+611800900090", "RFC3966", "tel:+61-1800-900-090")]
    [InlineData("+61131234", "U", "0131234")]
    [InlineData("+61399636800", "U", "0399636800")]
    [InlineData("+61436986301", "U", "0436986301")]
    [InlineData("+611800900090", "U", "1800900090")]
    public void Australia_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+16716323365", "E.123", "+1 671-632-3365")]
    [InlineData("+16716323365", "N", "(671) 632-3365")]
    [InlineData("+16716323365", "RFC3966", "tel:+1-671-632-3365")]
    [InlineData("+16716323365", "U", "6716323365")]
    public void Guam_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+6753033201", "E.123", "+675 303 3201")]
    [InlineData("+6753033201", "N", "303 3201")]
    [InlineData("+6753033201", "RFC3966", "tel:+675-303-3201")]
    [InlineData("+6753033201", "U", "3033201")]
    public void PapuaNewGuinea_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
