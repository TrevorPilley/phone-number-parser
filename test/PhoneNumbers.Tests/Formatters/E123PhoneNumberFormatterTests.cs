using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="E123PhoneNumberFormatter"/> class.
/// </summary>
public class E123PhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_E123() =>
        Assert.False(E123PhoneNumberFormatter.Instance.CanFormat("E.164"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(E123PhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_E123() =>
        Assert.True(E123PhoneNumberFormatter.Instance.CanFormat("E.123"));

    [Fact]
    public void Format_With_Ndc_And_Sn() =>
        Assert.Equal(
            "+422 12345 667788",
            E123PhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", "12345", "667788")));

    [Fact]
    public void Format_With_Sn() =>
        Assert.Equal(
            "+422 667788",
            E123PhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", null, "667788")));

    [Fact]
    public void Format_Throws_If_PhoneNumber_Null() =>
        Assert.Throws<ArgumentNullException>(() => E123PhoneNumberFormatter.Instance.Format(null));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(E123PhoneNumberFormatter.Instance);
        Assert.Same(E123PhoneNumberFormatter.Instance, E123PhoneNumberFormatter.Instance);
    }
}
