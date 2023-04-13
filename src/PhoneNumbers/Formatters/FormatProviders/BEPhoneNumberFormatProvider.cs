namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Belgium numbers.
/// </summary>
internal sealed class BEPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private BEPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new BEPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalDestinationCode!.Length switch
        {
            1 => international ? "# ### ## ##" : "0# ### ## ##",
            2 => international ? "## ## ## ##" : "0## ## ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
