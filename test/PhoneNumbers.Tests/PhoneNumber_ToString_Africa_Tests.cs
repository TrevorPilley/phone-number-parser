namespace PhoneNumbers.Tests;

public class PhoneNumber_ToString_Africa_Tests
{
    [Theory]
    [InlineData("+20235344239", "E.123", "+20 2 3534 4239")]
    [InlineData("+20235344239", "N", "02 3534 4239")]
    [InlineData("+20235344239", "RFC3966", "tel:+20-2-3534-4239")]
    [InlineData("+20235344239", "U", "0235344239")]
    public void Egypt_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+25420424200", "E.123", "+254 20 424200")]
    [InlineData("+254703042000", "E.123", "+254 703 042000")]
    [InlineData("+25420424200", "N", "020 424200")]
    [InlineData("+254703042000", "N", "0703 042000")]
    [InlineData("+25420424200", "RFC3966", "tel:+254-20-424200")]
    [InlineData("+254703042000", "RFC3966", "tel:+254-703-042000")]
    [InlineData("+25420424200", "U", "020424200")]
    [InlineData("+254703042000", "U", "0703042000")]
    public void Kenya_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+2342094617000", "E.123", "+234 209 461 7000")]
    [InlineData("+2342094617000", "N", "(0209) 461 7000")]
    [InlineData("+2342094617000", "RFC3966", "tel:+234-209-461-7000")]
    [InlineData("+2342094617000", "U", "02094617000")]
    public void Nigeria_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+27215616800", "E.123", "+27 21 561 6800")]
    [InlineData("+27215616800", "N", "021 561 6800")]
    [InlineData("+27215616800", "RFC3966", "tel:+27-21-561-6800")]
    [InlineData("+27215616800", "U", "0215616800")]
    public void SouthAfrica_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+255222199760", "E.123", "+255 22 219 9760")]
    [InlineData("+255222199760", "N", "022 219 9760")]
    [InlineData("+255222199760", "RFC3966", "tel:+255-22-219-9760")]
    [InlineData("+255222199760", "U", "0222199760")]
    public void Tanzania_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
