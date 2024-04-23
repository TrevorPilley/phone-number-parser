namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for France numbers.
/// </summary>
internal sealed class FRPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private FRPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new FRPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => international ? "# ## ## ## ##" : "0# ## ## ## ##",
            13 => international ? "# ## ## ## ## ## ##" : "0# ## ## ## ## ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
