namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Slovenia numbers.
/// </summary>
internal sealed class SLPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private SLPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new SLPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            1 => international ? "# ### ## ##" : "(0#) ### ## ##", // 1 digit NDCs are Geo only
            3 => international ? "### ## ###" : "0### ## ###",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
