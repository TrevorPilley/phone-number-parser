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
        private readonly IReadOnlyList<AreaCodeInfo> _areaCodeInfos;

        private readonly IList<string> _areaCodesWith5Digits = new[]
        {
            "13397", // Ballater
            "13398", // Aboyne
            "13873", // Langholm
            "15242", // Hornby
            "15394", // Hawkshead
            "15395", // Grange-Over-Sands
            "15396", // Sedbergh
            "16973", // Wigton
            "16974", // Raughton Head
            "16977", // Brampton
            "17683", // Appleby
            "17684", // Pooley Bridge
            "17687", // Keswick
            "19467", // Gosforth
            "19755", // Alford
            "19756", // Strathdon
        };

        private UKPhoneNumberParser(IReadOnlyList<AreaCodeInfo> areaCodeInfos)
            : base(CountryInfo.UK)
        {
            _areaCodeInfos = areaCodeInfos;
        }

        /// <summary>
        /// Creates an instance of the <see cref="UKPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        public static PhoneNumberParser Create()
        {
            var areaCodes = ResourceUtility.ReadAreaCodes("uk_area_codes.txt").ToList();

            return new UKPhoneNumberParser(areaCodes);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNationalSignificantNumber(string nsnValue) =>
            (nsnValue[0]) switch
            {
                '1' or '2' => ParseGeographicPhoneNumber(nsnValue),
                '3' or '8' => ParseNonGeographicPhoneNumber(nsnValue),
                '7' => ParseMobilePhoneNumber(nsnValue),
                _ => base.ParseNationalSignificantNumber(nsnValue),
            };

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
                for (var i = 0; i < _areaCodesWith5Digits.Count; i++)
                {
                    if (nsnValue.StartsWith(_areaCodesWith5Digits[i], StringComparison.Ordinal))
                    {
                        areaCodeLength = 5;
                        break;
                    }
                }
            }

            var areaCode = nsnValue.Substring(0, areaCodeLength);
            var localNumber = nsnValue.Substring(areaCode.Length);

            var areaCodeInfo = _areaCodeInfos
                .SingleOrDefault(x =>
                    x.AreaCodeRanges.Any(x => x.Contains(areaCode)) &&
                    x.LocalNumberRanges.Any(x => x.Contains(localNumber)));

            if (areaCodeInfo == null)
            {
                return ParseResult.Failure($"The area code {areaCode} and local number {localNumber} are not a valid combination.");
            }

            return ParseResult.Success(
                new GeographicPhoneNumber(Country, areaCode, localNumber, areaCodeInfo.GeographicArea!));
        }

        private ParseResult ParseMobilePhoneNumber(string nsnValue)
        {
            var areaCode = nsnValue.Substring(0, 4);
            var localNumber = nsnValue.Substring(areaCode.Length);

            var areaCodeInfo = _areaCodeInfos
                .SingleOrDefault(x =>
                    x.AreaCodeRanges.Any(x => x.Contains(areaCode)) &&
                    x.LocalNumberRanges.Any(x => x.Contains(localNumber)));

            if (areaCodeInfo == null)
            {
                return ParseResult.Failure($"The area code {areaCode} and local number {localNumber} are not a valid combination.");
            }

            var isDataOnly = areaCodeInfo.Hint == Hint.Data;
            var isPager = areaCodeInfo.Hint == Hint.Pager;
            var isVirtual = areaCodeInfo.Hint == Hint.Virtual;

            return ParseResult.Success(
                new MobilePhoneNumber(Country, areaCode, localNumber, isDataOnly, isPager, isVirtual));
        }

        private ParseResult ParseNonGeographicPhoneNumber(string nsnValue)
        {
            // All Non geographic phone numbers have a 3 digit area code (3XX or 8XX).
            var areaCode = nsnValue.Substring(0, 3);
            var localNumber = nsnValue.Substring(areaCode.Length);

            var areaCodeInfo = _areaCodeInfos
                .SingleOrDefault(x =>
                    x.AreaCodeRanges.Any(x => x.Contains(areaCode)) &&
                    x.LocalNumberRanges.Any(x => x.Contains(localNumber)));

            if (areaCodeInfo == null)
            {
                return ParseResult.Failure($"The area code {areaCode} and local number {localNumber} are not a valid combination.");
            }

            var isFreephone = areaCodeInfo.Hint == Hint.Freephone;

            return ParseResult.Success(
                new NonGeographicPhoneNumber(Country, areaCode, localNumber, isFreephone));
        }
    }
}
