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
            if (phoneNumber.AreaCode.Length = 3)
            {
                return $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 3)} {phoneNumber.LocalNumber.Substring(3)}";
            }

            return $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode}{phoneNumber.LocalNumber.Substring(0, 1)} {phoneNumber.LocalNumber.Substring(1, 3) {phoneNumber.LocalNumber.Substring(4)}";
        }
    }
}
