using System;
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

        internal void AssertLocalNumberLength(string localNumber)
        {
            if (!LocalNumberLengths.Contains(localNumber.Length))
            {
                throw new ArgumentException($"The for the area code {AreaCode}, the local number must be {string.Join(",", LocalNumberLengths)} digits.");
            }
        }
    }
}
