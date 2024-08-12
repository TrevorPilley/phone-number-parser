namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the Telephony Application Programming Interface (TAPI) international format.
/// </summary>
internal sealed class TapiPhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="TapiPhoneNumberFormatter"/> class.
    /// </summary>
    private TapiPhoneNumberFormatter()
        : base("TAPI")
    {
    }

    /// <summary>
    /// Gets the <see cref="TapiPhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new TapiPhoneNumberFormatter();

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        FormatInternational(phoneNumber, charBetweenCallingCodeAndNsn: Chars.Space, wrapNdc: false);
}
