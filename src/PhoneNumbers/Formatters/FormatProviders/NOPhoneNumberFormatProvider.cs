namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Norway numbers.
/// </summary>
internal sealed class NOPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private NOPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new NOPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        if (phoneNumber.NationalSignificantNumber[0] == '8')
        {
            return "### ## ###";
        }

        return phoneNumber.NationalSignificantNumber.Length switch
        {
            8 => "## ## ## ##",
            12 => "## ## ## ## ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
    }
}
