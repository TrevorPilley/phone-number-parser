namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Greece numbers.
/// </summary>
internal sealed class GRPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private GRPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new GRPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            2 => "### #######",
            3 => "#### ######",
            4 => "##### #####",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
