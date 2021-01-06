using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PhoneNumbers.Parsers
{
    internal static class ResourceUtility
    {
        // The file format is as follows (spaces for readability, not present in the file):
        // Kind | Area Code Ranges | Geographic Area | Local Number Ranges | Hint
        internal static IEnumerable<CountryNumber> ReadCountryNumbers(string name) =>
            ReadLines(name)
                .Select(x => x.Split('|'))
                .Select(x => new CountryNumber
                {
                    AreaCodeRanges = ParseNumberRanges(x[1]),
                    GeographicArea = x[2].Length > 0 ? x[2] : null,
                    Hint = ParseHint(x[4].Length > 0 ? x[4][0] : '\0'),
                    Kind = ParseKind(x[0][0]),
                    LocalNumberRanges = ParseNumberRanges(x[3]),
                });

        private static Hint ParseHint(char value) =>
            value switch
            {
                '\0' => Hint.None,
                'D' => Hint.Data,
                'F' => Hint.Freephone,
                'P' => Hint.Pager,
                'V' => Hint.Virtual,
                _ => throw new NotSupportedException(value.ToString()),
            };

        private static PhoneNumberKind ParseKind(char value) =>
            value switch
            {
                'G' => PhoneNumberKind.GeographicPhoneNumber,
                'M' => PhoneNumberKind.MobilePhoneNumber,
                'N' => PhoneNumberKind.NonGeographicPhoneNumber,
                _ => throw new NotSupportedException(value.ToString()),
            };

        private static IReadOnlyList<NumberRange> ParseNumberRanges(string value) =>
            value
                .Split(',')
                .Select(NumberRange.Create)
                .ToList();

        private static IEnumerable<string> ReadLines(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames()
                .Single(x => x.EndsWith(name, StringComparison.Ordinal));

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
