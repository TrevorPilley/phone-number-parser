using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// The default <see cref="PhoneNumberParser"/>.
    /// </summary>
    /// <remarks>
    /// Depending on the complexity of the country phone numbering, this can be a base class where
    /// ParseAreaAndNumber is overriden or used on its own.
    /// </remarks>
    internal class DefaultPhoneNumberParser : PhoneNumberParser
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DefaultPhoneNumberParser"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> of the country for the parser.</param>
        /// <param name="countryNumbers">The <see cref="CountryNumber"/>s for the country.</param>
        /// <remarks>The constructor is internal for unit tests only.</remarks>
        internal DefaultPhoneNumberParser(CountryInfo countryInfo, IReadOnlyList<CountryNumber> countryNumbers)
            : base(countryInfo)
            => CountryNumbers = countryNumbers ?? throw new ArgumentNullException(nameof(countryNumbers));

        /// <summary>
        /// Gets the <see cref="CountryNumber"/>s for the country.
        /// </summary>
        protected IReadOnlyList<CountryNumber> CountryNumbers { get; }

        /// <summary>
        /// Creates an instance of the <see cref="DefaultPhoneNumberParser"/> class.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
        internal static PhoneNumberParser Create(CountryInfo countryInfo)
        {
            var countryNumbers = ResourceUtility
                .ReadCountryNumbers($"{countryInfo.Iso3166Code}.txt")
                .ToList()
                .AsReadOnly();

            return new DefaultPhoneNumberParser(countryInfo, countryNumbers);
        }

        /// <summary>
        /// Parses the area code, local number and respective <see cref="CountryNumber"/>.
        /// </summary>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected virtual (string? AreaCode, string? LocalNumber, CountryNumber? CountryNumber) ParseAreaAndNumber(string nsnValue)
        {
            string? areaCode = null;
            string? localNumber = null;
            CountryNumber? countryNumber = null;

            if (Country.HasAreaCodes)
            {
                foreach (var len in Country.AreaCodeLengths)
                {
                    areaCode = nsnValue.Substring(0, len);
                    localNumber = nsnValue.Substring(areaCode.Length);

                    countryNumber = CountryNumbers
                        .FirstOrDefault(x =>
                            x.AreaCodeRanges!.Any(x => x.Contains(areaCode)) &&
                            x.LocalNumberRanges.Any(x => x.Contains(localNumber)));

                    if (countryNumber != null)
                    {
                        break;
                    }
                }
            }
            else
            {
                localNumber = nsnValue;

                countryNumber = CountryNumbers
                    .FirstOrDefault(x => x.LocalNumberRanges.Any(x => x.Contains(nsnValue)));
            }

            if (countryNumber != null)
            {
                return (areaCode, localNumber, countryNumber);
            }

            return (null, null, null);
        }

        /// <inheritdoc/>
        /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
        protected override ParseResult ParseNationalSignificantNumber(string nsnValue)
        {
            var areaAndNumber = ParseAreaAndNumber(nsnValue);

            return (areaAndNumber.CountryNumber?.Kind) switch
            {
                PhoneNumberKind.GeographicPhoneNumber =>
                    ParseResult.Success(
                        new GeographicPhoneNumber(
                            Country,
                            areaAndNumber.AreaCode!,
                            areaAndNumber.LocalNumber!,
                            areaAndNumber.CountryNumber.GeographicArea!)),

                PhoneNumberKind.MobilePhoneNumber =>
                    ParseResult.Success(
                        new MobilePhoneNumber(
                            Country,
                            areaAndNumber.AreaCode,
                            areaAndNumber.LocalNumber!,
                            isDataOnly: areaAndNumber.CountryNumber.Hint == Hint.Data,
                            isPager: areaAndNumber.CountryNumber.Hint == Hint.Pager,
                            isVirtual: areaAndNumber.CountryNumber.Hint == Hint.Virtual)),

                PhoneNumberKind.NonGeographicPhoneNumber =>
                    ParseResult.Success(
                        new NonGeographicPhoneNumber(
                            Country,
                            areaAndNumber.AreaCode,
                            areaAndNumber.LocalNumber!,
                            isFreephone: areaAndNumber.CountryNumber.Hint == Hint.Freephone)),

                _ => base.ParseNationalSignificantNumber(nsnValue),
            };
        }
    }
}
