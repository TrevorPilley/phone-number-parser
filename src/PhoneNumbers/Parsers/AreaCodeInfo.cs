using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    internal sealed class AreaCodeInfo : LocalNumberInfo
    {
        internal IReadOnlyList<NumberRange> AreaCodeRanges { get; init; } = null!;

        internal string? GeographicArea { get; init; }
    }
}
