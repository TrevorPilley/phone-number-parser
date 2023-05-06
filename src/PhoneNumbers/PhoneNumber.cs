using System.Diagnostics.CodeAnalysis;
using PhoneNumbers.Formatters;

namespace PhoneNumbers;

/// <summary>
/// The base class representing a <see cref="PhoneNumber"/>.
/// </summary>
public abstract class PhoneNumber
{
    /// <summary>
    /// Initialises a new instance of the <see cref="PhoneNumber"/> class.
    /// </summary>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    protected PhoneNumber(PhoneNumberHint phoneNumberHint)
    {
        Hint = phoneNumberHint;
    }

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the phone number.
    /// </summary>
    public required CountryInfo Country { get; init; }

    /// <summary>
    /// Gets a value indicating whether the phone number has a national destination code.
    /// </summary>
    public bool HasNationalDestinationCode => NationalDestinationCode is not null;

    /// <summary>
    /// Gets the <see cref="PhoneNumberKind"/> of the phone number.
    /// </summary>
    /// <remarks>This instance can be cast to the appropriate type based upon the value.</remarks>
    public abstract PhoneNumberKind Kind { get; }

    /// <summary>
    /// Gets the national destination code of the phone number.
    /// </summary>
    /// <remarks>May also be referred to as area code or mobile network code.</remarks>
    public string? NationalDestinationCode { get; init; }

    /// <summary>
    /// Gets the national significant number of the phone number.
    /// </summary>
    /// <remarks>Typically this is the number excluding the country code or trunk prefix.</remarks>
    public required string NationalSignificantNumber { get; init; }

    /// <summary>
    /// Gets the subscriber number of the phone number.
    /// </summary>
    /// <remarks>May also be referred to as local number.</remarks>
    public required string SubscriberNumber { get; init; }

    /// <summary>
    /// Gets the <see cref="PhoneNumberHint"/>.
    /// </summary>
    protected PhoneNumberHint Hint { get; }

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon its calling code.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, ParseOptions? options = null)
    {
        options = options ?? ParseOptions.Default;

        foreach (var countryInfo in options.GetCountryInfos(value))
        {
            var result = options.ParserFactory.GetParser(countryInfo).Parse(value);

            if (result.PhoneNumber is not null)
            {
                return result.PhoneNumber!;
            }
        }

        throw new ParseException($"The value '{value}' could not be successfully parsed into a phone number for any country enabled in ParseOptions.");
    }

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the specified <see cref="CountryInfo"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number in the international (e.g. +XX) or national format for the given <see cref="CountryInfo"/>.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="countryInfo"/> is null.</exception>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, CountryInfo countryInfo, ParseOptions? options = null)
    {
        if (countryInfo is null)
        {
            throw new ArgumentNullException(nameof(countryInfo));
        }

        options = options ?? ParseOptions.Default;

        if (!options.Countries.Contains(countryInfo))
        {
            throw new ParseException($"The country {countryInfo.Name} is not enabled in ParseOptions.");
        }

        var result = options.ParserFactory.GetParser(countryInfo).Parse(value);
        result.ThrowIfFailure();

        return result.PhoneNumber!;
    }

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Alpha-2 country code.
    /// </summary>
    /// <param name="value">A string containing a phone number in the international (e.g. +XX) or national format for the given ISO 3166 Alpha-2 country code.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, string countryCode, ParseOptions? options = null)
    {
        options = options ?? ParseOptions.Default;

        var countryInfo = options.GetCountryInfo(countryCode);

        if (countryInfo is null)
        {
            throw new ParseException($"The country code {countryCode} is not currently supported, or is not enabled in ParseOptions.");
        }

        return Parse(value, countryInfo, options);
    }

    /// <summary>
    /// Converts the string representation of a phone number to any possible <see cref="PhoneNumber"/> equivalents. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <param name="phoneNumbers">The <see cref="PhoneNumber"/> equivalents if the conversion succeeds, otherwise null.</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, out IEnumerable<PhoneNumber> phoneNumbers, ParseOptions? options = null)
    {
        options = options ?? ParseOptions.Default;

        phoneNumbers = options.Countries
            .Select(x => options.ParserFactory.GetParser(x).Parse(value))
            .Where(x => x.PhoneNumber is not null)
            .Select(x => x.PhoneNumber)
            .Cast<PhoneNumber>();

        return phoneNumbers.Any();
    }

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, [NotNullWhen(true)] out PhoneNumber? phoneNumber, ParseOptions? options = null)
    {
        options = options ?? ParseOptions.Default;

        foreach (var countryInfo in options.GetCountryInfos(value))
        {
            var result = options.ParserFactory.GetParser(countryInfo).Parse(value);

            if (result.PhoneNumber is not null)
            {
                phoneNumber = result.PhoneNumber;
                return true;
            }
        }

        phoneNumber = default;
        return false;
    }

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number in the international (e.g. +XX) or national format for the given <see cref="CountryInfo"/>.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, CountryInfo countryInfo, [NotNullWhen(true)] out PhoneNumber? phoneNumber, ParseOptions? options = null)
    {
        options = options ?? ParseOptions.Default;

        if (countryInfo is not null &&
            options.Countries.Contains(countryInfo))
        {
            var result = options.ParserFactory.GetParser(countryInfo).Parse(value);

            phoneNumber = result.PhoneNumber;
            return result.PhoneNumber is not null;
        }

        phoneNumber = default;
        return false;
    }

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number in the international (e.g. +XX) or national format for the given ISO 3166 Alpha-2 country code.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <param name="options">The <see cref="ParseOptions"/> to use for parsing the phone number, if not specified (or explicitly set to null) the default parse options are used.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, string countryCode, [NotNullWhen(true)] out PhoneNumber? phoneNumber, ParseOptions? options = null) =>
        TryParse(value, (options ?? ParseOptions.Default).GetCountryInfo(countryCode)!, out phoneNumber, options);

    /// <inheritdoc/>
    public override string ToString() =>
        ToString(PhoneNumberFormatter.DefaultFormat);

    /// <summary>
    /// Converts the phone number value of this instance to its equivalent string representation, using the specified format.
    /// </summary>
    /// <param name="format">The format string to use.</param>
    /// <exception cref="FormatException">Thrown if the format string is not valid.</exception>
    /// <returns>The string representation of the value of this instance as specified by the format.</returns>
    public string ToString(string format) =>
        CountryInfo.GetFormatter(format).Format(this);
}
