using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using PhoneNumbers.Formatters;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

/// <summary>
/// A class which contains country information related to phone numbers.
/// </summary>
[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public sealed partial class CountryInfo
{
    internal const string Africa = "Africa";
    internal const string Asia = "Asia";
    internal const string Europe = "Europe";
    internal const string NorthAmerica = "North America";
    internal const string Oceania = "Oceania";
    internal const string SouthAmerica = "South America";
    private static readonly ReadOnlyCollection<int> s_emptyIntArray = new(Array.Empty<int>());
    private static readonly ReadOnlyCollection<PhoneNumberFormatter> s_formatters = new(new[]
    {
        E164PhoneNumberFormatter.Instance,
        E123PhoneNumberFormatter.Instance,
        NationalPhoneNumberFormatter.Instance,
        Rfc3966PhoneNumberFormatter.Instance,
    });

    /// <summary>
    /// Initialises a new instance of the <see cref="CountryInfo"/> class.
    /// </summary>
    /// <remarks>The constructor is internal for unit tests only.</remarks>
    internal CountryInfo()
    {
    }

    /// <summary>
    /// Gets a value indicating whether local dialling (subscriber number only) is allowed within geographic national destination codes.
    /// </summary>
    public bool AllowsLocalGeographicDialling { get; init; }

    /// <summary>
    /// Gets the calling code for the country.
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/List_of_country_calling_codes, this property does not contain the + character.</remarks>
    public required string CallingCode { get; init; } = null!;

    /// <summary>
    /// Gets the name of the continent the country is part of.
    /// </summary>
    public required string Continent { get; init; } = null!;

    /// <summary>
    /// Gets a value indicating whether the country has national destination codes.
    /// </summary>
    public bool HasNationalDestinationCodes => NdcLengths.Count > 0;

    /// <summary>
    /// Gets a value indicating whether the country has a trunk prefix.
    /// </summary>
    public bool HasTrunkPrefix => TrunkPrefix is not null;

    /// <summary>
    /// Gets a value indicating whether the country is a member of the European Union.
    /// </summary>
    public bool IsEuropeanUnionMember { get; init; }

    /// <summary>
    /// Gets the ISO 3166 Alpha-2 code for the country.
    /// </summary>
    /// <remarks>See https://www.iso.org/iso-3166-country-codes.html</remarks>
    public required string Iso3166Code { get; init; } = null!;

    /// <summary>
    /// Gets the name of the country.
    /// </summary>
    public required string Name { get; init; } = null!;

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
    /// Gets the <see cref="PhoneNumberFormatProvider"/> for the country.
    /// </summary>
    internal PhoneNumberFormatProvider FormatProvider { get; init; } = ComplexPhoneNumberFormatProvider.Default;

    /// <summary>
    /// Gets the possible lengths of the national destination code.
    /// </summary>
    internal ReadOnlyCollection<int> NdcLengths { get; init; } = s_emptyIntArray;

    /// <summary>
    /// Gets the permitted lengths of the national significant number.
    /// </summary>
    internal ReadOnlyCollection<int> NsnLengths { get; init; } = s_emptyIntArray;

    internal static IEnumerable<CountryInfo> GetCountries() =>
        typeof(CountryInfo)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(x => x.PropertyType == typeof(CountryInfo))
            .Select(x => x.GetValue(null))
            .Cast<CountryInfo>()
            .OrderBy(x => x.SharesCallingCode);

    internal static IEnumerable<CountryInfo> GetCountries(Func<CountryInfo, bool> predicate) =>
        GetCountries()
        .Where(predicate);

    /// <summary>
    /// Gets the <see cref="PhoneNumberFormatter"/> for the specified format.
    /// </summary>
    /// <exception cref="FormatException">Thrown if the format string is not valid.</exception>
    /// <returns>The <see cref="PhoneNumberFormatter"/>.</returns>
    internal static PhoneNumberFormatter GetFormatter(string format) =>
        s_formatters.SingleOrDefault(x => x.CanFormat(format)) ?? throw new FormatException($"{format} is not a supported format");

    /// <summary>
    /// Gets a value indicating whether the specified value has the calling code for this country.
    /// </summary>
    /// <param name="value">A string containing a phone number in international format (e.g. +XX).</param>
    /// <returns>True if the value has the calling code for this country, otherwise false.</returns>
    internal bool HasCallingCode(string value)
    {
        if (value is null)
        {
            return false;
        }

#if NETSTANDARD2_0
        var plusIdx = value.IndexOf(Chars.Plus);
#else
        var plusIdx = value.IndexOf(Chars.Plus, StringComparison.Ordinal);
#endif

        return plusIdx >= 0 && value.IndexOf(CallingCode, StringComparison.Ordinal) == plusIdx + 1;
    }

    /// <summary>
    /// Gets a value indicating whether the specified value has a length equal to a valid national significant number (NSN) for this country.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <returns>True if the value has a valid length for this country, otherwise false.</returns>
    internal bool IsValidNsnLength(string value) =>
        NsnLengths.Contains(value.Length);

    /// <summary>
    /// Reads the national significant number (NSN) from the specified phone number value.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    /// <returns>The national significant number (NSN).</returns>
    /// <remarks>This excludes the CallingCode, TrunkPrefix and any non digit characters.</remarks>
    internal string ReadNationalSignificantNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        var startIdx = 0;

        if (HasCallingCode(value))
        {
            startIdx = value.IndexOf(CallingCode, StringComparison.Ordinal) + CallingCode.Length;
        }

        return ReadNationalSignificantNumber(value, startIdx);
    }

    /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
    private static bool IsDigit(char charVal) =>
        charVal is >= '0' and <= '9';

    private static bool IsSeparator(char charVal) =>
        charVal == Chars.Comma || charVal == Chars.Semicolon;

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private string GetDebuggerDisplay() =>
        $"{Iso3166Code} {CallingCode}";

    private string ReadNationalSignificantNumber(string value, int startPos)
    {
        Span<char> ar = stackalloc char[24]; // longer than any valid phone number
        var arPos = 0;

        for (var i = startPos; i < value.Length; i++)
        {
            var charVal = value[i];

            if (IsDigit(charVal))
            {
                ar[arPos++] = charVal;
            }

            if (IsSeparator(charVal))
            {
                break;
            }

            if (arPos == ar.Length)
            {
                break;
            }
        }

        if (TrunkPrefix is not null)
        {
            var startsWithTrunkPrefix = true;

            for (int i = 0; i < TrunkPrefix.Length; i++)
            {
                if (ar[i] != TrunkPrefix[i])
                {
                    startsWithTrunkPrefix = false;
                    break;
                }
            }

            if (startsWithTrunkPrefix)
            {
                return ar.Slice(TrunkPrefix.Length, arPos - TrunkPrefix.Length).ToString();
            }
        }

        return ar.Slice(0, arPos).ToString();
    }
}
