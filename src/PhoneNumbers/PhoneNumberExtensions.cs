namespace PhoneNumbers;

/// <summary>
/// Extensions for <see cref="PhoneNumber"/>.
/// </summary>
public static class PhoneNumberExtensions
{
    /// <summary>
    /// Determines the number needed to dial a <see cref="PhoneNumber"/> from another <see cref="PhoneNumber"/>.
    /// </summary>
    /// <param name="source">The <see cref="PhoneNumber"/> to dial from.</param>
    /// <param name="destination">The <see cref="PhoneNumber"/> to dial.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
    /// <returns>Returns the number needed to dial a <see cref="PhoneNumber"/> from another <see cref="PhoneNumber"/>.</returns>
    public static string NumberToDialFor(this PhoneNumber source, PhoneNumber destination)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (destination is null)
        {
            throw new ArgumentNullException(nameof(destination));
        }

        if (source.Country == destination.Country ||
            source.Country.SharesCallingCodeWith(destination.Country))
        {
            if (source.Country.NumberingPlanType == NumberingPlanType.Open &&
                source.PhoneNumberKind == PhoneNumberKind.GeographicPhoneNumber &&
                destination.PhoneNumberKind == PhoneNumberKind.GeographicPhoneNumber &&
                source.NationalDestinationCode == destination.NationalDestinationCode &&
                !((GeographicPhoneNumber)source).ClosedDiallingInOpenPlan)
                {
                    return destination.SubscriberNumber;
                }

            return destination.Country.TrunkPrefix is not null
                ? $"{destination.Country.TrunkPrefix}{destination.NationalSignificantNumber}"
                : destination.NationalSignificantNumber;
        }

        return $"{source.Country.InternationalCallPrefix}{destination.Country.CallingCode.Substring(1)}{destination.NationalSignificantNumber}";
    }
}
