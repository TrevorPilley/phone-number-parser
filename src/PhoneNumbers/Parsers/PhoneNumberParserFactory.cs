using System.Collections.Concurrent;

namespace PhoneNumbers.Parsers;

internal sealed class PhoneNumberParserFactory
{
    private readonly ConcurrentDictionary<CountryInfo, PhoneNumberParser> _parserCache = new();

    internal PhoneNumberParser GetParser(CountryInfo countryInfo)
    {
        ArgumentNullException.ThrowIfNull(countryInfo);

        return _parserCache.GetOrAdd(
            countryInfo,
            x =>
            {
                if (x == CountryInfo.UnitedKingdom)
                {
                    return GBPhoneNumberParser.Create();
                }

                return DefaultPhoneNumberParser.Create(x);
            });
    }
}
