namespace PhoneNumbers.Formatters;

/// <summary>
/// The base class for a class which can format a <see cref="PhoneNumber"/>.
/// </summary>
internal abstract class PhoneNumberFormatter
{
    internal const string DefaultFormat = "E.164";

    /// <summary>
    /// Gets a value indicating whether the format can format based upon the specified format string.
    /// </summary>
    /// <param name="format">The format string.</param>
    internal abstract bool CanFormat(string format);

    /// <summary>
    /// Formats the <see cref="PhoneNumber"/>.
    /// </summary>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> to format.</param>
    internal abstract string Format(PhoneNumber phoneNumber);
}
