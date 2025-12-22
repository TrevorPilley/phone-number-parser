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
        ArgumentNullException.ThrowIfNull(destination);
        ArgumentNullException.ThrowIfNull(countryInfo);

        if (destination.Country.SharesCallingCodeWith(countryInfo))
        {
            return destination.ToString("U");
        }

        if (countryInfo.InternationalCallPrefixes.TryGetValue(destination.Country.CallingCode, out var callPrefix))
        {
            return $"{callPrefix}{destination.NationalSignificantNumber}";
        }

        if (countryInfo == CountryInfo.Italy && destination.IsSanMarinoLandline())
        {
            return !destination.SubscriberNumber.StartsWith("0549", StringComparison.Ordinal)
                ? $"0549{destination.SubscriberNumber}"
                : destination.SubscriberNumber;
        }

        if (countryInfo == CountryInfo.Ireland && destination.IsNorthernIrelandLandline())
        {
            // Even though Northern Ireland is part of the United Kingdom numbering plan,
            // Republic of Ireland can dial Northern Ireland fixed line numbers via a 48 NDC.
            return $"{countryInfo.TrunkPrefix}48{destination.SubscriberNumber}";
        }

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
        ArgumentNullException.ThrowIfNull(destination);
        ArgumentNullException.ThrowIfNull(source);

        if (source.Country.SharesCallingCodeWith(destination.Country))
        {
            return source.SharesNdcWith(destination) && source.NdcIsOptional()
                ? destination.SubscriberNumber
                : destination.ToString("U");
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

    private static bool IsNorthernIrelandLandline(this PhoneNumber phoneNumber) =>
        phoneNumber.Country == CountryInfo.UnitedKingdom &&
        phoneNumber.NationalDestinationCode!.Equals("28", StringComparison.OrdinalIgnoreCase);

    private static bool IsSanMarinoLandline(this PhoneNumber phoneNumber) =>
        phoneNumber.Country == CountryInfo.SanMarino &&
        (phoneNumber.SubscriberNumber[0] == '0' || phoneNumber.SubscriberNumber[0] == '7' || phoneNumber.SubscriberNumber[0] == '8');
}
