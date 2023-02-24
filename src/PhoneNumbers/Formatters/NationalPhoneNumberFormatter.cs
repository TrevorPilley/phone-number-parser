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
    public override bool CanFormat(string format) =>
        format?.Equals("N", StringComparison.Ordinal) == true;

    /// <inheritdoc/>
    public override string Format(PhoneNumber phoneNumber)
    {
        if (phoneNumber is null)
        {
            throw new ArgumentNullException(nameof(phoneNumber));
        }

        if (phoneNumber.NationalDestinationCode is null)
        {
            return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.SubscriberNumber}";
        }

        if (phoneNumber.PhoneNumberKind == PhoneNumberKind.GeographicPhoneNumber && !phoneNumber.Country.RequireNdcForLocalGeographicDialling)
        {
            return $"({phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode}) {phoneNumber.SubscriberNumber}";
        }

        return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}".Trim();
    }
}
