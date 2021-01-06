using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    internal sealed class CountryNumber
    {
        internal IReadOnlyList<NumberRange>? AreaCodeRanges { get; init; }

        internal string? GeographicArea { get; init; }

        internal Hint Hint { get; init; }

        internal PhoneNumberKind Kind { get; init; }

        internal IReadOnlyList<NumberRange> LocalNumberRanges { get; init; } = null!;
    }
}
