using System.Collections.ObjectModel;

namespace PhoneNumbers.Parsers
{
    internal sealed class AreaCodeInfo
    {
        internal AreaCodeInfo(string areaCode, string? geographicArea, int[] localNumberLengths) =>
            (AreaCode, GeographicArea, LocalNumberLengths) = (areaCode, geographicArea, new ReadOnlyCollection<int>(localNumberLengths));

        internal string AreaCode { get; }

        internal string? GeographicArea { get; }

        internal ReadOnlyCollection<int> LocalNumberLengths { get; }
    }
}
