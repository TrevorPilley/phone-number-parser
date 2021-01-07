using System;
using System.Linq;
using PhoneNumbers.Formatters;

namespace PhoneNumbers
{
    /// <summary>
    /// The base class representing a <see cref="PhoneNumber"/>.
    /// </summary>
    /// <remarks>
    /// https://en.wikipedia.org/wiki/List_of_country_calling_codes
    /// </remarks>
    public abstract class PhoneNumber
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="PhoneNumber"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
        /// <param name="areaCode">The area code of the phone number.</param>
        /// <param name="localNumber">The local number of the phone number.</param>
        protected PhoneNumber(CountryInfo countryInfo, string? areaCode, string localNumber) =>
            (Country, AreaCode, LocalNumber) = (countryInfo, areaCode, localNumber);

        /// <summary>
        /// Gets the area code of the phone number.
        /// </summary>
        public string? AreaCode { get; }

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the phone number.
        /// </summary>
        public CountryInfo Country { get; }

        /// <summary>
        /// Gets the local number of the phone number.
        /// </summary>
        public string LocalNumber { get; }

        /// <summary>
        /// Gets the <see cref="PhoneNumberKind"/>.
        /// </summary>
        /// <remarks>The instance can be cast to the appropriate type based upon this value.</remarks>
        public abstract PhoneNumberKind PhoneNumberKind { get; }

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon the calling code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        public static PhoneNumber Parse(string value) =>
            Parse(value, ParseOptions.Default);

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Aplha-2 country code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Aplha-2 country code of the country for the phone number.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        public static PhoneNumber Parse(string value, string countryCode) =>
            Parse(value, countryCode, ParseOptions.Default);

        /// <summary>
        /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        public static bool TryParse(string value, out PhoneNumber? phoneNumber) =>
            TryParse(value, ParseOptions.Default, out phoneNumber);

        /// <summary>
        /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Aplha-2 country code of the country for the phone number.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        public static bool TryParse(string value, string countryCode, out PhoneNumber? phoneNumber) =>
            TryParse(value, countryCode, ParseOptions.Default, out phoneNumber);

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
            Country.Formatter.Format(this, format);

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon the calling code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        internal static PhoneNumber Parse(string value, ParseOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var country = options.Countries.SingleOrDefault(x => x.IsInternationalNumber(value));

            if (country == null)
            {
                throw new ParseException("Parse(value) only supports a value starting with a supported calling code, otherwise Parse(value, countryCode) must be used.");
            }

            var parser = options.GetParser(country);
            var result = parser.Parse(value);
            result.ThrowIfFailure();

            return result.PhoneNumber!;
        }

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Aplha-2 country code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Aplha-2 country code of the country for the phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        internal static PhoneNumber Parse(string value, string countryCode, ParseOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var country = options.Countries.SingleOrDefault(x => x.Iso3116Code == countryCode);

            if (country == null)
            {
                throw new ParseException($"The country code {countryCode} is not currently supported.");
            }

            var parser = options.GetParser(country);
            var result = parser.Parse(value);
            result.ThrowIfFailure();

            return result.PhoneNumber!;
        }

        /// <summary>
        /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        internal static bool TryParse(string value, ParseOptions options, out PhoneNumber? phoneNumber)
        {
            var country = options?.Countries.SingleOrDefault(x => x.IsInternationalNumber(value));

            if (country != null)
            {
                var parser = options!.GetParser(country);
                var result = parser.Parse(value);

                if (result.PhoneNumber != null)
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
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Aplha-2 country code of the country for the phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        internal static bool TryParse(string value, string countryCode, ParseOptions options, out PhoneNumber? phoneNumber)
        {
            var country = options?.Countries.SingleOrDefault(x => x.Iso3116Code == countryCode);

            if (country != null)
            {
                var parser = options!.GetParser(country);
                var result = parser.Parse(value);

                if (result.PhoneNumber != null)
                {
                    phoneNumber = result.PhoneNumber;
                    return true;
                }
            }

            phoneNumber = default;
            return false;
        }
    }
}
