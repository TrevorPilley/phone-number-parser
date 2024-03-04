namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Australia numbers.
/// </summary>
internal sealed class AUPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private AUPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new AUPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        if (phoneNumber is NonGeographicPhoneNumber nonGeographicPhoneNumber &&
        nonGeographicPhoneNumber.IsFreephone)
        {
            return "#### ### ###";
        }

        return phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => phoneNumber.Kind switch
            {
                PhoneNumberKind.MobilePhoneNumber => international ? "### ### ###" : "0### ### ###",
                _ => international ? "# #### ####" : "(0#) #### ####",
            },
            _ => base.ProvideFormat(phoneNumber, international),
        };
    }
}
