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
        /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
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
                throw new ArgumentException($"The value must be a {countryInfo.CountryCode} phone number starting {countryInfo.TrunkPrefix} or {countryInfo.CallingCode}.");
            }

            string nsnValue = countryInfo.GetNationalSignificantNumber(value);

            if (!countryInfo.NsnLengths.Contains(nsnValue.Length))
            {
                throw new ArgumentException($"The national significant number of the phone number must be {string.Join(",", countryInfo.NsnLengths)} in length.");
            }

            return ParseNationalSignificantNumber(nsnValue, countryInfo);
        }

        /// <summary>
        /// Parses the phone number represented in the specified string into a <see cref="PhoneNumber"/> instance.
        /// </summary>
        /// <param name="nsnValue">A string containing the national significant number.</param>
        /// <param name="countryInfo"></param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected abstract PhoneNumber ParseNationalSignificantNumber(string nsnValue, CountryInfo countryInfo);
    }
}
