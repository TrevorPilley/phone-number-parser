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
    public abstract bool CanFormat(string format);

    /// <summary>
    /// Formats the <see cref="PhoneNumber"/>.
    /// </summary>
    public abstract string Format(PhoneNumber phoneNumber);
}
