namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Romania numbers.
/// </summary>
internal sealed class ROPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private ROPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new ROPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        if ("21".Equals(phoneNumber.NationalDestinationCode, StringComparison.Ordinal) &&
            phoneNumber.NationalSignificantNumber.Length == 9)
        {
            return international ? "## ### ## ##" : "0## ### ## ##";
        }

        return phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => international ? "### ### ###" : "0### ### ###",
            _ => base.ProvideFormat(phoneNumber, international),
        };
    }
}
