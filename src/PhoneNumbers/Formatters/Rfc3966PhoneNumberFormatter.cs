namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the RFC3966 format.
/// </summary>
internal sealed class Rfc3966PhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="Rfc3966PhoneNumberFormatter"/> class.
    /// </summary>
    private Rfc3966PhoneNumberFormatter()
        : base("RFC3966")
    {
    }

    /// <summary>
    /// Gets the <see cref="Rfc3966PhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new Rfc3966PhoneNumberFormatter();

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        FormatInternational(phoneNumber, outputPrefix: "tel:", charBetweenCallingCodeAndNsn: Chars.Hyphen, nonDigitSubstitute: Chars.Hyphen);
}
