using System;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// The base class for a class which parses a string containing a phone number into a <see cref="PhoneNumber"/> instance.
    /// </summary>
    public abstract class PhoneNumberParser
    {
        /// <summary>
        /// Parses the phone number represented in the specified string into a <see cref="PhoneNumber"/> instance.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryInfo"></param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        public PhoneNumber Parse(string value, CountryInfo countryInfo)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A value must be specified.", nameof(value));
            }

            if (countryInfo is null)
            {
                throw new ArgumentNullException(nameof(countryInfo));
            }

            if (!countryInfo.IsNumber(value))
            {
                throw new ArgumentException($"The value must be a {countryInfo.CountryCode} phone number starting {countryInfo.TrunkPrefix} or {countryInfo.CallingCode}.", nameof(value));
            }

            return ParsePhoneNumber(countryInfo.ConvertToNationalNumber(value), countryInfo);
        }

        /// <summary>
        /// Parses the phone number represented in the specified string into a <see cref="PhoneNumber"/> instance.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryInfo"></param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        /// <remarks>By the time this method is called, the value will start with the TrunkPrefix and contain digits only.</remarks>
        protected abstract PhoneNumber ParsePhoneNumber(string value, CountryInfo countryInfo);
    }
}
