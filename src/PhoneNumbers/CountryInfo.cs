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
public sealed partial class CountryInfo : IEquatable<CountryInfo>
{
    internal const string Africa = "Africa";
    internal const string Asia = "Asia";
    internal const string Europe = "Europe";
    internal const string ItuInternationalCallPrefix = "00";
    internal const string NorthAmerica = "North America";
    internal const string Oceania = "Oceania";
    internal const string SouthAmerica = "South America";
    #if !NET8_0_OR_GREATER
    private static readonly ReadOnlyCollection<int> s_emptyIntArray = new(Array.Empty<int>());
    private static readonly ReadOnlyDictionary<string, string> s_emptyStringDictionary = new(new Dictionary<string, string>(StringComparer.Ordinal));
    #endif

    private static readonly ReadOnlyCollection<PhoneNumberFormatter> s_formatters = new(
    [
        E164PhoneNumberFormatter.Instance,
        E123PhoneNumberFormatter.Instance,
        NationalPhoneNumberFormatter.Instance,
        NationalUnformattedPhoneNumberFormatter.Instance,
        Rfc3966PhoneNumberFormatter.Instance,
    ]);

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
    /// Gets the full name of the country in English.
    /// </summary>
    public required string FullName { get; init; } = null!;

    /// <summary>
    /// Gets a value indicating whether the country has national destination codes.
    /// </summary>
    public bool HasNationalDestinationCodes => NdcLengths.Count > 0;

    /// <summary>
    /// Gets a value indicating whether the country has a trunk prefix.
    /// </summary>
    public bool HasTrunkPrefix => TrunkPrefix is not null;

    /// <summary>
    /// Gets the international call prefix.
    /// </summary>
    /// <remarks>May also be referred to as international direct dialling or international subscriber dialling, defaults to the ITU recommended '00', see https://en.wikipedia.org/wiki/List_of_international_call_prefixes.</remarks>
    public string InternationalCallPrefix { get; init; } = ItuInternationalCallPrefix;

    /// <summary>
    /// Gets a value indicating whether the country is a member of the European Union.
    /// </summary>
    public bool IsEuropeanUnionMember { get; init; }

    /// <summary>
    /// Gets a value indicating whether the country is a member of the North Atlantic Treaty Organisation.
    /// </summary>
    public bool IsNatoMember { get; init; }

    /// <summary>
    /// Gets a value indicating whether the country is a member of the Organisation for Economic Co-operation and Development.
    /// </summary>
    public bool IsOecdMember { get; init; }

    /// <summary>
    /// Gets the ISO 3166 Alpha-2 code for the country.
    /// </summary>
    /// <remarks>See https://www.iso.org/iso-3166-country-codes.html</remarks>
    public required string Iso3166Code { get; init; } = null!;

    /// <summary>
    /// Gets the name of the country in English.
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
    /// Gets country specific international call prefixes.
    /// </summary>
    internal ReadOnlyDictionary<string, string> InternationalCallPrefixes { get; init; } =
    #if NET8_0_OR_GREATER
    ReadOnlyDictionary<string, string>.Empty;
    #else
    s_emptyStringDictionary;
    #endif

    /// <summary>
    /// Gets the possible lengths of the national destination code.
    /// </summary>
    internal ReadOnlyCollection<int> NdcLengths { get; init; } =
    #if NET8_0_OR_GREATER
    ReadOnlyCollection<int>.Empty;
    #else
    s_emptyIntArray;
    #endif

    /// <summary>
    /// Gets the permitted lengths of the national significant number.
    /// </summary>
    internal ReadOnlyCollection<int> NsnLengths { get; init; } =
    #if NET8_0_OR_GREATER
    ReadOnlyCollection<int>.Empty;
    #else
    s_emptyIntArray;
    #endif

    /// <inheritdoc/>
    public static bool operator !=(CountryInfo? countryInfo1, CountryInfo? countryInfo2) =>
        !(countryInfo1 == countryInfo2);

    /// <inheritdoc/>
    public static bool operator ==(CountryInfo? countryInfo1, CountryInfo? countryInfo2)
    {
        if (countryInfo1 is null)
        {
            return countryInfo2 is null;
        }

        return countryInfo1.Equals(countryInfo2);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        Equals(obj as CountryInfo);

    /// <inheritdoc/>
    public bool Equals(CountryInfo? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Iso3166Code.Equals(other.Iso3166Code, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public override int GetHashCode() =>
        HashCode.Combine(Iso3166Code);

    internal static IEnumerable<CountryInfo> GetCountries() =>
        typeof(CountryInfo)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(x => x.PropertyType == typeof(CountryInfo))
            .Select(x => x.GetValue(null))
            .Cast<CountryInfo>();

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
    internal bool HasValidNsnLength(string value) =>
        IsValidNsnLength(value.Length);

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

    /// <summary>
    /// Gets a value indicting whether this <see cref="CountryInfo"/> shares a calling code with the specified <see cref="CountryInfo"/>.
    /// </summary>
    /// <returns>True if the both countries share a calling code, otherwise false.</returns>
    internal bool SharesCallingCodeWith(CountryInfo countryInfo) =>
        CallingCode.Equals(countryInfo.CallingCode, StringComparison.Ordinal);

    private static bool IsDelimiter(char charVal) =>
        charVal == Chars.Comma || charVal == Chars.Semicolon;

    /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
    private static bool IsDigit(char charVal) =>
        charVal is >= '0' and <= '9';

    private static bool IsSeparator(char charVal) =>
        charVal == Chars.Hyphen || charVal == Chars.ForwardSlash;

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private string GetDebuggerDisplay() =>
        $"{Iso3166Code} {CallingCode}";

    private bool IsValidNsnLength(int length) =>
        NsnLengths.Contains(length);

    private string ReadNationalSignificantNumber(string value, int startPos)
    {
        Span<char> ar = stackalloc char[16]; // longer than any valid phone number
        var arPos = 0;
        var startsWithTrunkPrefix = HasTrunkPrefix;

        for (var i = startPos; i < value.Length; i++)
        {
            var charVal = value[i];

            if (IsDigit(charVal))
            {
                if (startsWithTrunkPrefix && arPos < TrunkPrefix!.Length)
                {
                    startsWithTrunkPrefix &= TrunkPrefix[arPos] == charVal;
                }

                ar[arPos++] = charVal;

                if (arPos == ar.Length)
                {
                    break;
                }
            }
            else if (IsDelimiter(charVal)
                || IsSeparator(charVal) && (startsWithTrunkPrefix && IsValidNsnLength(arPos - TrunkPrefix!.Length) || (!startsWithTrunkPrefix && IsValidNsnLength(arPos))))
            {
                break;
            }
        }

        if (arPos == 0)
        {
            return string.Empty;
        }

        if (startsWithTrunkPrefix)
        {
            return ar.Slice(TrunkPrefix!.Length, arPos - TrunkPrefix.Length).ToString();
        }

        return ar.Slice(0, arPos).ToString();
    }
}
