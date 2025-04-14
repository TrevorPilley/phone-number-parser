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
    [InlineData("+96824222163", "E.123", "+968 24222163")]
    [InlineData("+96824222163", "N", "24222163")]
    [InlineData("+96824222163", "RFC3966", "tel:+968-24222163")]
    [InlineData("+96824222163", "U", "24222163")]
    public void Oman_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+97444994081", "E.123", "+974 44994081")]
    [InlineData("+97444994081", "N", "44994081")]
    [InlineData("+97444994081", "RFC3966", "tel:+974-44994081")]
    [InlineData("+97444994081", "U", "44994081")]
    public void Qatar_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));

    [Theory]
    [InlineData("+966114618281", "E.123", "+966 11 461 8281")]
    [InlineData("+966114618281", "N", "011 461 8281")]
    [InlineData("+966114618281", "RFC3966", "tel:+966-11-461-8281")]
    [InlineData("+966114618281", "U", "0114618281")]
    public void SaudiArabia_Numbers(string input, string format, string expected) =>
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

    [Theory]
    [InlineData("+97126212222", "E.123", "+971 2 621 2222")]
    [InlineData("+97126212222", "N", "(02) 621 2222")]
    [InlineData("+97126212222", "RFC3966", "tel:+971-2-621-2222")]
    [InlineData("+97126212222", "U", "026212222")]
    public void UnitedArabEmirates_Numbers(string input, string format, string expected) =>
        Assert.Equal(expected, PhoneNumber.Parse(input).ToString(format));
}
