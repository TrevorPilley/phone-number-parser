using System;

namespace PhoneNumbers.Parsers
{
    internal sealed class NumberRange
    {
        private readonly bool _singleNumber;

        internal NumberRange(string value)
            : this(value, value)
        {
        }

        // expects to to be numerically bigger than from (e.g. from '100' to '999') but both values must be the same length
        internal NumberRange(string from, string to)
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

            for (int i = 0; i < value.Length; i++)
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

            for (int i = 0; i < value.Length; i++)
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
    }
}
