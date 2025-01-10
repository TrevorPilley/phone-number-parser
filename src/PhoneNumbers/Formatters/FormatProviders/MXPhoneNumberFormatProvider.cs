namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Mexico numbers.
/// </summary>
internal sealed class MXPhoneNumberFormatProvider : PhoneNumberFormatProvider
{
    private MXPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new MXPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        "## #### ####";
}
