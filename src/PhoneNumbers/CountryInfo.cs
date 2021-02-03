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
        private const char PlusSign = '+';
        private static readonly char[] s_digits1To9 = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// Initialises a new instance of the <see cref="CountryInfo"/> class.
        /// </summary>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal CountryInfo()
        {
        }

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Spain.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.Spain' instead it will be removed in a future version.")]
        public static CountryInfo ES => Spain;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for France.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.France' instead it will be removed in a future version.")]
        public static CountryInfo FR => France;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for France.
        /// </summary>
        public static CountryInfo France { get; } = new()
        {
            CallingCode = "+33",
            Formatter = GroupedDigitPhoneNumberFormatter.Spaced2Digits,
            Iso3166Code = "FR",
            Name = "France",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Guernsey.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.Guernsey' instead it will be removed in a future version.")]
        public static CountryInfo GG => Guernsey;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Guernsey.
        /// </summary>
        public static CountryInfo Guernsey { get; } = new()
        {
            CallingCode = "+44",
            Formatter = GBPhoneNumberFormatter.Instance,
            Iso3166Code = "GG",
            Name = "Guernsey",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
            SharesCallingCode = true,
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Hong Kong.
        /// </summary>
        public static CountryInfo HongKong { get; } = new()
        {
            CallingCode = "+852",
            Formatter = GroupedDigitPhoneNumberFormatter.Spaced4Digits,
            InternationalCallPrefix = "001",
            Iso3166Code = "HK",
            Name = "Hong Kong",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Ireland.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.Ireland' instead it will be removed in a future version.")]
        public static CountryInfo IE => Ireland;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the Isle of Man.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.IsleOfMan' instead it will be removed in a future version.")]
        public static CountryInfo IM => IsleOfMan;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Ireland.
        /// </summary>
        /// <remarks>Covers the Republic of Ireland, Northern Ireland is part of the United Kingdom.</remarks>
        public static CountryInfo Ireland { get; } = new()
        {
            CallingCode = "+353",
            Formatter = new IEPhoneNumberFormatter(),
            Iso3166Code = "IE",
            Name = "Ireland",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 8, 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the Isle of Man.
        /// </summary>
        public static CountryInfo IsleOfMan { get; } = new()
        {
            CallingCode = "+44",
            Formatter = GBPhoneNumberFormatter.Instance,
            Iso3166Code = "IM",
            Name = "Isle of Man",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
            SharesCallingCode = true,
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Italy.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.Italy' instead it will be removed in a future version.")]
        public static CountryInfo IT => Italy;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Italy.
        /// </summary>
        /// <remarks>Covers Italy (includes the islands of Sardinia and Sicily), and Vatican City.</remarks>
        public static CountryInfo Italy { get; } = new()
        {
            CallingCode = "+39",
            Formatter = ITPhoneNumberFormatter.Instance,
            Iso3166Code = "IT",
            Name = "Italy",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9, 10, 11 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Jersey.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.Jersey' instead it will be removed in a future version.")]
        public static CountryInfo JE => Jersey;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Jersey.
        /// </summary>
        public static CountryInfo Jersey { get; } = new()
        {
            CallingCode = "+44",
            Formatter = GBPhoneNumberFormatter.Instance,
            Iso3166Code = "JE",
            Name = "Jersey",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
            SharesCallingCode = true,
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Macau.
        /// </summary>
        public static CountryInfo Macau { get; } = new()
        {
            CallingCode = "+853",
            Formatter = GroupedDigitPhoneNumberFormatter.Spaced4Digits,
            Iso3166Code = "MO",
            Name = "Macau",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Monaco.
        /// </summary>
        public static CountryInfo Monaco { get; } = new()
        {
            CallingCode = "+377",
            Formatter = GroupedDigitPhoneNumberFormatter.Spaced2Digits,
            Iso3166Code = "MC",
            Name = "Monaco",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for San Marino.
        /// </summary>
        public static CountryInfo SanMarino { get; } = new()
        {
            CallingCode = "+378",
            Formatter = ITPhoneNumberFormatter.Instance,
            Iso3166Code = "SM",
            Name = "San Marino",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9, 10 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Singapore.
        /// </summary>
        public static CountryInfo Singapore { get; } = new()
        {
            CallingCode = "+65",
            Formatter = GroupedDigitPhoneNumberFormatter.Spaced4Digits,
            InternationalCallPrefix = "001",
            Iso3166Code = "SG",
            Name = "Singapore",
            NsnLengths = new ReadOnlyCollection<int>(new[] { 8 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Spain.
        /// </summary>
        public static CountryInfo Spain { get; } = new()
        {
            CallingCode = "+34",
            Formatter = GroupedDigitPhoneNumberFormatter.Spaced3Digits,
            Iso3166Code = "ES",
            Name = "Spain",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for Switzerland.
        /// </summary>
        public static CountryInfo Switzerland { get; } = new()
        {
            CallingCode = "+41",
            Formatter = new CHPhoneNumberFormatter(),
            Iso3166Code = "CH",
            Name = "Switzerland",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
            NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
            TrunkPrefix = "0",
        };

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        [Obsolete("This property has been replaced, please use by 'CountryInfo.UnitedKingdom' instead it will be removed in a future version.")]
        public static CountryInfo UK => UnitedKingdom;

        /// <summary>
        /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
        /// </summary>
        /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
        public static CountryInfo UnitedKingdom { get; } = new()
        {
            CallingCode = "+44",
            Formatter = GBPhoneNumberFormatter.Instance,
            Iso3166Code = "GB",
            Name = "United Kingdom",
            NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
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
        [Obsolete("This property has been replaced, please use NationalDestinationCodes instead it will be removed in a future version.")]
        public bool HasAreaCodes => HasNationalDestinationCodes;

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
        /// Gets the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        [Obsolete("This property was incorrectly named, please use Iso3166Code instead it will be removed in a future version.")]
        public string Iso3116Code => Iso3166Code;

        /// <summary>
        /// Gets the ISO 3166 Aplha-2 code for the country.
        /// </summary>
        /// <remarks>See https://www.iso.org/iso-3166-country-codes.html</remarks>
        public string Iso3166Code { get; init; } = null!;

        /// <summary>
        /// Gets the name of the country.
        /// </summary>
        public string Name { get; init; } = null!;

        /// <summary>
        /// Gets the trunk prefix used by the country, if applicable.
        /// </summary>
        public string? TrunkPrefix { get; init; }

        /// <summary>
        /// Gets the <see cref="PhoneNumberFormatter"/> for the country.
        /// </summary>
        internal PhoneNumberFormatter Formatter { get; init; } = PhoneNumberFormatter.Default;

        /// <summary>
        /// Gets the possible lenghts of the national destination code.
        /// </summary>
        internal ReadOnlyCollection<int> NdcLengths { get; init; } = new(Array.Empty<int>());

        /// <summary>
        /// Gets the permitted lenghts of the national significant number.
        /// </summary>
        internal ReadOnlyCollection<int> NsnLengths { get; init; } = new(Array.Empty<int>());

        /// <summary>
        /// Gets a value indicating whether the calling code is shared with another country.
        /// </summary>
        internal bool SharesCallingCode { get; init; }

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

            if (value[0] == PlusSign)
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
