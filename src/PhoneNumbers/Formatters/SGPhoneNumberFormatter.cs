namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for SG phone numbers.
    /// </summary>
    internal sealed class SGPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.LocalNumber.Substring(0, 4)} {phoneNumber.LocalNumber.Substring(4)}";
    }
}
