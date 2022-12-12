using PhoneNumbers.Parsers;

namespace PhoneNumbers;

/// <summary>
/// A class containing the options for parsing phone numbers.
/// </summary>
public sealed class ParseOptions
{
    /// <summary>
    /// Gets the default parse options.
    /// </summary>
    public static ParseOptions Default { get; } = new();

    /// <summary>
    /// Gets the supported <see cref="CountryInfo"/>s.
    /// </summary>
    /// <remarks>By default, this will contain all <see cref="CountryInfo"/> static properties.</remarks>
    public ICollection<CountryInfo> Countries { get; } = CountryInfo.GetCountries().ToList();

    /// <summary>
    /// Gets the <see cref="PhoneNumberParserFactory"/>.
    /// </summary>
    internal PhoneNumberParserFactory Factory { get; } = new();

    /// <summary>
    /// Gets the supported <see cref="CountryInfo"/> with the specified ISO 3166 Alpha-2 code.
    /// </summary>
    /// <param name="countryCode">A string containing an ISO 3166 Alpha-2 code.</param>
    internal CountryInfo? GetCountryInfo(string countryCode) =>
        Countries.SingleOrDefault(x => x.Iso3166Code == countryCode);

    /// <summary>
    /// Gets the supported <see cref="CountryInfo"/>s for which the specified value is potentially an international number.
    /// </summary>
    /// <param name="value">A string containing a phone number.</param>
    internal IEnumerable<CountryInfo> GetCountryInfos(string value) =>
        Countries.Where(x => x.StartsWithCallingCode(value));
}
