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
        /// <param name="nationalDiallingCode">The national dialling code of the phone number.</param>
        /// <param name="subscriberNumber">The subscriber number of the phone number.</param>
        /// <param name="isFreephone">The number is a freephone (toll-free) number.</param>
        internal NonGeographicPhoneNumber(
            CountryInfo countryInfo,
            string? nationalDiallingCode,
            string subscriberNumber,
            bool isFreephone)
            : base(countryInfo, nationalDiallingCode, subscriberNumber) =>
            IsFreephone = isFreephone;

        /// <summary>
        /// The number is a freephone (toll-free) number.
        /// </summary>
        /// <remarks>This is an indication only based upon the data available for each country.</remarks>
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

            return Country.Equals(other.Country) &&
                IsFreephone.Equals(other.IsFreephone) &&
                PhoneNumberKind.Equals(other.PhoneNumberKind) &&
                (NationalDiallingCode == null && other.NationalDiallingCode == null || NationalDiallingCode!.Equals(other.NationalDiallingCode, StringComparison.Ordinal)) &&
                SubscriberNumber.Equals(other.SubscriberNumber, StringComparison.Ordinal);
        }

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public override int GetHashCode() =>
            HashCode.Combine(Country, IsFreephone, PhoneNumberKind, NationalDiallingCode, SubscriberNumber);
    }
}
