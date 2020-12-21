using System;
using System.Collections.Generic;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// A <see cref="PhoneNumberParser"/> for UK phone numbers.
    /// </summary>
    /// <remarks>
    /// https://en.m.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom
    /// https://en.wikipedia.org/wiki/List_of_dialling_codes_in_the_United_Kingdom
    /// </remarks>
    internal sealed class UkPhoneNumberParser : PhoneNumberParser
    {
        private static readonly List<string> s_crownDependencyAreas = new List<string>
        {
            // Guernsey Mobile
            "7781",
            "7839",
            "7911",
            // Jersey Mobile
            "7509",
            "7797",
            "7937",
            "7700",
            "7829",
            // Isle of Man Mobile
            "7524",
            "7624",
            "7924",
        };

        // The geographic areas which can be identified by an area code alone.
        private static readonly IReadOnlyDictionary<string, string> s_geographicAreas = new Dictionary<string, string>
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

        // For when the first digit of the local number is required in addition to the area code to identify the geographic area.
        private static readonly IReadOnlyDictionary<KeyValuePair<string, char>, string> s_geographicAreas2 = new Dictionary<KeyValuePair<string, char>, string>
        {
            [new KeyValuePair<string, char>("23", '8')] = "Southampton",
            [new KeyValuePair<string, char>("23", '9')] = "Portsmouth",
        };

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, the value will start with the TrunkPrefix and contain digits only.</remarks>
        protected override PhoneNumber ParsePhoneNumber(string value, CountryInfo countryInfo)
        {
            // UK NSN lengths are 7,9 & 10

            switch (value[1])
            {
                case '1':
                case '2':
                    return ParseGeographicPhoneNumber(value, countryInfo);

                case '7':
                    return ParseMobilePhoneNumber(value, countryInfo);

                default:
                    throw new NotSupportedException(value);
            }
        }

        private static string LookupGeographicArea(string areaCode, string localNumber)
        {
            if (s_geographicAreas.TryGetValue(areaCode, out string? geographicArea))
            {
                return geographicArea;
            }

            if (s_geographicAreas2.TryGetValue(new KeyValuePair<string, char>(areaCode, localNumber[0]), out geographicArea))
            {
                return geographicArea;
            }

            throw new NotSupportedException(areaCode);
        }

        private static PhoneNumber ParseGeographicPhoneNumber(string value, CountryInfo countryInfo)
        {
            int areaCodeLength = 0;

            // 11X or 1X1
            if (value[1] == '1' && (value[2] == '1' || value[3] == '1'))
            {
                areaCodeLength = 3;
            }
            else if (value[1] == '2') // 2X
            {
                areaCodeLength = 2;
            }

            string areaCode = value.Substring(countryInfo.TrunkPrefix.Length, areaCodeLength);
            string localNumber = value.Substring(countryInfo.TrunkPrefix.Length + areaCodeLength);

            if (areaCode.Length == 2 && localNumber.Length != 8
                || areaCode.Length == 3 && localNumber.Length != 7)
            {
                throw new NotSupportedException(localNumber);
            }

            string geographicArea = LookupGeographicArea(areaCode, localNumber);

            return new GeographicPhoneNumber(countryInfo, areaCode, localNumber, geographicArea);
        }

        private static PhoneNumber ParseMobilePhoneNumber(string value, CountryInfo countryInfo)
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

            string areaCode = value.Substring(1, 4);
            string localNumber = value.Substring(5);

            if (s_crownDependencyAreas.Contains(areaCode) &&
                !(areaCode == "7911" && (localNumber[0] == '2' || localNumber[0] == '8')))
            {
                throw new NotSupportedException($"{value} is not a GB mobile");
            }

            // UK Wifi (data only plans) start 7911 2xx or 8xx
            bool isDataOnly = areaCode == "7911" && (localNumber[0] == '2' || localNumber[0] == '8');

            // UK pagers start 76 except 7624 which is in use for the Isle of Man
            bool isPager = areaCode[1] == '6' && areaCode != "7624";

            // UK virtual (personal numbers) start 70
            bool isVirtual = areaCode[1] == '0';

            return new MobilePhoneNumber(countryInfo, areaCode, localNumber, isDataOnly, isPager, isVirtual);
        }
    }
}
