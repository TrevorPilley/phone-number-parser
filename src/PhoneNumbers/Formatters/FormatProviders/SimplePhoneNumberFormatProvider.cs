using System.Collections.Concurrent;
using System.Text;

namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for numbers which returns a mask based upon '{NDC}{space}{SN}',
/// prefixing the trunk prefix where appropriate.
/// </summary>
/// <remarks>
/// It caters for trunk prefixes, and whether the NDC is optional.
/// </remarks>
internal class SimplePhoneNumberFormatProvider : PhoneNumberFormatProvider
{
    private readonly ConcurrentDictionary<ValueTuple<int, int>, string> _maskCache = new();

    protected SimplePhoneNumberFormatProvider(Dictionary<ValueTuple<int, int>, string>? commonMasks = null)
    {
        if (commonMasks is not null)
        {
            _maskCache = new(commonMasks);
        }
    }

    internal static PhoneNumberFormatProvider Default { get; } = new SimplePhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        var ndcLength = phoneNumber.NationalDestinationCode?.Length ?? 0;
        var snLength = phoneNumber.SubscriberNumber.Length;

        var initialMask = _maskCache.GetOrAdd(
            ValueTuple.Create(ndcLength, snLength),
            x => GenerateMask(x.Item1, x.Item2));

        if (international ||
            (!phoneNumber.Country.HasTrunkPrefix && !phoneNumber.HasNationalDestinationCode))
        {
            return initialMask;
        }

        var maskBuilder = new StringBuilder(20);
        maskBuilder.Append(initialMask);

        if (phoneNumber.Country.HasTrunkPrefix)
        {
            maskBuilder.Insert(0, phoneNumber.Country.TrunkPrefix);
        }

        if (phoneNumber.NdcIsOptional())
        {
            maskBuilder.Insert(0, Chars.OpenParenthesis);
            maskBuilder.Insert(
                1 + (phoneNumber.Country.TrunkPrefix?.Length ?? 0) + phoneNumber.NationalDestinationCode!.Length,
                Chars.CloseParenthesis);
        }

        return maskBuilder.ToString();
    }
}
