using System.Collections.Concurrent;
using System.Reflection;

namespace PhoneNumbers.Parsers;

internal sealed class PhoneNumberParserFactory
{
    private readonly ConcurrentDictionary<CountryInfo, PhoneNumberParser> _parserCache = new();

    internal PhoneNumberParser GetParser(CountryInfo countryInfo) =>
        _parserCache.GetOrAdd(
            countryInfo,
            x =>
            {
                var createMethod = typeof(PhoneNumberParser)
                    .Assembly
                    .GetType($"PhoneNumbers.Parsers.{x.Iso3166Code}PhoneNumberParser")
                    ?.GetMethod("Create", BindingFlags.Public | BindingFlags.Static);

                if (createMethod?.Invoke(obj: null, parameters: null) is PhoneNumberParser parser)
                {
                    return parser;
                }

                return DefaultPhoneNumberParser.Create(x);
            });
}
