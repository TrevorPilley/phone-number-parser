namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Mexico numbers.
/// </summary>
internal sealed class MXPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private MXPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new MXPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber!.Length switch
        {
            10 => "## #### ####",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
