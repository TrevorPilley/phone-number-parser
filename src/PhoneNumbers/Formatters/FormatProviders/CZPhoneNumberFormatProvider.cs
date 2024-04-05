namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Czech Republic numbers.
/// </summary>
internal sealed class CZPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private CZPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new CZPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => "### ### ###",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
