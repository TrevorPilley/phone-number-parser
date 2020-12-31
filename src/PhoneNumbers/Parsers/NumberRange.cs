using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace PhoneNumbers.Parsers
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal sealed class NumberRange
    {
        private static readonly ConcurrentDictionary<string, NumberRange> s_numberRangeCache = new();

        private readonly bool _singleNumber;

        // expects to to be numerically bigger than from (e.g. from '100' to '999') but both values must be the same length
        private NumberRange(string from, string to)
        {
            if (from.Length != to.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(to), "From and To must be the same length");
            }

            (From, To) = (from, to);
            _singleNumber = From.Equals(To, StringComparison.Ordinal);
        }

        internal string From { get; }

        internal string To { get; }

        internal static NumberRange Create(string value) =>
            s_numberRangeCache.GetOrAdd(
                value,
                x =>
                {
                    var rangeParts = x.Split('-');
                    return rangeParts.Length == 1 ? new NumberRange(rangeParts[0], rangeParts[0]) : new NumberRange(rangeParts[0], rangeParts[1]);
                });

        internal bool Contains(string value)
        {
            if (_singleNumber)
            {
                return value.Equals(From, StringComparison.Ordinal);
            }

            // short circuit since all values are significant then '000' is not within '0000' to '9999'
            if (value.Length < From.Length || value.Length > To.Length)
            {
                return false;
            }

            for (var i = 0; i < value.Length; i++)
            {
                var val = value[i];

                if (val < From[i])
                {
                    return false;
                }

                if (val > From[i])
                {
                    break;
                }
            }

            for (var i = 0; i < value.Length; i++)
            {
                var val = value[i];

                if (val > To[i])
                {
                    return false;
                }

                if (val < To[i])
                {
                    break;
                }
            }

            return true;
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private string GetDebuggerDisplay() =>
            _singleNumber ? From : $"{From}-{To}";
    }
}
