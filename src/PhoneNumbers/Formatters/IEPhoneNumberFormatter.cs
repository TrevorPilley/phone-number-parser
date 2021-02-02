namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for IE phone numbers.
    /// </summary>
    internal sealed class IEPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.SubscriberNumber.Length > 5)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber.Substring(0, 3)} {phoneNumber.SubscriberNumber.Substring(3)}";
            }

            return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}";
        }
    }
}
