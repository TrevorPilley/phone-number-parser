namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the RFC3966 format.
/// </summary>
internal sealed class Rfc3966PhoneNumberFormatter : InternationalPhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="Rfc3966PhoneNumberFormatter"/> class.
    /// </summary>
    private Rfc3966PhoneNumberFormatter()
    {
    }

    /// <summary>
    /// Gets the <see cref="Rfc3966PhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new Rfc3966PhoneNumberFormatter();

    /// <inheritdoc/>
    internal override bool CanFormat(string format) =>
        format?.Equals("RFC3966", StringComparison.Ordinal) == true;

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        Format(phoneNumber, outputPrefix: "tel:", charBetweenCallingCodeAndNsn: Chars.Hyphen, nonDigitSubstitute: Chars.Hyphen);
}
