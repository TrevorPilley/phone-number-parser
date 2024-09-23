namespace PhoneNumbers.Parsers;

/// <summary>
/// The default <see cref="PhoneNumberParser"/>.
/// </summary>
/// <remarks>
/// Depending on the complexity of the country phone numbering, this can be a base class where
/// ParseAreaAndNumber is overridden or used on its own.
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
    internal static PhoneNumberParser Create(CountryInfo countryInfo) =>
        new DefaultPhoneNumberParser(countryInfo, ResourceUtility.ReadCountryNumbers($"{countryInfo.Iso3166Code}.txt"));

    /// <summary>
    /// Parses the national destination code, subscriber number and respective <see cref="CountryNumber"/>.
    /// </summary>
    /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
    protected virtual (string? NationalDestinationCode, string? SubscriberNumber, CountryNumber? CountryNumber) ParseNdcAndSn(string nsnValue)
    {
        string? ndc = null;
        string? sn = null;
        CountryNumber? countryNumber = null;

        if (Country.HasNationalDestinationCodes)
        {
            foreach (var len in Country.NdcLengths)
            {
                if (len > nsnValue.Length)
                {
                    continue;
                }

                ndc = len > 0 ? nsnValue.Substring(0, len) : null;
                sn = ndc is not null ? nsnValue.Substring(ndc.Length) : nsnValue;

                countryNumber = CountryNumbers
                    .FirstOrDefault(x =>
                        (ndc is null || x.NationalDestinationCodeRanges?.Any(x => x.Contains(ndc)) == true) &&
                        x.SubscriberNumberRanges.Any(x => x.Contains(sn)));

                if (countryNumber is not null)
                {
                    break;
                }
            }
        }
        else
        {
            sn = nsnValue;

            countryNumber = CountryNumbers
                .FirstOrDefault(x => x.SubscriberNumberRanges.Any(x => x.Contains(nsnValue)));
        }

        if (countryNumber is not null)
        {
            return (ndc, sn, countryNumber);
        }

        return (null, null, null);
    }

    /// <inheritdoc/>
    /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
    protected override ParseResult ParseNsn(string nsnValue)
    {
        var ndcAndSn = ParseNdcAndSn(nsnValue);

        return (ndcAndSn.CountryNumber?.Kind) switch
        {
            PhoneNumberKind.GeographicPhoneNumber =>
                ParseResult.Success(
                    new GeographicPhoneNumber(ndcAndSn.CountryNumber.Hint)
                    {
                        Country = Country,
                        GeographicArea = ndcAndSn.CountryNumber.GeographicArea!,
                        NationalDestinationCode = ndcAndSn.NationalDestinationCode!,
                        NationalSignificantNumber = nsnValue,
                        SubscriberNumber = ndcAndSn.SubscriberNumber!,
                    }),

            PhoneNumberKind.MobilePhoneNumber =>
                ParseResult.Success(
                    new MobilePhoneNumber(ndcAndSn.CountryNumber.Hint)
                    {
                        Country = Country,
                        NationalDestinationCode = ndcAndSn.NationalDestinationCode!,
                        NationalSignificantNumber = nsnValue,
                        SubscriberNumber = ndcAndSn.SubscriberNumber!,
                    }),

            PhoneNumberKind.NonGeographicPhoneNumber =>
                ParseResult.Success(
                    new NonGeographicPhoneNumber(ndcAndSn.CountryNumber.Hint)
                    {
                        Country = Country,
                        NationalDestinationCode = ndcAndSn.NationalDestinationCode!,
                        NationalSignificantNumber = nsnValue,
                        SubscriberNumber = ndcAndSn.SubscriberNumber!,
                    }),

            _ => base.ParseNsn(nsnValue),
        };
    }
}
