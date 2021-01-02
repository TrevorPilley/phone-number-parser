using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    internal sealed class AreaCodeInfo
    {
        internal AreaCodeInfo()
        {
        }

        internal IReadOnlyList<NumberRange> AreaCodeRanges { get; init; } = null!;

        internal string? GeographicArea { get; init; } = null!;

        internal Hint Hint { get; init; }

        internal IReadOnlyList<NumberRange> LocalNumberRanges { get; init; } = null!;
    }
}
