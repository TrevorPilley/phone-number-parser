using System.Collections.ObjectModel;
using System.Reflection;

namespace PhoneNumbers.Parsers;

internal static class ResourceUtility
{
    // The file format is as follows (spaces for readability, not present in the file):
    // Kind | NDC Range(s) | Geographic Area | SN Range(s) | Hint
    internal static IReadOnlyList<CountryNumber> ReadCountryNumbers(string name) =>
        ReadLines(name)
            .Select(x => x.Split(Chars.Pipe))
            .Select(x => new CountryNumber
            {
                GeographicArea = x[2].Length > 0 ? x[2] : null,
                Hint = ParseNumberHint(x[4].Length > 0 ? x[4][0] : Chars.Null),
                Kind = ParseNumberKind(x[0][0]),
                NationalDestinationCodeRanges = x[1].Length > 0 ? ParseNumberRanges(x[1]) : null,
                SubscriberNumberRanges = ParseNumberRanges(x[3]),
            })
            .ToList()
            .AsReadOnly();

    private static PhoneNumberHint ParseNumberHint(char value) =>
        value switch
        {
            Chars.Null => PhoneNumberHint.None,
            'F' => PhoneNumberHint.Freephone,
            'M' => PhoneNumberHint.MachineToMachine,
            'N' => PhoneNumberHint.NationalDiallingOnly,
            'P' => PhoneNumberHint.Pager,
            'R' => PhoneNumberHint.PremiumRate,
            'S' => PhoneNumberHint.SharedCost,
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

    private static ReadOnlyCollection<NumberRange> ParseNumberRanges(string value) =>
        value
            .Split(Chars.Comma)
            .Select(NumberRange.Create)
            .ToList()
            .AsReadOnly();

    private static IEnumerable<string> ReadLines(string name)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = assembly.GetManifestResourceNames()
            .Single(x => x.EndsWith(name, StringComparison.Ordinal));

        using var stream = assembly.GetManifestResourceStream(resourceName)!;
        using var reader = new StreamReader(stream);

        string? line;

        while ((line = reader.ReadLine()) is not null)
        {
            if (line[0] != Chars.Hash)
            {
                yield return line;
            }
        }
    }
}
