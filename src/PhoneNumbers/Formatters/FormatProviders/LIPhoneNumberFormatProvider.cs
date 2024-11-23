namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Liechtenstein numbers.
/// </summary>
internal sealed class LIPhoneNumberFormatProvider : SimplePhoneNumberFormatProvider
{
    private LIPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new LIPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            7 => "### ## ##",
            9 => "### ### ###",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
