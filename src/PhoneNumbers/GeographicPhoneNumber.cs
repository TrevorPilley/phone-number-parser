namespace PhoneNumbers
{
    /// <summary>
    /// An implementation of <see cref="PhoneNumber"/> which represents a geographicly assigned phone number.
    /// </summary>
    public sealed class GeographicPhoneNumber : PhoneNumber
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="GeographicPhoneNumber"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
        /// <param name="areaCode">The area code of the phone number.</param>
        /// <param name="localNumber">The local number of the phone number.</param>
        /// <param name="geographicArea"></param>
        public GeographicPhoneNumber(
            CountryInfo countryInfo,
            string areaCode,
            string localNumber,
            string geographicArea)
            : base(countryInfo, areaCode, localNumber) =>
            GeographicArea = geographicArea;

        /// <summary>
        /// Gets the name of the geographic area the phone number the area code is allocated to.
        /// Depending on the country, this could be an individual city or larger region such as a county.
        /// </summary>
        public string GeographicArea { get; }

        /// <inheritdoc/>
        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.GeographicPhoneNumber;
    }
}
