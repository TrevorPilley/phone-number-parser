using System.Reflection;
using PhoneNumbers.Parsers;

namespace PhoneNumbers;

/// <summary>
/// A class containing the options for parsing phone numbers.
/// </summary>
public sealed class ParseOptions
{
    /// <summary>
    /// Initialises a new instance of the <see cref="ParseOptions"/> class.
    /// </summary>
    public ParseOptions()
       : this( x => x != null)
    {
    }

    private ParseOptions(Func<CountryInfo, bool> filter)
    {
        Countries = typeof(CountryInfo)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(x => x.PropertyType == typeof(CountryInfo))
            .Select(x => x.GetValue(null))
            .Cast<CountryInfo>()
            .Where(filter)
            .OrderBy(x => x.SharesCallingCode)
            .ToList();
    }

    /// <summary>
    /// Gets the default parse options.
    /// </summary>
    public static ParseOptions Default { get; } = new();

    /// <summary>
    /// Gets the parse options limited to countries in Europe.
    /// </summary>
    public static ParseOptions Europe { get; } = new(x => x.Continent == CountryInfo.Europe);

    /// <summary>
    /// Gets the supported <see cref="CountryInfo"/>s.
    /// </summary>
    /// <remarks>By default, this will contain all <see cref="CountryInfo"/> static properties.</remarks>
    public ICollection<CountryInfo> Countries { get; }

    /// <summary>
    /// Gets the <see cref="PhoneNumberParserFactory"/>.
    /// </summary>
    internal PhoneNumberParserFactory Factory { get; } = new();

    /// <summary>
    /// Gets the supported <see cref="CountryInfo"/> with the specified ISO 3166 Alpha-2 code.
    /// </summary>
    internal CountryInfo? GetCountryInfo(string countryCode) =>
        Countries.SingleOrDefault(x => x.Iso3166Code == countryCode);

    /// <summary>
    /// Gets the supported <see cref="CountryInfo"/>s for which the specified value is potentially an international number.
    /// </summary>
    internal IEnumerable<CountryInfo> GetCountryInfos(string value) =>
        Countries.Where(x => x.IsInternationalNumber(value));
}
