namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Japan numbers.
/// </summary>
internal sealed class JPPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private JPPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new JPPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            3 => international ? "### ## ####" : "0### ## ####",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
