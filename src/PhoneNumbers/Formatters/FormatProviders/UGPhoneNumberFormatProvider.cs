namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Uganda numbers.
/// </summary>
internal sealed class UGPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private UGPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new UGPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        if (phoneNumber.NationalDestinationCode!.Equals("3", StringComparison.Ordinal) ||
            phoneNumber.NationalDestinationCode!.Equals("4", StringComparison.Ordinal))
        {
            return international ? "## ### ####" : "0## ### ####";
        }

        return base.ProvideFormat(phoneNumber, international);
    }
}
