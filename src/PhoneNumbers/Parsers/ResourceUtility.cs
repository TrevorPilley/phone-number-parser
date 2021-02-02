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
        // Kind | NDC Ranges | Geographic Area | SN Ranges | Hint
        internal static IEnumerable<CountryNumber> ReadCountryNumbers(string name) =>
            ReadLines(name)
                .Select(x => x.Split('|'))
                .Select(x => new CountryNumber
                {
                    GeographicArea = x[2].Length > 0 ? x[2] : null,
                    Hint = ParseNumberHint(x[4].Length > 0 ? x[4][0] : '\0'),
                    Kind = ParseNumberKind(x[0][0]),
                    NationalDiallingCodeRanges = x[1].Length > 0 ? ParseNumberRanges(x[1]) : null,
                    SubscriberNumberRanges = ParseNumberRanges(x[3]),
                });

        private static PhoneNumberHint ParseNumberHint(char value) =>
            value switch
            {
                '\0' => PhoneNumberHint.None,
                'D' => PhoneNumberHint.Data,
                'F' => PhoneNumberHint.Freephone,
                'P' => PhoneNumberHint.Pager,
                'V' => PhoneNumberHint.Virtual,
                _ => throw new NotSupportedException(value.ToString()),
            };

        private static PhoneNumberKind ParseNumberKind(char value) =>
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
                if (line[0] != '#')
                {
                    yield return line;
                }
            }
        }
    }
}
