namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Slovenia numbers.
/// </summary>
internal sealed class SLPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private SLPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new SLPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        return phoneNumber.NationalDestinationCode!.Length switch
        {
#pragma warning disable S3358 // Extract this nested ternary operation into an independent statement.
            1 => international ? "# ### ## ##" : "(0#) ### ## ##", // 1 digit NDCs are Geo only
            3 => international ? "### ## ###" : "0### ## ###",
#pragma warning restore S3358 // Extract this nested ternary operation into an independent statement.
            _ => base.ProvideFormat(phoneNumber, international),
        };
    }
}
