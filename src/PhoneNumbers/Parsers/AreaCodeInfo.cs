using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    internal sealed class AreaCodeInfo
    {
        internal AreaCodeInfo(
            IReadOnlyList<NumberRange> areaCodeRanges,
            string? geographicArea,
            IReadOnlyList<NumberRange> localNumberRanges,
            Hint hint) =>
            (AreaCodeRanges, GeographicArea, Hint, LocalNumberRanges) = (areaCodeRanges, geographicArea, hint, localNumberRanges);

        internal IReadOnlyList<NumberRange> AreaCodeRanges { get; }

        internal string? GeographicArea { get; }

        internal Hint Hint { get; }

        internal IReadOnlyList<NumberRange> LocalNumberRanges { get; }
    }
}
