namespace PhoneNumbers
{
    public sealed class MobilePhoneNumber : PhoneNumber
    {
        public MobilePhoneNumber(
            string callingCode,
            string trunkPrefix,
            string areaCode,
            string localNumber,
            bool isDataOnly,
            bool isPager,
            bool isVirtual)
            : base(callingCode, trunkPrefix, areaCode, localNumber)
        {
			IsDataOnly = isDataOnly;
			IsPager = isPager;
			IsVirtual = isVirtual;
        }

        public bool IsDataOnly { get; }

        public bool IsPager { get; }

        public bool IsVirtual { get; }

        public override PhoneNumberKind PhoneNumberKind =>
            PhoneNumberKind.MobilePhoneNumber;
    }
}
