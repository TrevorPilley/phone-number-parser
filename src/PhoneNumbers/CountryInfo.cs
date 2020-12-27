using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using PhoneNumbers.Formatters;
using PhoneNumbers.Parsers;

namespace PhoneNumbers
{
    /// <summary>
    /// A class which contains country information related to phone numbers.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
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
        /// <param name="nsnLengths">The permitted lengths for the national significant number.</param>
        private CountryInfo(
            string countryCode,
            string callingCode,
            string internationalCallPrefix,
            string trunkPrefix,
            PhoneNumberFormatter formatter,
            PhoneNumberParser parser,
            int[] nsnLengths) =>
            (CountryCode, CallingCode, Formatter, InternationalCallPrefix, Parser, TrunkPrefix, NsnLengths) =
            (countryCode, callingCode, formatter, internationalCallPrefix, parser, trunkPrefix, new ReadOnlyCollection<int>(nsnLengths));

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
        public static CountryInfo UK { get; } = new CountryInfo("GB", "+44", "00", "0", new UKPhoneNumberFormatter(), UKPhoneNumberParser.Create(), new[] { 7, 9, 10 });

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
        /// Gets the permitted lenghts of the national significant number.
        /// </summary>
        internal ReadOnlyCollection<int> NsnLengths { get; }

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

            var firstDigit = 0;

            for (var i = 0; i < value.Length; i++)
            {
                if (IsDigit(value[i]))
                {
                    firstDigit = i;
                    break;
                }
            }

            for (var i = 0; i < TrunkPrefix.Length; i++)
            {
                if (value[firstDigit++] != TrunkPrefix[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Reads the national significant number (NSN) from the specified phone number value.
        /// </summary>
        /// <param name="value">A string containing a phone number.</param>
        /// <returns>The national significant number (NSN).</returns>
        /// <remarks>This excludes the CallingCode and TrunkPrefix.</remarks>
        internal string ReadNationalSignificantNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The value must not be blank", nameof(value));
            }

            var startPos = IsInternationalNumber(value)
                ? CallingCode.Length
                : value.IndexOf(TrunkPrefix, StringComparison.Ordinal) + 1;

            var digits = 0;

            for (var i = startPos; i < value.Length; i++)
            {
                if (IsDigit(value[i]))
                {
                    digits++;
                }
            }

            if (startPos + digits == value.Length)
            {
                return value.Substring(startPos);
            }

            var chars = new char[digits];
            var charPos = 0;

            for (var i = startPos; i < value.Length; i++)
            {
                var charVal = value[i];

                if (IsDigit(charVal))
                {
                    chars[charPos++] = charVal;
                }
            }

            return new string(chars);
        }

        /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
        private static bool IsDigit(char charVal) =>
            charVal >= '0' && charVal <= '9';

        private string GetDebuggerDisplay() =>
            $"{CountryCode} {CallingCode}";
    }
}
