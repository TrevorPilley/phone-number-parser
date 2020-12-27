using System;

namespace PhoneNumbers
{
    /// <summary>
    /// An implementation of <see cref="PhoneNumber"/> which represents a mobile phone number.
    /// </summary>
    public sealed class MobilePhoneNumber : PhoneNumber, IEquatable<MobilePhoneNumber>
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
        internal MobilePhoneNumber(
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

        /// <inheritdoc/>
        public static bool operator ==(MobilePhoneNumber? phoneNumber1, MobilePhoneNumber? phoneNumber2)
        {
            if (ReferenceEquals(phoneNumber1, null))
            {
                return ReferenceEquals(phoneNumber2, null);
            }

            return phoneNumber1.Equals(phoneNumber2);
        }

        /// <inheritdoc/>
        public static bool operator !=(MobilePhoneNumber? phoneNumber1, MobilePhoneNumber? phoneNumber2) =>
            !(phoneNumber1 == phoneNumber2);

        /// <inheritdoc/>
        public override bool Equals(object? obj) =>
            Equals(obj as MobilePhoneNumber);

        /// <inheritdoc/>
        public bool Equals(MobilePhoneNumber? other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return AreaCode.Equals(other.AreaCode, StringComparison.Ordinal) &&
                Country.Equals(other.Country) &&
                LocalNumber.Equals(other.LocalNumber, StringComparison.Ordinal) &&
                PhoneNumberKind.Equals(other.PhoneNumberKind) &&
                IsDataOnly.Equals(other.IsDataOnly) &&
                IsPager.Equals(other.IsPager) &&
                IsVirtual.Equals(other.IsVirtual);
        }

        /// <inheritdoc/>
        public override int GetHashCode() =>
            HashCode.Combine(AreaCode, Country, LocalNumber, PhoneNumberKind, IsDataOnly, IsPager, IsVirtual, PhoneNumberKind);
    }
}
