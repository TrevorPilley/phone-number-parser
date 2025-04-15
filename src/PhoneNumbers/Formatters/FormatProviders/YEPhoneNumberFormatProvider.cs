namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Yemen numbers.
/// </summary>
internal sealed class YEPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private YEPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new YEPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            8 => international ? "# ### ## ##" : "0# ### ## ##",
            9 => international ? "### ### ###" : "0### ### ###",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
