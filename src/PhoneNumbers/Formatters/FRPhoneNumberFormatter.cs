namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for FR phone numbers.
    /// </summary>
    internal sealed class FRPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.LocalNumber.Substring(0, 1)} {phoneNumber.LocalNumber.Substring(1, 2)} {phoneNumber.LocalNumber.Substring(3, 2)} {phoneNumber.LocalNumber.Substring(5, 2)} {phoneNumber.LocalNumber.Substring(7, 2)}";
    }
}
