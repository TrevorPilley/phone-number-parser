using System;
using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    public sealed class UkPhoneNumberParser : PhoneNumberParser
    {
        private readonly string _callingCode = "+44";

        private readonly IReadOnlyDictionary<string, string> _geographicAreas = new Dictionary<string, string>
        {
            ["113"] = "Leeds",
            ["114"] = "Sheffield",
            ["115"] = "Nottingham",
            ["116"] = "Leicester",
            ["117"] = "Bristol",
            ["118"] = "Reading",
            ["121"] = "Birmingham",
            ["131"] = "Edinburgh",
            ["141"] = "Glasgow",
            ["151"] = "Liverpool",
            ["161"] = "Manchester",
            ["191"] = "Tyneside and Durham",
        };

        private readonly string _trunkPrefix = "0";

        public override PhoneNumber Parse(string value)
        {
            if (value[0] != '0')
            {
                throw new NotSupportedException();
            }

            switch (value[1])
            {
                case '1':
                    return ParseGeographicPhoneNumber(value);

                default:
                    throw new NotSupportedException(value);
            }
        }

        private string LookupGeographicArea(string areaCode)
        {
            string? geographicArea = null;

            if (_geographicAreas.TryGetValue(areaCode, out geographicArea))
            {
                return geographicArea;
            }

            throw new NotSupportedException(areaCode);
        }

        private PhoneNumber ParseGeographicPhoneNumber(string value)
        {
            int areaCodeLength = 0;

            // 11X or 1X1
            if (value[1] == '1' && (value[2] == '1' || value[3] == '1'))
            {
                areaCodeLength = 3;
            }

            var areaCode = value.Substring(1, areaCodeLength);
            var localNumber = value.Substring(_trunkPrefix.Length + areaCodeLength);
            var geographicArea = LookupGeographicArea(areaCode);

            return new GeographicPhoneNumber(
                _callingCode,
                _trunkPrefix,
                areaCode,
                localNumber,
                geographicArea);
        }
    }
}
