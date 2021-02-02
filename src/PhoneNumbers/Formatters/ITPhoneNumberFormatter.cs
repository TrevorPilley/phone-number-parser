namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for IT phone numbers.
    /// </summary>
    internal sealed class ITPhoneNumberFormatter : PhoneNumberFormatter
    {
        private ITPhoneNumberFormatter()
        {
        }

        internal static PhoneNumberFormatter Instance { get; } = new ITPhoneNumberFormatter();

        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.NationalDestinationCode![0] == '0' && phoneNumber.NationalDestinationCode!.Length == 2)
            {
                return $"{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 4)} {phoneNumber.SubscriberNumber.Substring(4)}";
            }

            if (phoneNumber.NationalDestinationCode![0] == '0' && phoneNumber.NationalDestinationCode.Length == 3)
            {
                return $"{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 3)} {phoneNumber.SubscriberNumber.Substring(3)}";
            }

            if (phoneNumber.NationalDestinationCode![0] == '3')
            {
                return $"{phoneNumber.NationalDestinationCode}{phoneNumber.SubscriberNumber.Substring(0, 1)} {phoneNumber.SubscriberNumber.Substring(1)}";
            }

            return $"{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}";
        }
    }
}
