namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for phone numbers where the display format is 'xxxx xxxx'.
    /// </summary>
    internal sealed class FourSpaceFourPhoneNumberFormatter : PhoneNumberFormatter
    {
        private FourSpaceFourPhoneNumberFormatter()
        {
        }

        internal static PhoneNumberFormatter Instance { get; } = new FourSpaceFourPhoneNumberFormatter();

        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.LocalNumber.Substring(0, 4)} {phoneNumber.LocalNumber.Substring(4)}";
    }
}
