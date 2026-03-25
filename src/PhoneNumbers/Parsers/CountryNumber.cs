namespace PhoneNumbers.Parsers;

/// <summary>
/// A class representing a line in a country data file.
/// </summary>
internal sealed record CountryNumber(
    string? GeographicArea,
    PhoneNumberHint Hint,
    PhoneNumberKind Kind,
    IReadOnlyList<NumberRange>? NationalDestinationCodeRanges,
    IReadOnlyList<NumberRange> SubscriberNumberRanges
);
