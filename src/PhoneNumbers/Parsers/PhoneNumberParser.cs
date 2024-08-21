namespace PhoneNumbers.Parsers;

/// <summary>
/// The base class for a class which parses a string containing a phone number into a <see cref="PhoneNumber"/> instance.
/// </summary>
internal abstract class PhoneNumberParser
{
    /// <summary>
    /// Initialises a new instance of the <see cref="PhoneNumberParser"/> class.
    /// </summary>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the parser.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="countryInfo"/> is null.</exception>
    protected PhoneNumberParser(CountryInfo countryInfo) =>
        Country = countryInfo ?? throw new ArgumentNullException(nameof(countryInfo));

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the parser.
    /// </summary>
    protected CountryInfo Country { get; }

    /// <summary>
    /// Parses the phone number represented in the specified string into a <see cref="PhoneNumber"/> instance.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
    internal ParseResult Parse(string value)
    {
        var nsnValue = Country.ReadNationalSignificantNumber(value);

        if (!Country.HasValidNsnLength(nsnValue))
        {
            return ParseResult.Failure(
                $"The value must be a {Country.Name} phone number starting {Chars.Plus}{Country.CallingCode}{(Country.HasTrunkPrefix ? " or " + Country.TrunkPrefix : "")} and the national significant number of the phone number must be {string.Join(" or ", Country.NsnLengths)} digits in length.");
        }

        return ParseNsn(nsnValue);
    }

    /// <summary>
    /// Parses the phone number represented in the specified string into a <see cref="PhoneNumber"/> instance.
    /// </summary>
    /// <param name="nsnValue">A string containing the national significant number.</param>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
    /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
    protected virtual ParseResult ParseNsn(string nsnValue) =>
        ParseResult.Failure($"The national significant number {nsnValue} is not a valid {Country.Name} phone number.");
}
