using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using PhoneNumbers.Formatters;

namespace PhoneNumbers
{
    /// <summary>
    /// A class which contains country information related to phone numbers.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public sealed class CountryInfo
    {
        private static readonly char[] s_digits1To9 = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// Initialises a new instance of the <see cref="CountryInfo"/> class.
        /// </summary>
        /// <param name="iso3116Code">The ISO 3166 Aplha-2 code for the country.</param>
        /// <param name="callingCode">The country calling code.</param>
        /// <param name="internationalCallPrefix">The international call prefix.</param>
        /// <param name="trunkPrefix">The trunk prefix (if applicable).</param>
        /// <param name="formatter">The <see cref="PhoneNumberFormatter"/>.</param>
        /// <param name="nsnLengths">The permitted lengths for the national significant number.</param>
        private CountryInfo(
            string iso3116Code,
            string callingCode,
            string internationalCallPrefix,
            string? trunkPrefix,
            PhoneNumberFormatter formatter,
            int[] nsnLengths) =>
            (Iso3116Code, CallingCode, Formatter, InternationalCallPrefix, TrunkPrefix, NsnLengths) =
            (iso3116Code, callingCode, formatter, internationalCallPrefix, trunkPrefix, new ReadOnlyCollection<int>(nsnLengths));

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
        public static CountryInfo UK { get; } = new CountryInfo("GB", "+44", "00", "0", new UKPhoneNumberFormatter(), new[] { 7, 9, 10 });

        /// <summary>
        /// Gets the country calling code.
        /// </summary>
        public string CallingCode { get; }

        /// <summary>
        /// Gets the international call prefix.
        /// </summary>
        public string InternationalCallPrefix { get; }

        /// <summary>
        /// Gets the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        public string Iso3116Code { get; }

        /// <summary>
        /// Gets the trunk prefix (if applicable).
        /// </summary>
        public string? TrunkPrefix { get; }

        /// <summary>
        /// Gets the <see cref="PhoneNumberFormatter"/> for the country.
        /// </summary>
        internal PhoneNumberFormatter Formatter { get; }

        /// <summary>
        /// Gets the permitted lenghts of the national significant number.
        /// </summary>
        internal ReadOnlyCollection<int> NsnLengths { get; }

        internal bool IsInternationalNumber(string value) =>
            value?.StartsWith(CallingCode, StringComparison.Ordinal) == true;

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
                return string.Empty;
            }

            var startPos = 0;

            if (value[0] == '+')
            {
                if (!IsInternationalNumber(value))
                {
                    return string.Empty;
                }

                startPos = CallingCode.Length;
            }
            else if (TrunkPrefix != null)
            {
                startPos = value.IndexOf(TrunkPrefix, StringComparison.Ordinal) + 1;

                if (startPos == 0 || startPos > value.IndexOfAny(s_digits1To9))
                {
                    return string.Empty;
                }
            }

            var digits = 0;

            for (var i = startPos; i < value.Length; i++)
            {
                var charVal = value[i];

                if (IsDigit(charVal) && !(digits == 0 && TrunkPrefix?[0] == charVal))
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

                if (IsDigit(charVal) && !(charPos == 0 && TrunkPrefix?[0] == charVal))
                {
                    chars[charPos++] = charVal;
                }
            }

            return new string(chars);
        }

        /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
        private static bool IsDigit(char charVal) =>
            charVal is >= '0' and <= '9';

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private string GetDebuggerDisplay() =>
            $"{Iso3116Code} {CallingCode}";
    }
}
