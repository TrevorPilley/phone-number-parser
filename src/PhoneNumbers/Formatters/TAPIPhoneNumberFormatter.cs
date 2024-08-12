namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the Telephony Application Programming Interface (TAPI) international format.
/// </summary>
internal sealed class TAPIPhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="TAPIPhoneNumberFormatter"/> class.
    /// </summary>
    private E123PhoneNumberFormatter()
        : base("TAPI")
    {
    }

    /// <summary>
    /// Gets the <see cref="TAPIPhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new TAPIPhoneNumberFormatter();

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        FormatInternational(phoneNumber, charBetweenCallingCodeAndNsn: Chars.Space);
}
