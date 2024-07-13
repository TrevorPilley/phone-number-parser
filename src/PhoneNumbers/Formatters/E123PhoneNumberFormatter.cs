namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the E.123 international format.
/// </summary>
internal sealed class E123PhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="E123PhoneNumberFormatter"/> class.
    /// </summary>
    private E123PhoneNumberFormatter()
        : base("E.123")
    {
    }

    /// <summary>
    /// Gets the <see cref="E123PhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new E123PhoneNumberFormatter();

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        FormatInternational(phoneNumber, charBetweenCallingCodeAndNsn: Chars.Space);
}
