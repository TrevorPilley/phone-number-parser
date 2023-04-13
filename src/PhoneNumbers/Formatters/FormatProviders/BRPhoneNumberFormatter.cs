namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Brazil numbers.
/// </summary>
internal sealed class BRPhoneNumberFormatProvider : PhoneNumberFormatProvider
{
    private BRPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new BRPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.Kind switch
        {
            PhoneNumberKind.MobilePhoneNumber => international ? "## #####-####" : "(0##) #####-####",
            _ => international ? "## ####-####" : "(0##) ####-####",
        };
}
