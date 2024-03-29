namespace PhoneNumbers.Parsers;

/// <summary>
/// A class representing a line in a country data file.
/// </summary>
internal sealed class CountryNumber
{
    /// <summary>
    /// Gets the name of the geographic area.
    /// </summary>
    internal string? GeographicArea { get; init; }

    /// <summary>
    /// Gets the <see cref="PhoneNumberHint"/>.
    /// </summary>
    internal required PhoneNumberHint Hint { get; init; }

    /// <summary>
    /// Gets the <see cref="PhoneNumberParser"/>.
    /// </summary>
    internal required PhoneNumberKind Kind { get; init; }

    /// <summary>
    /// Gets the <see cref="NumberRange"/>s of the national destination codes.
    /// </summary>
    internal IReadOnlyList<NumberRange>? NationalDestinationCodeRanges { get; init; }

    /// <summary>
    /// Gets the <see cref="NumberRange"/>s of the subscriber numbers.
    /// </summary>
    internal required IReadOnlyList<NumberRange> SubscriberNumberRanges { get; init; } = null!;
}
