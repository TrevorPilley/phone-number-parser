namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Malta numbers.
/// </summary>
internal sealed class MTPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private MTPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new MTPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            8 => "#### ####",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
