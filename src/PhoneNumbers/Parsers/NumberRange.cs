using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;

#if NET6_0_OR_GREATER
using static System.ArgumentException;
using static System.ArgumentOutOfRangeException;
#else
using static System.ArgumentExceptionEx;
using static System.ArgumentOutOfRangeExceptionEx;
#endif

namespace PhoneNumbers.Parsers;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
internal sealed class NumberRange
{
    private static readonly ConcurrentDictionary<string, NumberRange> s_numberRangeCache = new(StringComparer.Ordinal);

    private readonly long _fromIntValue;
    private readonly bool _isSingleNumber;
    private readonly long _toIntValue;

    private NumberRange(string from, string to)
    {
        ThrowIfNullOrWhiteSpace(from);
        ThrowIfNullOrWhiteSpace(to);
#pragma warning disable S3236
        ThrowIfLessThan(to.Length, from.Length, nameof(to));
#pragma warning restore S3236

        (From, To) = (from, to);
        _isSingleNumber = From.Equals(To, StringComparison.Ordinal);

        if (!_isSingleNumber)
        {
            _fromIntValue = long.Parse(From, CultureInfo.InvariantCulture);
            _toIntValue = long.Parse(To, CultureInfo.InvariantCulture);

#pragma warning disable S3236
            ThrowIfLessThan(_toIntValue, _fromIntValue, nameof(to));
#pragma warning restore S3236
        }
    }

    internal string From { get; }

    internal string To { get; }

    internal static NumberRange Create(string value) =>
        s_numberRangeCache.GetOrAdd(
            value,
            x =>
            {
                var separatorIndex = x.IndexOf(Chars.Hyphen, StringComparison.Ordinal);

                if (separatorIndex == -1)
                {
                    return new NumberRange(x, x);
                }

                if (separatorIndex != x.LastIndexOf(Chars.Hyphen))
                {
                    throw new InvalidOperationException($"A number range must be expressed as either X or X-X, the value '{x}' is invalid");
                }

                return new NumberRange(
                    x.Substring(0, separatorIndex),
                    x.Substring(separatorIndex + 1));
            });

    internal bool Contains(string value)
    {
        if (_isSingleNumber)
        {
            return value.Equals(From, StringComparison.Ordinal);
        }

        // Short circuit, since all values are significant, '000' is not within '0000' to '9999'.
        if (value.Length < From.Length || value.Length > To.Length)
        {
            return false;
        }

        var intValue = long.Parse(value, CultureInfo.InvariantCulture);

        return intValue >= _fromIntValue && intValue <= _toIntValue;
    }

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    private string GetDebuggerDisplay() =>
        _isSingleNumber ? From : $"{From}-{To}";
}
