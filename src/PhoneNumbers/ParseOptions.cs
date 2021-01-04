using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PhoneNumbers.Parsers;

namespace PhoneNumbers
{
    /// <summary>
    /// A class containing the options for parsing phone numbers.
    /// </summary>
    internal sealed class ParseOptions
    {
        private readonly PhoneNumberParserFactory _factory = new();

        /// <summary>
        /// Gets the default parse options.
        /// </summary>
        internal static ParseOptions Default { get; } = new();

        /// <summary>
        /// Gets the list of supported <see cref="CountryInfo"/>s.
        /// </summary>
        /// <remarks>By default, this will contain all <see cref="CountryInfo"/> static properties.</remarks>
        internal IList<CountryInfo> Countries { get; } = typeof(CountryInfo)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(x => x.PropertyType == typeof(CountryInfo))
            .Select(x => x.GetValue(null))
            .Cast<CountryInfo>()
            .ToList();

        internal PhoneNumberParser GetParser(CountryInfo countryInfo) =>
            _factory.GetParser(countryInfo);
    }
}
