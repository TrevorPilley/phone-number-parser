namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Netherlands numbers.
/// </summary>
internal sealed class NLPhoneNumberFormatProvider : PhoneNumberFormatProvider
{
    private NLPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new NLPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        international ? "# ## ## ## ##" : "0# ## ## ## ##";
}
