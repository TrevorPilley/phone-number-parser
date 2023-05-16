using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;

namespace PhoneNumbers.Parsers;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
internal sealed class NumberRange
{
    private static readonly ConcurrentDictionary<string, NumberRange> s_numberRangeCache = new();

    private readonly long _fromIntValue;
    private readonly bool _isSingleNumber;
    private readonly long _toIntValue;

    private NumberRange(string from, string to)
    {
        if (string.IsNullOrWhiteSpace(from))
        {
            throw new ArgumentException($"'{nameof(from)}' cannot be null or whitespace", nameof(from));
        }

        if (string.IsNullOrWhiteSpace(to))
        {
            throw new ArgumentException($"'{nameof(to)}' cannot be null or whitespace", nameof(to));
        }

        if (to.Length < from.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(to), $"The length of the value To ({to}) must be greater than or equal to the length of the value From ({from})");
        }

        (From, To) = (from, to);
        _isSingleNumber = From.Equals(To, StringComparison.Ordinal);

        if (!_isSingleNumber)
        {
            _fromIntValue = long.Parse(From, CultureInfo.InvariantCulture);
            _toIntValue = long.Parse(To, CultureInfo.InvariantCulture);

            if (_toIntValue < _fromIntValue)
            {
                throw new ArgumentOutOfRangeException(nameof(to), $"The value To ({to}) must be greater than or equal to the value From ({from})");
            }
        }
    }

    internal string From { get; }

    internal string To { get; }

    internal static NumberRange Create(string value) =>
        s_numberRangeCache.GetOrAdd(
            value,
            x =>
            {
#pragma warning disable CA1307 // Specify StringComparison for clarity
                var separatorIndex = x.IndexOf(Chars.Hyphen);
#pragma warning restore CA1307 // Specify StringComparison for clarity

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
