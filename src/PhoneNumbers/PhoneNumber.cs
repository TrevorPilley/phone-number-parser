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
    /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    /// <param name="nationalSignificantNumber">The national significant number of the phone number.</param>
    /// <param name="nationalDestinationCode">The national destination code of the phone number.</param>
    /// <param name="subscriberNumber">The subscriber number of the phone number.</param>
    /// <exception cref="ArgumentException">Thrown if the <paramref name="nationalSignificantNumber"/> or <paramref name="subscriberNumber"/> are null or whitespace.</exception>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="countryInfo"/> is null.</exception>
    protected PhoneNumber(
        CountryInfo countryInfo,
        PhoneNumberHint phoneNumberHint,
        string nationalSignificantNumber,
        string? nationalDestinationCode,
        string subscriberNumber)
    {
        if (countryInfo is null)
        {
            throw new ArgumentNullException(nameof(countryInfo));
        }

        if (string.IsNullOrWhiteSpace(nationalSignificantNumber))
        {
            throw new ArgumentException($"'{nameof(nationalSignificantNumber)}' cannot be null or whitespace.", nameof(nationalSignificantNumber));
        }

        if (string.IsNullOrWhiteSpace(subscriberNumber))
        {
            throw new ArgumentException($"'{nameof(subscriberNumber)}' cannot be null or whitespace.", nameof(subscriberNumber));
        }

        (Country, Hint, NationalSignificantNumber, NationalDestinationCode, SubscriberNumber) = (countryInfo, phoneNumberHint, nationalSignificantNumber, nationalDestinationCode, subscriberNumber);
    }

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the phone number.
    /// </summary>
    public CountryInfo Country { get; }

    /// <summary>
    /// Gets the national destination code of the phone number.
    /// </summary>
    /// <remarks>May also be referred to as area code or mobile network code.</remarks>
    public string? NationalDestinationCode { get; }

    /// <summary>
    /// Gets the national significant number of the phone number.
    /// </summary>
    /// <remarks>Typically this is the number excluding the country code or trunk prefix.</remarks>
    public string NationalSignificantNumber { get; }

    /// <summary>
    /// Gets the <see cref="PhoneNumberKind"/>.
    /// </summary>
    /// <remarks>The instance can be cast to the appropriate type based upon this value.</remarks>
    public abstract PhoneNumberKind PhoneNumberKind { get; }

    /// <summary>
    /// Gets the subscriber number of the phone number.
    /// </summary>
    /// <remarks>May also be referred to as local number.</remarks>
    public string SubscriberNumber { get; }

    /// <summary>
    /// Gets the <see cref="PhoneNumberHint"/>.
    /// </summary>
    protected PhoneNumberHint Hint { get; }

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
            var result = options.Factory.GetParser(countryInfo).Parse(value);

            if (result.PhoneNumber is not null)
            {
                return result.PhoneNumber!;
            }
        }

        throw new ParseException("Parse(value) only supports a value starting with a supported international calling code (e.g. +44), otherwise Parse(value, countryCode) must be used.");
    }

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
            throw new ParseException($"The country code {countryCode} is not currently supported.");
        }

        var result = options.Factory.GetParser(countryInfo).Parse(value);
        result.ThrowIfFailure();

        return result.PhoneNumber!;
    }

    /// <summary>
    /// Converts the string representation of a phone number to any <see cref="PhoneNumber"/> equivalents using the default <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="phoneNumbers">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
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
            phoneNumbers = options.Countries
                .Select(x => options.Factory.GetParser(x).Parse(value))
                .Where(x=> x.PhoneNumber is not null)
                .Select(x => x.PhoneNumber)
                .Cast<PhoneNumber>();

            return true;
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
                var result = options.Factory.GetParser(countryInfo).Parse(value);

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
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, string countryCode, [NotNullWhen(true)] out PhoneNumber? phoneNumber) =>
        TryParse(value, countryCode, ParseOptions.Default, out phoneNumber);

    /// <summary>
    /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent using the specified <see cref="ParseOptions"/>. A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
    /// <param name="options">The options for parsing phone numbers.</param>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
    /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string value, string countryCode, ParseOptions options, [NotNullWhen(true)] out PhoneNumber? phoneNumber)
    {
        var countryInfo = options?.GetCountryInfo(countryCode);

        if (countryInfo is not null)
        {
            var result = options!.Factory.GetParser(countryInfo).Parse(value);

            phoneNumber = result.PhoneNumber;
            return result.PhoneNumber is not null;
        }

        phoneNumber = default;
        return false;
    }

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
        Country.GetFormatter(format).Format(this);
}
