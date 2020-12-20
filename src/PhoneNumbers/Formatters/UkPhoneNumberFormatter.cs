namespace PhoneNumbers.Formatters
{
    public sealed class UkPhoneNumberFormatter : PhoneNumberFormatter
    {
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            return $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode} {phoneNumber.LocalNumber.Substring(0, 3)} {phoneNumber.LocalNumber.Substring(3)}";
        }
    }
}
