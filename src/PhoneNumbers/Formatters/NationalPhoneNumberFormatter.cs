namespace PhoneNumbers.Formatters;

/// <summary>
/// A <see cref="PhoneNumberFormatter"/> which returns the national dialling format.
/// </summary>
internal sealed class NationalPhoneNumberFormatter : PhoneNumberFormatter
{
    /// <summary>
    /// Initialises a new instance of the <see cref="NationalPhoneNumberFormatter"/> class.
    /// </summary>
    private NationalPhoneNumberFormatter()
    {
    }

    /// <summary>
    /// Gets the <see cref="NationalPhoneNumberFormatter"/> instance.
    /// </summary>
    internal static PhoneNumberFormatter Instance { get; } = new NationalPhoneNumberFormatter();

    /// <inheritdoc/>
    internal override bool CanFormat(string format) =>
        format?.Equals("N", StringComparison.Ordinal) == true;

    /// <inheritdoc/>
    internal override string Format(PhoneNumber phoneNumber)
    {
        if (phoneNumber.NationalDestinationCode is null)
        {
            return phoneNumber.Country.HasTrunkPrefix
                ? $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.SubscriberNumber}"
                : phoneNumber.SubscriberNumber;
        }

        if (phoneNumber.Kind == PhoneNumberKind.GeographicPhoneNumber &&
            phoneNumber.Country.NumberingPlanType == NumberingPlanType.Open &&
            !((GeographicPhoneNumber)phoneNumber).ClosedDiallingInOpenPlan)
        {
            return $"({phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode}) {phoneNumber.SubscriberNumber}";
        }

        return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}";
    }
}
