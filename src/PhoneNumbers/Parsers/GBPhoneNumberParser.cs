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
    internal sealed class GBPhoneNumberParser : DefaultPhoneNumberParser
    {
        private readonly IReadOnlyList<CountryNumber> _areaCodesWith5Digits;

        private GBPhoneNumberParser(IReadOnlyList<CountryNumber> countryNumbers)
            : base(CountryInfo.UnitedKingdom, countryNumbers) =>
            _areaCodesWith5Digits = countryNumbers.Where(x => x.NationalDiallingCodeRanges!.Any(x => x.From.Length == 5)).ToList();

        /// <summary>
        /// Creates an instance of the <see cref="GBPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        public static PhoneNumberParser Create()
        {
            var countryNumbers = ResourceUtility
                .ReadCountryNumbers("GB.txt")
                .ToList()
                .AsReadOnly();

            return new GBPhoneNumberParser(countryNumbers);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override (string? NationalDiallingCode, string? SubscriberNumber, CountryNumber? CountryNumber) ParseNdcAndSn(string nsnValue)
        {
            var ndcLength = 0;
            PhoneNumberKind phoneNumberKind = default;

            if (nsnValue[0] == '1')
            {
                // Most 1X UK area codes are 4 digits geographically assigned.
                ndcLength = 4;
                phoneNumberKind = PhoneNumberKind.GeographicPhoneNumber;

                if (nsnValue[1] == '1' || nsnValue[2] == '1')
                {
                    // Except 11X and 1X1 area codes, which are are 3 digits.
                    ndcLength = 3;
                }
                else if (_areaCodesWith5Digits
                            .Where(x => x.NationalDiallingCodeRanges!.Any(x => nsnValue.StartsWith(x.From, StringComparison.Ordinal)))
                            .Any(x => x.SubscriberNumberRanges.Any(x => x.Contains(nsnValue.Substring(5)))))
                {
                    // There are some 5 digit area codes which use a subset of numbers from the "parent" 4 digit area code:
                    // e.g. 1339 (Aboyne / Ballater) has 200000-719999 and 13397 (Ballater) has 20000-99899
                    // Since geographic area codes are for a single value only, so we can just check against From.
                    ndcLength = 5;
                }
            }
            else if (nsnValue[0] == '2')
            {
                // 2X area codes, are 2 digits and geographically assigned.
                ndcLength = 2;
                phoneNumberKind = PhoneNumberKind.GeographicPhoneNumber;
            }
            else if (nsnValue[0] == '3' || nsnValue[0] == '8')
            {
                // 3XX and 8XX area codes are 3 digits and non-geographic numbers.
                ndcLength = 3;
                phoneNumberKind = PhoneNumberKind.NonGeographicPhoneNumber;
            }
            else if (nsnValue[0] == '7')
            {
                // All UK mobile area codes are 4 digits.
                ndcLength = 4;
                phoneNumberKind = PhoneNumberKind.MobilePhoneNumber;
            }

            var ndc = nsnValue.Substring(0, ndcLength);
            var sn = nsnValue.Substring(ndc.Length);

            var countryNumber = CountryNumbers
                .FirstOrDefault(x => x.Kind == phoneNumberKind &&
                    x.NationalDiallingCodeRanges!.Any(x => x.Contains(ndc)) &&
                    x.SubscriberNumberRanges.Any(x => x.Contains(sn)));

            return (ndc, sn, countryNumber);
        }
    }
}
