using System;

namespace PhoneNumbers
{
    /// <summary>
    /// An implementation of <see cref="PhoneNumber"/> which represents a phone number which is not assigned to a geographic area.
    /// </summary>
    public sealed class NonGeographicPhoneNumber : PhoneNumber, IEquatable<NonGeographicPhoneNumber>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="NonGeographicPhoneNumber"/> class.
        /// </summary>
        /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
        /// <param name="areaCode">The area code of the phone number.</param>
        /// <param name="localNumber">The local number of the phone number.</param>
        /// <param name="isFreephone">The number is a freephone (toll-free) number.</param>
        internal NonGeographicPhoneNumber(
            CountryInfo countryInfo,
            string? areaCode,
            string localNumber,
            bool isFreephone)
            : base(countryInfo, areaCode, localNumber) =>
            IsFreephone = isFreephone;

        /// <summary>
        /// The number is a freephone (toll-free) number.
        /// </summary>
        public bool IsFreephone { get; }

        /// <inheritdoc/>
        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.NonGeographicPhoneNumber;

        /// <inheritdoc/>
        public static bool operator !=(NonGeographicPhoneNumber? phoneNumber1, NonGeographicPhoneNumber? phoneNumber2) =>
            !(phoneNumber1 == phoneNumber2);

        /// <inheritdoc/>
        public static bool operator ==(NonGeographicPhoneNumber? phoneNumber1, NonGeographicPhoneNumber? phoneNumber2)
        {
            if (phoneNumber1 is null)
            {
                return phoneNumber2 is null;
            }

            return phoneNumber1.Equals(phoneNumber2);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) =>
            Equals(obj as NonGeographicPhoneNumber);

        /// <inheritdoc/>
        public bool Equals(NonGeographicPhoneNumber? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return (AreaCode == null && other.AreaCode == null || AreaCode!.Equals(other.AreaCode, StringComparison.Ordinal)) &&
                Country.Equals(other.Country) &&
                IsFreephone.Equals(other.IsFreephone) &&
                LocalNumber.Equals(other.LocalNumber, StringComparison.Ordinal) &&
                PhoneNumberKind.Equals(other.PhoneNumberKind);
        }

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public override int GetHashCode() =>
            HashCode.Combine(AreaCode, Country, IsFreephone, LocalNumber, PhoneNumberKind);
    }
}
