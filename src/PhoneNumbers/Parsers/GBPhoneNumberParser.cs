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
    internal sealed class GBPhoneNumberParser : PhoneNumberParser
    {
        private readonly IReadOnlyList<AreaCodeInfo> _areaCodeInfos;
        private readonly IReadOnlyList<AreaCodeInfo> _areaCodesWith5Digits;

        private GBPhoneNumberParser(IReadOnlyList<AreaCodeInfo> areaCodeInfos)
            : base(CountryInfo.UK)
        {
            _areaCodeInfos = areaCodeInfos;
            _areaCodesWith5Digits = _areaCodeInfos.Where(x => x.AreaCodeRanges.Any(x => x.From.Length == 5)).ToList();
        }

        /// <summary>
        /// Creates an instance of the <see cref="GBPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        internal static PhoneNumberParser Create()
        {
            var areaCodeInfos = ResourceUtility
                .ReadAreaCodes("GB_area_codes.txt")
                .ToList()
                .AsReadOnly();

            return new GBPhoneNumberParser(areaCodeInfos);
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
                // There are some 5 digit area codes which use a subset of numbers from the "parent" 4 digit area code:
                // e.g. 1339 (Aboyne / Ballater) has 200000-719999 and 13397 (Ballater) has 20000-99899
                // Since geographic area codes are for a single value only, so we can just check against From.
                if (_areaCodesWith5Digits
                    .Where(x => x.AreaCodeRanges.Any(x => nsnValue.StartsWith(x.From, StringComparison.Ordinal)))
                    .Any(x => x.LocalNumberRanges.Any(x => x.Contains(nsnValue.Substring(5)))))
                {
                    areaCodeLength = 5;
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
            // All mobile phone numbers have a 4 digit area code (7XXX).
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
