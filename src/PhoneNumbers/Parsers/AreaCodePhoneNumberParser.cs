using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// A <see cref="PhoneNumberParser"/> for phone numbers of countries with area codes.
    /// </summary>
    /// <remarks>
    /// Depending on the complexity of the country phone numbering, this can be a base class where
    /// ParseAreaAndNumber is overriden or used on its own.
    /// </remarks>
    internal class AreaCodePhoneNumberParser : PhoneNumberParser
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="LocalOnlyPhoneNumberParser"/> class.
        /// </summary>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal AreaCodePhoneNumberParser(CountryInfo countryInfo, IReadOnlyList<AreaCodeInfo> areaCodeInfos)
            : base(countryInfo)
            => AreaCodeInfos = areaCodeInfos ?? throw new ArgumentNullException(nameof(areaCodeInfos));

        protected IReadOnlyList<AreaCodeInfo> AreaCodeInfos { get; }

        /// <summary>
        /// Creates an instance of the <see cref="AreaCodePhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        internal static PhoneNumberParser Create(CountryInfo countryInfo)
        {
            var areaCodeInfos = ResourceUtility
                .ReadAreaCodes($"{countryInfo.Iso3116Code}_area_codes.txt")
                .ToList()
                .AsReadOnly();

            return new AreaCodePhoneNumberParser(countryInfo, areaCodeInfos);
        }

        /// <summary>
        /// Parses the area code, local number and respective <see cref="AreaCodeInfo"/>.
        /// </summary>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected virtual (string? AreaCode, string? LocalNumber, AreaCodeInfo? AreaCodeInfo) ParseAreaAndNumber(string nsnValue)
        {
            string? areaCode = null;
            string? localNumber = null;
            AreaCodeInfo? areaCodeInfo = null;

            foreach (var len in Country.AreaCodeLengths)
            {
                areaCode = nsnValue.Substring(0, len);
                localNumber = nsnValue.Substring(areaCode.Length);

                areaCodeInfo = AreaCodeInfos
                    .SingleOrDefault(x =>
                        x.AreaCodeRanges.Any(x => x.Contains(areaCode)) &&
                        x.LocalNumberRanges.Any(x => x.Contains(localNumber)));

                if (areaCodeInfo != null)
                {
                    return (areaCode, localNumber, areaCodeInfo);
                }
            }

            return (null, null, null);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNationalSignificantNumber(string nsnValue)
        {
            (string? AreaCode, string? LocalNumber, AreaCodeInfo? AreaCodeInfo) x = ParseAreaAndNumber(nsnValue);

            if (x.AreaCodeInfo != null)
            {
                switch (x.AreaCodeInfo.Kind)
                {
                    case PhoneNumberKind.GeographicPhoneNumber:
                        return ParseResult.Success(
                            new GeographicPhoneNumber(Country, x.AreaCode!, x.LocalNumber!, x.AreaCodeInfo.GeographicArea!));

                    case PhoneNumberKind.MobilePhoneNumber:
                        var isDataOnly = x.AreaCodeInfo.Hint == Hint.Data;
                        var isPager = x.AreaCodeInfo.Hint == Hint.Pager;
                        var isVirtual = x.AreaCodeInfo.Hint == Hint.Virtual;

                        return ParseResult.Success(
                            new MobilePhoneNumber(Country, x.AreaCode, x.LocalNumber!, isDataOnly, isPager, isVirtual));

                    case PhoneNumberKind.NonGeographicPhoneNumber:
                        var isFreephone = x.AreaCodeInfo.Hint == Hint.Freephone;

                        return ParseResult.Success(
                            new NonGeographicPhoneNumber(Country, x.AreaCode, x.LocalNumber!, isFreephone));
                }
            }

            return base.ParseNationalSignificantNumber(nsnValue);
        }
    }
}
