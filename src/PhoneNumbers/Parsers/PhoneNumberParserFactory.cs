using System.Collections.Concurrent;
using System.Reflection;

namespace PhoneNumbers.Parsers
{
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
                        .GetType($"PhoneNumbers.Parsers.{x.Iso3116Code}PhoneNumberParser")?
                        .GetMethod("Create", BindingFlags.NonPublic | BindingFlags.Static);

                    if (createMethod?.Invoke(null, null) is PhoneNumberParser parser)
                    {
                        return parser;
                    }

                    if (countryInfo.HasAreaCodes)
                    {
                        return AreaCodePhoneNumberParser.Create(countryInfo);
                    }

                    return LocalOnlyPhoneNumberParser.Create(countryInfo);
                });
    }
}
