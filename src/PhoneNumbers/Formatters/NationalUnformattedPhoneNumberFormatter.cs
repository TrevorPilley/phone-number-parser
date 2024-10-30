namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the phone number in national notation without any formatting.
/// </summary>
internal sealed class NationalUnformattedPhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="NationalUnformattedPhoneNumberFormatter"/> class.
    /// </summary>
    private NationalUnformattedPhoneNumberFormatter()
        : base("U")
    {
    }

    /// <summary>
    /// Gets the <see cref="NationalUnformattedPhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new NationalUnformattedPhoneNumberFormatter();

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber) =>
        phoneNumber.Country.HasTrunkPrefix
        ? $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalSignificantNumber}"
        : phoneNumber.NationalSignificantNumber;
}
