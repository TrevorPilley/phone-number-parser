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
    private readonly List<CountryNumber> _fiveDigitGeoNdcs;

    private GBPhoneNumberParser(List<CountryNumber> countryNumbers)
        : base(CountryInfo.UnitedKingdom, countryNumbers) =>
        _fiveDigitGeoNdcs = [.. countryNumbers.Where(x => x.GeographicArea is not null && x.NationalDestinationCodeRanges![0].From.Length == 5)];

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
            case Chars.One:
                phoneNumberKind = PhoneNumberKind.GeographicPhoneNumber;

                if (nsnValue[1] == Chars.One || nsnValue[2] == Chars.One)
                {
                    ndcLength = 3;
                }
                else if (_fiveDigitGeoNdcs.Exists(x => nsnValue.StartsWith(x.NationalDestinationCodeRanges![0].From, StringComparison.Ordinal)))
                {
                    ndcLength = 5;
                }
                else
                {
                    ndcLength = 4;
                }
                break;
            case Chars.Two:
                phoneNumberKind = PhoneNumberKind.GeographicPhoneNumber;
                ndcLength = 2;
                break;
            case Chars.Three:
            case Chars.Eight:
            case Chars.Nine:
                phoneNumberKind = PhoneNumberKind.NonGeographicPhoneNumber;
                ndcLength = 3;
                break;
            case Chars.Seven:
                phoneNumberKind = PhoneNumberKind.MobilePhoneNumber;
                ndcLength = 4;
                break;
        }

        var ndc = nsnValue[0..ndcLength];
        var sn = nsnValue[ndcLength..];

        var countryNumber = CountryNumbers
            .Find(x => x.Kind == phoneNumberKind &&
                x.NationalDestinationCodeRanges!.Any(x => x.Contains(ndc)) &&
                x.SubscriberNumberRanges.Any(x => x.Contains(sn)));

        return (ndc, sn, countryNumber);
    }
}
