using System.Collections.Generic;
using PhoneNumbers.Parsers;

namespace PhoneNumbers
{
    /// <summary>
    /// A class containing the options for parsing phone numbers.
    /// </summary>
    internal sealed class ParseOptions
    {
        /// <summary>
        /// Gets the default parse options.
        /// </summary>
        internal static ParseOptions Default { get; } = new();

        /// <summary>
        /// Gets the <see cref="PhoneNumberParser"/>s.
        /// </summary>
        internal IList<PhoneNumberParser> Parsers { get; } = new List<PhoneNumberParser>
        {
            UKPhoneNumberParser.Create(),
        };
    }
}
