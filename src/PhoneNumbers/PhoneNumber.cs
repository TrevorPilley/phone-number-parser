using System;
using System.Collections.Generic;
using PhoneNumbers.Formatters;
using PhoneNumbers.Parsers;

namespace PhoneNumbers
{
    /// <remarks>
    /// https://en.wikipedia.org/wiki/List_of_country_calling_codes
    /// </remarks>
    public abstract class PhoneNumber
    {
        private static readonly IReadOnlyDictionary<string, PhoneNumberParser> _parsers = new Dictionary<string, PhoneNumberParser>
        {
            ["GB"] = new UkPhoneNumberParser(),
        };

        private static readonly IReadOnlyDictionary<string, PhoneNumberFormatter> _formatters = new Dictionary<string, PhoneNumberFormatter>
        {
            ["+44"] = new UkPhoneNumberFormatter(),
        };

        protected PhoneNumber(string callingCode, string trunkPrefix, string areaCode, string localNumber) =>
            (CallingCode, TrunkPrefix, AreaCode, LocalNumber) = (callingCode, trunkPrefix, areaCode, localNumber);

        public string AreaCode { get; }

        public string CallingCode { get; }

        public string LocalNumber { get; }

        public abstract PhoneNumberKind PhoneNumberKind { get; }

        public string TrunkPrefix { get; }

        public static PhoneNumber Parse(string value, string countryCode)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new NotSupportedException();
            }

            if (value[0] != '0')
            {
                throw new NotSupportedException(value);
            }

            if (_parsers.TryGetValue(countryCode, out PhoneNumberParser? parser))
            {
                return parser.Parse(ReadDigitsOnly(value));
            }

            throw new NotSupportedException(countryCode);
        }

        public override string ToString() =>
            ToString(PhoneNumberFormatter.DefaultFormat);

        public string ToString(string format) =>
            _formatters[CallingCode].Format(this, format);

        private static string ReadDigitsOnly(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new NotSupportedException();
            }

            int digits = 0;

            for (int i = 0; i < value.Length; i++)
            {
                var charVal = value[i];

                if (charVal >= '0' && charVal <= '9')
                {
                    digits++;
                }
            }

            if (digits == value.Length)
            {
                return value;
            }

            var chars = new char[digits];
            int charPos = 0;

            for (int i = 0; i < value.Length; i++)
            {
                var charVal = value[i];

                if (charVal >= '0' && charVal <= '9')
                {
                    chars[charPos++] = charVal;
                }
            }

            return new string(chars);
        }
    }
}
