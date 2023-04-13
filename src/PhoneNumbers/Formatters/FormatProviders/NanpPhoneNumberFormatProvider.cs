namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for North American Numbering Plan numbers.
/// </summary>
internal sealed class NanpPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private NanpPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new NanpPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            10 => international ? "###-###-####" : "(###) ###-####",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
