using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="E164PhoneNumberFormatter"/> class.
/// </summary>
public class E164PhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_E164() =>
        Assert.False(E164PhoneNumberFormatter.Instance.CanFormat("E.123"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(E164PhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_E164() =>
        Assert.True(E164PhoneNumberFormatter.Instance.CanFormat("E.164"));

    [Fact]
    public void Format_Throws_If_PhoneNumber_Null() =>
        Assert.Throws<ArgumentNullException>(() => E164PhoneNumberFormatter.Instance.Format(null));

    [Fact]
    public void Format_With_Ndc_And_Sn() =>
        Assert.Equal(
            "+42212345667788",
            E164PhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", "12345", "667788")));

    [Fact]
    public void Format_With_Sn() =>
        Assert.Equal(
            "+422667788",
            E164PhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", null, "667788")));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(E164PhoneNumberFormatter.Instance);
        Assert.Same(E164PhoneNumberFormatter.Instance, E164PhoneNumberFormatter.Instance);
    }
}
