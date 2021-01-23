namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for HK phone numbers.
    /// </summary>
    internal sealed class HKPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.LocalNumber.Substring(0, 4)} {phoneNumber.LocalNumber.Substring(4)}";
    }
}
