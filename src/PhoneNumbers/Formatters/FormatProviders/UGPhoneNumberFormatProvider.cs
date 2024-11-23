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
        if (phoneNumber.NationalDestinationCode! == 3 ||
            phoneNumber.NationalDestinationCode! == 4)
        {
            return international ? "## ### ####" : "0## ### ####";
        }

        return base.ProvideFormat(phoneNumber, international);
    }
}
