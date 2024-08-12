using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="TapiPhoneNumberFormatter"/> class.
/// </summary>
public class TapiPhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_TAPI() =>
        Assert.False(TapiPhoneNumberFormatter.Instance.CanFormat("E.164"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(TapiPhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_TAPI() =>
        Assert.True(TapiPhoneNumberFormatter.Instance.CanFormat("TAPI"));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(TapiPhoneNumberFormatter.Instance);
        Assert.Same(TapiPhoneNumberFormatter.Instance, TapiPhoneNumberFormatter.Instance);
    }
