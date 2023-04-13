using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="Rfc3966PhoneNumberFormatter"/> class.
/// </summary>
public class Rfc3966PhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_RFC3966() =>
        Assert.False(Rfc3966PhoneNumberFormatter.Instance.CanFormat("E.123"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(Rfc3966PhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_RFC3966() =>
        Assert.True(Rfc3966PhoneNumberFormatter.Instance.CanFormat("RFC3966"));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(Rfc3966PhoneNumberFormatter.Instance);
        Assert.Same(Rfc3966PhoneNumberFormatter.Instance, Rfc3966PhoneNumberFormatter.Instance);
    }
}
