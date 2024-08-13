namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// The base class for a class which can provide a format mask for a <see cref="PhoneNumber"/>.
/// </summary>
internal abstract class PhoneNumberFormatProvider
{
    /// <summary>
    /// Gets the national or international format mask for the specified <see cref="PhoneNumber"/>.
    /// </summary>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> to get the format mask for.</param>
    /// <param name="international">True if number is to be formatted for international, otherwise false.</param>
    internal string GetFormat(PhoneNumber phoneNumber, bool international) =>
        ProvideFormat(phoneNumber, international);

    protected static string GenerateMask(int nsnLength) =>
        new(Chars.Hash, nsnLength);

    protected static string GenerateMask(int ndcLength, int snLength) =>
        ndcLength == 0 ? GenerateMask(snLength) : $"{new string(Chars.Hash, ndcLength)} {new string(Chars.Hash, snLength)}";

    protected abstract string ProvideFormat(PhoneNumber phoneNumber, bool international);
}
