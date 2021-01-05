using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    internal sealed class LocalNumberInfo
    {
        internal Hint Hint { get; init; }

        internal PhoneNumberKind Kind { get; init; }

        internal IReadOnlyList<NumberRange> LocalNumberRanges { get; init; } = null!;
    }
}
