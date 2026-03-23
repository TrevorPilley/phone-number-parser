namespace PhoneNumbers.Parsers;

/// <summary>
/// A class representing a line in a country data file.
/// </summary>
internal sealed record CountryNumber(
    string? GeographicArea,
    PhoneNumberHint Hint,
    PhoneNumberKind Kind,
    List<NumberRange>? NationalDestinationCodeRanges,
    List<NumberRange> SubscriberNumberRanges
);
