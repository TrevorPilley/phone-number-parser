namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for CH phone numbers.
    /// </summary>
    internal sealed class CHPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.NationalDestinationCode!.Length == 3)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 3)} {phoneNumber.SubscriberNumber.Substring(3)}";
            }

            return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 3)} {phoneNumber.SubscriberNumber.Substring(3, 2)} {phoneNumber.SubscriberNumber.Substring(5)}";
        }
    }
}
