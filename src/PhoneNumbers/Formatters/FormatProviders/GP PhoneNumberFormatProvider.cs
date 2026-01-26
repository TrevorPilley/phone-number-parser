namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Guadeloupe numbers.
/// </summary>
internal sealed class GPPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private GPPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new GPPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => international ? "### ## ## ##" : "0### ## ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
