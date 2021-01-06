using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Globalization;

namespace PhoneNumbers.Parsers
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal sealed class NumberRange
    {
        private static readonly ConcurrentDictionary<string, NumberRange> s_numberRangeCache = new();

        private readonly int _fromIntValue;
        private readonly bool _isSingleNumber;
        private readonly int _toIntValue;

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

            // expects to to be numerically bigger than from (e.g. from '100' to '999') but both values must be the same length
            if (from.Length != to.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(to), $"The values From ({from}) and To ({to}) must be the same length");
            }

            (From, To) = (from, to);
            _isSingleNumber = From.Equals(To, StringComparison.Ordinal);
            _fromIntValue = int.Parse(From, CultureInfo.InvariantCulture);
            _toIntValue = int.Parse(To, CultureInfo.InvariantCulture);
        }

        internal string From { get; }

        internal string To { get; }

        internal static NumberRange Create(string value) =>
            s_numberRangeCache.GetOrAdd(
                value,
                x =>
                {
                    var rangeParts = x.Split('-');
                    return rangeParts.Length == 1
                        ? new NumberRange(rangeParts[0], rangeParts[0])
                        : new NumberRange(rangeParts[0], rangeParts[1]);
                });

        internal bool Contains(string value)
        {
            if (_isSingleNumber)
            {
                return value.Equals(From, StringComparison.Ordinal);
            }

            // short circuit since all values are significant then '000' is not within '0000' to '9999'
            if (value.Length < From.Length || value.Length > To.Length)
            {
                return false;
            }

            var intValue = int.Parse(value, CultureInfo.InvariantCulture);

            return intValue >= _fromIntValue && intValue <= _toIntValue;
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private string GetDebuggerDisplay() =>
            _isSingleNumber ? From : $"{From}-{To}";
    }
}
