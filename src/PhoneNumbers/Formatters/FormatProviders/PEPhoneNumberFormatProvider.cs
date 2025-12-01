namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Peru numbers.
/// </summary>
internal sealed class PEPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private PEPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new PEPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => international ? "### ### ###" : "0### ### ###",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
