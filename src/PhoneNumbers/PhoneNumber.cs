using System.Diagnostics.CodeAnalysis;
using PhoneNumbers.Formatters;

namespace PhoneNumbers;

/// <summary>
/// The base class representing a <see cref="PhoneNumber"/>.
/// </summary>
/// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
public abstract class PhoneNumber(PhoneNumberHint phoneNumberHint)
{
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
    protected PhoneNumberHint Hint { get; } = phoneNumberHint;

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon its calling code using the default <see cref="ParseOptions"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value) =>
        Parse(value, ParseOptions.Default);

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon its calling code using the specified <see cref="ParseOptions"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <param name="options">The options for parsing the phone number.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="options"/> is null.</exception>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, ParseOptions options)
    {
        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        foreach (var countryInfo in options.GetCountryInfos(value))
        {
            var result = options.ParserFactory.GetParser(countryInfo).Parse(value);

            if (result.PhoneNumber is not null)
            {
                return result.PhoneNumber!;
            }
        }

        throw new ParseException("Parse(value) only supports a value starting with a supported international calling code (e.g. +44), otherwise Parse(value, countryCode) must be used.");
    }

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the specified <see cref="CountryInfo"/> using the default <see cref="ParseOptions"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="countryInfo"/> is null.</exception>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, CountryInfo countryInfo) =>
        Parse(value, countryInfo, ParseOptions.Default);

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Alpha-2 country code using the default <see cref="ParseOptions"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, string countryCode) =>
        Parse(value, countryCode, ParseOptions.Default);

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the specified <see cref="CountryInfo"/> using the specified <see cref="ParseOptions"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
    /// <param name="options">The options for parsing the phone number.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="countryInfo"/> or <paramref name="options"/> are null.</exception>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, CountryInfo countryInfo, ParseOptions options)
    {
        if (countryInfo is null)
        {
            throw new ArgumentNullException(nameof(countryInfo));
        }

        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        if (!options.Countries.Contains(countryInfo))
        {
            throw new ParseException($"The country {countryInfo.Name} is not enabled in ParseOptions.");
        }

        var result = options.ParserFactory.GetParser(countryInfo).Parse(value);
        result.ThrowIfFailure();

        return result.PhoneNumber!;
    }

    /// <summary>
    /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Alpha-2 country code using the specified <see cref="ParseOptions"/>.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="options">The options for parsing the phone number.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="options"/> is null.</exception>
    /// <exception cref="ParseException">Thrown if the value cannot be successfully parsed into a <see cref="PhoneNumber"/>.</exception>
    /// <returns>A <see cref="PhoneNumber"/> instance representing the specified phone number string value.</returns>
    public static PhoneNumber Parse(string value, string countryCode, ParseOptions options)
    {
        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }

        var countryInfo = options.GetCountryInfo(countryCode);

        if (countryInfo is null)
        {
            throw new ParseException($"The country code {countryCode} is not currently supported, or is not enabled in the ParseOptions.");
        }

        return Parse(value, countryInfo, options);
    }

    /// <summary>
    /// Converts the string representation of a phone number to any possible <see cref="PhoneNumber"/> equivalents using the default <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="phoneNumbers">The <see cref="PhoneNumber"/> equivalents if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, out IEnumerable<PhoneNumber> phoneNumbers) =>
        TryParse(value, ParseOptions.Default, out phoneNumbers);

    /// <summary>
    /// Converts the string representation of a phone number to any possible <see cref="PhoneNumber"/> equivalents using the default <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="options">The options for parsing the phone number.</param>
    /// <param name="phoneNumbers">The <see cref="PhoneNumber"/> equivalents if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, ParseOptions options, out IEnumerable<PhoneNumber> phoneNumbers)
    {
        if (options is not null)
        {
            var countries = options.GetCountryInfos(value);

            phoneNumbers = (countries.Any() ? countries : options.Countries)
                .Select(x => options.ParserFactory.GetParser(x).Parse(value))
                .Where(x => x.PhoneNumber is not null)
                .Select(x => x.PhoneNumber)
                .Cast<PhoneNumber>()
                .ToList();

            return phoneNumbers.Any();
        }

        phoneNumbers = Enumerable.Empty<PhoneNumber>();
        return false;
    }

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the default <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, [NotNullWhen(true)] out PhoneNumber? phoneNumber) =>
        TryParse(value, ParseOptions.Default, out phoneNumber);

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the specified <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <param name="options">The options for parsing the phone number.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, ParseOptions options, [NotNullWhen(true)] out PhoneNumber? phoneNumber)
    {
        if (options is not null)
        {
            foreach (var countryInfo in options.GetCountryInfos(value))
            {
                var result = options.ParserFactory.GetParser(countryInfo).Parse(value);

                if (result.PhoneNumber is not null)
                {
                    phoneNumber = result.PhoneNumber;
                    return true;
                }
            }
        }

        phoneNumber = default;
        return false;
    }

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the default <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, CountryInfo countryInfo, [NotNullWhen(true)] out PhoneNumber? phoneNumber) =>
        TryParse(value, countryInfo, ParseOptions.Default, out phoneNumber);

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the default <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, string countryCode, [NotNullWhen(true)] out PhoneNumber? phoneNumber) =>
        TryParse(value, countryCode, ParseOptions.Default, out phoneNumber);

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the specified <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
    /// <param name="options">The options for parsing phone numbers.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, CountryInfo countryInfo, ParseOptions options, [NotNullWhen(true)] out PhoneNumber? phoneNumber)
    {
        if (countryInfo is not null &&
            options is not null &&
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
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the specified <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="options">The options for parsing phone numbers.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, string countryCode, ParseOptions options, [NotNullWhen(true)] out PhoneNumber? phoneNumber) =>
        TryParse(value, options?.GetCountryInfo(countryCode)!, options!, out phoneNumber);

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
