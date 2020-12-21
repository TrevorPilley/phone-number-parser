using System;
using System.Collections.Generic;
using PhoneNumbers.Formatters;
using PhoneNumbers.Parsers;

namespace PhoneNumbers
{
    /// <summary>
    /// A class which contains country information related to phone numbers.
    /// </summary>
    public sealed class CountryInfo
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="CountryInfo"/> class.
        /// </summary>
        /// <param name="countryCode">The ISO 3166 Aplha-2 code for the country.</param>
        /// <param name="callingCode">The country calling code.</param>
        /// <param name="internationalCallPrefix">The international call prefix.</param>
        /// <param name="trunkPrefix">The trunk prefix.</param>
        /// <param name="formatter">The <see cref="PhoneNumberFormatter"/>.</param>
        /// <param name="parser">The <see cref="PhoneNumberParser"/>.</param>
        private CountryInfo(
            string countryCode,
            string callingCode,
            string internationalCallPrefix,
            string trunkPrefix,
            PhoneNumberFormatter formatter,
            PhoneNumberParser parser) =>
            (CountryCode, CallingCode, Formatter, InternationalCallPrefix, Parser, TrunkPrefix) =
            (countryCode, callingCode, formatter, internationalCallPrefix, parser, trunkPrefix);

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
        public static CountryInfo UK { get; } = new CountryInfo("GB", "+44", "00", "0", new UkPhoneNumberFormatter(), new UkPhoneNumberParser());

        /// <summary>
        /// Gets the country calling code.
        /// </summary>
        public string CallingCode { get; }

        /// <summary>
        /// Gets the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        public string CountryCode { get; }

        /// <summary>
        /// Gets the international call prefix.
        /// </summary>
        public string InternationalCallPrefix { get; }

        /// <summary>
        /// Gets the trunk prefix.
        /// </summary>
        public string TrunkPrefix { get; }

        /// <summary>
        /// Gets the <see cref="PhoneNumberFormatter"/> for the country.
        /// </summary>
        internal PhoneNumberFormatter Formatter { get; }

        /// <summary>
        /// Gets the <see cref="PhoneNumberParser"/> for the country.
        /// </summary>
        internal PhoneNumberParser Parser { get; }

        /// <summary>
        /// Gets all supported <see cref="CountryInfo"/>s as an enumerable.
        /// </summary>
        /// <returns>All supported <see cref="CountryInfo"/>s as an enumerable.</returns>
        internal static IEnumerable<CountryInfo> AllSupported()
        {
            yield return UK;
        }

        /// <summary>
        /// Finds the <see cref="CountryInfo"/> based upon the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        /// <param name="countryCode">The ISO 3166 Aplha-2 code for the country.</param>
        /// <returns></returns>
        internal static CountryInfo Find(string countryCode) =>
            countryCode switch
            {
                "GB" => UK,
                _ => throw new NotSupportedException(countryCode),
            };

        internal string ConvertToNationalNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException();
            }

            // The number will either start with the international calling code (+XX) or the Trunk Prefix
            // If it starts with the calling code, replace it with the trunk prefix.
            bool isInternationalNumber = IsInternationalNumber(value);
            int startPos = isInternationalNumber ? CallingCode.Length : 0;
            int digits = isInternationalNumber ? TrunkPrefix.Length : 0;

            for (int i = startPos; i < value.Length; i++)
            {
                if (IsDigit(value[i]))
                {
                    digits++;
                }
            }

            if (digits == value.Length)
            {
                return value;
            }

            char[] chars = new char[digits];
            int charPos = 0;

            if (isInternationalNumber)
            {
                foreach (char charVal in TrunkPrefix)
                {
                    chars[charPos++] = charVal;
                }
            }

            for (int i = startPos; i < value.Length; i++)
            {
                char charVal = value[i];

                if (IsDigit(charVal))
                {
                    chars[charPos++] = charVal;
                }
            }

            return new string(chars);
        }

        internal bool IsInternationalNumber(string value) =>
            value?.StartsWith(CallingCode, StringComparison.Ordinal) == true;

        internal bool IsNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (value.StartsWith(TrunkPrefix, StringComparison.Ordinal))
            {
                return true;
            }

            if (value.StartsWith(CallingCode, StringComparison.Ordinal))
            {
                return true;
            }

            int firstDigit = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (IsDigit(value[i]))
                {
                    firstDigit = i;
                    break;
                }
            }

            for (int i = 0; i < TrunkPrefix.Length; i++)
            {
                if (value[firstDigit++] != TrunkPrefix[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
        private static bool IsDigit(char charVal) =>
            charVal >= '0' && charVal <= '9';
    }
}
