using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PhoneNumbers.Parsers
{
    internal static class ResourceUtility
    {
        internal static IEnumerable<AreaCodeInfo> ReadAreaCodes(string name) =>
            ReadLines(name)
            .Select(x => x.Split('|'))
            .Select(x => new AreaCodeInfo(
                ParseNumberRanges(x[0]),
                x[1].Length > 0 ? x[1] : null,
                ParseNumberRanges(x[2]),
                ParseHint(x[3].Length > 0 ? x[3][0] : '\0')));

        private static Hint ParseHint(char value) =>
            (value) switch
            {
                '\0' => Hint.None,
                'D' => Hint.Data,
                'V' => Hint.Virtual,
                'P' => Hint.Pager,
                'F' => Hint.Freephone,
                _ => throw new NotSupportedException(value.ToString()),
            };

        private static IReadOnlyList<NumberRange> ParseNumberRanges(string value)
        {
            // There are very few number ranges so cache and re-use them to avoid loads of identical instances.
            var numberRangeCache = new Dictionary<string, NumberRange>();

            return value.Split(',')
                .Select(x =>
                {
                    if (!numberRangeCache.TryGetValue(x, out var numberRange))
                    {
                        var rangeParts = x.Split('-');
                        numberRange = rangeParts.Length == 1 ? new NumberRange(rangeParts[0]) : new NumberRange(rangeParts[0], rangeParts[1]);
                        numberRangeCache.Add(x, numberRange);
                    }

                    return numberRange;
                })
                .ToList();
        }

        private static IEnumerable<string> ReadLines(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames().Single(x => x.EndsWith(name, StringComparison.Ordinal));

            using var stream = assembly.GetManifestResourceStream(resourceName)!;
            using var reader = new StreamReader(stream);

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}
