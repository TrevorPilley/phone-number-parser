namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Faroe Islands numbers.
/// </summary>
internal sealed class FOPhoneNumberFormatProvider : PhoneNumberFormatProvider
{
    private FOPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new FOPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        "## ## ##";
}
