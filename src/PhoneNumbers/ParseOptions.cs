using System.Collections.Generic;
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
        /// Gets the <see cref="PhoneNumberParser"/>s.
        /// </summary>
        public IList<PhoneNumberParser> Parsers { get; } = new List<PhoneNumberParser>
        {
            UKPhoneNumberParser.Create(),
        };
    }
}
