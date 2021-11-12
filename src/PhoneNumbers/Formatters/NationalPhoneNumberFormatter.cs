using System;

namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> which returns the national dialling format.
    /// </summary>
    internal sealed class NationalPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="NationalPhoneNumberFormatter"/> class.
        /// </summary>
        private NationalPhoneNumberFormatter()
        {
        }

        /// <summary>
        /// Gets the <see cref="NationalPhoneNumberFormatter"/> instance.
        /// </summary>
        internal static PhoneNumberFormatter Instance { get; } = new NationalPhoneNumberFormatter();

        /// <inheritdoc/>
        public override bool CanFormat(string format) =>
            format?.Equals("N", StringComparison.Ordinal) == true;

        /// <inheritdoc/>
        public override string Format(PhoneNumber phoneNumber) =>
            phoneNumber.Country.RequireNdcForLocalDialling
                ? $"{phoneNumber!.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}"
                : $"({phoneNumber!.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode}) {phoneNumber.SubscriberNumber}";
    }
}
