namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for French Overseas Departments numbers.
/// </summary>
internal sealed class FodPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private FodPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new FodPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => international ? "### ## ## ##" : "0### ## ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
