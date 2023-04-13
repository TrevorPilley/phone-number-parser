namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Ukraine numbers.
/// </summary>
internal sealed class UAPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private UAPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new UAPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            2 => phoneNumber.NationalSignificantNumber.Length switch
            {
                9 => international ? "## ### ## ##" : "(0##) ### ## ##",
                _ => base.ProvideFormat(phoneNumber, international),
            },
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
