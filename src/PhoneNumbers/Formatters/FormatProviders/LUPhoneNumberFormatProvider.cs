namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Luxembourg numbers.
/// </summary>
internal sealed class LUPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private LUPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new LUPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        if (phoneNumber.NationalSignificantNumber.Length == 8 &&
            phoneNumber.NationalSignificantNumber[0] == '2')
        {
            return "## ### ###";
        }

        return base.ProvideFormat(phoneNumber, international);
    }
}
