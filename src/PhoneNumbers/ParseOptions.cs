using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PhoneNumbers.Parsers;

namespace PhoneNumbers
{
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
        public ICollection<CountryInfo> Countries { get; } = typeof(CountryInfo)
            .GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Where(x => x.PropertyType == typeof(CountryInfo))
            .Select(x => x.GetValue(null))
            .Cast<CountryInfo>()
            .OrderBy(x => x.SharesCallingCode)
            .ToList();

        /// <summary>
        /// Gets the <see cref="PhoneNumberParserFactory"/>.
        /// </summary>
        internal PhoneNumberParserFactory Factory { get; } = new();
    }
}
