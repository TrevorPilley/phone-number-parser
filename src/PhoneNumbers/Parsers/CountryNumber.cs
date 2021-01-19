using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// A class representing a line in a country data file.
    /// </summary>
    internal sealed class CountryNumber
    {
        /// <summary>
        /// Gets the <see cref="NumberRange"/>s of the area code.
        /// </summary>
        internal IReadOnlyList<NumberRange>? AreaCodeRanges { get; init; }

        /// <summary>
        /// Gets the name of the geographic area.
        /// </summary>
        internal string? GeographicArea { get; init; }

        /// <summary>
        /// Gets the <see cref="Hint"/>.
        /// </summary>
        internal Hint Hint { get; init; }

        /// <summary>
        /// Gets the <see cref="PhoneNumberParser"/>.
        /// </summary>
        internal PhoneNumberKind Kind { get; init; }

        /// <summary>
        /// Gets the <see cref="NumberRange"/>s of the local numbers.
        /// </summary>
        internal IReadOnlyList<NumberRange> LocalNumberRanges { get; init; } = null!;
    }
}
