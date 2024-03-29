namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the E.123 international format.
/// </summary>
internal sealed class E123PhoneNumberFormatter : InternationalPhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="E123PhoneNumberFormatter"/> class.
    /// </summary>
    private E123PhoneNumberFormatter()
    {
    }

    /// <summary>
    /// Gets the <see cref="E123PhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new E123PhoneNumberFormatter();

    /// <inheritdoc/>
    internal override bool CanFormat(string format) =>
        format?.Equals("E.123", StringComparison.Ordinal) == true;

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        Format(phoneNumber, charBetweenCallingCodeAndNsn: Chars.Space);
}
