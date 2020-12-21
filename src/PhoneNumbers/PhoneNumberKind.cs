namespace PhoneNumbers
{
    /// <summary>
    /// The kinds of <see cref="PhoneNumber"/>.
    /// </summary>
    public enum PhoneNumberKind
    {
        /// <summary>
        /// The phone number represents a geographicly assigned phone number.
        /// </summary>
        GeographicPhoneNumber,

        /// <summary>
        /// The phone number represents a mobile phone.
        /// </summary>
        MobilePhoneNumber,
    }
}
