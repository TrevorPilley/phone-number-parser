namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for ES phone numbers.
    /// </summary>
    internal sealed class ESPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.NationalDiallingCode} {phoneNumber.SubscriberNumber.Substring(0, 3)} {phoneNumber.SubscriberNumber.Substring(3)}";
    }
}
