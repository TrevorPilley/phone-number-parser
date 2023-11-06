namespace PhoneNumbers.Formatters;

/// <summary>
/// The base class for a class which can format a <see cref="PhoneNumber"/>.
/// </summary>
internal abstract class InternationalPhoneNumberFormatter : PhoneNumberFormatter
{
    protected string Format(
        PhoneNumber phoneNumber,
        string? outputPrefix = null,
        Char charBetweenCallingCodeAndNsn = Chars.Null,
        Char nonDigitSubstitute = Chars.Null)
    {
        var nsnMask = phoneNumber.Country.FormatProvider.GetFormat(phoneNumber, international: true);

        var arSize = nsnMask.Length + 1; // add one for the + appended to the calling code

        if (outputPrefix is not null)
        {
            arSize += outputPrefix.Length;
        }

        arSize += phoneNumber.Country.CallingCode.Length;

        if (charBetweenCallingCodeAndNsn != Chars.Null)
        {
            arSize = arSize + 1;
        }

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
