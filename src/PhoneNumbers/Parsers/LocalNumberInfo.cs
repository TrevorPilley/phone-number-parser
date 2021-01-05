using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    internal class LocalNumberInfo
    {
        internal Hint Hint { get; init; }

        internal PhoneNumberKind Kind { get; init; }

        internal IReadOnlyList<NumberRange> LocalNumberRanges { get; init; } = null!;
    }
}
