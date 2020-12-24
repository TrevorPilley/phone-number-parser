namespace PhoneNumbers
{
    /// <summary>
    /// An implementation of <see cref="PhoneNumber"/> which represents a phone number which is not assigned to a geographic area.
    /// </summary>
    public sealed class NonGeographicPhoneNumber : PhoneNumber
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="NonGeographicPhoneNumber"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
        /// <param name="areaCode">The area code of the phone number.</param>
        /// <param name="localNumber">The local number of the phone number.</param>
        internal NonGeographicPhoneNumber(
            CountryInfo countryInfo,
            string areaCode,
            string localNumber)
            : base(countryInfo, areaCode, localNumber)
        {
        }

        /// <inheritdoc/>
        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.NonGeographicPhoneNumber;
    }
}
