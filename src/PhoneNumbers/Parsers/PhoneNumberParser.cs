using System;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// The base class for a class which parses a string containing a phone number into a <see cref="PhoneNumber"/> instance.
    /// </summary>
    internal abstract class PhoneNumberParser
    {
        /// <summary>
        /// Parses the phone number represented in the specified string into a <see cref="PhoneNumber"/> instance.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the phone number.</param>
        /// <returns>A <see cref="PhoneNumber"/> instance representing the specified string.</returns>
        internal ParseResult Parse(string value, CountryInfo countryInfo)
        {
            if (countryInfo is null)
            {
                throw new ArgumentNullException(nameof(countryInfo));
            }

            if (!countryInfo.IsNumber(value))
            {
                return ParseResult.Failure(
                    $"The value must be a {countryInfo.CountryCode} phone number starting {countryInfo.TrunkPrefix} or {countryInfo.CallingCode}.");
            }

            var nsnValue = countryInfo.ReadNationalSignificantNumber(value);

            if (!countryInfo.NsnLengths.Contains(nsnValue.Length))
            {
                return ParseResult.Failure(
                    $"The national significant number of the phone number must be {string.Join(" or ", countryInfo.NsnLengths)} digits in length.");
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
        protected abstract ParseResult ParseNationalSignificantNumber(string nsnValue, CountryInfo countryInfo);
    }
}
