namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for IT phone numbers.
    /// </summary>
    internal sealed class ITPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.AreaCode![0] == '0' && phoneNumber.AreaCode!.Length == 2)
            {
                return $"{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 4)} {phoneNumber.LocalNumber.Substring(4)}";
            }

            if (phoneNumber.AreaCode![0] == '0' && phoneNumber.AreaCode.Length == 3)
            {
                return $"{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 3)} {phoneNumber.LocalNumber.Substring(3)}";
            }

            if (phoneNumber.AreaCode![0] == '3')
            {
                return $"{phoneNumber.AreaCode}{phoneNumber.LocalNumber.Substring(0, 1)} {phoneNumber.LocalNumber.Substring(1)}";
            }

            return $"{phoneNumber.AreaCode} {phoneNumber.LocalNumber}";
        }
    }
}
