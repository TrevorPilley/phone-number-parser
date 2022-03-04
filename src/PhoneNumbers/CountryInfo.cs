using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using PhoneNumbers.Formatters;

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
    internal const string Oceania = "Oceania";
    internal const string NorthAmerica = "North America";
    internal const string SouthAmerica = "South America";
    private const char PlusSign = '+';
    private static readonly ReadOnlyCollection<int> s_emptyIntArray = new(Array.Empty<int>());
    private readonly List<PhoneNumberFormatter> _formatters;

    /// <summary>
    /// Initialises a new instance of the <see cref="CountryInfo"/> class.
    /// </summary>
    /// <remarks>The constructor is internal for unit tests only.</remarks>
    internal CountryInfo() =>
        _formatters = new(new[]
        {
            E164PhoneNumberFormatter.Instance,
            E123PhoneNumberFormatter.Instance,
            NationalPhoneNumberFormatter.Instance,
        });

    /// <summary>
    /// Gets the calling code for the country (e.g. '+XX').
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/List_of_country_calling_codes.</remarks>
    public string CallingCode { get; init; } = null!;

    /// <summary>
    /// Gets the name of the continent the country is part of.
    /// </summary>
    public string Continent { get; init; } = null!;

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
    internal ReadOnlyCollection<int> NdcLengths { get; init; } = s_emptyIntArray;

    /// <summary>
    /// Gets the permitted lengths of the national significant number.
    /// </summary>
    internal ReadOnlyCollection<int> NsnLengths { get; init; } = s_emptyIntArray;

    /// <summary>
    /// Gets a value indicating whether national dialling codes are required for local dialling within a geographic NDC.
    /// </summary>
    internal bool RequireNdcForLocalGeographicDialling { get; init; } = true;

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
    /// <remarks>This excludes the CallingCode, TrunkPrefix and any non digit characters.</remarks>
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

        return ReadNationalSignificantNumber(value, startPos);
    }

    internal static ICollection<CountryInfo> GetCountries(Func<CountryInfo, bool> predicate) =>
        typeof(CountryInfo)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(x => x.PropertyType == typeof(CountryInfo))
            .Select(x => x.GetValue(null))
            .Cast<CountryInfo>()
            .Where(predicate)
            .OrderBy(x => x.SharesCallingCode)
            .ToList();

    private static int CountDigitsAfter(string value, int startPos)
    {
        var digits = 0;

        for (var i = startPos; i < value.Length; i++)
        {
            var charVal = value[i];

            if (IsDigit(charVal))
            {
                digits++;
            }
        }

        return digits;
    }

    /// <remarks>Char.IsDigit returns true for more than 0-9 so use a more restricted version.</remarks>
    private static bool IsDigit(char charVal) =>
        charVal is >= '0' and <= '9';

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private string GetDebuggerDisplay() =>
        $"{Iso3166Code} {CallingCode}";

    private string ReadNationalSignificantNumber(string value, int startPos)
    {
        var digits = CountDigitsAfter(value, startPos);

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

        if (TrunkPrefix is not null)
        {
            var startsWithTrunkPrefix = true;

            for (int i = 0; i < TrunkPrefix.Length; i++)
            {
                if (chars[i] != TrunkPrefix[i])
                {
                    startsWithTrunkPrefix = false;
                    break;
                }
            }

            if (startsWithTrunkPrefix)
            {
                return chars.AsSpan().Slice(TrunkPrefix.Length).ToString();
            }
        }

        return new string(chars);
    }
}
