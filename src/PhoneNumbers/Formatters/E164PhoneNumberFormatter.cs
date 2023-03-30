namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the E.164 format.
/// </summary>
internal sealed class E164PhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="E164PhoneNumberFormatter"/> class.
    /// </summary>
    private E164PhoneNumberFormatter()
    {
    }

    /// <summary>
    /// Gets the <see cref="E164PhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new E164PhoneNumberFormatter();

    /// <inheritdoc/>
    internal override bool CanFormat(string format) =>
        format?.Equals(DefaultFormat, StringComparison.Ordinal) == true;

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        $"{Chars.Plus}{phoneNumber.Country.CallingCode}{phoneNumber.NationalSignificantNumber}";
}
