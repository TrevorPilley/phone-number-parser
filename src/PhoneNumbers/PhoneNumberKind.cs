namespace PhoneNumbers;

/// <summary>
/// The kinds of <see cref="PhoneNumber"/>.
/// </summary>
public enum PhoneNumberKind
{
    /// <summary>
    /// The phone number represents a geographically assigned phone number.
    /// </summary>
    GeographicPhoneNumber,

    /// <summary>
    /// The phone number represents a mobile phone.
    /// </summary>
    MobilePhoneNumber,

    /// <summary>
    /// The phone number is not assigned to a geographic area.
    /// </summary>
    NonGeographicPhoneNumber,
}
