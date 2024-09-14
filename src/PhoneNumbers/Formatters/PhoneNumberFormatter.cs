namespace PhoneNumbers.Formatters;

/// <summary>
/// The base class for a class which can format a <see cref="PhoneNumber"/>.
/// </summary>
internal abstract class PhoneNumberFormatter(string format)
{
    internal const string DefaultFormat = "E.164";
    private readonly string _format = format;

    /// <summary>
    /// Gets a value indicating whether the format can format based upon the specified format string.
    /// </summary>
    /// <param name="format">The format string.</param>
    internal bool CanFormat(string format) =>
        format?.Equals(_format, StringComparison.Ordinal) == true;

    /// <summary>
    /// Formats the <see cref="PhoneNumber"/>.
    /// </summary>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> to format.</param>
    internal abstract string Format(PhoneNumber phoneNumber);

    /// <summary>
    /// Formats the <see cref="PhoneNumber"/> for international dialling with the specified format parameters.
    /// </summary>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> to format.</param>
    /// <param name="outputPrefix">The optional prefix to be used.</param>
    /// <param name="charBetweenCallingCodeAndNsn">The character to use between the calling code and national significant number.</param>
    /// <param name="nonDigitSubstitute">The character to substitute for non digits in the format mask.</param>
    protected static string FormatInternational(
        PhoneNumber phoneNumber,
        string? outputPrefix = null,
        char charBetweenCallingCodeAndNsn = Chars.Null,
        char nonDigitSubstitute = Chars.Null)
    {
        var nsnMask = phoneNumber.Country.FormatProvider.GetFormat(phoneNumber, international: true);

        var arSize =
            (outputPrefix?.Length ?? 0)
            + 1 // add one for the + appended to the calling code
            + phoneNumber.Country.CallingCode.Length
            + (charBetweenCallingCodeAndNsn != Chars.Null ? 1 : 0)
            + nsnMask.Length;

        Span<char> ar = stackalloc char[arSize];
        var arPos = 0;

        if (outputPrefix is not null)
        {
            foreach (var c in outputPrefix)
            {
                ar[arPos++] = c;
            }
        }

        ar[arPos++] = Chars.Plus;

        foreach (var c in phoneNumber.Country.CallingCode)
        {
            ar[arPos++] = c;
        }

        if (charBetweenCallingCodeAndNsn != Chars.Null)
        {
            ar[arPos++] = charBetweenCallingCodeAndNsn;
        }

        var nsnPos = 0;
        for (var i = 0; i < nsnMask.Length; i++)
        {
            if (nsnMask[i] == Chars.Hash)
            {
                ar[arPos++] = phoneNumber.NationalSignificantNumber[nsnPos++];
            }
            else
            {
                ar[arPos++] = nonDigitSubstitute == Chars.Null ? nsnMask[i] : nonDigitSubstitute;
            }
        }

        return ar.ToString();
    }
}
