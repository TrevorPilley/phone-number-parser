using System.Collections.Concurrent;

namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for numbers which returns an unformatted mask the length of the NSN.
/// </summary>
/// <remarks>
/// It caters for trunk prefixes, but not the numbering plan type or whether the NDC is optional.
/// </remarks>
internal sealed class BasicPhoneNumberFormatProvider : PhoneNumberFormatProvider
{
    private readonly ConcurrentDictionary<int, string> _maskCache = new();

    private BasicPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new BasicPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        var initialMask = _maskCache.GetOrAdd(
            phoneNumber.NationalSignificantNumber.Length,
            GenerateMask);

        if (international || !phoneNumber.Country.HasTrunkPrefix)
        {
            return initialMask;
        }

        return $"{phoneNumber.Country.TrunkPrefix}{initialMask}";
    }
}
