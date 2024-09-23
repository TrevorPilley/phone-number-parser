namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Turkey numbers.
/// </summary>
internal sealed class TRPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private TRPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new TRPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            7 => international ? "### ## ##" : "(0###) ## ##",
            10 => international ? "### ### ## ##" : "(0###) ### ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
