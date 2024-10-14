namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the national dialling format.
/// </summary>
internal sealed class NationalPhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="NationalPhoneNumberFormatter"/> class.
    /// </summary>
    private NationalPhoneNumberFormatter()
        : base("N")
    {
    }

    /// <summary>
    /// Gets the <see cref="NationalPhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new NationalPhoneNumberFormatter();

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber)
    {
        var nsnMask = phoneNumber.Country.FormatProvider.GetFormat(phoneNumber, international: false);

        Span<char> ar = stackalloc char[nsnMask.Length];
        var arPos = 0;

        var nsnPos = 0;
        for (var i = 0; i < nsnMask.Length; i++)
        {
            if (nsnMask[i] == Chars.Hash)
            {
                ar[arPos++] = phoneNumber.NationalSignificantNumber[nsnPos++];
            }
            else
            {
                ar[arPos++] = nsnMask[i];
            }
        }

        return ar.ToString();
    }
}
