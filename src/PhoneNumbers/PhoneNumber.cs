using PhoneNumbers.Formatters;

namespace PhoneNumbers
{
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
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon the calling code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        public static PhoneNumber Parse(string value) =>
            Parse(value, ParseOptions.Default);

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance based upon the calling code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        public static PhoneNumber Parse(string value, ParseOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            foreach (var countryInfo in options.GetCountryInfos(value))
            {
                var result = options!.Factory.GetParser(countryInfo).Parse(value);

                if (result.PhoneNumber is not null)
                {
                    return result.PhoneNumber!;
                }
            }

            throw new ParseException("Parse(value) only supports a value starting with a supported calling code, otherwise Parse(value, countryCode) must be used.");
        }

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Alpha-2 country code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        public static PhoneNumber Parse(string value, string countryCode) =>
            Parse(value, countryCode, ParseOptions.Default);

        /// <summary>
        /// Parses the specified phone number value into a <see cref="PhoneNumber"/> instance for the given ISO 3166 Alpha-2 country code.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
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
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        public static bool TryParse(string value, ParseOptions options, out PhoneNumber? phoneNumber)
        {
            if (options is not null)
            {
                foreach (var countryInfo in options.GetCountryInfos(value))
                {
                    var result = options.Factory.GetParser(countryInfo).Parse(value);

                    phoneNumber = result.PhoneNumber;

                    if (result.PhoneNumber is not null)
                    {
                        return true;
                    }
                }
            }

            phoneNumber = default;
            return false;
        }

        /// <summary>
        /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        public static bool TryParse(string value, string countryCode, out PhoneNumber? phoneNumber) =>
            TryParse(value, countryCode, ParseOptions.Default, out phoneNumber);

        /// <summary>
        /// Converts the string representation of a phone number to its <see cref="PhoneNumber"/> equivalent. A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryCode">The ISO 3166 Alpha-2 country code of the country for the phone number.</param>
        /// <param name="options">The options for parsing phone numbers.</param>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> equivalent if the conversion succeeds, otherwise null.</param>
        /// <returns><c>true</c> if value was converted successfully; otherwise, <c>false</c>.</returns>
        public static bool TryParse(string value, string countryCode, ParseOptions options, out PhoneNumber? phoneNumber)
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
}
