namespace PhoneNumbers;

/// <summary>
/// A class containing extension methods for the <see cref="PhoneNumber"/> class.
/// </summary>
public static class PhoneNumberExtensions
{
    /// <summary>
    /// Determines the number needed to dial a <see cref="PhoneNumber"/> from another <see cref="CountryInfo"/>.
    /// </summary>
    /// <param name="destination">The <see cref="PhoneNumber"/> to dial.</param>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> to dial from.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="destination"/> or <paramref name="countryInfo"/> is null.</exception>
    /// <returns>Returns the number needed to dial a <see cref="PhoneNumber"/> from another <see cref="CountryInfo"/>.</returns>
    public static string NumberToDialFrom(this PhoneNumber destination, CountryInfo countryInfo)
    {
        if (destination is null)
        {
            throw new ArgumentNullException(nameof(destination));
        }

        if (countryInfo is null)
        {
            throw new ArgumentNullException(nameof(countryInfo));
        }

        if (destination.Country == countryInfo ||
            destination.Country.SharesCallingCodeWith(countryInfo))
        {
                return $"{destination.Country.TrunkPrefix}{destination.NationalSignificantNumber}";
        }

        //if (countryInfo.InternationalCallPrefixes.TryGet(destination.Country.CallingCode, out var callPrefix))
        //{
        //    return $"{callPrefix}{destination.Country.CallingCode}{destination.NationalSignificantNumber}";
        //}

        return $"{countryInfo.InternationalCallPrefix}{destination.Country.CallingCode}{destination.NationalSignificantNumber}";
    }

    /// <summary>
    /// Determines the number needed to dial a <see cref="PhoneNumber"/> from another <see cref="PhoneNumber"/>.
    /// </summary>
    /// <param name="destination">The <see cref="PhoneNumber"/> to dial.</param>
    /// <param name="source">The <see cref="PhoneNumber"/> to dial from.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
    /// <returns>Returns the number needed to dial a <see cref="PhoneNumber"/> from another <see cref="PhoneNumber"/>.</returns>
    public static string NumberToDialFrom(this PhoneNumber destination, PhoneNumber source)
    {
        if (destination is null)
        {
            throw new ArgumentNullException(nameof(destination));
        }

        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (source.Country == destination.Country ||
            source.Country.SharesCallingCodeWith(destination.Country))
        {
            if (source.NationalDestinationCode?.Equals(destination.NationalDestinationCode, StringComparison.Ordinal) == true &&
                source.NdcIsOptional())
            {
                return destination.SubscriberNumber;
            }

            return $"{destination.Country.TrunkPrefix}{destination.NationalSignificantNumber}";
        }

        return NumberToDialFrom(destination, source.Country);
    }

    /// <summary>
    /// Gets a value indicating if the National Destination Code is optional for the specified <see cref="PhoneNumber"/> instance.
    /// </summary>
    /// <param name="phoneNumber">The <see cref="PhoneNumber"/> instance to check.</param>
    /// <returns>The true if the National Destination Code is optional, otherwise false.</returns>
    internal static bool NdcIsOptional(this PhoneNumber phoneNumber) =>
        phoneNumber.Country.HasNationalDestinationCodes &&
        phoneNumber.Country.AllowsLocalGeographicDialling &&
        phoneNumber.Kind == PhoneNumberKind.GeographicPhoneNumber &&
        !((GeographicPhoneNumber)phoneNumber).NationalDiallingOnly;
}
