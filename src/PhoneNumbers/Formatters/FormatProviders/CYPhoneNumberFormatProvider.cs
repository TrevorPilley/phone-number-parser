namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Cyprus numbers.
/// </summary>
internal sealed class CYPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private CYPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new CYPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            8 => "#### ####",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
