namespace PhoneNumbers;

/// <summary>
/// A class containing extension methods for the <see cref="PhoneNumber"/> class.
/// </summary>
internal static class PhoneNumberExtensions
{
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
