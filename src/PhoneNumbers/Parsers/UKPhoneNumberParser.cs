using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// A <see cref="PhoneNumberParser"/> for UK phone numbers.
    /// </summary>
    /// <remarks>
    /// https://en.m.wikipedia.org/wiki/Telephone_numbers_in_the_United_Kingdom
    /// https://en.wikipedia.org/wiki/List_of_dialling_codes_in_the_United_Kingdom
    /// https://www.area-codes.org.uk/full-uk-area-code-list.php
    /// </remarks>
    internal sealed class UKPhoneNumberParser : PhoneNumberParser
    {
        private static readonly string[] s_5DigitAreaCodes =
            ResourceUtility.ReadLines("uk_area_codes.txt").Select(x => x.Split('|')).Where(x => x[0].Length == 5).Select(x => x[0]).ToArray();

        private static readonly IReadOnlyDictionary<string, AreaCodeInfo> s_areaCodes =
            ResourceUtility.ReadLines("uk_area_codes.txt").Select(x => x.Split('|')).ToDictionary(x => x[0], x => new AreaCodeInfo(x[0], x[1]));

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override PhoneNumber ParseNationalSignificantNumber(string nsnValue, CountryInfo countryInfo)
        {
            switch (nsnValue[0])
            {
                case '1':
                case '2':
                    return ParseGeographicPhoneNumber(nsnValue, countryInfo);

                case '3':
                case '8':
                    return ParseNonGeographicPhoneNumber(nsnValue, countryInfo);

                case '7':
                    return ParseMobilePhoneNumber(nsnValue, countryInfo);

                default:
                    throw new NotSupportedException(nsnValue);
            }
        }

        private static PhoneNumber ParseGeographicPhoneNumber(string nsnValue, CountryInfo countryInfo)
        {
            // Most UK area codes are 4 digits.
            var areaCodeLength = 4;

            // 11X or 1X1 area codes are 3 digits.
            if (nsnValue[0] == '1' && (nsnValue[1] == '1' || nsnValue[2] == '1'))
            {
                areaCodeLength = 3;
            }
            else if (nsnValue[0] == '2') // 2X
            {
                areaCodeLength = 2;
            }
            else
            {
                for (var i = 0; i < s_5DigitAreaCodes.Length; i++)
                {
                    if (nsnValue.StartsWith(s_5DigitAreaCodes[i], StringComparison.Ordinal))
                    {
                        areaCodeLength = 5;
                        break;
                    }
                }
            }

            var areaCode = nsnValue.Substring(0, areaCodeLength);

            if (!s_areaCodes.TryGetValue(areaCode, out var areaCodeInfo))
            {
                throw new ArgumentException($"The area code {areaCode} is invalid.");
            }

            var localNumber = nsnValue.Substring(areaCode.Length);

            if (areaCode.Length == 2 && localNumber.Length != 8
                || areaCode.Length == 3 && localNumber.Length != 7
                || areaCode.Length == 4 && localNumber.Length != 6
                || areaCode.Length == 5 && localNumber.Length != 5)
            {
                throw new ArgumentException($"The for the area code {areaCode}, the local number must be {10 - areaCode.Length} digits.");
            }

            return new GeographicPhoneNumber(countryInfo, areaCode, localNumber, areaCodeInfo.GeographicArea!);
        }

        private static PhoneNumber ParseMobilePhoneNumber(string nsnValue, CountryInfo countryInfo)
        {
            // All UK mobile numbers have a 10 digit NSN.
            if (nsnValue.Length != 10)
            {
                throw new ArgumentException("For a UK mobile phone, the national significant number of the phone number must be 10 digits.");
            }

            var areaCode = nsnValue.Substring(0, 4);
            var localNumber = nsnValue.Substring(areaCode.Length);

            // 70XX are personal numbers but won't be in the phone area codes list.
            if (!s_areaCodes.ContainsKey(areaCode) && areaCode[1] != '0')
            {
                throw new ArgumentException($"The area code {areaCode} is invalid.");
            }

            // UK Wifi (data only plans) start 7911 2xx or 8xx
            var isDataOnly = areaCode == "7911" && (localNumber[0] == '2' || localNumber[0] == '8');

            // UK pagers start 76 (except 7624 which is used by mobile phones in Isle of Man)
            var isPager = areaCode[1] == '6' && areaCode != "7624";

            // UK virtual (personal numbers) start 70
            var isVirtual = areaCode[1] == '0';

            return new MobilePhoneNumber(countryInfo, areaCode, localNumber, isDataOnly, isPager, isVirtual);
        }

        private static PhoneNumber ParseNonGeographicPhoneNumber(string nsnValue, CountryInfo countryInfo)
        {
            // All UK non geographic numbers have a 10 digit NSN.
            if (nsnValue.Length != 10)
            {
                throw new ArgumentException("For a UK non-geographic number, the national significant number of the phone number must be 10 digits.");
            }

            // All Non geographic phone numbers have a 3 digit area code (3XX or 8XX).
            var areaCode = nsnValue.Substring(0, 3);

            if (!s_areaCodes.ContainsKey(areaCode))
            {
                throw new ArgumentException($"The area code {areaCode} is invalid.");
            }

            var localNumber = nsnValue.Substring(areaCode.Length);

            return new NonGeographicPhoneNumber(countryInfo, areaCode, localNumber);
        }
    }
}
