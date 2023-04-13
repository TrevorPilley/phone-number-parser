namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Monaco numbers.
/// </summary>
internal sealed class MCPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private MCPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new MCPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            8 => "## ## ## ##",
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
