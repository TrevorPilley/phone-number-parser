using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// A <see cref="PhoneNumberParser"/> for phone numbers of countries without area codes.
    /// </summary>
    internal sealed class LocalOnlyPhoneNumberParser : PhoneNumberParser
    {
        private readonly IReadOnlyList<LocalNumberInfo> _localNumberInfos;

        /// <summary>
        /// Initialises a new instance of the <see cref="LocalOnlyPhoneNumberParser"/> class.
        /// </summary>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal LocalOnlyPhoneNumberParser(CountryInfo countryInfo, IReadOnlyList<LocalNumberInfo> localNumberInfos)
            : base(countryInfo) =>
            _localNumberInfos = localNumberInfos ?? throw new ArgumentNullException(nameof(localNumberInfos));

        /// <summary>
        /// Creates an instance of the <see cref="LocalOnlyPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        internal static PhoneNumberParser Create(CountryInfo countryInfo)
        {
            var localNumberInfos = ResourceUtility
                .ReadLocalNumbers($"{countryInfo.Iso3116Code}_number_ranges.txt")
                .ToList()
                .AsReadOnly();

            return new LocalOnlyPhoneNumberParser(countryInfo, localNumberInfos);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNationalSignificantNumber(string nsnValue)
        {
            var localNumberInfo = _localNumberInfos
                .SingleOrDefault(x => x.LocalNumberRanges.Any(x => x.Contains(nsnValue)));

            if (localNumberInfo == null)
            {
                return ParseResult.Failure($"{nsnValue} is not a valid {Country.Iso3116Code} phone number.");
            }

            switch (localNumberInfo.Kind)
            {
                case PhoneNumberKind.MobilePhoneNumber:
                    var isDataOnly = localNumberInfo.Hint == Hint.Data;
                    var isPager = localNumberInfo.Hint == Hint.Pager;
                    var isVirtual = localNumberInfo.Hint == Hint.Virtual;

                    return ParseResult.Success(
                        new MobilePhoneNumber(Country, null, nsnValue, isDataOnly, isPager, isVirtual));

                case PhoneNumberKind.NonGeographicPhoneNumber:
                    var isFreephone = localNumberInfo.Hint == Hint.Freephone;

                    return ParseResult.Success(new NonGeographicPhoneNumber(Country, null, nsnValue, isFreephone));
            }

            return base.ParseNationalSignificantNumber(nsnValue);
        }
    }
}
