using System;

namespace PhoneNumbers
{
    public abstract class PhoneNumberFormatter
    {
        public string Format(PhoneNumber phoneNumber, string format)
        {
            switch (format)
            {
                case "D":
                    return FormatDisplay(phoneNumber);

                case "I":
                    return FormatInternational(phoneNumber);

                case "N":
                    return FormatNational(phoneNumber);

                default:
                    throw new NotSupportedException(format);
            }
        }

        protected virtual string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.CallingCode} {phoneNumber.AreaCode} {phoneNumber.LocalNumber}";

        protected virtual string FormatInternational(PhoneNumber phoneNumber) =>
            $"{phoneNumber.CallingCode}{phoneNumber.AreaCode}{phoneNumber.LocalNumber}";

        protected virtual string FormatNational(PhoneNumber phoneNumber) =>
            $"{phoneNumber.TrunkPrefix}{phoneNumber.AreaCode}{phoneNumber.LocalNumber}";
    }
}
