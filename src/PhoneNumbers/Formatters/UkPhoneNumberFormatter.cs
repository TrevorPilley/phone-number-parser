namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for UK phone numbers.
    /// </summary>
    /// <remarks>See https://www.area-codes.org.uk/formatting.php for the rules this class implements.</remarks>
    internal sealed class UKPhoneNumberFormatter : PhoneNumberFormatter
    {
        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.AreaCode.Length == 2)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 4)} {phoneNumber.LocalNumber.Substring(4)}";
            }

            if (phoneNumber.AreaCode.Length == 3)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 3)} {phoneNumber.LocalNumber.Substring(3)}";
            }

            // Geographic and Mobiles can both have a 4 digit area code, however the preference is to only split the local number for geographical
            if (phoneNumber.AreaCode.Length == 4 && phoneNumber.PhoneNumberKind == PhoneNumberKind.GeographicPhoneNumber)
            {
                return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 3)} {phoneNumber.LocalNumber.Substring(3)}";
            }

            return $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber}";
        }
    }
}
