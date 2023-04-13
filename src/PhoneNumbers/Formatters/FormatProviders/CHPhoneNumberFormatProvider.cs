namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Switzerland numbers.
/// </summary>
internal sealed class CHPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private CHPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new CHPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            2 => international ? "## ### ## ##" : "0## ### ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
