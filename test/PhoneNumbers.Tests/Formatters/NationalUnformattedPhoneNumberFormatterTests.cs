using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="NationalUnformattedPhoneNumberFormatter"/> class.
/// </summary>
public class NationalUnformattedPhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_U() =>
        Assert.False(NationalUnformattedPhoneNumberFormatter.Instance.CanFormat("E.164"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(NationalUnformattedPhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_U() =>
        Assert.True(NationalUnformattedPhoneNumberFormatter.Instance.CanFormat("U"));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(NationalUnformattedPhoneNumberFormatter.Instance);
        Assert.Same(NationalUnformattedPhoneNumberFormatter.Instance, NationalUnformattedPhoneNumberFormatter.Instance);
    }
}
