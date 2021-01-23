namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for MC phone numbers.
    /// </summary>
    internal sealed class MCPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            return $"{phoneNumber.LocalNumber.Substring(0, 2)} {phoneNumber.LocalNumber.Substring(2, 2)} {phoneNumber.LocalNumber.Substring(4, 2)} {phoneNumber.LocalNumber.Substring(6, 2)}";
        }
    }
}
