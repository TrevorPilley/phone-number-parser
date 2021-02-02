namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for UK phone numbers.
    /// </summary>
    /// <remarks>See https://www.area-codes.org.uk/formatting.php for the rules this class implements.</remarks>
    internal sealed class GBPhoneNumberFormatter : PhoneNumberFormatter
    {
        private GBPhoneNumberFormatter()
        {
        }

        internal static PhoneNumberFormatter Instance { get; } = new GBPhoneNumberFormatter();

        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.NationalDestinationCode!.Length == 2)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 4)} {phoneNumber.SubscriberNumber.Substring(4)}";
            }

            if (phoneNumber.NationalDestinationCode!.Length == 3)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 3)} {phoneNumber.SubscriberNumber.Substring(3)}";
            }

            return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}";
        }
    }
}
