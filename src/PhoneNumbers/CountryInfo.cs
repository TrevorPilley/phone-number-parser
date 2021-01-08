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
        private static readonly char[] s_digits1To9 = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// Initialises a new instance of the <see cref="CountryInfo"/> class.
        /// </summary>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal CountryInfo()
        {
        }

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
        public static CountryInfo UK { get; } = new()
        {
            AreaCodeLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
            CallingCode = "+44",
            Formatter = new GBPhoneNumberFormatter(),
            Iso3166Code = "GB",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 9, 10 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the calling code for the country (e.g. '+XX').
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/List_of_country_calling_codes.</remarks>
        public string CallingCode { get; init; } = null!;

        /// <summary>
        /// Gets a value indicating whether the country has area codes.
        /// </summary>
        public bool HasAreaCodes => AreaCodeLengths.Count > 0;

        /// <summary>
        /// Gets the international call prefix.
        /// </summary>
        /// <remarks>Default to the ITU recommended '00', see https://en.wikipedia.org/wiki/List_of_international_call_prefixes.</remarks>
        public string InternationalCallPrefix { get; init; } = "00";

        /// <summary>
        /// Gets the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        [Obsolete("This property was incorrectly named, please use Iso3166Code instead it will be removed in a future version.")]
        public string Iso3116Code => Iso3166Code;

        /// <summary>
        /// Gets the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        /// <remarks>See https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string Iso3166Code { get; init; } = null!;

        /// <summary>
        /// Gets the trunk prefix used by the country, if applicable.
        /// </summary>
        public string? TrunkPrefix { get; init; }

        /// <summary>
        /// Gets the possible lenghts of the area code.
        /// </summary>
        internal ReadOnlyCollection<int> AreaCodeLengths { get; init; } = new(Array.Empty<int>());

        /// <summary>
        /// Gets the <see cref="PhoneNumberFormatter"/> for the country.
        /// </summary>
        internal PhoneNumberFormatter Formatter { get; init; } = PhoneNumberFormatter.Default;

        /// <summary>
        /// Gets the permitted lenghts of the national significant number.
        /// </summary>
        internal ReadOnlyCollection<int> NsnLengths { get; init; } = new(Array.Empty<int>());

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

            return ReadNsnStringFrom(startPos, value);
        }

        /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
        private static bool IsDigit(char charVal) =>
            charVal is >= '0' and <= '9';

        private int CountDigitsAfter(int startPos, string value)
        {
            var digits = 0;

            for (var i = startPos; i < value.Length; i++)
            {
                var charVal = value[i];

                if (IsDigit(charVal) && !(digits == 0 && TrunkPrefix?[0] == charVal))
                {
                    digits++;
                }
            }

            return digits;
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private string GetDebuggerDisplay() =>
            $"{Iso3166Code} {CallingCode}";

        private string ReadNsnStringFrom(int startPos, string value)
        {
            var digits = CountDigitsAfter(startPos, value);

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
    }
}
