using System;
using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    /// <remarks>
    /// https://en.m.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom
    /// https://en.wikipedia.org/wiki/List_of_dialling_codes_in_the_United_Kingdom
    /// </remarks>
    public sealed class UkPhoneNumberParser : PhoneNumberParser
    {
        private readonly string _callingCode = "+44";

        private readonly IReadOnlyDictionary<string, string> _geographicAreas = new Dictionary<string, string>
        {
            ["20"] = "London",
            ["24"] = "Coventry",
            ["28"] = "Northern Ireland",
            ["29"] = "Cardiff",
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
            ["191"] = "Tyneside, Sunderland and Durham",
        };

        private readonly IReadOnlyDictionary<KeyValuePair<string, char>, string> _geographicAreas2 = new Dictionary<KeyValuePair<string, char>, string>
        {
            [new KeyValuePair<string, char>("23", '8')] = "Southampton",
            [new KeyValuePair<string, char>("23", '9')] = "Portsmouth",
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
                case '2':
                    return ParseGeographicPhoneNumber(value);

                case '7':
                    return ParseMobilePhoneNumber(value);

                default:
                    throw new NotSupportedException(value);
            }
        }

        private string LookupGeographicArea(string areaCode, string localNumber)
        {
            string? geographicArea = null;

            if (_geographicAreas.TryGetValue(areaCode, out geographicArea))
            {
                return geographicArea;
            }

            if (_geographicAreas2.TryGetValue(new KeyValuePair<string, char>(areaCode, localNumber[0]), out geographicArea))
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

            // 2X
            if (value[1] == '2')
            {
                areaCodeLength = 2;
            }

            var areaCode = value.Substring(_trunkPrefix.Length, areaCodeLength);
            var localNumber = value.Substring(_trunkPrefix.Length + areaCodeLength);

            if (areaCode.Length == 2 && localNumber.Length != 8
                || areaCode.Length == 3 && localNumber.Length != 7)
            {
                throw new NotSupportedException(localNumber);
            }

            var geographicArea = LookupGeographicArea(areaCode, localNumber);

            return new GeographicPhoneNumber(
                _callingCode,
                _trunkPrefix,
                areaCode,
                localNumber,
                geographicArea);
        }

        private PhoneNumber ParseMobilePhoneNumber(string value)
        {
            // Including the Trunk Prefix, all UK mobile numbers are 11 digits
            if (value.Length != 11)
            {
                throw new NotSupportedException(value);
            }

            // 72xx is not a mobile area code
            if (value[2] == '2')
            {
                throw new NotSupportedException(value);
            }

            var areaCode = value.Substring(1, 4);

            var localNumber = value.Substring(5);

            // UK Wifi (data only plans) start 7911 2xx or 8xx
            var isDataOnly = areaCode == "7911" && (value[5] == '2' || value[5] == '8');

            // start 7911 2xx or 8xx
            if (areaCode == "7911" && value[5] != '2' && value[5] != '8')
            {
                throw new NotSupportedException(value);
            }

            // UK pagers start 76 except 7624 which is in use for the Isle of Man
            var isPager = value[2] == '6' && areaCode != "7624";

            // UK virtual (personal numbers) start 70
            var isVirtual = value[2] == '0';

            return new MobilePhoneNumber(
                _callingCode,
                _trunkPrefix,
                areaCode,
                localNumber,
                isDataOnly,
                isPager,
                isVirtual);
        }
    }
}
