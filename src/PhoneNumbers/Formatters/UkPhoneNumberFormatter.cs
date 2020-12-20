namespace PhoneNumbers.Formatters
{
    /// <remarks>
    /// https://www.area-codes.org.uk/formatting.php
    /// </remarks>
    public sealed class UkPhoneNumberFormatter : PhoneNumberFormatter
    {
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.AreaCode.Length == 2)
            {
                return $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 4)} {phoneNumber.LocalNumber.Substring(4)}";
            }

            if (phoneNumber.AreaCode.Length == 3)
            {
                return $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 3)} {phoneNumber.LocalNumber.Substring(3)}";
            }

            return $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber}";
        }
    }
}
