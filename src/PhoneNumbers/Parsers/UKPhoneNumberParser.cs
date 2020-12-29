using System;
using System.Collections.Generic;
using System.Globalization;
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
    public sealed class UKPhoneNumberParser : PhoneNumberParser
    {
        private readonly IReadOnlyDictionary<string, AreaCodeInfo> _areaCodes;

        private readonly string[] _areaCodesWith5Digits;

        private UKPhoneNumberParser(IReadOnlyDictionary<string, AreaCodeInfo> areaCodes)
            : base(CountryInfo.UK)
        {
            _areaCodes = areaCodes;
            _areaCodesWith5Digits = areaCodes.Keys.Where(x => x.Length == 5).ToArray();
        }

        /// <summary>
        /// Creates an instance of the <see cref="UKPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="UKPhoneNumberParser"/>.</returns>
        public static PhoneNumberParser Create()
        {
            // There are very few local number lengths so cache and re-use them to avoid loads of identical int arrays.
            var localNumberLengthsCache = new Dictionary<string, int[]>();

            // each line in uk_area_codes.txt is pipe separated and contains the following values in the specified order:
            // AREA_CODE is a mandatory string
            // GEOGRAPHIC_AREA is optional string which will be represented as an empty string (we switch that to null)
            // LOCAL_NUMBER_LENGTHS is a mandatory comma separated list of integers
            var areaCodes = ResourceUtility.ReadLines("uk_area_codes.txt")
                .Select(x => x.Split('|'))
                .Select(x =>
                {
                    if (!localNumberLengthsCache.TryGetValue(x[2], out var localNumberLengths))
                    {
                        localNumberLengths = x[2].Split(',').Select(x => int.Parse(x, CultureInfo.InvariantCulture)).ToArray();
                        localNumberLengthsCache.Add(x[2], localNumberLengths);
                    }

                    return new AreaCodeInfo(x[0], x[1].Length > 0 ? x[1] : null, localNumberLengths);
                })
                .ToDictionary(x => x.AreaCode, x => x);

            return new UKPhoneNumberParser(areaCodes);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNationalSignificantNumber(string nsnValue)
        {
            switch (nsnValue[0])
            {
                case '1':
                case '2':
                    return ParseGeographicPhoneNumber(nsnValue);

                case '3':
                case '8':
                    return ParseNonGeographicPhoneNumber(nsnValue);

                case '7':
                    return ParseMobilePhoneNumber(nsnValue);

                default:
                    return ParseResult.Failure($"A GB phone number cannot have a national significant number starting {nsnValue[0]}.");
            }
        }

        private ParseResult ParseGeographicPhoneNumber(string nsnValue)
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
                for (var i = 0; i < _areaCodesWith5Digits.Length; i++)
                {
                    if (nsnValue.StartsWith(_areaCodesWith5Digits[i], StringComparison.Ordinal))
                    {
                        areaCodeLength = 5;
                        break;
                    }
                }
            }

            var areaCode = nsnValue.Substring(0, areaCodeLength);

            if (!_areaCodes.TryGetValue(areaCode, out var areaCodeInfo))
            {
                return ParseResult.Failure($"The area code {areaCode} is invalid.");
            }

            var localNumber = nsnValue.Substring(areaCode.Length);

            if (!areaCodeInfo.LocalNumberLengths.Contains(localNumber.Length))
            {
                return ParseResult.Failure(
                    $"The for the area code {areaCodeInfo.AreaCode}, the local number must be {string.Join(" or ", areaCodeInfo.LocalNumberLengths)} digits in length.");
            }

            return ParseResult.Success(
                new GeographicPhoneNumber(Country, areaCode, localNumber, areaCodeInfo.GeographicArea!));
        }

        private ParseResult ParseMobilePhoneNumber(string nsnValue)
        {
            var areaCode = nsnValue.Substring(0, 4);

            if (!_areaCodes.TryGetValue(areaCode, out var areaCodeInfo))
            {
                // 70XX are personal numbers but aren't be in the phone area codes list at the moment so fake one.
                if (areaCode[1] == '0')
                {
                    areaCodeInfo = new AreaCodeInfo(areaCode, null, new[] { 6 });
                }
                else
                {
                    return ParseResult.Failure($"The area code {areaCode} is invalid.");
                }
            }

            var localNumber = nsnValue.Substring(areaCode.Length);

            if (!areaCodeInfo.LocalNumberLengths.Contains(localNumber.Length))
            {
                return ParseResult.Failure(
                    $"The for the area code {areaCodeInfo.AreaCode}, the local number must be {string.Join(" or ", areaCodeInfo.LocalNumberLengths)} digits in length.");
            }

            // UK Wifi (data only plans) start 7911 2xx or 8xx
            var isDataOnly = areaCode == "7911" && (localNumber[0] == '2' || localNumber[0] == '8');

            // UK pagers start 76 (except 7624 which is used by mobile phones in Isle of Man)
            var isPager = areaCode[1] == '6' && areaCode != "7624";

            // UK virtual (personal numbers) start 70
            var isVirtual = areaCode[1] == '0';

            return ParseResult.Success(
                new MobilePhoneNumber(Country, areaCode, localNumber, isDataOnly, isPager, isVirtual));
        }

        private ParseResult ParseNonGeographicPhoneNumber(string nsnValue)
        {
            // All Non geographic phone numbers have a 3 digit area code (3XX or 8XX).
            var areaCode = nsnValue.Substring(0, 3);

            if (!_areaCodes.TryGetValue(areaCode, out var areaCodeInfo))
            {
                return ParseResult.Failure($"The area code {areaCode} is invalid.");
            }

            var localNumber = nsnValue.Substring(areaCode.Length);

            if (!areaCodeInfo.LocalNumberLengths.Contains(localNumber.Length))
            {
                return ParseResult.Failure(
                    $"The for the area code {areaCodeInfo.AreaCode}, the local number must be {string.Join(" or ", areaCodeInfo.LocalNumberLengths)} digits in length.");
            }

            return ParseResult.Success(
                new NonGeographicPhoneNumber(Country, areaCode, localNumber));
        }
    }
}
