namespace PhoneNumbers.Parsers;

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
        _areaCodesWith5Digits = countryNumbers
            .Where(x => x.NationalDestinationCodeRanges!.Any(x => x.From.Length == 5))
            .ToList();

    /// <summary>
    /// Creates an instance of the <see cref="GBPhoneNumberParser"/> class.
    /// </summary>
    /// <returns>The created <see cref="PhoneNumberParser"/>.</returns>
    public static PhoneNumberParser Create() =>
        new GBPhoneNumberParser(ResourceUtility.ReadCountryNumbers("GB.txt"));

    /// <inheritdoc/>
    /// <remarks>By the time this method is called, nsnValue will have been validated against the <see cref="CountryInfo"/>.NsnLengths and contain digits only.</remarks>
    protected override (string? NationalDestinationCode, string? SubscriberNumber, CountryNumber? CountryNumber) ParseNdcAndSn(string nsnValue)
    {
        var ndcLength = 0;
        PhoneNumberKind phoneNumberKind = default;

        switch (nsnValue[0])
        {
            case '1':
                phoneNumberKind = PhoneNumberKind.GeographicPhoneNumber;

                if (nsnValue[1] == '1' || nsnValue[2] == '1')
                {
                    ndcLength = 3;
                }
                else if (_areaCodesWith5Digits.Any(x => x.NationalDestinationCodeRanges!.Any(x => nsnValue.StartsWith(x.From, StringComparison.Ordinal))))
                {
                    ndcLength = 5;
                }
                else
                {
                    ndcLength = 4;
                }
                break;
            case '2':
                phoneNumberKind = PhoneNumberKind.GeographicPhoneNumber;
                ndcLength = 2;
                break;
            case '3':
            case '8':
            case '9':
                phoneNumberKind = PhoneNumberKind.NonGeographicPhoneNumber;
                ndcLength = 3;
                break;
            case '7':
                phoneNumberKind = PhoneNumberKind.MobilePhoneNumber;
                ndcLength = 4;
                break;
        }

        var ndc = nsnValue.Substring(0, ndcLength);
        var sn = nsnValue.Substring(ndc.Length);

        var countryNumber = CountryNumbers
            .FirstOrDefault(x => x.Kind == phoneNumberKind &&
                x.NationalDestinationCodeRanges!.Any(x => x.Contains(ndc)) &&
                x.SubscriberNumberRanges.Any(x => x.Contains(sn)));

        return (ndc, sn, countryNumber);
    }
}
