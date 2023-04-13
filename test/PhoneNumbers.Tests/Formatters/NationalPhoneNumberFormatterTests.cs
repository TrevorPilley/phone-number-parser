using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="NationalPhoneNumberFormatter"/> class.
/// </summary>
public class NationalPhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_N() =>
        Assert.False(NationalPhoneNumberFormatter.Instance.CanFormat("E.164"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(NationalPhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_N() =>
        Assert.True(NationalPhoneNumberFormatter.Instance.CanFormat("N"));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(NationalPhoneNumberFormatter.Instance);
        Assert.Same(NationalPhoneNumberFormatter.Instance, NationalPhoneNumberFormatter.Instance);
    }
}
