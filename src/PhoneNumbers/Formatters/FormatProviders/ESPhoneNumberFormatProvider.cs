namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Spain numbers.
/// </summary>
internal sealed class ESPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private ESPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new ESPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            2 => "## ### ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
