using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using PhoneNumbers.Formatters;

namespace PhoneNumbers
{
    /// <summary>
    /// A class which contains country information related to phone numbers.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public sealed partial class CountryInfo
    {
        private const char PlusSign = '+';
        private static readonly char[] s_digits1To9 = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private readonly List<PhoneNumberFormatter> _formatters;

        /// <summary>
        /// Initialises a new instance of the <see cref="CountryInfo"/> class.
        /// </summary>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal CountryInfo()
        {
            _formatters = new(new[]
            {
                E164PhoneNumberFormatter.Instance,
                E123PhoneNumberFormatter.Instance,
                NationalPhoneNumberFormatter.Instance,
            });
        }

        /// <summary>
        /// Gets the calling code for the country (e.g. '+XX').
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/List_of_country_calling_codes.</remarks>
        public string CallingCode { get; init; } = null!;

        /// <summary>
        /// Gets a value indicating whether the country has national destination codes.
        /// </summary>
        public bool HasNationalDestinationCodes => NdcLengths.Count > 0;

        /// <summary>
        /// Gets the international call prefix.
        /// </summary>
        /// <remarks>Default to the ITU recommended '00', see https://en.wikipedia.org/wiki/List_of_international_call_prefixes.</remarks>
        public string InternationalCallPrefix { get; init; } = "00";

        /// <summary>
        /// Gets the ISO 3166 Alpha-2 code for the country.
        /// </summary>
        /// <remarks>See https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string Iso3166Code { get; init; } = null!;

        /// <summary>
        /// Gets the name of the country.
        /// </summary>
        public string Name { get; init; } = null!;

        /// <summary>
        /// Gets a value indicating whether the calling code is shared with another country.
        /// </summary>
        /// <remarks>For example Guernsey, Jersey and the Isle of Man share the United Kingdom +44 calling code.</remarks>
        public bool SharesCallingCode { get; init; }

        /// <summary>
        /// Gets the trunk prefix used by the country, if applicable.
        /// </summary>
        public string? TrunkPrefix { get; init; }

        /// <summary>
        /// Gets the possible lengths of the national destination code.
        /// </summary>
        internal ReadOnlyCollection<int> NdcLengths { get; init; } = new(Array.Empty<int>());

        /// <summary>
        /// Gets the permitted lengths of the national significant number.
        /// </summary>
        internal ReadOnlyCollection<int> NsnLengths { get; init; } = new(Array.Empty<int>());

        internal PhoneNumberFormatter GetFormatter(string format) =>
            _formatters.SingleOrDefault(x => x.CanFormat(format)) ?? throw new FormatException($"{format} is not a supported format");

        internal bool IsInternationalNumber(string value) =>
            value?.StartsWith(CallingCode, StringComparison.Ordinal) == true;

        internal bool IsValidNsnLength(string value) =>
            NsnLengths.Contains(value!.Length);

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

            if (value[0] == PlusSign)
            {
                if (!IsInternationalNumber(value))
                {
                    return string.Empty;
                }

                startPos = CallingCode.Length;
            }
            else if (TrunkPrefix is not null)
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
