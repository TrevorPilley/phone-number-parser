namespace PhoneNumbers
{
    /// <summary>
    /// An implementation of <see cref="PhoneNumber"/> which represents a mobile phone number.
    /// </summary>
    public sealed class MobilePhoneNumber : PhoneNumber
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="MobilePhoneNumber"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
        /// <param name="areaCode">The area code of the phone number.</param>
        /// <param name="localNumber">The local number of the phone number.</param>
        /// <param name="isDataOnly"></param>
        /// <param name="isPager"></param>
        /// <param name="isVirtual"></param>
        public MobilePhoneNumber(
            CountryInfo countryInfo,
            string areaCode,
            string localNumber,
            bool isDataOnly,
            bool isPager,
            bool isVirtual)
            : base(countryInfo, areaCode, localNumber)
        {
            IsDataOnly = isDataOnly;
            IsPager = isPager;
            IsVirtual = isVirtual;
        }

        /// <summary>
        /// The mobile number is likely for a data only plan (e.g. a 3G/LTE laptop or tablet).
        /// </summary>
        public bool IsDataOnly { get; }

        /// <summary>
        /// The mobile number is likely for a pager.
        /// </summary>
        public bool IsPager { get; }

        /// <summary>
        /// The mobile number is likely a virtual number.
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Virtual_number for further details.</remarks>
        public bool IsVirtual { get; }

        /// <inheritdoc/>
        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.MobilePhoneNumber;
    }
}
